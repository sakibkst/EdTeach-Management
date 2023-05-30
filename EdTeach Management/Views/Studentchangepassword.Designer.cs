namespace EdTeach_Management.Views
{
    partial class Studentchangepassword
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.newpasswordtextbox = new System.Windows.Forms.TextBox();
            this.updatebutton = new System.Windows.Forms.Button();
            this.backbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EdTeach_Management.Properties.Resources.onlinelogomaker_121322_0306_7332;
            this.pictureBox1.Location = new System.Drawing.Point(168, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 13F);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(270, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 30);
            this.label1.TabIndex = 212;
            this.label1.Text = "New Password:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.newpasswordtextbox);
            this.panel2.Location = new System.Drawing.Point(493, 282);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel2.Size = new System.Drawing.Size(347, 27);
            this.panel2.TabIndex = 211;
            // 
            // newpasswordtextbox
            // 
            this.newpasswordtextbox.Location = new System.Drawing.Point(1, -5);
            this.newpasswordtextbox.Name = "newpasswordtextbox";
            this.newpasswordtextbox.Size = new System.Drawing.Size(347, 26);
            this.newpasswordtextbox.TabIndex = 1;
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.updatebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.updatebutton.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold);
            this.updatebutton.ForeColor = System.Drawing.Color.White;
            this.updatebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updatebutton.Location = new System.Drawing.Point(493, 358);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(165, 54);
            this.updatebutton.TabIndex = 221;
            this.updatebutton.Text = "Update";
            this.updatebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.Red;
            this.backbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.backbutton.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold);
            this.backbutton.ForeColor = System.Drawing.Color.White;
            this.backbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backbutton.Location = new System.Drawing.Point(12, 623);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(137, 54);
            this.backbutton.TabIndex = 223;
            this.backbutton.Text = "Back";
            this.backbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // Studentchangepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1099, 689);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Studentchangepassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studentchangepassword";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox newpasswordtextbox;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button backbutton;
    }
}