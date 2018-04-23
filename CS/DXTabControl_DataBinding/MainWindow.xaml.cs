using System.Windows;
using DXExample.DemoData;

namespace DXTabControl_DataBinding {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e) {
            tabControl.ItemsSource = Invoice.GetData();
        }
    }
}
