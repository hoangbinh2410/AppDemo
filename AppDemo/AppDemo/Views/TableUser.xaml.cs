using AppDemo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TableUser : ContentPage
    {
        public TableUser()
        {
            InitializeComponent();
            ListUser();
        }

        public async void ListUser()
        {

            var uri = "http://192.168.108.2:8080/api/Home";
            var client = new HttpClient();
            var response = await client.GetStringAsync(uri);
            
            var list = JsonConvert.DeserializeObject<List<UserInfo>>(response);
            ListDemo.ItemsSource = list;

        }
    }
}