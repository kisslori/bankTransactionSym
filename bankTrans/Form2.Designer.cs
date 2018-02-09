namespace bankTrans
{
    partial class Form2
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
            this.ballance_label = new System.Windows.Forms.Label();
            this.ballance_amount_label = new System.Windows.Forms.Label();
            this.welc_label = new System.Windows.Forms.Label();
            this.welc_user_label = new System.Windows.Forms.Label();
            this.minus_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.plus_button = new System.Windows.Forms.Button();
            this.status_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ballance_label
            // 
            this.ballance_label.AutoSize = true;
            this.ballance_label.Location = new System.Drawing.Point(16, 59);
            this.ballance_label.Name = "ballance_label";
            this.ballance_label.Size = new System.Drawing.Size(84, 13);
            this.ballance_label.TabIndex = 0;
            this.ballance_label.Text = "Current ballance";
            this.ballance_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // ballance_amount_label
            // 
            this.ballance_amount_label.AutoSize = true;
            this.ballance_amount_label.ForeColor = System.Drawing.Color.Green;
            this.ballance_amount_label.Location = new System.Drawing.Point(130, 59);
            this.ballance_amount_label.Name = "ballance_amount_label";
            this.ballance_amount_label.Size = new System.Drawing.Size(0, 13);
            this.ballance_amount_label.TabIndex = 1;
            // 
            // welc_label
            // 
            this.welc_label.AutoSize = true;
            this.welc_label.Location = new System.Drawing.Point(67, 13);
            this.welc_label.Name = "welc_label";
            this.welc_label.Size = new System.Drawing.Size(57, 13);
            this.welc_label.TabIndex = 2;
            this.welc_label.Text = "Wellcome ";
            // 
            // welc_user_label
            // 
            this.welc_user_label.AutoSize = true;
            this.welc_user_label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.welc_user_label.Location = new System.Drawing.Point(130, 13);
            this.welc_user_label.Name = "welc_user_label";
            this.welc_user_label.Size = new System.Drawing.Size(0, 13);
            this.welc_user_label.TabIndex = 3;
            // 
            // minus_button
            // 
            this.minus_button.Location = new System.Drawing.Point(12, 99);
            this.minus_button.Name = "minus_button";
            this.minus_button.Size = new System.Drawing.Size(52, 42);
            this.minus_button.TabIndex = 4;
            this.minus_button.Text = "-";
            this.minus_button.UseVisualStyleBackColor = true;
            this.minus_button.Click += new System.EventHandler(this.minus_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // plus_button
            // 
            this.plus_button.Location = new System.Drawing.Point(206, 99);
            this.plus_button.Name = "plus_button";
            this.plus_button.Size = new System.Drawing.Size(46, 41);
            this.plus_button.TabIndex = 6;
            this.plus_button.Text = "+";
            this.plus_button.UseVisualStyleBackColor = true;
            this.plus_button.Click += new System.EventHandler(this.plus_button_Click);
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(16, 163);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(0, 13);
            this.status_label.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 185);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.plus_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.minus_button);
            this.Controls.Add(this.welc_user_label);
            this.Controls.Add(this.welc_label);
            this.Controls.Add(this.ballance_amount_label);
            this.Controls.Add(this.ballance_label);
            this.Name = "Form2";
            this.Text = "Account overview";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ballance_label;
        private System.Windows.Forms.Label ballance_amount_label;
        private System.Windows.Forms.Label welc_label;
        private System.Windows.Forms.Label welc_user_label;
        private System.Windows.Forms.Button minus_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button plus_button;
        private System.Windows.Forms.Label status_label;
    }
}