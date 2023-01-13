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
        private string find;

        private string replace;


        private void Utilities_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void SayHello_Click(object sender, RibbonControlEventArgs e)
        {

            var pages = Globals.ThisAddIn.Application.ActiveDocument.Pages;
            var properties = new List<string>();
            foreach (Visio.Page page in pages)
            {
                foreach (Visio.Shape shape in page.Shapes)
                {
                    short row = 0;

                    while (shape.get_CellsSRCExists(
                                                    (short)Visio.VisSectionIndices.visSectionProp,
                                                    row,
                                                    (short)Visio.VisCellIndices.visCustPropsValue,
                                                    (short)0) != 0)
                    {
                        string value = shape.get_CellsSRC(
                                                          (short)Visio.VisSectionIndices.visSectionProp,
                                                          row,
                                                          (short)Visio.VisCellIndices.visCustPropsValue
                                                         ).get_ResultStr(Visio.VisUnitCodes.visNoCast);

                        properties.Add(value);
                        row++;
                    }
                }
            }


            System.Windows.Forms.MessageBox.Show("Hello properties! => "+string.Join("|",properties));
        }

        private void buttonReplace_Click(object sender, RibbonControlEventArgs e)
        {

           

            var pages = Globals.ThisAddIn.Application.ActiveDocument.Pages;
            var formulas = new List<string>();
            
            foreach (Visio.Page page in pages)
            {
                foreach (Visio.Shape shape in page.Shapes)
                {
                    short row = 0;

                    while (shape.get_CellsSRCExists(
                                                    (short)Visio.VisSectionIndices.visSectionProp,
                                                    row,
                                                    (short)Visio.VisCellIndices.visCustPropsValue,
                                                    (short)0) != 0)
                    {

                        var label = shape.get_CellsSRC(
                                                   (short)Visio.VisSectionIndices.visSectionProp,
                                                   row,
                                                   (short)Visio.VisCellIndices.visCustPropsLabel
                                                  ).get_ResultStr(Visio.VisUnitCodes.visNoCast);

                        var cell = shape.get_CellsSRC(
                                                      (short)Visio.VisSectionIndices.visSectionProp,
                                                      row,
                                                      (short)Visio.VisCellIndices.visCustPropsValue
                                                     );

                        string value = cell.get_ResultStr(Visio.VisUnitCodes.visNoCast);

                        if (value.Contains(find))
                        {
                            //cell.Formula = value.Replace(find, replace);
                            formulas.Add(cell.Formula);
                            cell.FormulaU = $"\"\"\"{value.Replace(find, replace)}\"\"\"";
                        }


                        
                        row++;
                    }
                }
            }

            System.Windows.Forms.MessageBox.Show("formulas: "+ string.Join("**", formulas));
            //System.Windows.Forms.MessageBox.Show($"find {find} replace {replace}");

        }

        private void Find_TextChanged(object sender, RibbonControlEventArgs e)
        {
            find = Find.Text;
        }

        private void Replace_TextChanged(object sender, RibbonControlEventArgs e)
        {
            replace = Replace.Text;
        }
    }
}
