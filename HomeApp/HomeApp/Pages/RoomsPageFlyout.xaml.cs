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
    public partial class RoomsPageFlyout : ContentPage
    {
        public ListView ListView;

        public RoomsPageFlyout()
        {
            InitializeComponent();

            BindingContext = new RoomsPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class RoomsPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<RoomsPageFlyoutMenuItem> MenuItems { get; set; }

            public RoomsPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<RoomsPageFlyoutMenuItem>(new[]
                {
                    new RoomsPageFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new RoomsPageFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new RoomsPageFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new RoomsPageFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new RoomsPageFlyoutMenuItem { Id = 4, Title = "Page 5" },
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