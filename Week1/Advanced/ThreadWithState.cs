using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced
{
    public delegate void ExampleCallback(int linecount);

    public class ThreadWithState
    {
        private string boilerplate;
        private int value;

        private ExampleCallback callback;

        public ThreadWithState(string text, int number, ExampleCallback callbackDelegate)
        {
            boilerplate = text;
            value = number;
            callback = callbackDelegate;

        }
    }
}
