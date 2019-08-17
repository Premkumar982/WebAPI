namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picComicImage = new System.Windows.Forms.PictureBox();
            this.btnGetComicImage = new System.Windows.Forms.Button();
            this.btnSunForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picComicImage)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // picComicImage
            // 
            this.picComicImage.Location = new System.Drawing.Point(187, 77);
            this.picComicImage.Name = "picComicImage";
            this.picComicImage.Size = new System.Drawing.Size(547, 700);
            this.picComicImage.TabIndex = 0;
            this.picComicImage.TabStop = false;
            // 
            // btnGetComicImage
            // 
            this.btnGetComicImage.Location = new System.Drawing.Point(53, 28);
            this.btnGetComicImage.Name = "btnGetComicImage";
            this.btnGetComicImage.Size = new System.Drawing.Size(75, 23);
            this.btnGetComicImage.TabIndex = 1;
            this.btnGetComicImage.Text = "Get Image";
            this.btnGetComicImage.UseVisualStyleBackColor = true;
            this.btnGetComicImage.Click += new System.EventHandler(this.GetComicImage);
            // 
            // btnSunForm
            // 
            this.btnSunForm.Location = new System.Drawing.Point(175, 27);
            this.btnSunForm.Name = "btnSunForm";
            this.btnSunForm.Size = new System.Drawing.Size(75, 23);
            this.btnSunForm.TabIndex = 2;
            this.btnSunForm.Text = "Get Sun Form";
            this.btnSunForm.UseVisualStyleBackColor = true;
            this.btnSunForm.Click += new System.EventHandler(this.RedirectToSun);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSunForm);
            this.Controls.Add(this.btnGetComicImage);
            this.Controls.Add(this.picComicImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picComicImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picComicImage;
        private System.Windows.Forms.Button btnGetComicImage;
        private System.Windows.Forms.Button btnSunForm;
    }
}

