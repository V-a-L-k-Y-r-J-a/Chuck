using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
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

namespace Chuck
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Searchs : Window
    {
        ApiProvider Api { get; }
        List<Result> Results { get; set; }
        List<ComboBoxItem> categories { get; set; }
        public Searchs()
        {
            InitializeComponent();  
            Results = new List<Result>();
            Api = new ApiProvider();
            LoadCategories();
            LoadRanDGridAsync();
        }
        async void LoadCategories() 
        {
            var c = await Api.GetCategoriesAsyncs();
            categories= new List<ComboBoxItem>();
            foreach (var item in c)
            categories.Add(new ComboBoxItem() { Content = item });
            CatCBox.DataContext = categories;
        }
        async void LoadJokesDGridAsync() 
        {
            Rootobject? rootobject = await Api.GetJokesAsyncs(SearchJokeTBox.Text);
            //foreach (var item in rootobject.result)
            //    Results.Add(item);
            JokesDGrid.ItemsSource = rootobject.result;
        }


        async void LoadRanDGridAsync()
        {
            Rootobject? rootobject = await Api.GetRanAsyncs();

            JokesDGrid.ItemsSource = rootobject.result; 
        }


          




        private void SearchJokeBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadJokesDGridAsync();
        }

        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private async void CatCBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void RandomJokeBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadRanDGridAsync();
        }

     
    }
}
