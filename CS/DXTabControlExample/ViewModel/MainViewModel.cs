using DevExpress.Mvvm;
using System.Collections.ObjectModel;

namespace DXTabControlExample.ViewModel {
    public class MainViewModel : ViewModelBase {
        
        private ObservableCollection<TabItemViewModel> _TabItems;
        public ObservableCollection<TabItemViewModel> TabItems {
            get { return GetProperty(() => TabItems); }
            set { SetProperty(() => TabItems, value); }
        }

        public MainViewModel() {
            TabItems = new ObservableCollection<TabItemViewModel>();
            TabItems.Add(new TabItemViewModel() { Header = "Tab 1", Content = "Tab Item 1" });
            TabItems.Add(new TabItemViewModel() { Header = "Tab 2", Content = "Tab Item 2" });
            TabItems.Add(new TabItemViewModel() { Header = "Tab 3", Content = "Tab Item 3" });
            TabItems.Add(new TabItemViewModel() { Header = "Tab 4", Content = "Tab Item 4" });
            TabItems.Add(new TabItemViewModel() { Header = "Tab 5", Content = "Tab Item 5" });
            TabItems.Add(new TabItemViewModel() { Header = "Tab 6", Content = "Tab Item 6" });
        }
    }
}
