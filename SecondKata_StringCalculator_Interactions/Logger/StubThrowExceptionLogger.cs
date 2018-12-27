using System;
using System.Collections.Generic;
using System.Text;

namespace SecondKata_StringCalculator_Interactions.Logger
{
    public class StubThrowExceptionLogger : ILogger
    {
        public void Write(string message)
        {
            throw new NotImplementedException();
        }
    }
}
