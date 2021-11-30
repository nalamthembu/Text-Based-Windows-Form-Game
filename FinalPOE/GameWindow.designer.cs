
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
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(586, 309);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(70, 19);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblMapDisplay
            // 
            this.lblMapDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMapDisplay.Font = new System.Drawing.Font("Courier New", 12F);
            this.lblMapDisplay.Location = new System.Drawing.Point(140, 6);
            this.lblMapDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMapDisplay.Name = "lblMapDisplay";
            this.lblMapDisplay.Size = new System.Drawing.Size(379, 322);
            this.lblMapDisplay.TabIndex = 8;
            this.lblMapDisplay.Text = "label1";
            this.lblMapDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Movement";
            // 
            // lblAttack
            // 
            this.lblAttack.AutoSize = true;
            this.lblAttack.Location = new System.Drawing.Point(559, 175);
            this.lblAttack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.Size = new System.Drawing.Size(38, 13);
            this.lblAttack.TabIndex = 23;
            this.lblAttack.Text = "Attack";
            // 
            // btnAttackDown
            // 
            this.btnAttackDown.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnAttackDown.ForeColor = System.Drawing.Color.Crimson;
            this.btnAttackDown.Location = new System.Drawing.Point(562, 257);
            this.btnAttackDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttackDown.Name = "btnAttackDown";
            this.btnAttackDown.Size = new System.Drawing.Size(34, 32);
            this.btnAttackDown.TabIndex = 22;
            this.btnAttackDown.Text = "X";
            this.btnAttackDown.UseVisualStyleBackColor = true;
            this.btnAttackDown.Click += new System.EventHandler(this.btnAttackDown_Click);
            // 
            // btnAttackRight
            // 
            this.btnAttackRight.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnAttackRight.ForeColor = System.Drawing.Color.Crimson;
            this.btnAttackRight.Location = new System.Drawing.Point(602, 225);
            this.btnAttackRight.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttackRight.Name = "btnAttackRight";
            this.btnAttackRight.Size = new System.Drawing.Size(34, 32);
            this.btnAttackRight.TabIndex = 21;
            this.btnAttackRight.Text = "○";
            this.btnAttackRight.UseVisualStyleBackColor = true;
            this.btnAttackRight.Click += new System.EventHandler(this.btnAttackRight_Click);
            // 
            // btnAttackLeft
            // 
            this.btnAttackLeft.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnAttackLeft.ForeColor = System.Drawing.Color.Crimson;
            this.btnAttackLeft.Location = new System.Drawing.Point(524, 225);
            this.btnAttackLeft.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttackLeft.Name = "btnAttackLeft";
            this.btnAttackLeft.Size = new System.Drawing.Size(34, 32);
            this.btnAttackLeft.TabIndex = 20;
            this.btnAttackLeft.Text = "□";
            this.btnAttackLeft.UseVisualStyleBackColor = true;
            this.btnAttackLeft.Click += new System.EventHandler(this.btnAttackLeft_Click);
            // 
            // btnAttackUp
            // 
            this.btnAttackUp.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnAttackUp.ForeColor = System.Drawing.Color.Crimson;
            this.btnAttackUp.Location = new System.Drawing.Point(562, 197);
            this.btnAttackUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnAttackUp.Name = "btnAttackUp";
            this.btnAttackUp.Size = new System.Drawing.Size(34, 28);
            this.btnAttackUp.TabIndex = 19;
            this.btnAttackUp.Text = "△";
            this.btnAttackUp.UseVisualStyleBackColor = true;
            this.btnAttackUp.Click += new System.EventHandler(this.btnAttackUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnDown.ForeColor = System.Drawing.Color.Crimson;
            this.btnDown.Location = new System.Drawing.Point(62, 257);
            this.btnDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(34, 32);
            this.btnDown.TabIndex = 18;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnRight.ForeColor = System.Drawing.Color.Crimson;
            this.btnRight.Location = new System.Drawing.Point(101, 224);
            this.btnRight.Margin = new System.Windows.Forms.Padding(2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(34, 32);
            this.btnRight.TabIndex = 17;
            this.btnRight.Text = "→";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnLeft.ForeColor = System.Drawing.Color.Crimson;
            this.btnLeft.Location = new System.Drawing.Point(23, 224);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(34, 32);
            this.btnLeft.TabIndex = 16;
            this.btnLeft.Text = "←";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnUp.ForeColor = System.Drawing.Color.Crimson;
            this.btnUp.Location = new System.Drawing.Point(62, 193);
            this.btnUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(34, 28);
            this.btnUp.TabIndex = 15;
            this.btnUp.Text = "↑ ";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(524, 8);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 25;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(40, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 20);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSaveState
            // 
            this.lblSaveState.Location = new System.Drawing.Point(12, 52);
            this.lblSaveState.Name = "lblSaveState";
            this.lblSaveState.Size = new System.Drawing.Size(114, 23);
            this.lblSaveState.TabIndex = 27;
            this.lblSaveState.Text = "Save State";
            this.lblSaveState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 336);
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
            this.Text = "GameWindow";
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
    }
}