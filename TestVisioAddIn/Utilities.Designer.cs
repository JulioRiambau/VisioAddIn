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
            this.group1 = this.Factory.CreateRibbonGroup();
            this.SayHello = this.Factory.CreateRibbonButton();
            this.buttonReplace = this.Factory.CreateRibbonButton();
            this.Find = this.Factory.CreateRibbonEditBox();
            this.Replace = this.Factory.CreateRibbonEditBox();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.SayHello);
            this.group1.Items.Add(this.buttonReplace);
            this.group1.Items.Add(this.Find);
            this.group1.Items.Add(this.Replace);
            this.group1.Label = "group1";
            this.group1.Name = "group1";
            // 
            // SayHello
            // 
            this.SayHello.Label = "Hello!";
            this.SayHello.Name = "SayHello";
            this.SayHello.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SayHello_Click);
            // 
            // buttonReplace
            // 
            this.buttonReplace.Label = "Replace";
            this.buttonReplace.Name = "buttonReplace";
            this.buttonReplace.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonReplace_Click);
            // 
            // Find
            // 
            this.Find.Label = "Find";
            this.Find.Name = "Find";
            this.Find.Text = null;
            this.Find.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Find_TextChanged);
            // 
            // Replace
            // 
            this.Replace.Label = "Replace";
            this.Replace.Name = "Replace";
            this.Replace.Text = null;
            this.Replace.TextChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Replace_TextChanged);
            // 
            // Utilities
            // 
            this.Name = "Utilities";
            this.RibbonType = "Microsoft.Visio.Drawing";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Utilities_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SayHello;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonReplace;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox Find;
        internal Microsoft.Office.Tools.Ribbon.RibbonEditBox Replace;
    }

    partial class ThisRibbonCollection
    {
        internal Utilities Utilities
        {
            get { return this.GetRibbon<Utilities>(); }
        }
    }
}
