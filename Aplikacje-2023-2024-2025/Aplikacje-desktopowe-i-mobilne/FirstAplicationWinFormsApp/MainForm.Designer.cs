namespace FirstAplicationWinFormsApp
{
    partial class MainForm
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
            buttonFirst = new Button();
            SuspendLayout();
            // 
            // buttonFirst
            // 
            buttonFirst.BackColor = Color.FromArgb(0, 192, 0);
            buttonFirst.Font = new Font("SimSun", 15.75F, FontStyle.Italic | FontStyle.Strikeout, GraphicsUnit.Point, 0);
            buttonFirst.ForeColor = Color.Red;
            buttonFirst.Location = new Point(182, 56);
            buttonFirst.Name = "buttonFirst";
            buttonFirst.Size = new Size(295, 68);
            buttonFirst.TabIndex = 0;
            buttonFirst.Text = "Pierwszy przycisk2";
            buttonFirst.UseVisualStyleBackColor = false;
            buttonFirst.Click += buttonFirst_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(676, 348);
            Controls.Add(buttonFirst);
            Name = "MainForm";
            Text = "Pierwsza aplikacja";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonFirst;
    }
}
