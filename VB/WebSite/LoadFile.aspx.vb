Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class LoadFile
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		Dim fileName As String = "Images/" & Request.Params(0) & ".jpg"
		Dim filePath As String = Server.MapPath(fileName)

		Response.AddHeader("Content-Disposition", "attachment; filename=" & Request.Params(0) & ".jpg")
		Response.ContentType = "image/x-jpg"
		Response.TransmitFile(filePath)
		Response.End()
	End Sub
End Class