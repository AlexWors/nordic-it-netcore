using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ClassWork17
{
    public class Worker
    {
        public event Action<WorkType, int> OnWorkComplete;
        public event Action<WorkType, int, int> OnWorkHourPassed;
        public void DoWork(int hours, WorkType workType)
        {
            for(int i = 1; i < hours; i++)
            {
                OnWorkHourPassed?.Invoke(workType, hours, i);
            }
            OnWorkComplete?.Invoke(workType, hours);
        }
    }
}
