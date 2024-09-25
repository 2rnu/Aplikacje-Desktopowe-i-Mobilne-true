namespace WinFormsApp1
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
            button1 = new Button();
            checkBoxMath = new CheckBox();
            checkBoxPolish = new CheckBox();
            label1 = new Label();
            checkBoxWebDevelopment = new CheckBox();
            lessonChecked = new Label();
            resault = new Label();
            label2 = new Label();
            radioButtonPizzaNo = new RadioButton();
            radioButtonPizzaYes = new RadioButton();
            label3 = new Label();
            pizzaResault = new Label();
            label4 = new Label();
            textBoxName = new TextBox();
            label5 = new Label();
            labelName = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Location = new Point(190, 12);
            button1.Name = "button1";
            button1.Size = new Size(413, 88);
            button1.TabIndex = 0;
            button1.Text = "Przycisk";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBoxMath
            // 
            checkBoxMath.AutoSize = true;
            checkBoxMath.Checked = true;
            checkBoxMath.CheckState = CheckState.Checked;
            checkBoxMath.Location = new Point(12, 139);
            checkBoxMath.Name = "checkBoxMath";
            checkBoxMath.Size = new Size(92, 19);
            checkBoxMath.TabIndex = 1;
            checkBoxMath.Text = "Matematyka";
            checkBoxMath.UseVisualStyleBackColor = true;
            checkBoxMath.CheckedChanged += checkBoxMath_CheckedChanged;
            // 
            // checkBoxPolish
            // 
            checkBoxPolish.AutoSize = true;
            checkBoxPolish.Location = new Point(12, 164);
            checkBoxPolish.Name = "checkBoxPolish";
            checkBoxPolish.Size = new Size(57, 19);
            checkBoxPolish.TabIndex = 2;
            checkBoxPolish.Text = "Polski";
            checkBoxPolish.UseVisualStyleBackColor = true;
            checkBoxPolish.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 121);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 3;
            label1.Text = "Ulubione zajęcia w szkole";
            // 
            // checkBoxWebDevelopment
            // 
            checkBoxWebDevelopment.AutoSize = true;
            checkBoxWebDevelopment.Location = new Point(12, 189);
            checkBoxWebDevelopment.Name = "checkBoxWebDevelopment";
            checkBoxWebDevelopment.Size = new Size(133, 19);
            checkBoxWebDevelopment.TabIndex = 4;
            checkBoxWebDevelopment.Text = "Witryny Internetowe";
            checkBoxWebDevelopment.UseVisualStyleBackColor = true;
            // 
            // lessonChecked
            // 
            lessonChecked.AutoSize = true;
            lessonChecked.Location = new Point(390, 121);
            lessonChecked.Name = "lessonChecked";
            lessonChecked.Size = new Size(114, 15);
            lessonChecked.TabIndex = 5;
            lessonChecked.Text = "Wybrany przedmiot:";
            // 
            // resault
            // 
            resault.AutoSize = true;
            resault.Location = new Point(565, 121);
            resault.Name = "resault";
            resault.Size = new Size(126, 15);
            resault.TabIndex = 6;
            resault.Text = "Czekam na odpowiedz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 229);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 7;
            label2.Text = "Czy lubisz pizze z ananasem?";
            // 
            // radioButtonPizzaNo
            // 
            radioButtonPizzaNo.AutoSize = true;
            radioButtonPizzaNo.Location = new Point(13, 261);
            radioButtonPizzaNo.Name = "radioButtonPizzaNo";
            radioButtonPizzaNo.Size = new Size(43, 19);
            radioButtonPizzaNo.TabIndex = 8;
            radioButtonPizzaNo.TabStop = true;
            radioButtonPizzaNo.Text = "Nie";
            radioButtonPizzaNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonPizzaYes
            // 
            radioButtonPizzaYes.AutoSize = true;
            radioButtonPizzaYes.Location = new Point(13, 285);
            radioButtonPizzaYes.Name = "radioButtonPizzaYes";
            radioButtonPizzaYes.Size = new Size(42, 19);
            radioButtonPizzaYes.TabIndex = 9;
            radioButtonPizzaYes.TabStop = true;
            radioButtonPizzaYes.Text = "Tak";
            radioButtonPizzaYes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(390, 229);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 10;
            label3.Text = "Twoja odpowiedź:";
            // 
            // pizzaResault
            // 
            pizzaResault.AutoSize = true;
            pizzaResault.Location = new Point(568, 229);
            pizzaResault.Name = "pizzaResault";
            pizzaResault.Size = new Size(126, 15);
            pizzaResault.TabIndex = 11;
            pizzaResault.Text = "Czekam na odpowiedz";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 330);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 12;
            label4.Text = "Podaj swoje imię:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(13, 348);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(98, 23);
            textBoxName.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(390, 330);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 14;
            label5.Text = "Mam na imię:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(568, 330);
            labelName.Name = "labelName";
            labelName.Size = new Size(30, 15);
            labelName.TabIndex = 15;
            labelName.Text = "Brak";
            labelName.Click += label6_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 407);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 16;
            label6.Text = "Ulubiona gra:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "GTA V", "CS:GO", "OVERWATCH 2", "BRAWL STARS" });
            comboBox1.Location = new Point(13, 425);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(805, 575);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(labelName);
            Controls.Add(label5);
            Controls.Add(textBoxName);
            Controls.Add(label4);
            Controls.Add(pizzaResault);
            Controls.Add(label3);
            Controls.Add(radioButtonPizzaYes);
            Controls.Add(radioButtonPizzaNo);
            Controls.Add(label2);
            Controls.Add(resault);
            Controls.Add(lessonChecked);
            Controls.Add(checkBoxWebDevelopment);
            Controls.Add(label1);
            Controls.Add(checkBoxPolish);
            Controls.Add(checkBoxMath);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Pierwszy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox checkBoxMath;
        private CheckBox checkBoxPolish;
        private Label label1;
        private CheckBox checkBoxWebDevelopment;
        private Label lessonChecked;
        private Label resault;
        private Label label2;
        private RadioButton radioButtonPizzaNo;
        private RadioButton radioButtonPizzaYes;
        private Label label3;
        private Label pizzaResault;
        private Label label4;
        private TextBox textBoxName;
        private Label label5;
        private Label labelName;
        private Label label6;
        private ComboBox comboBox1;
    }
}