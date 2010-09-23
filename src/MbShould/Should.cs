using System;
using MbUnit.Framework;

namespace MbShould
{
    public static class Should
    {
        public static void Throw(Action action)
        {
            Throw<Exception>(action);
        }

        public static void Throw<TException>(Action action)
            where TException : Exception
        {
            TException thrownException = null;

            try
            {
                action();
            }
            catch (TException exception)
            {
                thrownException = exception;
            }

            Assert.IsNotNull(thrownException);
        }

        public static void NotThrow(Action action)
        {
            NotThrow<Exception>(action);
        }

        public static void NotThrow<TException>(Action action)
            where TException : Exception
        {
            TException thrownException = null;

            try
            {
                action();
            }
            catch (TException exception)
            {
                thrownException = exception;
            }

            Assert.IsNull(thrownException);
        }

        public static void Throw(Action action, string exceptionMessage)
        {
            Throw<Exception>(action, exceptionMessage);
        }

        public static void Throw<TException>(Action action, string exceptionMessage)
            where TException : Exception
        {
            TException thrownException = null;

            try
            {
                action();
            }
            catch (TException exception)
            {
                thrownException = exception;
            }

            Assert.IsNotNull(thrownException);
            Assert.Contains(thrownException.Message, exceptionMessage);
        }
    }
}