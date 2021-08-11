using AppDemo.Models;
using AppDemo.ViewModels;
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
    public partial class Adduser : ContentPage
    {
        public DateTime enteredDate;
        public Adduser()
        {
            InitializeComponent();
            
        }


        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            var date = e.NewDate.ToString();
            enteredDate = DateTime.Parse(date);

            //return enteredDate;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            SaveUser();

        }
        public async void SaveUser()
        {
            
            var _user = new UserInfo();

            _user.Ten = Ten.Text;
            _user.Manv = Manv.Text;
            _user.Diachi = Diachi.Text;
            _user.Ngaysinh = enteredDate;
            _user.Gioitinh = itemPicker.ItemsSource.ToString();

            string url = "http://192.168.108.2:8080/api/Home";
            HttpClient client = new HttpClient();
            string jsonData = JsonConvert.SerializeObject(_user);
            StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(url, content);
            string result = await response.Content.ReadAsStringAsync();
        }

        //private DateTime DatePicker_DateSelected()
        //{
        //    throw new NotImplementedException();
        //}
    }
}