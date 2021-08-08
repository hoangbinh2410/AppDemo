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
    public partial class Adduser : ContentPage
    {
        public Adduser()
        {
            InitializeComponent();
            
       }
        public Command SaveUser
        {
            get
            {
                return new Command(async () =>
                {
                    UserInfo userInfo = new UserInfo();
                    userInfo.Ten = Ten;
                    userInfo.Manv = Manv;
                    userInfo.Diachi = Diachi;
                    string url = "http://192.168.0.102:5000/api/Home";
                    HttpClient client = new HttpClient();
                    string jsonData = JsonConvert.SerializeObject(userInfo);
                    StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await client.PostAsync(url, content);
                    
                });
            }

        }
        string _ten;
        public string Ten
        {
            get
            {
                return _ten;
            }
            set
            {
                if (value != null)
                {
                    _ten = value;
                    OnPropertyChanged();
                }
            }
        }
        string _manv;
        public string Manv
        {
            get
            {
                return _manv;
            }
            set
            {
                if (value != null)
                {
                    _manv = value;
                    OnPropertyChanged();
                }
            }
        }
        string _diachi;
        public string Diachi
        {
            get
            {
                return _diachi;
            }
            set
            {
                if (value != null)
                {
                    _diachi = value;
                    OnPropertyChanged();
                }
            }
        }
        
    }
}