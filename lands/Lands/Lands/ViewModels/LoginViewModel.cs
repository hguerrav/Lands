using System;
using System.Collections.Generic;
using System.Text;


namespace Lands.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.ComponentModel;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;

    public class LoginViewModel : BaseViewModel

    {
        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        #region Attibutes
        private string email;
        private string password;
        private bool isRunning;
        private bool isEnabled;
        
        #endregion
        #region Property

        public string Email
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }
        public string Password
        {
            get { return this.password; }
            set{SetValue(ref this.password, value);}
        }
        public Boolean IsRunning
        {
            get
            {
                return this.isRunning;
            }
            set
            {
                SetValue(ref this.isRunning, value); 
            }

        }
        public Boolean IsRemembered
        {
            get;
            set;
        }
        public bool IsEnabled
        {
            get
            {
                return this.isEnabled;
            }
            set
            {
                SetValue(ref this.isEnabled, value);
            }
        }
            
        

        #endregion
        #region Command
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
            
        }

       

        private async void Login()
        {
            if(string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Your must enter an email.",
                    "Accept");
                return;
            }
            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error", 
                    "Your must enter an Password.", 
                    "Accept");
                return;
            }
            this.IsRunning = true;
            this.IsEnabled = false;
            if(this.Email != "hector@apsoingt.com" || this.Password !="1234")
            {
                this.IsRunning = false;
                this.IsEnabled = true;
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Email or Password Incorrect.",
                    "Accept");
                this.Password = string.Empty;
                return;
            }
            this.IsRunning = false;
            this.IsEnabled = true;

            this.Email = string.Empty;
            this.Password = string.Empty;

            MainViewModel.GetInstance().Lands = new LandsViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new LandsPage());
        }

        #endregion
        #region Contructors
        public LoginViewModel()
        {
            this.IsRemembered = true;
            this.IsEnabled = true;

            this.Email = "hector@apsoingt.com";
            this.Password = "1234";
        }
        #endregion
    }

    
}
