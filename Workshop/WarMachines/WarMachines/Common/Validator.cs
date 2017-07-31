using System;

namespace WarMachines.Common
{
    public static class Validator
    {
        public static void CheckIfObjIsNull(object obj, string message = null)
        {
            if (obj == null)
            {
                throw new NullReferenceException(message);
            }
        }

        public static void CheckIfStringIsNullOrEmpty(string text, string message = null)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException(message);
            }
        }
    }
}
