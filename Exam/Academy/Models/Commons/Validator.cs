using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Commons
{
    public static class Validator
    {
        public static void CheckIfStringIsNullOrEmpty(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException();
            }
        }

        public static void CheckIfNull(object obj)
        {
            if (obj == null)
            {
                throw new NullReferenceException();
            }
        }

        public static void ValidateIntRange(int value, int min, int max, string message)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(message);
            }
        }
        public static void ValidateFloatInRange(float value, float min, float max, string message)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(message);
            }
        }
    }

}
