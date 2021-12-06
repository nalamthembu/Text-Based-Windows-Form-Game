
namespace FinalPOE
{
    partial class GameWindow
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
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblMapDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAttack = new System.Windows.Forms.Label();
            this.btnAttackDown = new System.Windows.Forms.Button();
            this.btnAttackRight = new System.Windows.Forms.Button();
            this.btnAttackLeft = new System.Windows.Forms.Button();
            this.btnAttackUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSaveState = new System.Windows.Forms.Label();
            this.btnShop0 = new System.Windows.Forms.Button();
            this.btnShop1 = new System.Windows.Forms.Button();
            this.btnShop2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(684, 357);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(82, 22);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblMapDisplay
            // 
            this.lblMapDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMapDisplay.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMapDisplay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMapDisplay.Location = new System.Drawing.Point(163, 7);
            this.lblMapDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMapDisplay.Name = "lblMapDisplay";
            this.lblMapDisplay.Size = new System.Drawing.Size(442, 372);
            this.lblMapDisplay.TabIndex = 8;
            this.lblMapDisplay.Text = "{Game}";
            this.lblMapDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(64, 202);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Movement";
            // 
            // lblAttack
            // 
            this.lblAttack.AutoSize = true;
            this.lblAttack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAttack.Location = new System.Drawing.Point(652, 202);
            this.lblAttack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.Size = new System.Drawing.Size(41, 15);
            this.lblAttack.TabIndex = 23;
            this.lblAttack.Text = "Attack";
            // 
            // btnAttackDown
            // 
            this.btnAttackDown.BackColor = System.Drawing.Color.DimGray;
            this.btnAttackDown.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAttackDown.ForeColor = System.Drawing.Color.White;
            this.btnAttackDown.Location = new System.Drawing.Point(656, 297);
            this.btnAttackDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttackDown.Name = "btnAttackDown";
            this.btnAttackDown.Size = new System.Drawing.Size(40, 37);
            this.btnAttackDown.TabIndex = 22;
            this.btnAttackDown.Text = "X";
            this.btnAttackDown.UseVisualStyleBackColor = false;
            this.btnAttackDown.Click += new System.EventHandler(this.btnAttackDown_Click);
            // 
            // btnAttackRight
            // 
            this.btnAttackRight.BackColor = System.Drawing.Color.DimGray;
            this.btnAttackRight.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAttackRight.ForeColor = System.Drawing.Color.White;
            this.btnAttackRight.Location = new System.Drawing.Point(702, 260);
            this.btnAttackRight.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttackRight.Name = "btnAttackRight";
            this.btnAttackRight.Size = new System.Drawing.Size(40, 37);
            this.btnAttackRight.TabIndex = 21;
            this.btnAttackRight.Text = "○";
            this.btnAttackRight.UseVisualStyleBackColor = false;
            this.btnAttackRight.Click += new System.EventHandler(this.btnAttackRight_Click);
            // 
            // btnAttackLeft
            // 
            this.btnAttackLeft.BackColor = System.Drawing.Color.DimGray;
            this.btnAttackLeft.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAttackLeft.ForeColor = System.Drawing.Color.White;
            this.btnAttackLeft.Location = new System.Drawing.Point(611, 260);
            this.btnAttackLeft.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttackLeft.Name = "btnAttackLeft";
            this.btnAttackLeft.Size = new System.Drawing.Size(40, 37);
            this.btnAttackLeft.TabIndex = 20;
            this.btnAttackLeft.Text = "□";
            this.btnAttackLeft.UseVisualStyleBackColor = false;
            this.btnAttackLeft.Click += new System.EventHandler(this.btnAttackLeft_Click);
            // 
            // btnAttackUp
            // 
            this.btnAttackUp.BackColor = System.Drawing.Color.DimGray;
            this.btnAttackUp.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAttackUp.ForeColor = System.Drawing.Color.White;
            this.btnAttackUp.Location = new System.Drawing.Point(656, 227);
            this.btnAttackUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttackUp.Name = "btnAttackUp";
            this.btnAttackUp.Size = new System.Drawing.Size(40, 32);
            this.btnAttackUp.TabIndex = 19;
            this.btnAttackUp.Text = "△";
            this.btnAttackUp.UseVisualStyleBackColor = false;
            this.btnAttackUp.Click += new System.EventHandler(this.btnAttackUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.DimGray;
            this.btnDown.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDown.ForeColor = System.Drawing.Color.White;
            this.btnDown.Location = new System.Drawing.Point(72, 297);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(40, 37);
            this.btnDown.TabIndex = 18;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.DimGray;
            this.btnRight.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRight.ForeColor = System.Drawing.Color.White;
            this.btnRight.Location = new System.Drawing.Point(118, 258);
            this.btnRight.Margin = new System.Windows.Forms.Padding(2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(40, 37);
            this.btnRight.TabIndex = 17;
            this.btnRight.Text = "→";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.DimGray;
            this.btnLeft.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLeft.ForeColor = System.Drawing.Color.White;
            this.btnLeft.Location = new System.Drawing.Point(27, 258);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(40, 37);
            this.btnLeft.TabIndex = 16;
            this.btnLeft.Text = "←";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.DimGray;
            this.btnUp.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Location = new System.Drawing.Point(72, 223);
            this.btnUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(40, 32);
            this.btnUp.TabIndex = 15;
            this.btnUp.Text = "↑ ";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInfo.Location = new System.Drawing.Point(611, 9);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 15);
            this.lblInfo.TabIndex = 25;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DimGray;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(47, 33);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 23);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSaveState
            // 
            this.lblSaveState.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSaveState.Location = new System.Drawing.Point(14, 60);
            this.lblSaveState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaveState.Name = "lblSaveState";
            this.lblSaveState.Size = new System.Drawing.Size(133, 27);
            this.lblSaveState.TabIndex = 27;
            this.lblSaveState.Text = "Save State";
            this.lblSaveState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShop0
            // 
            this.btnShop0.Location = new System.Drawing.Point(766, 231);
            this.btnShop0.Name = "btnShop0";
            this.btnShop0.Size = new System.Drawing.Size(163, 28);
            this.btnShop0.TabIndex = 28;
            this.btnShop0.Text = "{Weapon}";
            this.btnShop0.UseVisualStyleBackColor = true;
            this.btnShop0.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnShop1
            // 
            this.btnShop1.Location = new System.Drawing.Point(766, 263);
            this.btnShop1.Name = "btnShop1";
            this.btnShop1.Size = new System.Drawing.Size(163, 28);
            this.btnShop1.TabIndex = 29;
            this.btnShop1.Text = "{Weapon}";
            this.btnShop1.UseVisualStyleBackColor = true;
            this.btnShop1.Click += new System.EventHandler(this.btnShop1_Click);
            // 
            // btnShop2
            // 
            this.btnShop2.Location = new System.Drawing.Point(766, 297);
            this.btnShop2.Name = "btnShop2";
            this.btnShop2.Size = new System.Drawing.Size(163, 28);
            this.btnShop2.TabIndex = 30;
            this.btnShop2.Text = "{Weapon}";
            this.btnShop2.UseVisualStyleBackColor = true;
            this.btnShop2.Click += new System.EventHandler(this.btnShop2_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(941, 388);
            this.Controls.Add(this.btnShop2);
            this.Controls.Add(this.btnShop1);
            this.Controls.Add(this.btnShop0);
            this.Controls.Add(this.lblSaveState);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAttack);
            this.Controls.Add(this.btnAttackDown);
            this.Controls.Add(this.btnAttackRight);
            this.Controls.Add(this.btnAttackLeft);
            this.Controls.Add(this.btnAttackUp);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.lblMapDisplay);
            this.Controls.Add(this.btnHelp);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameWindow";
            this.Text = "The Hunt (POE)";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblMapDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAttack;
        private System.Windows.Forms.Button btnAttackDown;
        private System.Windows.Forms.Button btnAttackRight;
        private System.Windows.Forms.Button btnAttackLeft;
        private System.Windows.Forms.Button btnAttackUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSaveState;
        private System.Windows.Forms.Button btnShop0;
        private System.Windows.Forms.Button btnShop1;
        private System.Windows.Forms.Button btnShop2;
    }
}