namespace TASK1POINT1
{
    partial class Display
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
            this.HelloWorldBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HelloWorldBox
            // 
            this.HelloWorldBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloWorldBox.Location = new System.Drawing.Point(89, 182);
            this.HelloWorldBox.Multiline = true;
            this.HelloWorldBox.Name = "HelloWorldBox";
            this.HelloWorldBox.ReadOnly = true;
            this.HelloWorldBox.Size = new System.Drawing.Size(588, 62);
            this.HelloWorldBox.TabIndex = 0;
            this.HelloWorldBox.Text = "HELLO WORLD";
            this.HelloWorldBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HelloWorldBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Display";
            this.Text = "HELLO WORLD TASK1.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HelloWorldBox;
    }
}

