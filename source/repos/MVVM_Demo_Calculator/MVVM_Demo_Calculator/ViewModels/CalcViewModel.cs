using MVVM_Demo_Calculator.Commands;
using MVVM_Demo_Calculator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Demo_Calculator.ViewModels
{
    public class CalcViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

            }
        }

        private ModelNum modelNum = new ModelNum();

        public string FirstNum
        {
            get
            {
                return modelNum.FirstNum.ToString();
            }
            set
            {
                modelNum.FirstNum = Convert.ToDouble(value);
                OnPropertyChanged("Result");
            }
        }
        public string SecondNum
        {
            get
            {
                return modelNum.SecondNum.ToString();
            }
            set
            {
                modelNum.SecondNum = Convert.ToDouble(value);
                OnPropertyChanged("Result");
            }
        }
        private string result;
        public string Result
        {
            get
            {
                return result;
                //return value;
                //return modelNum.Result.ToString();
            }
            set
            {
                result = value;
                OnPropertyChanged("Result");
            }
        }

        //Constructor
        public CalcViewModel()
        {
            Result = "500";
            addCommand = new RelayCommand(AddNumber, CanAdd);
        }
        private ICommand addCommand;
        public ICommand AddCommand
        {
            get { return addCommand; }
            set { addCommand = value; }
        }

        public bool CanAdd(object obj)
        {
            //if(Convert.ToDouble(FirstNum)>0 && Convert.ToDecimal(SecondNum)>0)
            //{
            //    return true;
            //}
            return true;
        }
        public void AddNumber(object obj)
        {
            Result = (Convert.ToDouble(FirstNum) +Convert.ToDouble(SecondNum)).ToString();
        }



    }
}
