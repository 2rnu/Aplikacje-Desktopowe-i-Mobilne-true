namespace Layout
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            groupBox1 = new GroupBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            treeView1 = new TreeView();
            textBox2 = new TextBox();
            splitContainer1 = new SplitContainer();
            button1 = new Button();
            label2 = new Label();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(radioButton1);
            flowLayoutPanel1.Location = new Point(292, 52);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 100);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(3, 32);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(516, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 73);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(69, 23);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(60, 15);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(treeView1);
            panel1.Location = new Point(368, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(324, 100);
            panel1.TabIndex = 2;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(3, 3);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(121, 97);
            treeView1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(151, 31);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(203, 161);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Size = new Size(150, 99);
            splitContainer1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(18, 13);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 17);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox1;
        private RadioButton radioButton1;
        private GroupBox groupBox1;
        private LinkLabel linkLabel1;
        private Label label1;
        private Panel panel1;
        private TextBox textBox2;
        private TreeView treeView1;
        private SplitContainer splitContainer1;
        private Label label2;
        private Button button1;
    }
}