﻿

namespace Lands.ViewModels
    
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Models;
    public class MainViewModel
    {
      
        #region Porperties
        public List<Land> LandsList
        {
            get;
            set;
        }
        #endregion
        #region ViewModels
        public LoginViewModel Login
        {
            get;
            set;
        }
        public LandsViewModel Lands
        {
            get;
            set;
        }
        public LandViewModel Land
        {
            get;
            set;
        }
        #endregion
        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }
        #endregion
        #region Singleyton
        private static MainViewModel instance;
         public static MainViewModel GetInstance()
        {
            if(instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }
        #endregion
    }
}
