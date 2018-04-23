Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace DXTabControlExample.ViewModel
    Public Class TabItemViewModel
        Inherits ViewModelBase

        Public Property Header() As String
            Get
                Return GetProperty(Function() Header)
            End Get
            Set(ByVal value As String)
                SetProperty(Function() Header, value)
            End Set
        End Property

        Public Property Content() As Object
            Get
                Return GetProperty(Function() Content)
            End Get
            Set(ByVal value As Object)
                SetProperty(Function() Content, value)
            End Set
        End Property

        Public Sub New()
            Header = "New Item"
            Content = "New Tab Item"
        End Sub
    End Class
End Namespace
