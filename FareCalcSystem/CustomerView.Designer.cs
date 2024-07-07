namespace FareCalcSystem
{
    partial class CustomerView
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
            this.startPlaceCB = new System.Windows.Forms.ComboBox();
            this.endPlaceCB = new System.Windows.Forms.ComboBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.canacelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startPlaceCB
            // 
            this.startPlaceCB.FormattingEnabled = true;
            this.startPlaceCB.Location = new System.Drawing.Point(124, 78);
            this.startPlaceCB.Name = "startPlaceCB";
            this.startPlaceCB.Size = new System.Drawing.Size(121, 20);
            this.startPlaceCB.TabIndex = 0;
            this.startPlaceCB.SelectedIndexChanged += new System.EventHandler(this.changePrice);
            // 
            // endPlaceCB
            // 
            this.endPlaceCB.FormattingEnabled = true;
            this.endPlaceCB.Location = new System.Drawing.Point(364, 78);
            this.endPlaceCB.Name = "endPlaceCB";
            this.endPlaceCB.Size = new System.Drawing.Size(121, 20);
            this.endPlaceCB.TabIndex = 1;
            this.endPlaceCB.SelectedIndexChanged += new System.EventHandler(this.changePrice);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.priceLabel.Location = new System.Drawing.Point(124, 251);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(0, 16);
            this.priceLabel.TabIndex = 2;
            // 
            // canacelButton
            // 
            this.canacelButton.Location = new System.Drawing.Point(497, 389);
            this.canacelButton.Name = "canacelButton";
            this.canacelButton.Size = new System.Drawing.Size(75, 23);
            this.canacelButton.TabIndex = 3;
            this.canacelButton.Text = "キャンセル";
            this.canacelButton.UseVisualStyleBackColor = true;
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.canacelButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.endPlaceCB);
            this.Controls.Add(this.startPlaceCB);
            this.Name = "CustomerView";
            this.Text = "CustomerView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox startPlaceCB;
        private System.Windows.Forms.ComboBox endPlaceCB;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button canacelButton;
    }
}