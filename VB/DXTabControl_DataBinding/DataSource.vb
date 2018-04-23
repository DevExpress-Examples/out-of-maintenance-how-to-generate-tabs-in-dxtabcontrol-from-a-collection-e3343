Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Namespace DXExample.DemoData
	Public Enum InvoiceStatus
		Ordered
		Payed
		Shipped
		Delivered
		Invalidated
	End Enum
	Public Class Invoice
		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateProductName As String
		Public Property ProductName() As String
			Get
				Return privateProductName
			End Get
			Set(ByVal value As String)
				privateProductName = value
			End Set
		End Property
		Private privatePrice As Double
		Public Property Price() As Double
			Get
				Return privatePrice
			End Get
			Set(ByVal value As Double)
				privatePrice = value
			End Set
		End Property
		Private privateOrderDate As DateTime
		Public Property OrderDate() As DateTime
			Get
				Return privateOrderDate
			End Get
			Set(ByVal value As DateTime)
				privateOrderDate = value
			End Set
		End Property
		Private privateDiscount As Double
		Public Property Discount() As Double
			Get
				Return privateDiscount
			End Get
			Set(ByVal value As Double)
				privateDiscount = value
			End Set
		End Property
		Private privateIsUrgent As Boolean
		Public Property IsUrgent() As Boolean
			Get
				Return privateIsUrgent
			End Get
			Set(ByVal value As Boolean)
				privateIsUrgent = value
			End Set
		End Property
		Private privateStatus As InvoiceStatus
		Public Property Status() As InvoiceStatus
			Get
				Return privateStatus
			End Get
			Set(ByVal value As InvoiceStatus)
				privateStatus = value
			End Set
		End Property
		Public Shared Function GetData() As List(Of Invoice)
			Dim data As New List(Of Invoice)()

            data.Add(New Invoice() With {.ID = 0, .ProductName = "Tofu", .IsUrgent = False,
                                         .Price = 235.54, .Discount = 9.4,
                                         .Status = InvoiceStatus.Invalidated,
                                         .OrderDate = New DateTime(2009, 3, 12)})
            data.Add(New Invoice() With {.ID = 1, .ProductName = "Ravioli Angelo", .IsUrgent = True,
                                         .Price = 178.45, .Discount = 6.1,
                                         .Status = InvoiceStatus.Delivered,
                                         .OrderDate = New DateTime(2009, 2, 9)})
            data.Add(New Invoice() With {.ID = 2, .ProductName = "Geitost", .IsUrgent = False,
                                         .Price = 89.98, .Discount = 5.4,
                                         .Status = InvoiceStatus.Payed,
                                         .OrderDate = New DateTime(2009, 4, 1)})
            data.Add(New Invoice() With {.ID = 3, .ProductName = "Chang", .IsUrgent = True,
                                         .Price = 189.33, .Discount = 18.2,
                                         .Status = InvoiceStatus.Shipped,
                                         .OrderDate = New DateTime(2009, 5, 23)})
            data.Add(New Invoice() With {.ID = 4, .ProductName = "Inlagd Sill", .IsUrgent = False,
                                         .Price = 509.1, .Discount = 22.2,
                                         .Status = InvoiceStatus.Ordered,
                                         .OrderDate = New DateTime(2009, 6, 30)})
            data.Add(New Invoice() With {.ID = 5, .ProductName = "Alice Mutton", .IsUrgent = True,
                                         .Price = 791.18, .Discount = 24.4,
                                         .Status = InvoiceStatus.Invalidated,
                                         .OrderDate = New DateTime(2009, 5, 7)})

			Return data
		End Function
	End Class
End Namespace
