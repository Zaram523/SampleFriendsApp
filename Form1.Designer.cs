
namespace Friends
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtbox_nwFrnd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_nwFrnd = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_bstFrnds = new System.Windows.Forms.Button();
            this.btn_reverse = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 1);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(224, 446);
            this.listBox1.TabIndex = 0;
            // 
            // txtbox_nwFrnd
            // 
            this.txtbox_nwFrnd.Location = new System.Drawing.Point(231, 13);
            this.txtbox_nwFrnd.Name = "txtbox_nwFrnd";
            this.txtbox_nwFrnd.Size = new System.Drawing.Size(345, 20);
            this.txtbox_nwFrnd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btn_nwFrnd
            // 
            this.btn_nwFrnd.Location = new System.Drawing.Point(230, 51);
            this.btn_nwFrnd.Name = "btn_nwFrnd";
            this.btn_nwFrnd.Size = new System.Drawing.Size(111, 37);
            this.btn_nwFrnd.TabIndex = 2;
            this.btn_nwFrnd.Text = "New Friend";
            this.btn_nwFrnd.UseVisualStyleBackColor = true;
            this.btn_nwFrnd.Click += new System.EventHandler(this.btn_nwFrnd_Click);
            this.btn_nwFrnd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn_nwFrnd_KeyUp);
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(231, 401);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(111, 37);
            this.btn_sort.TabIndex = 4;
            this.btn_sort.Text = "A -> Z";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_bstFrnds
            // 
            this.btn_bstFrnds.Location = new System.Drawing.Point(230, 106);
            this.btn_bstFrnds.Name = "btn_bstFrnds";
            this.btn_bstFrnds.Size = new System.Drawing.Size(111, 37);
            this.btn_bstFrnds.TabIndex = 3;
            this.btn_bstFrnds.Text = "Best Friends";
            this.btn_bstFrnds.UseVisualStyleBackColor = true;
            this.btn_bstFrnds.Click += new System.EventHandler(this.btn_bstFrnds_Click);
            // 
            // btn_reverse
            // 
            this.btn_reverse.Location = new System.Drawing.Point(348, 401);
            this.btn_reverse.Name = "btn_reverse";
            this.btn_reverse.Size = new System.Drawing.Size(111, 37);
            this.btn_reverse.TabIndex = 5;
            this.btn_reverse.Text = "Z -> A";
            this.btn_reverse.UseVisualStyleBackColor = true;
            this.btn_reverse.Click += new System.EventHandler(this.btn_reverse_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(465, 401);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(111, 37);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_reverse);
            this.Controls.Add(this.btn_bstFrnds);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.btn_nwFrnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_nwFrnd);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Friends App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtbox_nwFrnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_nwFrnd;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Button btn_bstFrnds;
        private System.Windows.Forms.Button btn_reverse;
        private System.Windows.Forms.Button btn_clear;
    }
}

