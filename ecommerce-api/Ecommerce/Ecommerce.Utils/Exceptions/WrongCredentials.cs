﻿namespace Ecommerce.Utils.Exceptions
{
    public class WrongCredentials : Exception
    {
        public WrongCredentials(string errorMessage) : base(errorMessage)
        {

        }
    }
}