

namespace Lands.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Models;
    public class LandViewModel
    {
        #region Properties
        public Land Land
        {
            get;
            set;
        }
        #endregion
        

        #region Consturctors
        public LandViewModel(Land land)
        {
            this.Land = land;
        } 
        #endregion
    }
}
