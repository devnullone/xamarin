using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using xamarin.Auth;

namespace xamarin.ViewModels
{
    public class Page1ViewModel : BaseViewModel
    {
        public Page1ViewModel()
        {
            UtilisateurEstIlConnecter();
        }

        private async void UtilisateurEstIlConnecter()
        {
            var isAuth = DependencyService.Resolve<IFirebaseAuthentication>();
            if (isAuth.IsLoggedIn())
            {
                await Xamarin.Forms.Shell.Current.GoToAsync("//LoginPage");
            }
        }
    }
}
