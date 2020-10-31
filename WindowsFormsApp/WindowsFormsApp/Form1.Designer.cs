namespace WindowsFormsApp
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
            this.btnP509 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnP509
            // 
            this.btnP509.BackColor = System.Drawing.Color.DarkRed;
            this.btnP509.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP509.Location = new System.Drawing.Point(388, 226);
            this.btnP509.Name = "btnP509";
            this.btnP509.Size = new System.Drawing.Size(229, 79);
            this.btnP509.TabIndex = 0;
            this.btnP509.Text = "Click here";
            this.btnP509.UseVisualStyleBackColor = false;
            this.btnP509.Click += new System.EventHandler(this.btnP509_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 619);
            this.Controls.Add(this.btnP509);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "P509";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnP509;
    }
}

