using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_INotify_Property
{
    public class IncrementCounter : INotifyPropertyChanged
    {
        //RelayCommand Property - Increment
        private RelayCommand incrementCommand;
        public RelayCommand IncrementCommand
        {
            get { return incrementCommand; }
            set { incrementCommand = value; }
        }

        //RelayCommand property Decrement
        public RelayCommand DecrementCommand { get; set; }
        public IncrementCounter()
        {
            IncrementCommand = new RelayCommand(Increment, CanExecute);
            DecrementCommand = new RelayCommand(Decrement, CanExecute);
        }


        private int count;
        public int Counter
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Counter"));

            }
        }

        public void Increment(object obj)
        {
            Counter++;
        }
        public void Decrement(object obj)
        {
            Counter--;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        

        public bool CanExecute(object obj)
        {
            if(Counter>-1)
            {
                return true;
            }
            return false;
        }

        
       
    }
}
