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
    public partial class GridPageFlyout : ContentPage
    {
        public ListView ListView;

        public GridPageFlyout()
        {
            InitializeComponent();

            BindingContext = new GridPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class GridPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<GridPageFlyoutMenuItem> MenuItems { get; set; }

            public GridPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<GridPageFlyoutMenuItem>(new[]
                {
                    new GridPageFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new GridPageFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new GridPageFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new GridPageFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new GridPageFlyoutMenuItem { Id = 4, Title = "Page 5" },
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