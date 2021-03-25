
namespace ColorsAndShadesDB
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
            this.Primary_colors_list = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Shades_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Primary_colors_list
            // 
            this.Primary_colors_list.FormattingEnabled = true;
            this.Primary_colors_list.Location = new System.Drawing.Point(67, 93);
            this.Primary_colors_list.Name = "Primary_colors_list";
            this.Primary_colors_list.Size = new System.Drawing.Size(120, 95);
            this.Primary_colors_list.TabIndex = 0;
            this.Primary_colors_list.SelectedIndexChanged += new System.EventHandler(this.Primary_colors_list_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Primary Colors";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shades";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Shades_list
            // 
            this.Shades_list.FormattingEnabled = true;
            this.Shades_list.Location = new System.Drawing.Point(345, 93);
            this.Shades_list.Name = "Shades_list";
            this.Shades_list.Size = new System.Drawing.Size(120, 95);
            this.Shades_list.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Shades_list);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Primary_colors_list);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Primary_colors_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Shades_list;
    }
}

