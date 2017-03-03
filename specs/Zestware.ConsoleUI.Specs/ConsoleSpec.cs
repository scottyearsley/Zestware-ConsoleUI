using System;
using System.IO;
using Xunit;
using TestStack.BDDfy;

namespace Zestware.ConsoleUI.Specs
{
    public abstract class ConsoleSpec
    {
        public StringWriter _writer;

        [Fact]
        public void Run()
        {
            var originalConsoleOut = Console.Out; // preserve the original stream
            using(_writer = new StringWriter())
            {
                Console.SetOut(_writer);

                this.BDDfy();
            }

            Console.SetOut(originalConsoleOut); // restore Console.Out

        }

        public string GetResult()
        {
            _writer.Flush(); // when you're done, make sure everything is written out

            return _writer.GetStringBuilder().ToString();
        }
    }
}