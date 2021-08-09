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
<<<<<<< HEAD
        // Get List User
=======
>>>>>>> b6a33113512e3f30ab70cfc710fe17ef4ffdf454
        public async void ListUser()
        {

            var uri = "http://192.168.0.102:5000/api/Home";
            var client = new HttpClient();
            var response = await client.GetStringAsync(uri);

            var list = JsonConvert.DeserializeObject<List<UserInfo>>(response);
            ListDemo.ItemsSource = list;

        }
    }
}