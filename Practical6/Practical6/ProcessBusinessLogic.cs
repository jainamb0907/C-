using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Practical6
{
    public delegate void Notify(); // delegate

    internal class ProcessBusinessLogic
    {
        public event Notify ProcessCompleted; // event

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            // some code here..
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted() //protected virtual method
        {
            //if ProcessCompleted is not null then call delegate
            ProcessCompleted?.Invoke();
        }
    }
}
