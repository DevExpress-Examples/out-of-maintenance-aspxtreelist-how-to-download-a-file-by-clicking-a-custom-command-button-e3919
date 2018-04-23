Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports DevExpress.Web.ASPxTreeList
Imports System.Collections

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		treeList.DataBind()
	End Sub


	Protected Sub atlSelection_DataBinding(ByVal sender As Object, ByVal e As EventArgs)
		TryCast(sender, ASPxTreeList).DataSource = CreateLeftListDataSource()
	End Sub
	Private Function CreateLeftListDataSource() As IEnumerable
		Dim l As New List(Of Object)()
		For i As Integer = 0 To 2
			l.Add(New With {Key .ItemId = i, Key .Code = "Code " & i, Key .Name = "Name " & i, Key .Description = "Description " & i, Key .ItemType = i Mod 3, Key .ParentId = i Mod 10, Key .Price = i * 10.00})
		Next i
		Return l
	End Function
End Class