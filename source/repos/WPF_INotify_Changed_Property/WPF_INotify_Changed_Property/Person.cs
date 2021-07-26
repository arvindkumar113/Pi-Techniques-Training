using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_INotify_Changed_Property
{
    public class Person : INotifyPropertyChanged
    {
        
        public event PropertyChangedEventHandler PropertyChanged;
         public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyChanged("FullName");
            }
        }
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChanged("FullName");
            }
        }
        public string fullName;
        public string FullName
        {
            get { return firstName+" "+lastName; }
        }



    }
}
