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
    public partial class MergeGridPageFlyout : ContentPage
    {
        public ListView ListView;

        public MergeGridPageFlyout()
        {
            InitializeComponent();

            BindingContext = new MergeGridPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class MergeGridPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MergeGridPageFlyoutMenuItem> MenuItems { get; set; }

            public MergeGridPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<MergeGridPageFlyoutMenuItem>(new[]
                {
                    new MergeGridPageFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new MergeGridPageFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new MergeGridPageFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new MergeGridPageFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new MergeGridPageFlyoutMenuItem { Id = 4, Title = "Page 5" },
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