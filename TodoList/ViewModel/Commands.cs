using System;
using System.Collections.Generic;
using System.Text;
using Rg.Plugins.Popup.Extensions;


namespace TodoList.ViewModel
{
    class Commands: Rg.Plugins.Popup.Pages.PopupPage
    {
       public void CloseWindow()
        {
            Navigation.PopPopupAsync();
        }
    }
}
