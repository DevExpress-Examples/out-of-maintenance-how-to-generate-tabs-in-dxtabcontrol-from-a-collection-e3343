Imports DevExpress.Mvvm.POCO
Imports DXTabControlExample.Common
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.IO

Namespace DXTabControlExample.ViewModel

    Public Class MainViewModel

        Public Overridable Property Contacts As ObservableCollection(Of ContactViewModel)

        Public Sub New()
            Contacts = New ObservableCollection(Of ContactViewModel)() From {ViewModelSource.Create(Function() New ContactViewModel() With {.FirstName = "Carolyn", .LastName = "Baker", .Gender = Gender.Female, .Email = "carolyn.baker@example.com", .Phone = "(555)349-3010", .Address = "1198 Theresa Cir", .City = "Whitinsville", .State = "MA", .Zip = "01582"}), ViewModelSource.Create(Function() New ContactViewModel() With {.FirstName = "Amber", .LastName = "Seaman", .Gender = Gender.Female, .Phone = "(555)698-4285", .Address = "28700 S Main St", .City = "Wilsonville", .State = "AL", .Zip = "35188"}), ViewModelSource.Create(Function() New ContactViewModel() With {.FirstName = "Annie", .LastName = "Vicars", .Gender = Gender.Female, .Email = "annie.vicars@example.com", .Phone = "(555)922-1349", .Address = "7267 New York Ave", .City = "Jersey City", .State = "NJ", .Zip = "07306"}), ViewModelSource.Create(Function() New ContactViewModel() With {.FirstName = "Darlene", .LastName = "Catto", .Gender = Gender.Female, .Email = "darlene.catto@example.com", .Phone = "(555)752-0582", .Address = "32125 4th St NW #210", .City = "Washington", .State = "DC", .Zip = "20001"}), ViewModelSource.Create(Function() New ContactViewModel() With {.FirstName = "Angela", .LastName = "Gross", .Gender = Gender.Female, .Email = "angela.gross@example.com", .Phone = "(555)247-1252", .Address = "8723 Chicago Ave", .City = "Nederland", .State = "TX", .Zip = "77620"}), ViewModelSource.Create(Function() New ContactViewModel() With {.FirstName = "Edward", .LastName = "Keck", .Gender = Gender.Male, .Email = "edward.keck@example.com", .Phone = "410-7042", .Address = "38202 Greens Rd", .City = "Humble", .State = "TX", .Zip = "77397"}), ViewModelSource.Create(Function() New ContactViewModel() With {.FirstName = "Angela", .LastName = "Walker", .Gender = Gender.Female, .Email = "angela.walker@example.com", .Phone = "555", .Address = "8913 Lakeshore Dr", .City = "Jacksons Gap", .State = "AL", .Zip = "36863"}), ViewModelSource.Create(Function() New ContactViewModel() With {.FirstName = "Alice", .LastName = "Martin", .Gender = Gender.Female, .Email = "alice.martin@example.com", .Phone = "(555)493-8440", .Address = "652 Avonwick Gate", .City = "Toronto", .State = "ON", .Zip = "33125"}), ViewModelSource.Create(Function() New ContactViewModel() With {.FirstName = "Andrew", .LastName = "Carter", .Gender = Gender.Male, .Email = "andrew.carter@example.com", .Phone = "(555)578-3946", .Address = "7121 Bailey St", .City = "Worcester", .State = "MA", .Zip = "01605"}), ViewModelSource.Create(Function() New ContactViewModel() With {.FirstName = "George", .LastName = "Morrison", .Email = "george.morrison@example.com", .Phone = "(555)468-3668", .Address = "7716 Country Woods Cir", .City = "Kissimmee", .State = "FL", .Zip = "34747"})}
            InitializePhotos(Contacts)
        End Sub

        Private Sub InitializePhotos(ByVal contacts As IList(Of ContactViewModel))
            For Each contact As ContactViewModel In contacts
                contact.Photo = GetPhoto(contact)
            Next
        End Sub

        Private Function GetPhoto(ByVal name As String) As Byte()
            Return File.ReadAllBytes("Images\" & name)
        End Function

        Private Function GetPhoto(ByVal contact As ContactViewModel) As Byte()
            Return GetPhoto(contact.FirstName & contact.LastName & ".jpg")
        End Function
    End Class
End Namespace
