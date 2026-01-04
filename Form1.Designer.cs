namespace LLMChatDesktop
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbChatHistory = new System.Windows.Forms.RichTextBox();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // rtbChatHistory
            // 
            this.rtbChatHistory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbChatHistory.Location = new System.Drawing.Point(36, 37);
            this.rtbChatHistory.Name = "rtbChatHistory";
            this.rtbChatHistory.ReadOnly = true;
            this.rtbChatHistory.Size = new System.Drawing.Size(501, 194);
            this.rtbChatHistory.TabIndex = 0;
            this.rtbChatHistory.Text = "";
            // 
            // txtUserInput
            // 
            this.txtUserInput.BackColor = System.Drawing.Color.AliceBlue;
            this.txtUserInput.Location = new System.Drawing.Point(79, 253);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(408, 20);
            this.txtUserInput.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.LightBlue;
            this.btnSend.Location = new System.Drawing.Point(227, 279);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(135, 55);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "gönder";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.rtbChatHistory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbChatHistory;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panel1;
    }
}

