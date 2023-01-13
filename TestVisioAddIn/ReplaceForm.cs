using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestVisioAddIn
{
    public partial class ReplaceText : Form
    {
        private string find;

        private string replace;

        public ReplaceText()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void replace_Click(object sender, EventArgs e)
        {
            var replaceCounter = FindAndReplace();
            MessageBox.Show($"Replaced {replaceCounter} occurence(s)");
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            find = FindTextBox.Text;
        }

        private void ReplaceTextBox_TextChanged(object sender, EventArgs e)
        {
            replace = ReplaceTextBox.Text;
        }

        private int FindAndReplace()
        {
            var pages = Globals.ThisAddIn.Application.ActiveDocument.Pages;
            var formulas = new List<string>();
            var replaceCounter = 0;

            foreach (Microsoft.Office.Interop.Visio.Page page in pages)
            {
                foreach (Microsoft.Office.Interop.Visio.Shape shape in page.Shapes)
                {
                    short row = 0;

                    if (shape.Text.Contains(find))
                    {
                        replaceCounter++;
                        shape.Text = shape.Text.Replace(find, replace);
                    }

                    while (shape.get_CellsSRCExists(
                                                    (short)Microsoft.Office.Interop.Visio.VisSectionIndices.visSectionProp,
                                                    row,
                                                    (short)Microsoft.Office.Interop.Visio.VisCellIndices.visCustPropsValue,
                                                    (short)0) != 0)
                    {
                        var cell = shape.get_CellsSRC(
                                                      (short)Microsoft.Office.Interop.Visio.VisSectionIndices.visSectionProp,
                                                      row,
                                                      (short)Microsoft.Office.Interop.Visio.VisCellIndices.visCustPropsValue
                                                     );

                        string value = cell.get_ResultStr(Microsoft.Office.Interop.Visio.VisUnitCodes.visNoCast);

                        if (value.Contains(find))
                        {
                            replaceCounter++;
                            formulas.Add(cell.Formula);
                            cell.FormulaU = "\"" + value.Replace(find, replace) + "\"";
                        }

                        row++;
                    }
                }
            }

            return replaceCounter;
        }
    }
}
