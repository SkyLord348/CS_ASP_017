using System;
using System.Windows;
using System.Windows.Controls;

namespace CS_ASP_017LPB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Instatiate 2 Date Time variables

        public DateTime myFirstDate, mySecondDate;

        



        // Get First Date

        public void myCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {

            myFirstDate = myCalendar.SelectedDate.Value;
            


        }

        // Get Second Date

        public void mySecondCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {

            mySecondDate = mySecondCalendar.SelectedDate.Value;



        }

        // Call Black Out Method

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            SetBlackOutDates(myFirstDate, mySecondDate);




        }

        private void SetBlackOutDates(DateTime myFirstDate, DateTime mySecondDate)
        {

            BlackOutCalendar.BlackoutDates.Add(new CalendarDateRange(myFirstDate, mySecondDate));
            
            
            
        }





    }

}
