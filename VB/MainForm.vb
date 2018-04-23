Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports System.Reflection
Imports System.Drawing
Imports DevExpress.XtraBars.ViewInfo
Imports DevExpress.XtraBars.Controls
Imports DevExpress.XtraBars.Forms

Namespace RibbonApplicationMenuBottomPaneFlicker
	Partial Public Class MainForm
		Inherits RibbonForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub exitButton_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles exitButton.ItemClick
			Close()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitSimpleButton.Click
			Close()
		End Sub

		Private Sub simpleButton1_Click_1(ByVal sender As Object, ByVal e As System.EventArgs)
		End Sub

		Private internalCalculating As Boolean = False

		Private Sub applicationMenu_BeforePopup(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles applicationMenu.BeforePopup
			If internalCalculating Then
				Return
			End If

			internalCalculating = True

			Try
			   Dim mi As MethodInfo = GetType(ApplicationMenu).GetMethod("CreateSubControl", BindingFlags.NonPublic Or BindingFlags.Instance)
			   Dim pc As IFormContainedControl = TryCast(mi.Invoke(applicationMenu, New Object() { Ribbon.Manager }), IFormContainedControl)
			   bottomPaneControlContainer.Width = pc.CalcSize(-1, -1).Width
			Finally
				internalCalculating = False
			End Try


		End Sub
	End Class
End Namespace