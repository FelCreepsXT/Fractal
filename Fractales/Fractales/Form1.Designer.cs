using System.Drawing;
using System.Windows.Forms;

namespace Fractales
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtAngle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelSetting = new System.Windows.Forms.Panel();
            this.BtnCreateBranch = new System.Windows.Forms.Button();
            this.TxtLongitude = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelPaint = new System.Windows.Forms.Panel();
            this.PanelSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtAngle
            // 
            this.TxtAngle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtAngle.Location = new System.Drawing.Point(66, 232);
            this.TxtAngle.Name = "TxtAngle";
            this.TxtAngle.Size = new System.Drawing.Size(82, 29);
            this.TxtAngle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(66, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Angle\r\n(0 - 90)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelSetting
            // 
            this.PanelSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PanelSetting.Controls.Add(this.BtnCreateBranch);
            this.PanelSetting.Controls.Add(this.TxtLongitude);
            this.PanelSetting.Controls.Add(this.label2);
            this.PanelSetting.Controls.Add(this.label1);
            this.PanelSetting.Controls.Add(this.TxtAngle);
            this.PanelSetting.Location = new System.Drawing.Point(968, 1);
            this.PanelSetting.Name = "PanelSetting";
            this.PanelSetting.Size = new System.Drawing.Size(203, 566);
            this.PanelSetting.TabIndex = 2;
            // 
            // BtnCreateBranch
            // 
            this.BtnCreateBranch.BackColor = System.Drawing.Color.OrangeRed;
            this.BtnCreateBranch.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.BtnCreateBranch.FlatAppearance.BorderSize = 10;
            this.BtnCreateBranch.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnCreateBranch.ForeColor = System.Drawing.Color.White;
            this.BtnCreateBranch.Location = new System.Drawing.Point(57, 471);
            this.BtnCreateBranch.Name = "BtnCreateBranch";
            this.BtnCreateBranch.Size = new System.Drawing.Size(91, 64);
            this.BtnCreateBranch.TabIndex = 0;
            this.BtnCreateBranch.Text = "Create Branch!";
            this.BtnCreateBranch.UseVisualStyleBackColor = false;
            this.BtnCreateBranch.Click += new System.EventHandler(this.BtnCreateBranch_Click);
            // 
            // TxtLongitude
            // 
            this.TxtLongitude.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtLongitude.Location = new System.Drawing.Point(66, 387);
            this.TxtLongitude.Name = "TxtLongitude";
            this.TxtLongitude.Size = new System.Drawing.Size(82, 29);
            this.TxtLongitude.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(47, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "Longitude\r\n(100 - 160)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelPaint
            // 
            this.PanelPaint.BackColor = System.Drawing.Color.White;
            this.PanelPaint.Location = new System.Drawing.Point(-1, 1);
            this.PanelPaint.Name = "PanelPaint";
            this.PanelPaint.Size = new System.Drawing.Size(973, 566);
            this.PanelPaint.TabIndex = 3;
            this.PanelPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 566);
            this.Controls.Add(this.PanelPaint);
            this.Controls.Add(this.PanelSetting);
            this.Name = "Form1";
            this.Text = "Angle";
            this.PanelSetting.ResumeLayout(false);
            this.PanelSetting.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private TextBox TxtAngle;
        private Label label1;
        private Panel PanelSetting;
        private Label label2;
        private TextBox TxtLongitude;
        private Panel PanelPaint;
        private Button BtnCreateBranch;
    }
}

