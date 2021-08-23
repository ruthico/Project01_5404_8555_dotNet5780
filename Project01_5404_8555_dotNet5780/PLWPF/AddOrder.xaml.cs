using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BE;
using BL;

namespace PLWPF
{
    /// <summary>
    /// Interaction logic for AddOrder.xaml
    /// </summary>
    /// 

    public partial class AddOrder : Window
    {
        BL.IBL bl;
        GuestRequest g;
        Host host;
       
        HostingUnit hostingUnit = new HostingUnit();


        IEnumerable<GuestRequest> guestRequest;
        public AddOrder(Host H)
        {
            bl = BL.FactoryBL.GetBL();
            guestRequest = new ObservableCollection<GuestRequest>();
            g = new GuestRequest();
            host = H;
            this.DataContext = host;
            InitializeComponent();
            NavigationService.NavigationStack.Push(this);
            this.AreaCB.ItemsSource = Enum.GetValues(typeof(BE.AreasInTheCountry));
            this.TypeHostingUnitCB.ItemsSource = Enum.GetValues(typeof(BE.TypesOfVacation));
            IEnumerable<string> nameHu = bl.NameOfUnit(host);
            this.NameHu.ItemsSource = nameHu;
        }

        
        private void Button_Click_All(object sender, RoutedEventArgs e)
        {
                
                ListView_GR.ItemsSource = bl.Get_GuestRequestListB();
           
        }
            private void Button_Click_HU(object sender, RoutedEventArgs e)
            {
                NameHu.Visibility = Visibility.Visible;
            }

            private void Choise_Click(object sender, RoutedEventArgs e)
            {
                BGR1.Visibility = Visibility.Visible;
            

        }
        void BackButton_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.NavigateBack();
        }

        private void NameHuCB_SelectionChanged(object sender, SelectionChangedEventArgs e)

        {

            guestRequest = bl.Get_GuestRequestListB();
            hostingUnit = bl.Host_ToHostingUnit(host, NameHu.SelectedItem.ToString());
            GuestRequest G = new GuestRequest();

            if (hostingUnit.Pool == false)
             guestRequest = bl.Condition_Guest_Request1(bl.PoolF, guestRequest); 
            if (hostingUnit.Garden == false)
            guestRequest = bl.Condition_Guest_Request1(bl.GardenF, guestRequest); 
            if (hostingUnit.Jacuzzi == false)
            guestRequest = bl.Condition_Guest_Request1(bl.GardenF, guestRequest); 
            if (hostingUnit.ChildrensAttractions == false)
            guestRequest = bl.Condition_Guest_Request1(bl.AttractionF, guestRequest); 
             if (hostingUnit.Breakfast == false)
            guestRequest = bl.Condition_Guest_Request1(bl.Breakfast, guestRequest);
            if (hostingUnit.Lunch == false)
             guestRequest = bl.Condition_Guest_Request1(bl.Lunch, guestRequest);
            if (hostingUnit.Dinner == false)
            guestRequest = bl.Condition_Guest_Request1(bl.Dinner, guestRequest);
            if (hostingUnit.Children > 0)
            { 
                guestRequest = bl.Condition_Guest_Request2(g => g.Children <= hostingUnit.Children, guestRequest);
            }
            if (hostingUnit.Adults > 0)
            {
                guestRequest = bl.Condition_Guest_Request2(g => g.Adults <= hostingUnit.Children, guestRequest);
            }
            if (hostingUnit.Room > 0)
            {
                guestRequest = bl.Condition_Guest_Request2(g => g.Room <= hostingUnit.Children, guestRequest);
            }
            guestRequest = bl.Condition_Guest_Request2(g => g.Type == hostingUnit.Type, guestRequest);
            guestRequest = bl.Condition_Guest_Request2(g => g.SubArea == hostingUnit.SubArea, guestRequest);
            ListView_GR.ItemsSource = guestRequest;

            }
        
            private void AreaCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                SubAreaCB.Visibility = Visibility.Visible;
            
            switch (AreaCB.SelectedValue.ToString())
                {
                    case ("הכל"):
                        SubAreaCB.SelectedItem = "{Binding Path=All,Mode=TwoWay}";
                        this.SubAreaCB.ItemsSource = Enum.GetValues(typeof(BE.All));
                        break;

                    case ("ירושלים"):
                        SubAreaCB.SelectedItem = "{Binding Path=Jerusalem,Mode=TwoWay}";
                        this.SubAreaCB.ItemsSource = Enum.GetValues(typeof(BE.Jerusalem));
                        break;

                    case ("צפון"):
                        SubAreaCB.SelectedItem = "{Binding Path=North,Mode=TwoWay}";
                        this.SubAreaCB.ItemsSource = Enum.GetValues(typeof(BE.North));
                        break;
                    case ("דרום"):
                        SubAreaCB.SelectedItem = "{Binding Path=South,Mode=TwoWay}";
                        this.SubAreaCB.ItemsSource = Enum.GetValues(typeof(BE.South));
                        break;
                    case ("מרכז"):
                        SubAreaCB.SelectedItem = "{Binding Path=Center,Mode=TwoWay}";
                        this.SubAreaCB.ItemsSource = Enum.GetValues(typeof(BE.Center));
                        break;
                }
            }

            private void SubAreaCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
            }


        private void ListView_GR_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void MouseDoubleClick_ListView_GR(object sender, RoutedEventArgs e)
        {
            if (((ListView)sender).SelectedItem!=null)
            {
                GuestRequest g = new GuestRequest();
                g = ((ListView)sender).SelectedItem as GuestRequest;
                GetHuName WIN = new GetHuName(host,g);
                WIN.Show();
            }
        }
        private void Execut_Click(object sender, RoutedEventArgs e)
        {
            GuestRequest G = new GuestRequest();
            g.Area = (AreasInTheCountry)Enum.Parse(typeof(AreasInTheCountry), AreaCB.SelectedItem.ToString(), true);
            g.SubArea = (All)Enum.Parse(typeof(All), SubAreaCB.SelectedItem.ToString(), true);
            g.Type = (TypesOfVacation)Enum.Parse(typeof(TypesOfVacation), TypeHostingUnitCB.SelectedItem.ToString(), true);

            if (int.Parse(SumAdults.Text) > 0)
            {
                guestRequest = bl.Condition_Guest_Request2(g =>g.Adults >= int.Parse(SumAdults.Text), guestRequest);
            }
            if (int.Parse(SumAdults.Text) > 0)
            {
                guestRequest = bl.Condition_Guest_Request2(g => g.Children >= int.Parse(Sumchilds.Text), guestRequest);
            }
            if (int.Parse(SumAdults.Text) > 0)
            {
                guestRequest = bl.Condition_Guest_Request2(g => g.Adults >= int.Parse(SumRoom.Text), guestRequest);
            }

            if (poolcb.IsChecked == true) guestRequest = bl.Condition_Guest_Request1(bl.PoolT, bl.Get_GuestRequestListB());
            else guestRequest = bl.Condition_Guest_Request1(bl.PoolF, bl.Get_GuestRequestListB());
            if (GardenCB.IsChecked == true) guestRequest = bl.Condition_Guest_Request1(bl.GardenT, guestRequest);
            else guestRequest = bl.Condition_Guest_Request1(bl.GardenF, guestRequest);
            if (jakuziCB.IsChecked == true) guestRequest = bl.Condition_Guest_Request1(bl.jakuzziT, guestRequest);
            else guestRequest = bl.Condition_Guest_Request1(bl.jakuzziF, guestRequest);
            if (AttractionCB.IsChecked == true) guestRequest = bl.Condition_Guest_Request1(bl.AttractionT, guestRequest);
            else guestRequest = bl.Condition_Guest_Request1(bl.AttractionF, guestRequest);
            if (BreakFastCB.IsChecked == true)
            {
                guestRequest = bl.Condition_Guest_Request1(bl.Breakfast, guestRequest);
            }
            if (LunchCB.IsChecked == true)
            {
                guestRequest = bl.Condition_Guest_Request1(bl.Lunch, guestRequest);
            }
            if (DinnerCB.IsChecked == true)
            {
                guestRequest = bl.Condition_Guest_Request1(bl.Dinner, guestRequest);
            }
            ListView_GR.ItemsSource = guestRequest;
        }
        private void ComboBox_SelectionChanged_4(object sender, SelectionChangedEventArgs e)
        {

        }




            //        if (hostingUnit.Pool == true)
            // guestRequest = bl.Condition_Guest_Request1(bl.PoolT, guestRequest); 
            //else
            // guestRequest = bl.Condition_Guest_Request1(bl.PoolF, guestRequest); 
            //if (hostingUnit.Garden == true)
            // guestRequest = bl.Condition_Guest_Request1(bl.GardenT, guestRequest); 
            //else
            //guestRequest = bl.Condition_Guest_Request1(bl.GardenF, guestRequest); 
            //if (hostingUnit.Jacuzzi == true)
            // guestRequest = bl.Condition_Guest_Request1(bl.GardenT, guestRequest); 
            //else
            //guestRequest = bl.Condition_Guest_Request1(bl.GardenF, guestRequest); 
            //if (hostingUnit.ChildrensAttractions == true)
            //guestRequest = bl.Condition_Guest_Request1(bl.AttractionT, guestRequest); 
            //else
            //guestRequest = bl.Condition_Guest_Request1(bl.AttractionF, guestRequest); 
            // if (hostingUnit.Breakfast == false)
            //guestRequest = bl.Condition_Guest_Request1(bl.Breakfast, guestRequest);
            //if (hostingUnit.Lunch == false)
            // guestRequest = bl.Condition_Guest_Request1(bl.Lunch, guestRequest);
            //if (hostingUnit.Dinner == false)
            //guestRequest = bl.Condition_Guest_Request1(bl.Dinner, guestRequest);
    }
}

