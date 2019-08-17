namespace WindowsFormsApp1
{
    partial class SunForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblSunRise = new System.Windows.Forms.Label();
            this.lblSunRiseValue = new System.Windows.Forms.Label();
            this.lblSunSet = new System.Windows.Forms.Label();
            this.lblSunSetValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Sun Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GetSunData);
            // 
            // lblSunRise
            // 
            this.lblSunRise.AutoSize = true;
            this.lblSunRise.Location = new System.Drawing.Point(168, 201);
            this.lblSunRise.Name = "lblSunRise";
            this.lblSunRise.Size = new System.Drawing.Size(50, 13);
            this.lblSunRise.TabIndex = 1;
            this.lblSunRise.Text = "Sun Rise";
            // 
            // lblSunRiseValue
            // 
            this.lblSunRiseValue.AutoSize = true;
            this.lblSunRiseValue.Location = new System.Drawing.Point(260, 201);
            this.lblSunRiseValue.Name = "lblSunRiseValue";
            this.lblSunRiseValue.Size = new System.Drawing.Size(0, 13);
            this.lblSunRiseValue.TabIndex = 2;
            // 
            // lblSunSet
            // 
            this.lblSunSet.AutoSize = true;
            this.lblSunSet.Location = new System.Drawing.Point(171, 233);
            this.lblSunSet.Name = "lblSunSet";
            this.lblSunSet.Size = new System.Drawing.Size(45, 13);
            this.lblSunSet.TabIndex = 3;
            this.lblSunSet.Text = "Sun Set";
            // 
            // lblSunSetValue
            // 
            this.lblSunSetValue.AutoSize = true;
            this.lblSunSetValue.Location = new System.Drawing.Point(263, 232);
            this.lblSunSetValue.Name = "lblSunSetValue";
            this.lblSunSetValue.Size = new System.Drawing.Size(0, 13);
            this.lblSunSetValue.TabIndex = 4;
            // 
            // SunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSunSetValue);
            this.Controls.Add(this.lblSunSet);
            this.Controls.Add(this.lblSunRiseValue);
            this.Controls.Add(this.lblSunRise);
            this.Controls.Add(this.button1);
            this.Name = "SunForm";
            this.Text = "SunForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSunRise;
        private System.Windows.Forms.Label lblSunRiseValue;
        private System.Windows.Forms.Label lblSunSet;
        private System.Windows.Forms.Label lblSunSetValue;
    }
}