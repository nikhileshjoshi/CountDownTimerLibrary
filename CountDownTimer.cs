using System;

namespace CountDownTimerLibrary
{
    public class CountDownTimer
    {
        TimeSpan duration;
        bool started;
        DateTime startTime;
        DateTime endTime;
        /// <summary>
        /// Constructor sets up a countdown timer.
        /// </summary>
        /// <param name="set">TimeSpan for the countdown</param>
        public CountDownTimer(TimeSpan set) 
        {
            this.duration = set;
        }
        /// <summary>
        /// Starts timer.
        /// </summary>
        public void Start()
        {
            this.started = true;
            this.startTime = DateTime.Now;
            this.endTime = this.startTime.Add(this.duration);
        }

        /// <summary>
        /// Retuns the time left in count down.
        /// 
        /// Exception: Throws an expecption when the timer has not started.
        /// </summary>
        /// <returns></returns>
        public TimeSpan Remaining()
        {
            if (this.started)
            {
                return this.endTime - DateTime.Now;
            }
            else
            {
                throw new Exception("Timer is yet to start");
            }
        }
        
    }
}
