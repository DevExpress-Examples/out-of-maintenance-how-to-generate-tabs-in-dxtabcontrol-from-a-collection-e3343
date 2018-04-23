Imports DevExpress.Mvvm
Imports System.Collections.ObjectModel

Namespace DXTabControlExample.ViewModel
    Public Class MainViewModel
        Inherits ViewModelBase

        Private _TabItems As ObservableCollection(Of TabItemViewModel)
        Public Property TabItems() As ObservableCollection(Of TabItemViewModel)
            Get
                Return GetProperty(Function() TabItems)
            End Get
            Set(ByVal value As ObservableCollection(Of TabItemViewModel))
                SetProperty(Function() TabItems, value)
            End Set
        End Property

        Public Sub New()
            TabItems = New ObservableCollection(Of TabItemViewModel)()
            TabItems.Add(New TabItemViewModel() With {.Header = "Tab 1", .Content = "Tab Item 1"})
            TabItems.Add(New TabItemViewModel() With {.Header = "Tab 2", .Content = "Tab Item 2"})
            TabItems.Add(New TabItemViewModel() With {.Header = "Tab 3", .Content = "Tab Item 3"})
            TabItems.Add(New TabItemViewModel() With {.Header = "Tab 4", .Content = "Tab Item 4"})
            TabItems.Add(New TabItemViewModel() With {.Header = "Tab 5", .Content = "Tab Item 5"})
            TabItems.Add(New TabItemViewModel() With {.Header = "Tab 6", .Content = "Tab Item 6"})
        End Sub
    End Class
End Namespace
