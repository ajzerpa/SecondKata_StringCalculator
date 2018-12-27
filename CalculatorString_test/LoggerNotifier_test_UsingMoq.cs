using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Xunit;
using SecondKata_StringCalculator_Interactions.Logger;
using SecondKata_StringCalculator_Interactions;
using SecondKata_StringCalculator_Interactions.Notifier;

namespace CalculatorString_test
{
    public class LoggerNotifier_test_UsingMoq
    {
        [Fact]
        public void logger_VerifyWritte_test()
        {
            var mockLog = new Mock<ILogger>();
            mockLog.Setup(x => x.Write(It.IsAny<string>())).Verifiable();
            
            CalculatorString calculator = new CalculatorString(mockLog.Object);
            var result = calculator.Add("2,2");

            mockLog.Verify(x => x.Write(It.IsAny<string>()), Times.Once);
        }

        [Fact]
        public void logger_VerifyNotifier_test()
        {
            var stubLog = new Mock<ILogger>();
            stubLog.Setup(x => x.Write(It.IsAny<string>())).Throws<Exception>().Verifiable();

            var mockNotifier = new Mock<IWebservice>();
            mockNotifier.Setup(x => x.Notify(It.IsAny<string>())).Verifiable();

            CalculatorString calculator = new CalculatorString(stubLog.Object, mockNotifier.Object);
            var result = calculator.Add("1");

            mockNotifier.Verify(x => x.Notify(It.IsAny<string>()), Times.Once);
        }
    }
}
