using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_INotify_Changed_Property
{
    public class IncrementCounter :INotifyPropertyChanged
    {
        IncrementCommandCounter incrementCommandCounter;
        public IncrementCounter()
        {
            incrementCommandCounter = new IncrementCommandCounter(this);
        }
        public int count { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Increment()
        {
            count++;
            PropertyChanged(this, new PropertyChangedEventArgs("Counter"));
        }
        
    }
}
