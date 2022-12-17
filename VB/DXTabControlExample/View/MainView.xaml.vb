Imports System.Windows.Controls

Namespace DXTabControlExample.View

    ''' <summary>
    ''' Interaction logic for MainView.xaml
    ''' </summary>
    Public Partial Class MainView
        Inherits UserControl

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub DXTabControl_TabShown(ByVal sender As Object, ByVal e As DevExpress.Xpf.Core.TabControlTabShownEventArgs)
        End Sub
    End Class
End Namespace
