namespace TestVisioAddIn
{
    partial class Utilities : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Utilities()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.TextAdjust = this.Factory.CreateRibbonGroup();
            this.buttonReplace = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.TextAdjust.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.TextAdjust);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // TextAdjust
            // 
            this.TextAdjust.Items.Add(this.buttonReplace);
            this.TextAdjust.Label = "Text Adjust";
            this.TextAdjust.Name = "TextAdjust";
            // 
            // buttonReplace
            // 
            this.buttonReplace.Label = "Replace";
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonReplace_Click);
            // 
            // Utilities
            // 
            this.Name = "Utilities";
            this.RibbonType = "Microsoft.Visio.Drawing";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Utilities_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.TextAdjust.ResumeLayout(false);
            this.TextAdjust.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup TextAdjust;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonReplace;
    }

    partial class ThisRibbonCollection
    {
        internal Utilities Utilities
        {
            get { return this.GetRibbon<Utilities>(); }
        }
    }
}
