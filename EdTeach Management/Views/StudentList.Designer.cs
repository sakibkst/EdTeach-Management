namespace EdTeach_Management.Views
{
    partial class StudentList
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
            this.studentlistdatagridview = new System.Windows.Forms.DataGridView();
            this.backbutton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentlistdatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EdTeach_Management.Properties.Resources.onlinelogomaker_121322_0306_7332;
            this.pictureBox1.Location = new System.Drawing.Point(173, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 98;
            this.pictureBox1.TabStop = false;
            // 
            // studentlistdatagridview
            // 
            this.studentlistdatagridview.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.studentlistdatagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentlistdatagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.studentlistdatagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.studentlistdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentlistdatagridview.EnableHeadersVisualStyles = false;
            this.studentlistdatagridview.GridColor = System.Drawing.Color.MidnightBlue;
            this.studentlistdatagridview.Location = new System.Drawing.Point(13, 241);
            this.studentlistdatagridview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.studentlistdatagridview.Name = "studentlistdatagridview";
            this.studentlistdatagridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.studentlistdatagridview.RowHeadersWidth = 62;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.studentlistdatagridview.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.studentlistdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentlistdatagridview.Size = new System.Drawing.Size(1073, 447);
            this.studentlistdatagridview.TabIndex = 97;
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.Red;
            this.backbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.backbutton.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold);
            this.backbutton.ForeColor = System.Drawing.Color.White;
            this.backbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backbutton.Location = new System.Drawing.Point(921, 180);
            this.backbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(165, 54);
            this.backbutton.TabIndex = 141;
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
            this.label11.Location = new System.Drawing.Point(455, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 28);
            this.label11.TabIndex = 232;
            this.label11.Text = "Student List";
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 689);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.studentlistdatagridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentList";
            this.Load += new System.EventHandler(this.StudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentlistdatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView studentlistdatagridview;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Label label11;
    }
}