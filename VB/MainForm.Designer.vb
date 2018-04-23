Imports Microsoft.VisualBasic
Imports System
Namespace RibbonApplicationMenuBottomPaneFlicker
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.ribbon = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.applicationMenu = New DevExpress.XtraBars.Ribbon.ApplicationMenu(Me.components)
			Me.bottomPaneControlContainer = New DevExpress.XtraBars.PopupControlContainer(Me.components)
			Me.exitSimpleButton = New DevExpress.XtraEditors.SimpleButton()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.exitButton = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
			Me.clientPanel = New DevExpress.XtraEditors.PanelControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.applicationMenu, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bottomPaneControlContainer, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.bottomPaneControlContainer.SuspendLayout()
			CType(Me.clientPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.clientPanel.SuspendLayout()
			Me.SuspendLayout()
			' 
			' ribbon
			' 
			Me.ribbon.ApplicationButtonDropDownControl = Me.applicationMenu
			Me.ribbon.ApplicationButtonKeyTip = ""
			Me.ribbon.ApplicationIcon = Nothing
			Me.ribbon.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.exitButton, Me.barButtonItem1, Me.barButtonItem2, Me.barButtonItem3})
			Me.ribbon.Location = New System.Drawing.Point(0, 0)
			Me.ribbon.MaxItemId = 4
			Me.ribbon.Name = "ribbon"
			Me.ribbon.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
			Me.ribbon.SelectedPage = Me.ribbonPage1
			Me.ribbon.Size = New System.Drawing.Size(320, 143)
			Me.ribbon.StatusBar = Me.ribbonStatusBar
			' 
			' applicationMenu
			' 
			Me.applicationMenu.BottomPaneControlContainer = Me.bottomPaneControlContainer
			Me.applicationMenu.ItemLinks.Add(Me.barButtonItem2)
			Me.applicationMenu.ItemLinks.Add(Me.exitButton)
			Me.applicationMenu.ItemLinks.Add(Me.barButtonItem3)
			Me.applicationMenu.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.LargeImagesText
			Me.applicationMenu.Name = "applicationMenu"
			Me.applicationMenu.Ribbon = Me.ribbon
			Me.applicationMenu.RightPaneControlContainer = Nothing
			Me.applicationMenu.RightPaneWidth = 240
'			Me.applicationMenu.BeforePopup += New System.ComponentModel.CancelEventHandler(Me.applicationMenu_BeforePopup);
			' 
			' bottomPaneControlContainer
			' 
			Me.bottomPaneControlContainer.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.bottomPaneControlContainer.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.bottomPaneControlContainer.Appearance.Options.UseBackColor = True
			Me.bottomPaneControlContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.bottomPaneControlContainer.Controls.Add(Me.simpleButton1)
			Me.bottomPaneControlContainer.Controls.Add(Me.exitSimpleButton)
			Me.bottomPaneControlContainer.Location = New System.Drawing.Point(27, 36)
			Me.bottomPaneControlContainer.Name = "bottomPaneControlContainer"
			Me.bottomPaneControlContainer.Ribbon = Me.ribbon
			Me.bottomPaneControlContainer.Size = New System.Drawing.Size(281, 31)
			Me.bottomPaneControlContainer.TabIndex = 0
			Me.bottomPaneControlContainer.Visible = False
			' 
			' exitSimpleButton
			' 
			Me.exitSimpleButton.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.exitSimpleButton.Location = New System.Drawing.Point(203, 3)
			Me.exitSimpleButton.Name = "exitSimpleButton"
			Me.exitSimpleButton.Size = New System.Drawing.Size(75, 23)
			Me.exitSimpleButton.TabIndex = 0
			Me.exitSimpleButton.Text = "Exit"
'			Me.exitSimpleButton.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Caption = "barButtonItem2"
			Me.barButtonItem2.Id = 2
			Me.barButtonItem2.Name = "barButtonItem2"
			' 
			' exitButton
			' 
			Me.exitButton.Caption = "Exit"
			Me.exitButton.Id = 0
			Me.exitButton.Name = "exitButton"
'			Me.exitButton.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.exitButton_ItemClick);
			' 
			' barButtonItem3
			' 
			Me.barButtonItem3.Caption = "barButtonItem3 wwer werwre werwerw werwer werwer"
			Me.barButtonItem3.Id = 3
			Me.barButtonItem3.Name = "barButtonItem3"
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "barButtonItem1 edfsdf sdfsdf sdfsdf sdfsfd"
			Me.barButtonItem1.Id = 1
			Me.barButtonItem1.Name = "barButtonItem1"
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
			Me.ribbonPage1.KeyTip = ""
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "ribbonPage1"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.KeyTip = ""
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
			' 
			' ribbonStatusBar
			' 
			Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 267)
			Me.ribbonStatusBar.Name = "ribbonStatusBar"
			Me.ribbonStatusBar.Ribbon = Me.ribbon
			Me.ribbonStatusBar.Size = New System.Drawing.Size(320, 25)
			' 
			' clientPanel
			' 
			Me.clientPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.clientPanel.Controls.Add(Me.bottomPaneControlContainer)
			Me.clientPanel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.clientPanel.Location = New System.Drawing.Point(0, 143)
			Me.clientPanel.Name = "clientPanel"
			Me.clientPanel.Size = New System.Drawing.Size(320, 124)
			Me.clientPanel.TabIndex = 2
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(3, 5)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "simpleButton1"
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(320, 292)
			Me.Controls.Add(Me.clientPanel)
			Me.Controls.Add(Me.ribbonStatusBar)
			Me.Controls.Add(Me.ribbon)
			Me.Name = "MainForm"
			Me.Ribbon = Me.ribbon
			Me.StatusBar = Me.ribbonStatusBar
			Me.Text = "MainForm"
			CType(Me.applicationMenu, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bottomPaneControlContainer, System.ComponentModel.ISupportInitialize).EndInit()
			Me.bottomPaneControlContainer.ResumeLayout(False)
			CType(Me.clientPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.clientPanel.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private ribbon As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
		Private clientPanel As DevExpress.XtraEditors.PanelControl
		Private WithEvents applicationMenu As DevExpress.XtraBars.Ribbon.ApplicationMenu
		Private WithEvents exitButton As DevExpress.XtraBars.BarButtonItem
		Private bottomPaneControlContainer As DevExpress.XtraBars.PopupControlContainer
		Private WithEvents exitSimpleButton As DevExpress.XtraEditors.SimpleButton
		Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem
		Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace