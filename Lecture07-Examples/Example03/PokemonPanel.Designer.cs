﻿namespace Example03
{
    partial class PokemonPanel
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pokemonNameLabel = new System.Windows.Forms.Label();
            this.pokemonHpLabel = new System.Windows.Forms.Label();
            this.pokemonCurrentHpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pokemonNameLabel
            // 
            this.pokemonNameLabel.AutoSize = true;
            this.pokemonNameLabel.Location = new System.Drawing.Point(6, 24);
            this.pokemonNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.pokemonNameLabel.Name = "pokemonNameLabel";
            this.pokemonNameLabel.Size = new System.Drawing.Size(155, 24);
            this.pokemonNameLabel.TabIndex = 0;
            this.pokemonNameLabel.Text = "Pokemon Name";
            this.pokemonNameLabel.Click += new System.EventHandler(this.pokemonNameLabel_Click);
            // 
            // pokemonHpLabel
            // 
            this.pokemonHpLabel.AutoSize = true;
            this.pokemonHpLabel.Location = new System.Drawing.Point(6, 72);
            this.pokemonHpLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.pokemonHpLabel.Name = "pokemonHpLabel";
            this.pokemonHpLabel.Size = new System.Drawing.Size(177, 24);
            this.pokemonHpLabel.TabIndex = 1;
            this.pokemonHpLabel.Text = "HP : {Pokemon HP}";
            // 
            // pokemonCurrentHpLabel
            // 
            this.pokemonCurrentHpLabel.AutoSize = true;
            this.pokemonCurrentHpLabel.Location = new System.Drawing.Point(6, 121);
            this.pokemonCurrentHpLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.pokemonCurrentHpLabel.Name = "pokemonCurrentHpLabel";
            this.pokemonCurrentHpLabel.Size = new System.Drawing.Size(306, 24);
            this.pokemonCurrentHpLabel.TabIndex = 2;
            this.pokemonCurrentHpLabel.Text = "CurrentHp :{PokemonCurrentHP}";
            // 
            // PokemonPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pokemonCurrentHpLabel);
            this.Controls.Add(this.pokemonHpLabel);
            this.Controls.Add(this.pokemonNameLabel);
            this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PokemonPanel";
            this.Size = new System.Drawing.Size(202, 168);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pokemonNameLabel;
        private System.Windows.Forms.Label pokemonHpLabel;
        private System.Windows.Forms.Label pokemonCurrentHpLabel;
    }
}
