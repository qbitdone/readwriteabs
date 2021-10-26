
namespace readwriteabs
{
    partial class ReadWrite
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
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.rtbPopis = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(183, 45);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(228, 51);
            this.btnUcitaj.TabIndex = 0;
            this.btnUcitaj.Text = "Učitaj";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            this.btnUcitaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbPopis
            // 
            this.rtbPopis.Location = new System.Drawing.Point(12, 102);
            this.rtbPopis.Name = "rtbPopis";
            this.rtbPopis.Size = new System.Drawing.Size(626, 287);
            this.rtbPopis.TabIndex = 1;
            this.rtbPopis.Text = "";
            // 
            // ReadWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 401);
            this.Controls.Add(this.rtbPopis);
            this.Controls.Add(this.btnUcitaj);
            this.Name = "ReadWrite";
            this.Text = "ReadWrite";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.RichTextBox rtbPopis;
    }
}

