namespace RibbonApplicationMenuBottomPaneFlicker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.applicationMenu = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.bottomPaneControlContainer = new DevExpress.XtraBars.PopupControlContainer(this.components);
            this.exitSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.exitButton = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.clientPanel = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPaneControlContainer)).BeginInit();
            this.bottomPaneControlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientPanel)).BeginInit();
            this.clientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.applicationMenu;
            this.ribbon.ApplicationButtonKeyTip = "";
            this.ribbon.ApplicationIcon = null;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.exitButton,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.SelectedPage = this.ribbonPage1;
            this.ribbon.Size = new System.Drawing.Size(320, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // applicationMenu
            // 
            this.applicationMenu.BottomPaneControlContainer = this.bottomPaneControlContainer;
            this.applicationMenu.ItemLinks.Add(this.barButtonItem2);
            this.applicationMenu.ItemLinks.Add(this.exitButton);
            this.applicationMenu.ItemLinks.Add(this.barButtonItem3);
            this.applicationMenu.MenuDrawMode = DevExpress.XtraBars.MenuDrawMode.LargeImagesText;
            this.applicationMenu.Name = "applicationMenu";
            this.applicationMenu.Ribbon = this.ribbon;
            this.applicationMenu.RightPaneControlContainer = null;
            this.applicationMenu.RightPaneWidth = 240;
            this.applicationMenu.BeforePopup += new System.ComponentModel.CancelEventHandler(this.applicationMenu_BeforePopup);
            // 
            // bottomPaneControlContainer
            // 
            this.bottomPaneControlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomPaneControlContainer.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.bottomPaneControlContainer.Appearance.Options.UseBackColor = true;
            this.bottomPaneControlContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.bottomPaneControlContainer.Controls.Add(this.simpleButton1);
            this.bottomPaneControlContainer.Controls.Add(this.exitSimpleButton);
            this.bottomPaneControlContainer.Location = new System.Drawing.Point(27, 36);
            this.bottomPaneControlContainer.Name = "bottomPaneControlContainer";
            this.bottomPaneControlContainer.Ribbon = this.ribbon;
            this.bottomPaneControlContainer.Size = new System.Drawing.Size(281, 31);
            this.bottomPaneControlContainer.TabIndex = 0;
            this.bottomPaneControlContainer.Visible = false;
            // 
            // exitSimpleButton
            // 
            this.exitSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitSimpleButton.Location = new System.Drawing.Point(203, 3);
            this.exitSimpleButton.Name = "exitSimpleButton";
            this.exitSimpleButton.Size = new System.Drawing.Size(75, 23);
            this.exitSimpleButton.TabIndex = 0;
            this.exitSimpleButton.Text = "Exit";
            this.exitSimpleButton.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // exitButton
            // 
            this.exitButton.Caption = "Exit";
            this.exitButton.Id = 0;
            this.exitButton.Name = "exitButton";
            this.exitButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.exitButton_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3 wwer werwre werwerw werwer werwer";
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1 edfsdf sdfsdf sdfsdf sdfsfd";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.KeyTip = "";
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.KeyTip = "";
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 267);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(320, 25);
            // 
            // clientPanel
            // 
            this.clientPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.clientPanel.Controls.Add(this.bottomPaneControlContainer);
            this.clientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientPanel.Location = new System.Drawing.Point(0, 143);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(320, 124);
            this.clientPanel.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(3, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 292);
            this.Controls.Add(this.clientPanel);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPaneControlContainer)).EndInit();
            this.bottomPaneControlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientPanel)).EndInit();
            this.clientPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.PanelControl clientPanel;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu;
        private DevExpress.XtraBars.BarButtonItem exitButton;
        private DevExpress.XtraBars.PopupControlContainer bottomPaneControlContainer;
        private DevExpress.XtraEditors.SimpleButton exitSimpleButton;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}