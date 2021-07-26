using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_INotify_Property
{
    public class RelayCommand : ICommand
    {

        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;

        //constructor
        public RelayCommand(Action<object> execute)
            : this(execute, null) { }

        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {//Constructor
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }
            _execute = execute;
            _canExecute = canExecute;
        }



        public bool CanExecute(object parameter)
        {
            return _canExecute ==null ? true:_canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            //method call using delegate
            _execute(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }


    }
}
