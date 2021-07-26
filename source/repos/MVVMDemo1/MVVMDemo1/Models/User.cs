using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo1.Models
{
    public class User : INotifyPropertyChanged
    {

        private int userId;
        public int UserId
        {
            get { return userId; }
            set
            {
                userId = value;
                OnPropertyChanged("UserId");
            }
        }

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }
        private string country;
        public string Country
        {
            get { return country; }
            set
            {
                country = value;
                OnPropertyChanged("Country");
            }
        }


        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
