using System;

namespace my_lib
{
    public class Class1
    {
        private Action<string> _writer;

        public Class1(Action<string> writer)
        {
            _writer = writer;
        }

        public void Log() => _writer($"Logging {DateTime.Now:s}");
    }
}
