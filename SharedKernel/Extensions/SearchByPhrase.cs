using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper.Internal;
using SharedKernel.Models;

namespace SharedKernel.Extensions
{
    public static class SearchQueryableExtension
    {
        public static IQueryable<T> SearchByPhrase<T, TReview>(this IQueryable<T> query, string phrase) where TReview : IRating where T : IMovieShow<TReview>
        {
            var numberFromPhrase = GetNumberFromPhrase(phrase);
            phrase = phrase.ToLower();

            if (!phrase.HasKeywords())
                return query.FilterByText<T, TReview>(phrase);

            if (numberFromPhrase is not null)
                return query.FilterByKeywords<T, TReview>(phrase, numberFromPhrase!.Value);

            return query;
        }

        private static IQueryable<T> FilterByKeywords<T, TReview>(this IQueryable<T> query, string phrase, int numberFromPhrase) where T : IMovieShow<TReview> where TReview : IRating
        {
            if (phrase.HasStarKeyword())
                return query.FilterByStars<T, TReview>(phrase, numberFromPhrase);

            if (phrase.HasTimeKeywords())
                return query.FilterByTime<T, TReview>(phrase, numberFromPhrase);

            return query;
        }

        private static IQueryable<T> FilterByText<T, TReview>(this IQueryable<T> query, string phrase) where T : IMovieShow<TReview> where TReview : IRating
        {
            return query.Where(x => x.Title.ToLower().Contains(phrase) || x.Description.ToLower().Contains(phrase));
        }

        #region Filter by time

        private static IQueryable<T> FilterByTime<T, TReview>(this IQueryable<T> query, string phrase, int numberFromPhrase) where T : IMovieShow<TReview> where TReview : IRating
        {
            if (phrase.HasOlderThanKeyword())
                return query.Where(x => (DateTime.UtcNow.Year - x.ReleaseDate.Year) > numberFromPhrase);

            return phrase.HasAfterKeyword() ? query.Where(x => x.ReleaseDate.Year > numberFromPhrase) : query;
        }
        #endregion

        #region Filtering by stars

        private static IQueryable<T> FilterByStars<T, TReview>(this IQueryable<T> query, String phrase, int numberFromPhrase) where T : IMovieShow<TReview> where TReview : IRating
        {
            return phrase.HasAtLeastKeyword() ? query.FilterAtLeastStars<T, TReview>(numberFromPhrase) : query.FilterEqualStars<T, TReview>(numberFromPhrase);
        }

        private static IQueryable<T> FilterAtLeastStars<T, TReview>(this IQueryable<T> query, int numberFromPhrase) where T : IMovieShow<TReview> where TReview : IRating
        {
            return query.Where(x => (int)x.AverageRating >= numberFromPhrase);
        }

        private static IQueryable<T> FilterEqualStars<T, TReview>(this IQueryable<T> query, int numberFromPhrase) where T : IMovieShow<TReview> where TReview : IRating
        {
            return query.Where(x => (int)x.AverageRating == numberFromPhrase);
        }

        #endregion

        private static int? GetNumberFromPhrase(string phrase)
        {
            _ = int.TryParse(new string(phrase
                .SkipWhile(x => !char.IsDigit(x))
                .TakeWhile(char.IsDigit)
                .ToArray()), out var result);

            return result;
        }
    }

    public static class PhraseDictionary
    {
        public static Dictionary<PhraseEnums, string> Dictionary { get; set; }

        static PhraseDictionary()
        {
            InitializeDictionary();
        }

        public enum PhraseEnums
        {
            Stars,
            OlderThan,
            After,
            AtLeast
        }

        private static void InitializeDictionary()
        {
            Dictionary = new Dictionary<PhraseEnums, string>
            {
                {PhraseEnums.Stars, "stars"},

                {PhraseEnums.OlderThan, "older than"},
                {PhraseEnums.After, "after"},

                {PhraseEnums.AtLeast, "at least"}
            };
        }

        public static bool HasStarKeyword(this string phrase) =>
            phrase.Contains(Dictionary[PhraseEnums.Stars]) || phrase.HasAtLeastKeyword();

        public static bool HasTimeKeywords(this string phrase) =>
            phrase.HasOlderThanKeyword() || phrase.HasAfterKeyword();

        public static bool HasOlderThanKeyword(this string phrase)
        {
            var value = Dictionary[PhraseEnums.OlderThan];
            return phrase.Contains(value);
        }

        public static bool HasAfterKeyword(this string phrase) =>
            phrase.Contains(Dictionary[PhraseEnums.After]);

        public static bool HasAtLeastKeyword(this string phrase) =>
            phrase.Contains(Dictionary[PhraseEnums.AtLeast]);

        public static bool HasKeywords(this string phrase) => Dictionary.Any(dict => phrase.Contains(dict.Value));

    }
}