using System;
using System.Collections.Generic;
using System.Text;

namespace SecondKata_StringCalculator_Interactions.Logger
{
    public class MockLogger : ILogger
    {
        public string verifyMessage = null;

        public void Write(string message)
        {
            verifyMessage = "LOG.WROTE";
        }
    }
}
