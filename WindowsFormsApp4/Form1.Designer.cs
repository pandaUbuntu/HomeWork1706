namespace WindowsFormsApp4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartText = new System.Windows.Forms.TextBox();
            this.Key = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поле вводу тексту:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "Зсув:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 56);
            this.label3.TabIndex = 2;
            this.label3.Text = "Результат:";
            // 
            // StartText
            // 
            this.StartText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartText.Location = new System.Drawing.Point(34, 68);
            this.StartText.Name = "StartText";
            this.StartText.Size = new System.Drawing.Size(1132, 63);
            this.StartText.TabIndex = 3;
            // 
            // Key
            // 
            this.Key.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Key.Location = new System.Drawing.Point(34, 204);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(76, 63);
            this.Key.TabIndex = 4;
            this.Key.Text = "3";
            // 
            // Result
            // 
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result.Location = new System.Drawing.Point(34, 329);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(1132, 63);
            this.Result.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 639);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 93);
            this.button1.TabIndex = 6;
            this.button1.Text = "Зашифрувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(845, 639);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(321, 93);
            this.button2.TabIndex = 7;
            this.button2.Text = "Очистити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 56F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.StartText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StartText;
        private System.Windows.Forms.TextBox Key;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

