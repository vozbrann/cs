using System.Windows.Controls;
using Practice4.Models;
using Practice4.ViewModels;

namespace Practice4.Views
{
    /// <summary>
    /// Interaction logic for CalendarView.xaml
    /// </summary>
    public partial class CalendarView
    {

        private CalendarViewModel _calendarViewModel;

        public CalendarView()
        {
            InitializeComponent();
            _calendarViewModel = new CalendarViewModel();
            DataContext = _calendarViewModel;
        }
    }
}
