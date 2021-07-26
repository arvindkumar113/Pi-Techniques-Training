using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_INotify_Changed_Property
{
    public class IncrementCommandCounter : ICommand
    {
        private IncrementCounter incrementCounter;
        //dependency Injection
        public IncrementCommandCounter(IncrementCounter counterObject)
        {
            incrementCounter = counterObject;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)//when to execute
        {
            //if(incrementCounter.Coun)
            return true;
        }

        public void Execute(object parameter)//what to executr
        {
            incrementCounter.Increment();
        }
    }
}
