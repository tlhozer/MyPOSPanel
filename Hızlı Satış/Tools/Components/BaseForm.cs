using System.Windows.Forms;

namespace Hızlı_Satış.Tools.Components
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Icon = Properties.Resources.AppIcon;
        }
    }
}