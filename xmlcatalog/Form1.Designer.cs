namespace xmlcatalog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.titleHeader = new System.Windows.Forms.ColumnHeader();
            this.artistHeader = new System.Windows.Forms.ColumnHeader();
            this.countryHeader = new System.Windows.Forms.ColumnHeader();
            this.companyHeader = new System.Windows.Forms.ColumnHeader();
            this.priceHeader = new System.Windows.Forms.ColumnHeader();
            this.yearHeader = new System.Windows.Forms.ColumnHeader();
            this.numberHeader = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(344, 424);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadXMLToolStripMenuItem,
            this.transformToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1234, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadXMLToolStripMenuItem
            // 
            this.loadXMLToolStripMenuItem.Name = "loadXMLToolStripMenuItem";
            this.loadXMLToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.loadXMLToolStripMenuItem.Text = "Load XML";
            this.loadXMLToolStripMenuItem.Click += new System.EventHandler(this.loadXMLToolStripMenuItem_Click);
            // 
            // transformToolStripMenuItem
            // 
            this.transformToolStripMenuItem.Name = "transformToolStripMenuItem";
            this.transformToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.transformToolStripMenuItem.Text = "Transform";
            this.transformToolStripMenuItem.Click += new System.EventHandler(this.transformToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 27);
            this.textBox1.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.numberHeader,
            this.titleHeader,
            this.artistHeader,
            this.countryHeader,
            this.companyHeader,
            this.priceHeader,
            this.yearHeader});
            this.listView1.Location = new System.Drawing.Point(365, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(857, 459);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // titleHeader
            // 
            this.titleHeader.Text = "Title";
            this.titleHeader.Width = 120;
            // 
            // artistHeader
            // 
            this.artistHeader.Text = "Artist";
            this.artistHeader.Width = 120;
            // 
            // countryHeader
            // 
            this.countryHeader.Text = "Country";
            this.countryHeader.Width = 120;
            // 
            // companyHeader
            // 
            this.companyHeader.Text = "Company";
            this.companyHeader.Width = 120;
            // 
            // priceHeader
            // 
            this.priceHeader.Text = "Price";
            this.priceHeader.Width = 80;
            // 
            // yearHeader
            // 
            this.yearHeader.Text = "Year";
            this.yearHeader.Width = 80;
            // 
            // numberHeader
            // 
            this.numberHeader.Text = "#";
            this.numberHeader.Width = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 502);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Xml to Object";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loadXMLToolStripMenuItem;
        private ToolStripMenuItem transformToolStripMenuItem;
        private TextBox textBox1;
        private ListView listView1;
        private ColumnHeader titleHeader;
        private ColumnHeader artistHeader;
        private ColumnHeader countryHeader;
        private ColumnHeader companyHeader;
        private ColumnHeader priceHeader;
        private ColumnHeader yearHeader;
        private ColumnHeader numberHeader;
    }
}