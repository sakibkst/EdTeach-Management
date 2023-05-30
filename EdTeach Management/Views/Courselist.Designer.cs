namespace EdTeach_Management.Views
{
    partial class Courselist
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.courselistdatagridview = new System.Windows.Forms.DataGridView();
            this.backbutton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courselistdatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EdTeach_Management.Properties.Resources.onlinelogomaker_121322_0306_7332;
            this.pictureBox1.Location = new System.Drawing.Point(140, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // courselistdatagridview
            // 
            this.courselistdatagridview.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.courselistdatagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.courselistdatagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.courselistdatagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.courselistdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courselistdatagridview.EnableHeadersVisualStyles = false;
            this.courselistdatagridview.GridColor = System.Drawing.Color.MidnightBlue;
            this.courselistdatagridview.Location = new System.Drawing.Point(35, 173);
            this.courselistdatagridview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.courselistdatagridview.Name = "courselistdatagridview";
            this.courselistdatagridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.courselistdatagridview.RowHeadersWidth = 62;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.courselistdatagridview.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.courselistdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.courselistdatagridview.Size = new System.Drawing.Size(1051, 461);
            this.courselistdatagridview.TabIndex = 88;
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.backbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.backbutton.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold);
            this.backbutton.ForeColor = System.Drawing.Color.White;
            this.backbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backbutton.Location = new System.Drawing.Point(35, 636);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(139, 49);
            this.backbutton.TabIndex = 92;
            this.backbutton.Text = "Back";
            this.backbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Bisque;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(459, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 28);
            this.label11.TabIndex = 233;
            this.label11.Text = "Course List";
            // 
            // Courselist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1099, 689);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.courselistdatagridview);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Courselist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Courselist";
            this.Load += new System.EventHandler(this.Courselist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courselistdatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView courselistdatagridview;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Label label11;
    }
}