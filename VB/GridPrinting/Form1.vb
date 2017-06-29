Imports Microsoft.VisualBasic
#Region "#usings"
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
' ...
#End Region ' #usings

Namespace GridPrinting
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

        Private Sub Form1_Load(ByVal sender As Object, _
        ByVal e As EventArgs) Handles MyBase.Load
            ' TODO: This line of code loads data into the 'nwindDataSet.SalesPerson' table. You can move, or remove it, as needed.
            Me.salesPersonTableAdapter.Fill(Me.nwindDataSet.SalesPerson)
        End Sub

#Region "#code"
Private Sub simpleButton1_Click(ByVal sender As Object, _
ByVal e As EventArgs) Handles simpleButton1.Click
    Dim componentLink As New PrintableComponentLink(New PrintingSystem())
    componentLink.Component = gridControl1
    componentLink.CreateDocument()
    Dim pt As New PrintTool(componentLink.PrintingSystemBase)
    pt.ShowPreviewDialog()
End Sub
#End Region ' #code

	End Class
End Namespace
