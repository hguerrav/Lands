

namespace Lands.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using Models;
    public class LandViewModel : BaseViewModel
    {
        #region Attributes
        private ObservableCollection<Border> bordes;
        #endregion
        #region Properties
        public Land Land
        {
            get;
            set;
        }
        public ObservableCollection<Border> Borders
        {
            get { return this.bordes; }
            set { SetValue(ref this.bordes, value); }
        }
        #endregion
        #region Methods
        private void LoadBoreders()
        {
            this.Borders = new ObservableCollection<Border>();
            foreach (var border in this.Land.Borders)
            {
                var land = MainViewModel.GetInstance().LandsList.
                                         Where(l => l.Alpha3Code == border).
                                         FirstOrDefault();
                if(land != null)
                {
                    this.Borders.Add(new Border
                    {
                        Code = land.Alpha3Code,
                        Name = land.Name,
                    });
                }
            }
        }
        #endregion

        #region Consturctors
        public LandViewModel(Land land)
        {
            this.Land = land;
            this.LoadBoreders();
        }

        
        #endregion
    }
}
