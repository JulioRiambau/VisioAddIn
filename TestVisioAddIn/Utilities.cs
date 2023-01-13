using Microsoft.Office.Tools.Ribbon;

namespace TestVisioAddIn
{
    public partial class Utilities
    {
        private void Utilities_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void buttonReplace_Click(object sender, RibbonControlEventArgs e)
        {

            var form = new ReplaceText();
            form.Show();
        }
    }

    
}
