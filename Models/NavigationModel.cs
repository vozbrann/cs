using System;
using Practice4.Views;
using Practice4.Windows;

namespace Practice4.Models
{

    public enum ModesEnum
    {
        Calendar,
    }

    public class NavigationModel
    {

        private ContentWindow _contentWindow;
        private CalendarView _calendarView;

        public NavigationModel(ContentWindow contentWindow)
        {
            _contentWindow = contentWindow;
            _calendarView = new CalendarView();
        }

        public void Navigate(ModesEnum mode)
        {
            switch (mode)
            {
                case ModesEnum.Calendar:
                    _contentWindow.ContentControl.Content = _calendarView;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }
        }

    }
}
