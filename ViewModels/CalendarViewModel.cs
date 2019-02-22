using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using Practice4.Models;
using Practice4.Tools;

namespace Practice4.ViewModels
{
    class CalendarViewModel : ObservableItem
    {
        private DateTime _date = DateTime.Today;
        private int _age;
        private bool _birthday;
        private string _western;
        private string _chinese;

        public CalendarModel Model { get; private set; }

        public CalendarViewModel()
        {
            Model = new CalendarModel();
        }

        public DateTime Date
        {
            get { return _date; }
            set
            {
                ChangeAndNotify(ref _date, value, () => Date);
                Refresh_data(Date);
            }
        }

        public void Refresh_data(DateTime Date)
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            DateTime today = DateTime.Today;
            TimeSpan span = today - Date;
            if (DateTime.Today >= Date && (zeroTime + span).Year - 1 <= 135)
            {
                Age = Model.CalculateAge(Date);
                Model.CheckForBirthday(Date);
                Western = Model.WesternAstrological(Date);
                Chinese = Model.ChineseAstrological(Date);
                this.OnPropertyChanged("Age");
                this.OnPropertyChanged("Western");
                this.OnPropertyChanged("Chinese");
            }
            else
            {
                MessageBox.Show("Wrong birthday!");
            }
        }

        public int Age
        {
            get { return _age;}
            set
            {
                ChangeAndNotify(ref _age, value, () => Age);
            }
        }

        public bool Birthday
        {
            get { return _birthday; }
            set
            {
                ChangeAndNotify(ref _birthday, value, () => Birthday);
            }
        }

        public string Western
        {
            get { return _western; }
            set
            {
                ChangeAndNotify(ref _western, value, () => Western);
            }
        }

        public string Chinese
        {
            get { return _chinese; }
            set
            {
                ChangeAndNotify(ref _chinese, value, () => Chinese);
            }
        }
    }
}
