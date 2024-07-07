namespace FareCalcSystem
{
    partial class addView
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
            this.endPlaceTB = new System.Windows.Forms.TextBox();
            this.startPlaceTB = new System.Windows.Forms.TextBox();
            this.priceNB = new System.Windows.Forms.NumericUpDown();
            this.confirmButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.priceNB)).BeginInit();
            this.SuspendLayout();
            // 
            // endPlaceTB
            // 
            this.endPlaceTB.Location = new System.Drawing.Point(265, 237);
            this.endPlaceTB.Name = "endPlaceTB";
            this.endPlaceTB.Size = new System.Drawing.Size(100, 19);
            this.endPlaceTB.TabIndex = 0;
            // 
            // startPlaceTB
            // 
            this.startPlaceTB.Location = new System.Drawing.Point(265, 173);
            this.startPlaceTB.Name = "startPlaceTB";
            this.startPlaceTB.Size = new System.Drawing.Size(100, 19);
            this.startPlaceTB.TabIndex = 1;
            // 
            // priceNB
            // 
            this.priceNB.Location = new System.Drawing.Point(265, 300);
            this.priceNB.Name = "priceNB";
            this.priceNB.Size = new System.Drawing.Size(120, 19);
            this.priceNB.TabIndex = 2;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(422, 380);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "完了";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(580, 380);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "閉じる";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // addView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.priceNB);
            this.Controls.Add(this.startPlaceTB);
            this.Controls.Add(this.endPlaceTB);
            this.Name = "addView";
            this.Text = "addView";
            ((System.ComponentModel.ISupportInitialize)(this.priceNB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox endPlaceTB;
        private System.Windows.Forms.TextBox startPlaceTB;
        private System.Windows.Forms.NumericUpDown priceNB;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button closeButton;
    }
}