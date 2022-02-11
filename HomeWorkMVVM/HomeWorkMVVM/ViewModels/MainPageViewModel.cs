using HomeWorkMVVM.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Xamarin.Forms;
using System.Windows.Input;

namespace HomeWorkMVVM.ViewModels
{
    internal class MainPageViewModel 
    {
        private const string url = "https://gorest.co.in/public/v2/users";
        private HttpClient _Client = new HttpClient();
      
        public ICommand FILL => new Command(LoadData().Start);
        public async Task<ObservableCollection<Data>> LoadData()
        {
            var content = await _Client.GetStringAsync(url);
            var data = JsonConvert.DeserializeObject<List<Data>>(content);
            return (new ObservableCollection<Data>(data));
        }
      
    }
}
