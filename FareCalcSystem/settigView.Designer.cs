namespace FareCalcSystem
{
    partial class settigView
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.settingGV = new System.Windows.Forms.DataGridView();
            this.u = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.displayCustomerBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.settingGV)).BeginInit();
            this.SuspendLayout();
            // 
            // settingGV
            // 
            this.settingGV.AllowUserToAddRows = false;
            this.settingGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.settingGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.u,
            this.Column1,
            this.Column2});
            this.settingGV.Location = new System.Drawing.Point(242, 90);
            this.settingGV.MultiSelect = false;
            this.settingGV.Name = "settingGV";
            this.settingGV.ReadOnly = true;
            this.settingGV.RowTemplate.Height = 21;
            this.settingGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.settingGV.Size = new System.Drawing.Size(345, 207);
            this.settingGV.TabIndex = 0;
            // 
            // u
            // 
            this.u.HeaderText = "出発地";
            this.u.Name = "u";
            this.u.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "目的地";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "運賃";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(242, 352);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "追加";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(367, 352);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "編集";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(508, 352);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "削除";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // displayCustomerBtn
            // 
            this.displayCustomerBtn.Location = new System.Drawing.Point(64, 107);
            this.displayCustomerBtn.Name = "displayCustomerBtn";
            this.displayCustomerBtn.Size = new System.Drawing.Size(75, 23);
            this.displayCustomerBtn.TabIndex = 4;
            this.displayCustomerBtn.Text = "お客様画面";
            this.displayCustomerBtn.UseVisualStyleBackColor = true;
            this.displayCustomerBtn.Click += new System.EventHandler(this.displayCustomerBtn_Click);
            // 
            // settigView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displayCustomerBtn);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.settingGV);
            this.Name = "settigView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.settingGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView settingGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn u;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button displayCustomerBtn;
    }
}

