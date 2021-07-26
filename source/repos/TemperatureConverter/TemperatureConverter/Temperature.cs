using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    public class Temperature: INotifyPropertyChanged
    {
        private RelayCommand convertCommand;
        public RelayCommand ConvertCommand
        {
            get { return convertCommand; }
            set { convertCommand = value; }
        }

        public Temperature()
        {
            ConvertCommand = new RelayCommand(ConvertFtoC, CanExecute);
            //DecrementCommand = new RelayCommand(Decrement, CanExecute);
        }



        private double temp;
        public string Result
        {
            get; set;
        }
        public double Temp
        {
            get { return temp; }
            set 
            {
                temp = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Temp"));

            }
        }

        public void ConvertFtoC(object obj)
        {
            double calc1 = 5 / 9;
            double calc2;
            calc2 = (Temp - 32)*calc1;
            Result= calc2.ToString();
            
        }

        public void ConvertCtoF()
        {
            double Result = (9 * Temp - 160) / 5;
            //return Result;

        }



        public event PropertyChangedEventHandler PropertyChanged;
        public bool CanExecute(object obj)
        {
            if(Temp>-459)
            {
                return true;
            }
            return false;
        }
    }
}
