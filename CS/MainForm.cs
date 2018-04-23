using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System.Reflection;
using System.Drawing;
using DevExpress.XtraBars.ViewInfo;
using DevExpress.XtraBars.Controls;
using DevExpress.XtraBars.Forms;

namespace RibbonApplicationMenuBottomPaneFlicker
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void simpleButton1_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void simpleButton1_Click_1(object sender, System.EventArgs e)
        {
        }

        bool internalCalculating = false;

        private void applicationMenu_BeforePopup(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (internalCalculating)
                return;

            internalCalculating = true;

            try
            {
               MethodInfo mi = typeof(ApplicationMenu).GetMethod("CreateSubControl", BindingFlags.NonPublic | BindingFlags.Instance);
               IFormContainedControl pc = mi.Invoke(applicationMenu, new object[] { Ribbon.Manager }) as IFormContainedControl;
               bottomPaneControlContainer.Width = pc.CalcSize(-1, -1).Width;
            }
            finally {
                internalCalculating = false;
            }


        }
    }
}