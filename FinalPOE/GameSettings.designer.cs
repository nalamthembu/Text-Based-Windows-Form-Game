
namespace FinalPOE
{
    partial class GameSettings
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
            this.lblMinWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblMaxHeight = new System.Windows.Forms.Label();
            this.lblMaxWidth = new System.Windows.Forms.Label();
            this.txtMinWidth = new System.Windows.Forms.TextBox();
            this.txtMaxWidth = new System.Windows.Forms.TextBox();
            this.txtMinHeight = new System.Windows.Forms.TextBox();
            this.txtMaxHeight = new System.Windows.Forms.TextBox();
            this.txtNumEnemies = new System.Windows.Forms.TextBox();
            this.lblNumberOfEnemies = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblAmountGold = new System.Windows.Forms.Label();
            this.txtNumGold = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMinWidth
            // 
            this.lblMinWidth.AutoSize = true;
            this.lblMinWidth.Location = new System.Drawing.Point(11, 103);
            this.lblMinWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinWidth.Name = "lblMinWidth";
            this.lblMinWidth.Size = new System.Drawing.Size(68, 13);
            this.lblMinWidth.TabIndex = 0;
            this.lblMinWidth.Text = "Min Width(X)";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(11, 132);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(74, 13);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Min Height (Y)";
            // 
            // lblMaxHeight
            // 
            this.lblMaxHeight.AutoSize = true;
            this.lblMaxHeight.Location = new System.Drawing.Point(152, 135);
            this.lblMaxHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxHeight.Name = "lblMaxHeight";
            this.lblMaxHeight.Size = new System.Drawing.Size(77, 13);
            this.lblMaxHeight.TabIndex = 2;
            this.lblMaxHeight.Text = "Max Height (Y)";
            // 
            // lblMaxWidth
            // 
            this.lblMaxWidth.AutoSize = true;
            this.lblMaxWidth.Location = new System.Drawing.Point(152, 101);
            this.lblMaxWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxWidth.Name = "lblMaxWidth";
            this.lblMaxWidth.Size = new System.Drawing.Size(74, 13);
            this.lblMaxWidth.TabIndex = 3;
            this.lblMaxWidth.Text = "Max Width (X)";
            // 
            // txtMinWidth
            // 
            this.txtMinWidth.Location = new System.Drawing.Point(88, 99);
            this.txtMinWidth.Margin = new System.Windows.Forms.Padding(2);
            this.txtMinWidth.Name = "txtMinWidth";
            this.txtMinWidth.Size = new System.Drawing.Size(42, 20);
            this.txtMinWidth.TabIndex = 4;
            this.txtMinWidth.Text = "10";
            // 
            // txtMaxWidth
            // 
            this.txtMaxWidth.Location = new System.Drawing.Point(235, 96);
            this.txtMaxWidth.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaxWidth.Name = "txtMaxWidth";
            this.txtMaxWidth.Size = new System.Drawing.Size(42, 20);
            this.txtMaxWidth.TabIndex = 5;
            this.txtMaxWidth.Text = "10";
            // 
            // txtMinHeight
            // 
            this.txtMinHeight.Location = new System.Drawing.Point(88, 130);
            this.txtMinHeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtMinHeight.Name = "txtMinHeight";
            this.txtMinHeight.Size = new System.Drawing.Size(42, 20);
            this.txtMinHeight.TabIndex = 6;
            this.txtMinHeight.Text = "10";
            // 
            // txtMaxHeight
            // 
            this.txtMaxHeight.Location = new System.Drawing.Point(235, 130);
            this.txtMaxHeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaxHeight.Name = "txtMaxHeight";
            this.txtMaxHeight.Size = new System.Drawing.Size(42, 20);
            this.txtMaxHeight.TabIndex = 7;
            this.txtMaxHeight.Text = "10";
            // 
            // txtNumEnemies
            // 
            this.txtNumEnemies.Location = new System.Drawing.Point(122, 161);
            this.txtNumEnemies.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumEnemies.Name = "txtNumEnemies";
            this.txtNumEnemies.Size = new System.Drawing.Size(156, 20);
            this.txtNumEnemies.TabIndex = 8;
            this.txtNumEnemies.Text = "5";
            this.txtNumEnemies.TextChanged += new System.EventHandler(this.txtNumEnemies_TextChanged);
            // 
            // lblNumberOfEnemies
            // 
            this.lblNumberOfEnemies.AutoSize = true;
            this.lblNumberOfEnemies.Location = new System.Drawing.Point(11, 165);
            this.lblNumberOfEnemies.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfEnemies.Name = "lblNumberOfEnemies";
            this.lblNumberOfEnemies.Size = new System.Drawing.Size(101, 13);
            this.lblNumberOfEnemies.TabIndex = 9;
            this.lblNumberOfEnemies.Text = "Number Of Enemies";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Consolas", 25.8F);
            this.lblTitle.Location = new System.Drawing.Point(11, 7);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(266, 55);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Treasure Hunt";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.lblSubtitle.Location = new System.Drawing.Point(11, 52);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(266, 32);
            this.lblSubtitle.TabIndex = 11;
            this.lblSubtitle.Text = "Game Settings";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(11, 216);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(266, 37);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblAmountGold
            // 
            this.lblAmountGold.AutoSize = true;
            this.lblAmountGold.Location = new System.Drawing.Point(11, 199);
            this.lblAmountGold.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmountGold.Name = "lblAmountGold";
            this.lblAmountGold.Size = new System.Drawing.Size(82, 13);
            this.lblAmountGold.TabIndex = 13;
            this.lblAmountGold.Text = "Amount Of Gold";
            // 
            // txtNumGold
            // 
            this.txtNumGold.Location = new System.Drawing.Point(122, 192);
            this.txtNumGold.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumGold.Name = "txtNumGold";
            this.txtNumGold.Size = new System.Drawing.Size(156, 20);
            this.txtNumGold.TabIndex = 14;
            this.txtNumGold.Text = "5";
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Maroon;
            this.lblError.Location = new System.Drawing.Point(11, 296);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(266, 32);
            this.lblError.TabIndex = 15;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(11, 257);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(266, 37);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Load Game";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // GameSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 345);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtNumGold);
            this.Controls.Add(this.lblAmountGold);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblNumberOfEnemies);
            this.Controls.Add(this.txtNumEnemies);
            this.Controls.Add(this.txtMaxHeight);
            this.Controls.Add(this.txtMinHeight);
            this.Controls.Add(this.txtMaxWidth);
            this.Controls.Add(this.txtMinWidth);
            this.Controls.Add(this.lblMaxWidth);
            this.Controls.Add(this.lblMaxHeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblMinWidth);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameSettings";
            this.Text = "Treasure Hunt (POE) : GameSettings";
            this.Load += new System.EventHandler(this.GameSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMinWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblMaxHeight;
        private System.Windows.Forms.Label lblMaxWidth;
        private System.Windows.Forms.TextBox txtMinWidth;
        private System.Windows.Forms.TextBox txtMaxWidth;
        private System.Windows.Forms.TextBox txtMinHeight;
        private System.Windows.Forms.TextBox txtMaxHeight;
        private System.Windows.Forms.TextBox txtNumEnemies;
        private System.Windows.Forms.Label lblNumberOfEnemies;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblAmountGold;
        private System.Windows.Forms.TextBox txtNumGold;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnLoad;
    }
}