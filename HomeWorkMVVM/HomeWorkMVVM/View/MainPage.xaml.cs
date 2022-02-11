using HomeWorkMVVM.Models;
using HomeWorkMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HomeWorkMVVM
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel _vm = new MainPageViewModel();
        public MainPage()
        {
            InitializeComponent();
        }
        
      
        private async void Button_Clicked(object sender, EventArgs e)
        {
            ObservableCollection<Data> datas;
            datas = await _vm.LoadData();
            BindableLayout.SetItemsSource(Data_list, datas);
            base.OnAppearing();
        }
    }
}
