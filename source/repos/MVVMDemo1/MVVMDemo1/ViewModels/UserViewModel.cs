using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MVVMDemo1.Commands;
using MVVMDemo1.Models;
namespace MVVMDemo1.ViewModels
{
    public class UserViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("propertyName"));

            }
        }

        private User userObject = new User();

        public string UserId
        {
            get { return userObject.UserId.ToString(); }
            set
            {
                userObject.UserId = Convert.ToInt32(value);
                    OnPropertyChanged("UserId");
            }
        }

        public string FirstName
        {
            get { return userObject.FirstName; }
            set
            {
                userObject.FirstName= value;
                OnPropertyChanged("FirstName");
            }
        }
        public string LastName
        {
            get { return userObject.LastName; }
            set
            {
                userObject.LastName = value;
                OnPropertyChanged("LastName");
            }
        }
        public string Country
        {
            get { return userObject.Country; }
            set
            {
                userObject.Country = value;
                OnPropertyChanged("Country");
            }
        }



        #region
        //collection

        private ObservableCollection<User> _UserList;
        public ObservableCollection<User> Users
        {
            get
            {
                return _UserList;
            }
            set
            {
                Users = value;
            }
        }

        //add collection using constructor
        public UserViewModel()
        {
            _UserList = new ObservableCollection<User>
            {
                new User { UserId = 101, FirstName = "Arvind", LastName = "Kumar", Country = "India" },
                new User { UserId = 102, FirstName = "Arnav", LastName = "Kumar", Country = "India" },
                new User { UserId = 103, FirstName = "Atul", LastName = "Kumar", Country = "India" }
            };
            addCommand = new RelayCommand(AddUser, CanAdd);
            removeCommand = new RelayCommand(DeleteUser, CanDelete);
        }

        #endregion

        #region Command
        private ICommand addCommand;
        public ICommand AddCommand
        {
            get { return addCommand; }
            set { addCommand = value; }
        }

        private ICommand removeCommand;
        public ICommand RemoveCommand
        {
            get { return removeCommand; }
            set { removeCommand = value; }
        }

        #endregion

        public bool CanAdd(object obj)
        {

            if(Convert.ToInt32(UserId) > 0 )
            {
                return true;
            }
            return false;
        }
        public void AddUser(object obj)
        {
            User userobj = new User() { UserId = Convert.ToInt32(UserId), Country = Country, FirstName = FirstName, LastName = LastName };
            Users.Add(userobj);
            MessageBox.Show("Inserted User");
        }

        public bool CanDelete(object obj)
        {
            if (Convert.ToInt32(UserId) > 0)
            {
                return true;
            }
            return false;
        }
        public void DeleteUser(object obj)
        {
            User userobj = new User() { UserId = Convert.ToInt32(UserId), Country = Country, FirstName = FirstName, LastName = LastName };
            User searchUser = (from u in Users where u.UserId == userobj.UserId select u).SingleOrDefault();
            Users.Remove(searchUser);
            MessageBox.Show("Deleted Successfully");

        }



    }
}
