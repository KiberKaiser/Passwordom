
namespace Program
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.ButtonClose = new System.Windows.Forms.Button();
            this.ButtonCover = new System.Windows.Forms.Button();
            this.LowerCaseBox = new System.Windows.Forms.CheckBox();
            this.SpecialSymbolsBox = new System.Windows.Forms.CheckBox();
            this.NumbericBox = new System.Windows.Forms.CheckBox();
            this.ButtonGenerate = new System.Windows.Forms.Button();
            this.MainLabel = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.LengthBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UpperCaseBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonClose
            // 
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Noto Sans Cond", 21.75F, System.Drawing.FontStyle.Bold);
            this.ButtonClose.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonClose.Location = new System.Drawing.Point(323, 2);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(46, 48);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.Text = "X";
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonCover
            // 
            this.ButtonCover.FlatAppearance.BorderSize = 0;
            this.ButtonCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCover.Font = new System.Drawing.Font("Rubik", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCover.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonCover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonCover.Location = new System.Drawing.Point(265, -8);
            this.ButtonCover.Name = "ButtonCover";
            this.ButtonCover.Size = new System.Drawing.Size(52, 58);
            this.ButtonCover.TabIndex = 1;
            this.ButtonCover.Text = "-";
            this.ButtonCover.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonCover.UseVisualStyleBackColor = true;
            this.ButtonCover.Click += new System.EventHandler(this.ButtonCover_Click);
            // 
            // LowerCaseBox
            // 
            this.LowerCaseBox.AutoSize = true;
            this.LowerCaseBox.Font = new System.Drawing.Font("Noto Sans Cond", 14.25F, System.Drawing.FontStyle.Bold);
            this.LowerCaseBox.ForeColor = System.Drawing.SystemColors.Control;
            this.LowerCaseBox.Location = new System.Drawing.Point(5, 156);
            this.LowerCaseBox.Name = "LowerCaseBox";
            this.LowerCaseBox.Size = new System.Drawing.Size(119, 30);
            this.LowerCaseBox.TabIndex = 2;
            this.LowerCaseBox.Text = "Lower case";
            this.LowerCaseBox.UseVisualStyleBackColor = true;
            // 
            // SpecialSymbolsBox
            // 
            this.SpecialSymbolsBox.AutoSize = true;
            this.SpecialSymbolsBox.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.SpecialSymbolsBox.ForeColor = System.Drawing.SystemColors.Control;
            this.SpecialSymbolsBox.Location = new System.Drawing.Point(5, 126);
            this.SpecialSymbolsBox.Name = "SpecialSymbolsBox";
            this.SpecialSymbolsBox.Size = new System.Drawing.Size(136, 26);
            this.SpecialSymbolsBox.TabIndex = 3;
            this.SpecialSymbolsBox.Text = "Special symbols";
            this.SpecialSymbolsBox.UseVisualStyleBackColor = true;
            // 
            // NumbericBox
            // 
            this.NumbericBox.AutoSize = true;
            this.NumbericBox.Font = new System.Drawing.Font("Noto Sans Cond", 14.25F, System.Drawing.FontStyle.Bold);
            this.NumbericBox.ForeColor = System.Drawing.SystemColors.Control;
            this.NumbericBox.Location = new System.Drawing.Point(141, 125);
            this.NumbericBox.Name = "NumbericBox";
            this.NumbericBox.Size = new System.Drawing.Size(104, 30);
            this.NumbericBox.TabIndex = 5;
            this.NumbericBox.Text = "Numbers";
            this.NumbericBox.UseVisualStyleBackColor = true;
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.BackColor = System.Drawing.Color.White;
            this.ButtonGenerate.FlatAppearance.BorderSize = 0;
            this.ButtonGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGenerate.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonGenerate.ForeColor = System.Drawing.Color.Black;
            this.ButtonGenerate.Location = new System.Drawing.Point(265, 156);
            this.ButtonGenerate.Name = "ButtonGenerate";
            this.ButtonGenerate.Size = new System.Drawing.Size(91, 30);
            this.ButtonGenerate.TabIndex = 6;
            this.ButtonGenerate.Text = "Generate";
            this.ButtonGenerate.UseVisualStyleBackColor = false;
            this.ButtonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Grunt Grotesk", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.MainLabel.Location = new System.Drawing.Point(-2, 7);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(257, 41);
            this.MainLabel.TabIndex = 7;
            this.MainLabel.Text = "Passwordom";
            this.MainLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MainLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // TextBox
            // 
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox.Location = new System.Drawing.Point(5, 62);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(272, 20);
            this.TextBox.TabIndex = 8;
            // 
            // LengthBox
            // 
            this.LengthBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LengthBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LengthBox.Location = new System.Drawing.Point(5, 100);
            this.LengthBox.Name = "LengthBox";
            this.LengthBox.Size = new System.Drawing.Size(68, 20);
            this.LengthBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(79, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Length of password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Cond", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(283, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 44);
            this.label2.TabIndex = 11;
            this.label2.Text = "Generated \r\n password";
            // 
            // UpperCaseBox
            // 
            this.UpperCaseBox.AutoSize = true;
            this.UpperCaseBox.Font = new System.Drawing.Font("Noto Sans Cond", 14.25F, System.Drawing.FontStyle.Bold);
            this.UpperCaseBox.ForeColor = System.Drawing.SystemColors.Control;
            this.UpperCaseBox.Location = new System.Drawing.Point(141, 156);
            this.UpperCaseBox.Name = "UpperCaseBox";
            this.UpperCaseBox.Size = new System.Drawing.Size(118, 30);
            this.UpperCaseBox.TabIndex = 13;
            this.UpperCaseBox.Text = "Upper case";
            this.UpperCaseBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(2, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 14);
            this.label3.TabIndex = 14;
            this.label3.Text = "by CyberKaiser\'s software";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(368, 209);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UpperCaseBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LengthBox);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.ButtonGenerate);
            this.Controls.Add(this.NumbericBox);
            this.Controls.Add(this.SpecialSymbolsBox);
            this.Controls.Add(this.LowerCaseBox);
            this.Controls.Add(this.ButtonCover);
            this.Controls.Add(this.ButtonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "Passwordom";
            this.Load += new System.EventHandler(this.Form_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Button ButtonCover;
        private System.Windows.Forms.CheckBox LowerCaseBox;
        private System.Windows.Forms.CheckBox SpecialSymbolsBox;
        private System.Windows.Forms.CheckBox NumbericBox;
        private System.Windows.Forms.Button ButtonGenerate;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.TextBox LengthBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox UpperCaseBox;
        private System.Windows.Forms.Label label3;
    }
}

