using System;

namespace StopWatchExercise
{
    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _isStarted;


        public void Start()
        {
            if (_isStarted)
                throw new InvalidOperationException("The StopWatch is already started");

            _isStarted = true;
            _startTime = DateTime.Now;
        }

        public void Stop()
        {
            if (!(_isStarted))
                throw new InvalidOperationException("StopWatch is not started");

            _isStarted = false;
            _endTime = DateTime.Now;
        }

        public TimeSpan GetDuration()
        {
            if (_isStarted)
                throw new InvalidOperationException("StopWatch have not been stopped");

            return _endTime - _startTime;
        }

    }
}