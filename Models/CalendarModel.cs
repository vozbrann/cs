using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Practice4.Manager;
using Practice4.ViewModels;

namespace Practice4.Models
{
    public class CalendarModel
    {
        public int CalculateAge(DateTime date)
        {
            DateTime? selectedDate = date;
            DateTime zeroTime = new DateTime(1, 1, 1);

            DateTime today = DateTime.Today;
            TimeSpan span = today - date;
            int age = (zeroTime + span).Year - 1;

            return age;
        }

        public bool CheckForBirthday(DateTime date)
        {
            DateTime today = DateTime.Today;
            if (today.Month == date.Month && today.Day == date.Day)
            {
                MessageBox.Show("Happy Birthday!!!");
                return true;
            }
            else
            {
                return false;
            }
        }

        public string WesternAstrological(DateTime date)
        {
            switch (date.Month)
            {
                case 1: return (date.Day <= 20) ? "Козерог" : "Водолей"; break;
                case 2: return (date.Day <= 19) ? "Водолей" : "Рыбы"; break;
                case 3: return (date.Day <= 21) ? "Рыбы" : "Овен"; break;
                case 4: return (date.Day <= 20) ? "Овен" : "Телец"; break;
                case 5: return (date.Day <= 21) ? "Телец" : "Близнецы"; break;
                case 6: return (date.Day <= 22) ? "Близнецы" : "Рак"; break;
                case 7: return (date.Day <= 23) ? "Рак" : "Лев"; break;
                case 8: return (date.Day <= 23) ? "Лев" : "Дева"; break;
                case 9: return (date.Day <= 24) ? "Дева" : "Весы"; break;
                case 10: return (date.Day <= 23) ? "Весы" : "Скорпион"; break;
                case 11: return (date.Day <= 23) ? "Скорпион" : "Стрелец"; break;
                case 12: return (date.Day <= 22) ? "Стрелец" : "Козерог"; break;
                default: return "Error";
            }
        }

        public string ChineseAstrological(DateTime date)
        {
            int startYear = 1876;
            int year = date.Year;

            while ((year - startYear)>=12)
            {
                startYear += 12;
            }

            int resultNumber = year - startYear + 1;

            switch (resultNumber)
            {
                case 1: return "Крыса";
                case 2: return "Бык";
                case 3: return "Тигр";
                case 4: return "Заяц";
                case 5: return "Дракон";
                case 6: return "Змея";
                case 7: return "Лошадь";
                case 8: return "Овца";
                case 9: return "Обезьяна";
                case 10: return "Петух";
                case 11: return "Собака";
                case 12: return "Кабан";
                default: return "Error";
            }

        }

    }
}
