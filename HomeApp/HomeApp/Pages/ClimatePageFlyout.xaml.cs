using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClimatePageFlyout : ContentPage
    {
        public ListView ListView;

        public ClimatePageFlyout()
        {
            InitializeComponent();

            BindingContext = new ClimatePageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class ClimatePageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<ClimatePageFlyoutMenuItem> MenuItems { get; set; }

            public ClimatePageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<ClimatePageFlyoutMenuItem>(new[]
                {
                    new ClimatePageFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new ClimatePageFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new ClimatePageFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new ClimatePageFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new ClimatePageFlyoutMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}