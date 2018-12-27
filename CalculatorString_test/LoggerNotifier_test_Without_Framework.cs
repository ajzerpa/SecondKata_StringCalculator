using System;
using Xunit;
using SecondKata_StringCalculator_Interactions;
using SecondKata_StringCalculator_Interactions.Logger;
using SecondKata_StringCalculator_Interactions.Notifier;

namespace CalculatorString_test
{
    public class LoggerNotifier_test_Without_Framework
    {
        [Fact]
        public void logger_VerifyWritte_test()
        {
            MockLogger mockLog = new MockLogger();
            CalculatorString calculator = new CalculatorString(mockLog);
            var result = calculator.Add("2,2");
            Assert.Equal("LOG.WROTE", mockLog.verifyMessage);
        }

        [Fact]
        public void logger_VerifyNotifier_test()
        {
            StubThrowExceptionLogger stubLogger = new StubThrowExceptionLogger();
            MockNotifier mockNotifier = new MockNotifier();

            CalculatorString calculator = new CalculatorString(stubLogger, mockNotifier);
            var result = calculator.Add("1");

            Assert.Equal("MESSAGE.NOTIFIED", mockNotifier.verifyMessage);
        }
    }
}
