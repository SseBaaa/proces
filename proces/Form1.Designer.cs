
namespace proces
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
            this.buttonInternet = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.buttonWord = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInternet
            // 
            this.buttonInternet.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInternet.Location = new System.Drawing.Point(12, 12);
            this.buttonInternet.Name = "buttonInternet";
            this.buttonInternet.Size = new System.Drawing.Size(372, 191);
            this.buttonInternet.TabIndex = 0;
            this.buttonInternet.Text = "internet";
            this.buttonInternet.UseVisualStyleBackColor = true;
            // 
            // buttonExcel
            // 
            this.buttonExcel.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcel.Location = new System.Drawing.Point(390, 12);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(398, 191);
            this.buttonExcel.TabIndex = 1;
            this.buttonExcel.Text = "Excel";
            this.buttonExcel.UseVisualStyleBackColor = true;
            // 
            // buttonWord
            // 
            this.buttonWord.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWord.Location = new System.Drawing.Point(12, 209);
            this.buttonWord.Name = "buttonWord";
            this.buttonWord.Size = new System.Drawing.Size(372, 229);
            this.buttonWord.TabIndex = 2;
            this.buttonWord.Text = "word";
            this.buttonWord.UseVisualStyleBackColor = true;
            this.buttonWord.Click += new System.EventHandler(this.buttonWord_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.Location = new System.Drawing.Point(390, 209);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(398, 229);
            this.buttonInfo.TabIndex = 3;
            this.buttonInfo.Text = "info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonWord);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.buttonInternet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonInternet;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.Button buttonWord;
        private System.Windows.Forms.Button buttonInfo;
    }
}

