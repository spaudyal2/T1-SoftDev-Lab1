                                                            //Subit Paudyal PROG 1124 Section 03;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Booking_Flight
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e) //for radio button for 1 way or 2 way trip.
        {

        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e) //for textblock- Full name
        {

        }

        private void TextBlock_SelectionChanged_1(object sender, RoutedEventArgs e) //for textblock- trip type
        {

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e) //since 1 way radio button is automatically selected as option
        {

        }

        private void okClick(object sender, RoutedEventArgs e) //what happens when you click "Submit" on the solution.
        {
            MessageDialog msg = new MessageDialog("Thank you for booking a flight with Air International, " + userName.Text);
            msg.ShowAsync();

         }
    }
}
