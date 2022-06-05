using System;

namespace Stopwatch
{
    public class StopWatch
    {
        private DateTime _start;

        private DateTime _stop;
        private bool _hasStarted;

        public void Start()
        {
            if(_hasStarted)
            {
                throw new InvalidOperationException("Watch is already Running!");
            }
            
            _start = DateTime.Now;
            _hasStarted = true;
            
        }

        public void Stop()
        {
            if(!_hasStarted)
            {
                throw new InvalidOperationException("Gotta start the watch first, buddy!");
            }

            _stop = DateTime.Now;
            _hasStarted = false;
        }

        public TimeSpan GetDuration() 
        {
            return _stop - _start;
        }       
    }
}