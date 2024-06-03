namespace GAMETICTACTOE
{
    partial class Welcome
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
            this.Adminbutton = new System.Windows.Forms.Button();
            this.Playerbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Adminbutton
            // 
            this.Adminbutton.Location = new System.Drawing.Point(268, 174);
            this.Adminbutton.Name = "Adminbutton";
            this.Adminbutton.Size = new System.Drawing.Size(250, 56);
            this.Adminbutton.TabIndex = 0;
            this.Adminbutton.Text = "ADMINISTRATOR";
            this.Adminbutton.UseVisualStyleBackColor = true;
            this.Adminbutton.Click += new System.EventHandler(this.Adminbutton_Click);
            // 
            // Playerbutton
            // 
            this.Playerbutton.Location = new System.Drawing.Point(268, 247);
            this.Playerbutton.Name = "Playerbutton";
            this.Playerbutton.Size = new System.Drawing.Size(250, 56);
            this.Playerbutton.TabIndex = 1;
            this.Playerbutton.Text = "Player";
            this.Playerbutton.UseVisualStyleBackColor = true;
            this.Playerbutton.Click += new System.EventHandler(this.Playerbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Playerbutton);
            this.Controls.Add(this.Adminbutton);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Adminbutton;
        private System.Windows.Forms.Button Playerbutton;
        private System.Windows.Forms.Label label1;
    }
}