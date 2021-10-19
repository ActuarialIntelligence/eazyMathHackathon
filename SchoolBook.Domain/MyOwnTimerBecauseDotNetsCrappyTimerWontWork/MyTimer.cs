using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBook.Domain.MyOwnTimerBecauseDotNetsCrappyTimerWontWork
{
    public static class MyTimer
    {
        public static void IntervalTimer_Elapsed(decimal seconds)
        {
            var timeAtBeginningOfFunction = DateTime.Now;
            var timeCnt = DateTime.Now.Second;
            int total = 0;
            for (int i = 0; i >= 0; i++)
            {
                total = (DateTime.Now - timeAtBeginningOfFunction).Seconds;
                if (total > seconds)
                {
                    break;
                }

            }
        }

        private class TimerTimedOutException : Exception 
        {
            public TimerTimedOutException() : base("This thing works in a loop and it has ran out.")
            {

            }
        }
    }
}
