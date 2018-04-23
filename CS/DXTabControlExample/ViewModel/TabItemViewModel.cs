using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DXTabControlExample.ViewModel {
    public class TabItemViewModel : ViewModelBase {
        public string Header {
            get { return GetProperty(() => Header); }
            set { SetProperty(() => Header, value); }
        }

        public object Content {
            get { return GetProperty(() => Content); }
            set { SetProperty(() => Content, value); }
        }

        public TabItemViewModel() {
            Header = "New Item";
            Content = "New Tab Item";
        }
    }
}
