using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoLogger;

namespace forLoggerTest
{
    [Logger]
    public class TestConstructor
    {
        string _test = "test";

        public TestConstructor(string test)
        {
            _test = setWords();
        }

        private string setWords()
        {
            return "test";
        }

    }
}