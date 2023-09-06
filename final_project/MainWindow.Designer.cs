namespace final_project
{
    partial class MainWindow
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lettersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createLetterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLetterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containsShapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containsColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containsTextureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nOfShapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.stopFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopFilterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.listBox1.Location = new System.Drawing.Point(37, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(86, 244);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(129, 94);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(315, 244);
            this.listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 20;
            this.listBox3.Location = new System.Drawing.Point(450, 94);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(338, 244);
            this.listBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Letters:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Created Shapes:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shapesToolStripMenuItem,
            this.lettersToolStripMenuItem,
            this.undoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // shapesToolStripMenuItem
            // 
            this.shapesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.createToolStripMenuItem,
            this.filterToolStripMenuItem1,
            this.stopFilterToolStripMenuItem1});
            this.shapesToolStripMenuItem.Name = "shapesToolStripMenuItem";
            this.shapesToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.shapesToolStripMenuItem.Text = "Shapes";
            this.shapesToolStripMenuItem.Click += new System.EventHandler(this.shapesToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editToolStripMenuItem.Text = "Edit...";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.createToolStripMenuItem.Text = "Create...";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem1
            // 
            this.filterToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shapeToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.textureToolStripMenuItem});
            this.filterToolStripMenuItem1.Name = "filterToolStripMenuItem1";
            this.filterToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.filterToolStripMenuItem1.Text = "Filter";
            this.filterToolStripMenuItem1.Click += new System.EventHandler(this.filterToolStripMenuItem1_Click);
            // 
            // shapeToolStripMenuItem
            // 
            this.shapeToolStripMenuItem.Name = "shapeToolStripMenuItem";
            this.shapeToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.shapeToolStripMenuItem.Text = "Shape ...";
            this.shapeToolStripMenuItem.Click += new System.EventHandler(this.shapeToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.colorToolStripMenuItem.Text = "Color ...";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // textureToolStripMenuItem
            // 
            this.textureToolStripMenuItem.Name = "textureToolStripMenuItem";
            this.textureToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.textureToolStripMenuItem.Text = "Texture ...";
            this.textureToolStripMenuItem.Click += new System.EventHandler(this.textureToolStripMenuItem_Click);
            // 
            // lettersToolStripMenuItem
            // 
            this.lettersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createLetterToolStripMenuItem,
            this.deleteLetterToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.stopFilterToolStripMenuItem});
            this.lettersToolStripMenuItem.Name = "lettersToolStripMenuItem";
            this.lettersToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.lettersToolStripMenuItem.Text = "Letters";
            this.lettersToolStripMenuItem.Click += new System.EventHandler(this.lettersToolStripMenuItem_Click);
            // 
            // createLetterToolStripMenuItem
            // 
            this.createLetterToolStripMenuItem.Name = "createLetterToolStripMenuItem";
            this.createLetterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.createLetterToolStripMenuItem.Text = "Create Letter";
            this.createLetterToolStripMenuItem.Click += new System.EventHandler(this.createLetterToolStripMenuItem_Click);
            // 
            // deleteLetterToolStripMenuItem
            // 
            this.deleteLetterToolStripMenuItem.Name = "deleteLetterToolStripMenuItem";
            this.deleteLetterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteLetterToolStripMenuItem.Text = "Delete Letter";
            this.deleteLetterToolStripMenuItem.Click += new System.EventHandler(this.deleteLetterToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.letterToolStripMenuItem,
            this.containsShapeToolStripMenuItem,
            this.containsColorToolStripMenuItem,
            this.containsTextureToolStripMenuItem,
            this.nOfShapesToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.filterToolStripMenuItem.Text = "Filter";
            this.filterToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
            // 
            // letterToolStripMenuItem
            // 
            this.letterToolStripMenuItem.Name = "letterToolStripMenuItem";
            this.letterToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.letterToolStripMenuItem.Text = "Letter ...";
            this.letterToolStripMenuItem.Click += new System.EventHandler(this.letterToolStripMenuItem_Click);
            // 
            // containsShapeToolStripMenuItem
            // 
            this.containsShapeToolStripMenuItem.Name = "containsShapeToolStripMenuItem";
            this.containsShapeToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.containsShapeToolStripMenuItem.Text = "Contains: Shape ...";
            this.containsShapeToolStripMenuItem.Click += new System.EventHandler(this.containsShapeToolStripMenuItem_Click);
            // 
            // containsColorToolStripMenuItem
            // 
            this.containsColorToolStripMenuItem.Name = "containsColorToolStripMenuItem";
            this.containsColorToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.containsColorToolStripMenuItem.Text = "Contains: Color ...";
            this.containsColorToolStripMenuItem.Click += new System.EventHandler(this.containsColorToolStripMenuItem_Click);
            // 
            // containsTextureToolStripMenuItem
            // 
            this.containsTextureToolStripMenuItem.Name = "containsTextureToolStripMenuItem";
            this.containsTextureToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.containsTextureToolStripMenuItem.Text = "Contains: Texture ...";
            this.containsTextureToolStripMenuItem.Click += new System.EventHandler(this.containsTextureToolStripMenuItem_Click);
            // 
            // nOfShapesToolStripMenuItem
            // 
            this.nOfShapesToolStripMenuItem.Name = "nOfShapesToolStripMenuItem";
            this.nOfShapesToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.nOfShapesToolStripMenuItem.Text = "N # of Shapes";
            this.nOfShapesToolStripMenuItem.Click += new System.EventHandler(this.nOfShapesToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Created Letters:";
            // 
            // stopFilterToolStripMenuItem
            // 
            this.stopFilterToolStripMenuItem.Name = "stopFilterToolStripMenuItem";
            this.stopFilterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.stopFilterToolStripMenuItem.Text = "Stop Filter";
            this.stopFilterToolStripMenuItem.Click += new System.EventHandler(this.stopFilterToolStripMenuItem_Click);
            // 
            // stopFilterToolStripMenuItem1
            // 
            this.stopFilterToolStripMenuItem1.Name = "stopFilterToolStripMenuItem1";
            this.stopFilterToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.stopFilterToolStripMenuItem1.Text = "Stop Filter";
            this.stopFilterToolStripMenuItem1.Click += new System.EventHandler(this.stopFilterToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem shapesToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem lettersToolStripMenuItem;
        private ToolStripMenuItem createLetterToolStripMenuItem;
        private ToolStripMenuItem deleteLetterToolStripMenuItem;
        private ToolStripMenuItem filterToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private Label label3;
        private ToolStripMenuItem filterToolStripMenuItem1;
        private ToolStripMenuItem shapeToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem textureToolStripMenuItem;
        private ToolStripMenuItem letterToolStripMenuItem;
        private ToolStripMenuItem containsShapeToolStripMenuItem;
        private ToolStripMenuItem containsColorToolStripMenuItem;
        private ToolStripMenuItem containsTextureToolStripMenuItem;
        private ToolStripMenuItem nOfShapesToolStripMenuItem;
        private ToolStripMenuItem stopFilterToolStripMenuItem1;
        private ToolStripMenuItem stopFilterToolStripMenuItem;
    }
}