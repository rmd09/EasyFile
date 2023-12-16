namespace Interface
{
    partial class FormForPath
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForPath));
            button2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            checkCut = new CheckBox();
            checkSubdirictories = new CheckBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(499, 150);
            button2.Name = "button2";
            button2.Size = new Size(100, 34);
            button2.TabIndex = 18;
            button2.Text = "Обзор";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(17, 150);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(456, 34);
            textBox2.TabIndex = 17;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 106);
            label2.Name = "label2";
            label2.Size = new Size(335, 41);
            label2.TabIndex = 16;
            label2.Text = "Путь к конечной папке";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(499, 54);
            button1.Name = "button1";
            button1.Size = new Size(100, 34);
            button1.TabIndex = 15;
            button1.Text = "Обзор";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(17, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(456, 34);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(508, 41);
            label1.TabIndex = 12;
            label1.Text = "Путь к корневой (начальной) папке";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(380, 219);
            button3.Name = "button3";
            button3.Size = new Size(219, 62);
            button3.TabIndex = 14;
            button3.Text = "Готово";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkCut
            // 
            checkCut.AutoSize = true;
            checkCut.Checked = true;
            checkCut.CheckState = CheckState.Checked;
            checkCut.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkCut.Location = new Point(17, 205);
            checkCut.Name = "checkCut";
            checkCut.Size = new Size(326, 27);
            checkCut.TabIndex = 19;
            checkCut.Text = "Премещать отсортированные файлы";
            checkCut.UseVisualStyleBackColor = true;
            // 
            // checkSubdirictories
            // 
            checkSubdirictories.AutoSize = true;
            checkSubdirictories.Checked = true;
            checkSubdirictories.CheckState = CheckState.Checked;
            checkSubdirictories.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkSubdirictories.Location = new Point(17, 254);
            checkSubdirictories.Name = "checkSubdirictories";
            checkSubdirictories.Size = new Size(342, 27);
            checkSubdirictories.TabIndex = 20;
            checkSubdirictories.Text = "Сортировать файлы во всех подпапках";
            checkSubdirictories.UseVisualStyleBackColor = true;
            // 
            // FormForPath
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 304);
            Controls.Add(checkSubdirictories);
            Controls.Add(checkCut);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button3);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormForPath";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выберите путь...";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button button3;
        private CheckBox checkCut;
        private CheckBox checkSubdirictories;
    }
}