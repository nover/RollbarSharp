using System;

namespace RollbarSharp
{
    /// <summary>
    /// Provides extension methods for .net Exceptions
    /// </summary>
	public static class ExceptionExtension
	{
        /// <summary>
        /// Adds the <see cref="Exception"/> instance to Rollbar
        /// </summary>
        /// <param name="exception">The exception.</param>
		public static void ToRollbar (this Exception exception)
		{
            if (exception != null)
            {
                (new RollbarClient()).SendException(exception);
            }
		}
	}
}

