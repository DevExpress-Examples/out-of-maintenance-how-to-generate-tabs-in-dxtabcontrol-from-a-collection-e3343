Imports Microsoft.VisualBasic
Imports System.Windows
Imports DXExample.DemoData

Namespace DXTabControl_DataBinding
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub LayoutRoot_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			tabControl.ItemsSource = Invoice.GetData()
		End Sub
	End Class
End Namespace
