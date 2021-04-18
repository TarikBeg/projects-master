using System;

namespace SharedKernel.Exceptions
{
    [Serializable]
    public class InvalidStarException : Exception
    {
        public InvalidStarException(string value) : base($"The value {value} for game life is not in correct format.")
        {
        }
    }
}