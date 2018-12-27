using System;
using System.Collections.Generic;
using System.Text;

namespace SecondKata_StringCalculator_Interactions.Notifier
{
    public class MockNotifier : IWebservice
    {
        public string verifyMessage = null;

        public void Notify(string message)
        {
            verifyMessage = "MESSAGE.NOTIFIED";
        }
    }
}
