namespace RandomNumberFormsApp
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxForNum = new System.Windows.Forms.TextBox();
            this.btnCheckNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(263, 285);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите число";
            // 
            // txtBoxForNum
            // 
            this.txtBoxForNum.Location = new System.Drawing.Point(390, 48);
            this.txtBoxForNum.Name = "txtBoxForNum";
            this.txtBoxForNum.Size = new System.Drawing.Size(78, 20);
            this.txtBoxForNum.TabIndex = 2;
            // 
            // btnCheckNum
            // 
            this.btnCheckNum.Location = new System.Drawing.Point(490, 48);
            this.btnCheckNum.Name = "btnCheckNum";
            this.btnCheckNum.Size = new System.Drawing.Size(45, 20);
            this.btnCheckNum.TabIndex = 3;
            this.btnCheckNum.Text = "ОК";
            this.btnCheckNum.UseVisualStyleBackColor = true;
            this.btnCheckNum.Click += new System.EventHandler(this.btnCheckNum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 310);
            this.Controls.Add(this.btnCheckNum);
            this.Controls.Add(this.txtBoxForNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxForNum;
        private System.Windows.Forms.Button btnCheckNum;
    }
}

