
namespace Koleksiyonlar
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
            this.flpButon = new System.Windows.Forms.FlowLayoutPanel();
            this.rbTek = new System.Windows.Forms.RadioButton();
            this.rbCift = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // flpButon
            // 
            this.flpButon.Location = new System.Drawing.Point(84, 120);
            this.flpButon.Name = "flpButon";
            this.flpButon.Size = new System.Drawing.Size(400, 253);
            this.flpButon.TabIndex = 0;
            // 
            // rbTek
            // 
            this.rbTek.AutoSize = true;
            this.rbTek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTek.Location = new System.Drawing.Point(174, 80);
            this.rbTek.Name = "rbTek";
            this.rbTek.Size = new System.Drawing.Size(50, 21);
            this.rbTek.TabIndex = 1;
            this.rbTek.TabStop = true;
            this.rbTek.Text = "Tek";
            this.rbTek.UseVisualStyleBackColor = true;
            this.rbTek.CheckedChanged += new System.EventHandler(this.rbTek_CheckedChanged);
            // 
            // rbCift
            // 
            this.rbCift.AutoSize = true;
            this.rbCift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbCift.Location = new System.Drawing.Point(310, 80);
            this.rbCift.Name = "rbCift";
            this.rbCift.Size = new System.Drawing.Size(46, 21);
            this.rbCift.TabIndex = 1;
            this.rbCift.TabStop = true;
            this.rbCift.Text = "Çift";
            this.rbCift.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(310, 80);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Çift";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 400);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rbCift);
            this.Controls.Add(this.rbTek);
            this.Controls.Add(this.flpButon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpButon;
        private System.Windows.Forms.RadioButton rbTek;
        private System.Windows.Forms.RadioButton rbCift;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

