using Microsoft.Office.Tools.Ribbon;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Visio = Microsoft.Office.Interop.Visio;
using Office = Microsoft.Office.Core;

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
