using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Demo_Calculator.Models
{
    public class ModelNum:INotifyPropertyChanged
    {
        private double firstNum;
        public double FirstNum
        {
            get { return firstNum; }
            set 
            { 
                firstNum = value;
                OnPropertyChanged("FirstNum");
            }
        }
        private double secondNum;
        public double SecondNum
        {
            get { return secondNum; }
            set
            {
                secondNum = value;
                OnPropertyChanged("SecondNum");
            }
        }

        private double result;
        public double Result
        {
            get { return result; }
            set
            {
                result = value;
                OnPropertyChanged("Result");
            }
        }



        public void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("propertyName"));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
