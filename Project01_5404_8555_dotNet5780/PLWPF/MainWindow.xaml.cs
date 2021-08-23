using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace PLWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
            NavigationService.NavigationStack.Push(this);
            //SunTimes.CalculateSunRiseSetTimes(35.224,);



        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            grGR.Visibility = Visibility.Visible;

        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            grHu.Visibility = Visibility.Visible;

           
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {


        }

        private void Button_Click_PrivateHost(object sender, RoutedEventArgs e)
        {
            PrivateHost w1 = new PrivateHost();
            w1.Show();
            this.Visibility = Visibility.Collapsed;
        }

        private void enter(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            if (b != null)
            {
                b.Content = b.Content;
            }

        }
        private void live(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            if (b != null)
            {
                b.Content = b.Content;
            }
        }
        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_AddGr(object sender, RoutedEventArgs e)
        {
            AddGR win = new AddGR();
            win.Show();
            this.Visibility = Visibility.Collapsed;
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Question win = new Question();
            win.Show();
            this.Visibility = Visibility.Collapsed;
        }
        private void Button_Click_feed(object sender, RoutedEventArgs e)
        {
            Feedback win = new Feedback();
            win.Show();
            this.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_(object sender, RoutedEventArgs e)
        {
            Feedback win = new Feedback();
            win.Show();
            this.Close();
        }
        private void grHu_MouseLeave(object sender, RoutedEventArgs e)
        {
            grHu.Visibility = Visibility.Collapsed;
        }
        private void grGR_MouseLeave(object sender, RoutedEventArgs e)
        {
            grGR.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_SiteOwner(object sender, RoutedEventArgs e)
        {
            SiteOwner SO = new SiteOwner();
            SO.Show();
            this.Visibility = Visibility.Collapsed;
        }
        public System.Collections.Specialized.NameValueCollection ServerVariables;
        private void Language_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_AddHost(object sender, RoutedEventArgs e)
        {
            AddHost Ah = new AddHost();
            Ah.Show();
            this.Visibility = Visibility.Collapsed;
        }

        private void Button_Click_hu(object sender, RoutedEventArgs e)
        {
            HotelRecommended Hr = new HotelRecommended();
            Hr.Show();
            this.Visibility = Visibility.Collapsed;
        }
    }
}
