using System;

namespace ClassLibForUnitTesting
{
    public class Demo
    {
        public int TheAnswerOfTheUniverse() => 42;

        public string SomeStringHandling(string s)
        {
            if (s is null) throw new ArgumentNullException(nameof(s));

            if (s.Length > 3)
            {
                return s.ToUpper();
            }
            else
            {
                return s.ToLower();
            }
        }
    }
}
