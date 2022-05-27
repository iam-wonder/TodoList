using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListApp;
using Xamarin.Forms;

namespace TodoList
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

      

      

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushPopupAsync(new PopupPage());
        }
    }
}
