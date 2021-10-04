
namespace laba_2_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите стоимость в копейках";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Price.Location = new System.Drawing.Point(12, 31);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(202, 23);
            this.Price.TabIndex = 1;
            // 
            // CalcButton
            // 
            this.CalcButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CalcButton.Location = new System.Drawing.Point(12, 60);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(202, 23);
            this.CalcButton.TabIndex = 2;
            this.CalcButton.Text = "Рассчитать";
            this.CalcButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(230, 105);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задача 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Button CalcButton;
    }
}

