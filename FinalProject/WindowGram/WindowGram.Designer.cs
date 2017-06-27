namespace WindowGram
{
    partial class WindowGram
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.originPictureBox = new System.Windows.Forms.PictureBox();
            this.processedPictureBox = new System.Windows.Forms.PictureBox();
            this.originImageLabel = new System.Windows.Forms.Label();
            this.ImageLabel = new System.Windows.Forms.Label();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.applyFilterButtom = new System.Windows.Forms.Button();
            this.filterSelector = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveImageButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.originPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // originPictureBox
            // 
            this.originPictureBox.Location = new System.Drawing.Point(15, 40);
            this.originPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.originPictureBox.Name = "originPictureBox";
            this.originPictureBox.Size = new System.Drawing.Size(500, 375);
            this.originPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.originPictureBox.TabIndex = 0;
            this.originPictureBox.TabStop = false;
            // 
            // processedPictureBox
            // 
            this.processedPictureBox.Location = new System.Drawing.Point(751, 40);
            this.processedPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.processedPictureBox.Name = "processedPictureBox";
            this.processedPictureBox.Size = new System.Drawing.Size(500, 375);
            this.processedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.processedPictureBox.TabIndex = 1;
            this.processedPictureBox.TabStop = false;
            // 
            // originImageLabel
            // 
            this.originImageLabel.AutoSize = true;
            this.originImageLabel.Location = new System.Drawing.Point(213, 9);
            this.originImageLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.originImageLabel.Name = "originImageLabel";
            this.originImageLabel.Size = new System.Drawing.Size(105, 24);
            this.originImageLabel.TabIndex = 2;
            this.originImageLabel.Text = "原始的圖片";
            // 
            // ImageLabel
            // 
            this.ImageLabel.AutoSize = true;
            this.ImageLabel.Location = new System.Drawing.Point(930, 10);
            this.ImageLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ImageLabel.Name = "ImageLabel";
            this.ImageLabel.Size = new System.Drawing.Size(143, 24);
            this.ImageLabel.TabIndex = 3;
            this.ImageLabel.Text = "套用濾鏡的圖片";
            // 
            // loadImageButton
            // 
            this.loadImageButton.Location = new System.Drawing.Point(565, 40);
            this.loadImageButton.Margin = new System.Windows.Forms.Padding(6);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(138, 46);
            this.loadImageButton.TabIndex = 4;
            this.loadImageButton.Text = "開啟圖片";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // applyFilterButtom
            // 
            this.applyFilterButtom.Location = new System.Drawing.Point(565, 254);
            this.applyFilterButtom.Margin = new System.Windows.Forms.Padding(6);
            this.applyFilterButtom.Name = "applyFilterButtom";
            this.applyFilterButtom.Size = new System.Drawing.Size(138, 46);
            this.applyFilterButtom.TabIndex = 5;
            this.applyFilterButtom.Text = "套用濾鏡";
            this.applyFilterButtom.UseVisualStyleBackColor = true;
            this.applyFilterButtom.Click += new System.EventHandler(this.applyFilterButtom_Click);
            // 
            // filterSelector
            // 
            this.filterSelector.FormattingEnabled = true;
            this.filterSelector.Items.AddRange(new object[] {
            "GrayFilter"});
            this.filterSelector.Location = new System.Drawing.Point(525, 154);
            this.filterSelector.Margin = new System.Windows.Forms.Padding(6);
            this.filterSelector.Name = "filterSelector";
            this.filterSelector.Size = new System.Drawing.Size(219, 32);
            this.filterSelector.TabIndex = 6;
            this.filterSelector.Text = "請選擇濾鏡";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // saveImageButton
            // 
            this.saveImageButton.Location = new System.Drawing.Point(565, 368);
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.Size = new System.Drawing.Size(138, 46);
            this.saveImageButton.TabIndex = 7;
            this.saveImageButton.Text = "儲存圖片";
            this.saveImageButton.UseVisualStyleBackColor = true;
            this.saveImageButton.Click += new System.EventHandler(this.saveImageButton_Click);
            // 
            // WindowGram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 445);
            this.Controls.Add(this.saveImageButton);
            this.Controls.Add(this.filterSelector);
            this.Controls.Add(this.applyFilterButtom);
            this.Controls.Add(this.loadImageButton);
            this.Controls.Add(this.ImageLabel);
            this.Controls.Add(this.originImageLabel);
            this.Controls.Add(this.processedPictureBox);
            this.Controls.Add(this.originPictureBox);
            this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "WindowGram";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.originPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox originPictureBox;
        private System.Windows.Forms.PictureBox processedPictureBox;
        private System.Windows.Forms.Label originImageLabel;
        private System.Windows.Forms.Label ImageLabel;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.Button applyFilterButtom;
        private System.Windows.Forms.ComboBox filterSelector;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button saveImageButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

