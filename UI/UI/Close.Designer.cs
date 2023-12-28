﻿namespace UI
{
    partial class Close
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
            this.components = new System.ComponentModel.Container();
            this.btCloseAll = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.btCloseCurrentTab = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btCloseAll
            // 
            this.btCloseAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCloseAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCloseAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCloseAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCloseAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btCloseAll.ForeColor = System.Drawing.Color.White;
            this.btCloseAll.Location = new System.Drawing.Point(30, 50);
            this.btCloseAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCloseAll.Name = "btCloseAll";
            this.btCloseAll.Size = new System.Drawing.Size(135, 37);
            this.btCloseAll.TabIndex = 0;
            this.btCloseAll.Text = "Close All";
            this.btCloseAll.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btCloseCurrentTab
            // 
            this.btCloseCurrentTab.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCloseCurrentTab.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCloseCurrentTab.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCloseCurrentTab.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCloseCurrentTab.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btCloseCurrentTab.ForeColor = System.Drawing.Color.White;
            this.btCloseCurrentTab.Location = new System.Drawing.Point(199, 50);
            this.btCloseCurrentTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCloseCurrentTab.Name = "btCloseCurrentTab";
            this.btCloseCurrentTab.Size = new System.Drawing.Size(135, 37);
            this.btCloseCurrentTab.TabIndex = 1;
            this.btCloseCurrentTab.Text = "Close Current Tab";
            this.btCloseCurrentTab.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // Close
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 118);
            this.Controls.Add(this.btCloseCurrentTab);
            this.Controls.Add(this.btCloseAll);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Close";
            this.Text = "Close";
            this.Load += new System.EventHandler(this.Close_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btCloseAll;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button btCloseCurrentTab;
    }
}