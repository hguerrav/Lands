


namespace Lands.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Models;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;

    public class LandItemViewModel : Land
    { 
        #region Command
         public ICommand SelectLandCommand

         {
            get
            {
                return new RelayCommand(SelectLand);
            }
        }
         public async void SelectLand()
         {
            MainViewModel.GetInstance().Land = new LandViewModel(this);

            await Application.Current.MainPage.Navigation.PushAsync(new LandTabbedPage());
         }
    #endregion

    }
}
