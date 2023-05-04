namespace ToolEntrySHD
{
    partial class frmToolEntrySHD
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
            this.btnInputPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.ImageView = new System.Windows.Forms.PictureBox();
            this.lblValueIndex = new System.Windows.Forms.Label();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.lblNameImage = new System.Windows.Forms.Label();
            this.txtNameImage = new System.Windows.Forms.TextBox();
            this.txtNameSubmited = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInputPath
            // 
            this.btnInputPath.Location = new System.Drawing.Point(18, 14);
            this.btnInputPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInputPath.Name = "btnInputPath";
            this.btnInputPath.Size = new System.Drawing.Size(45, 31);
            this.btnInputPath.TabIndex = 0;
            this.btnInputPath.Text = "....";
            this.btnInputPath.UseVisualStyleBackColor = true;
            this.btnInputPath.Click += new System.EventHandler(this.btnInputPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(71, 16);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(539, 26);
            this.txtPath.TabIndex = 3;
            this.txtPath.TabStop = false;
            // 
            // ImageView
            // 
            this.ImageView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageView.Location = new System.Drawing.Point(20, 52);
            this.ImageView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ImageView.Name = "ImageView";
            this.ImageView.Size = new System.Drawing.Size(590, 602);
            this.ImageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageView.TabIndex = 2;
            this.ImageView.TabStop = false;
            // 
            // lblValueIndex
            // 
            this.lblValueIndex.AutoSize = true;
            this.lblValueIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblValueIndex.Location = new System.Drawing.Point(1049, 54);
            this.lblValueIndex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValueIndex.Name = "lblValueIndex";
            this.lblValueIndex.Size = new System.Drawing.Size(20, 29);
            this.lblValueIndex.TabIndex = 3;
            this.lblValueIndex.Text = "/";
            // 
            // txtEntry
            // 
            this.txtEntry.Location = new System.Drawing.Point(617, 90);
            this.txtEntry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(503, 26);
            this.txtEntry.TabIndex = 1;
            this.txtEntry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEntry_KeyDown);
            // 
            // lblNameImage
            // 
            this.lblNameImage.AutoSize = true;
            this.lblNameImage.Location = new System.Drawing.Point(25, 596);
            this.lblNameImage.Name = "lblNameImage";
            this.lblNameImage.Size = new System.Drawing.Size(0, 20);
            this.lblNameImage.TabIndex = 4;
            // 
            // txtNameImage
            // 
            this.txtNameImage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNameImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameImage.Location = new System.Drawing.Point(617, 55);
            this.txtNameImage.Name = "txtNameImage";
            this.txtNameImage.ReadOnly = true;
            this.txtNameImage.Size = new System.Drawing.Size(392, 28);
            this.txtNameImage.TabIndex = 5;
            this.txtNameImage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNameImage_KeyDown);
            // 
            // txtNameSubmited
            // 
            this.txtNameSubmited.Location = new System.Drawing.Point(20, 628);
            this.txtNameSubmited.Name = "txtNameSubmited";
            this.txtNameSubmited.Size = new System.Drawing.Size(100, 26);
            this.txtNameSubmited.TabIndex = 6;
            this.txtNameSubmited.Visible = false;
            // 
            // frmToolEntrySHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 668);
            this.Controls.Add(this.txtNameSubmited);
            this.Controls.Add(this.txtNameImage);
            this.Controls.Add(this.lblNameImage);
            this.Controls.Add(this.txtEntry);
            this.Controls.Add(this.lblValueIndex);
            this.Controls.Add(this.ImageView);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnInputPath);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmToolEntrySHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmToolEntrySHD_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmToolEntrySHD_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ImageView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInputPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.PictureBox ImageView;
        private System.Windows.Forms.Label lblValueIndex;
        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.Label lblNameImage;
        private System.Windows.Forms.TextBox txtNameImage;
        private System.Windows.Forms.TextBox txtNameSubmited;
    }
}

