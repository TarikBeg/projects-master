import { Component, OnInit } from '@angular/core';
import { ApiResponse } from 'src/app/shared/models/shared.models';
import { TvShow } from 'src/app/tv-show/tv-show';

import { MoviesApiService } from '../services/movies-api.service';

@Component({
  selector: 'app-rate-movie',
  templateUrl: './rate-movie.component.html'
})
export class RateMovieComponent implements OnInit {
  movies: ApiResponse<TvShow[]> = {} as ApiResponse<TvShow[]>;
  addedStars: any;

  constructor(private readonly movieApiService: MoviesApiService) { }

  ngOnInit(): void {
    this.getMovies();
  }

  getMovies(): void {
    this.movieApiService
      .searchMovies("", 0, 0)
      .subscribe(data => this.onSuccess(data));
  }

  onSuccess(data: any): void {
    this.movies = data;
  }

  onAddesStars(id: string, addedStars: number): void {
    debugger;
    this.movieApiService.addStars(id, addedStars).subscribe();
  }
}
