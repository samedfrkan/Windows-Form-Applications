namespace CaesarCipherApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.RadioButton radioButtonRot2;
        private System.Windows.Forms.RadioButton radioButtonCaesar;
        private System.Windows.Forms.TextBox textBoxCaesarCode;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Label successLabel;
        private System.Windows.Forms.Label encryptedTextLabel; // Yeni eklenen kontrol

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.radioButtonRot2 = new System.Windows.Forms.RadioButton();
            this.radioButtonCaesar = new System.Windows.Forms.RadioButton();
            this.textBoxCaesarCode = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.successLabel = new System.Windows.Forms.Label();
            this.encryptedTextLabel = new System.Windows.Forms.Label(); // Yeni eklenen kontrol
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(33, 33);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(227, 20);
            this.textBoxPassword.TabIndex = 0;
            // 
            // radioButtonRot2
            // 
            this.radioButtonRot2.AutoSize = true;
            this.radioButtonRot2.Location = new System.Drawing.Point(33, 78);
            this.radioButtonRot2.Name = "radioButtonRot2";
            this.radioButtonRot2.Size = new System.Drawing.Size(53, 17);
            this.radioButtonRot2.TabIndex = 1;
            this.radioButtonRot2.TabStop = true;
            this.radioButtonRot2.Text = "ROT2";
            this.radioButtonRot2.UseVisualStyleBackColor = true;
            // 
            // radioButtonCaesar
            // 
            this.radioButtonCaesar.AutoSize = true;
            this.radioButtonCaesar.Location = new System.Drawing.Point(111, 78);
            this.radioButtonCaesar.Name = "radioButtonCaesar";
            this.radioButtonCaesar.Size = new System.Drawing.Size(58, 17);
            this.radioButtonCaesar.TabIndex = 2;
            this.radioButtonCaesar.TabStop = true;
            this.radioButtonCaesar.Text = "Caesar";
            this.radioButtonCaesar.UseVisualStyleBackColor = true;
            this.radioButtonCaesar.CheckedChanged += new System.EventHandler(this.radioButtonCaesar_CheckedChanged);
            // 
            // textBoxCaesarCode
            // 
            this.textBoxCaesarCode.Location = new System.Drawing.Point(189, 78);
            this.textBoxCaesarCode.Name = "textBoxCaesarCode";
            this.textBoxCaesarCode.Size = new System.Drawing.Size(71, 20);
            this.textBoxCaesarCode.TabIndex = 3;
            this.textBoxCaesarCode.Visible = false;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(33, 118);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(227, 23);
            this.buttonEncrypt.TabIndex = 4;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.Location = new System.Drawing.Point(30, 164);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(0, 13);
            this.successLabel.TabIndex = 5;
            // 
            // encryptedTextLabel
            // 
            this.encryptedTextLabel.AutoSize = true;
            this.encryptedTextLabel.Location = new System.Drawing.Point(30, 200);
            this.encryptedTextLabel.Name = "encryptedTextLabel";
            this.encryptedTextLabel.Size = new System.Drawing.Size(0, 13);
            this.encryptedTextLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 235); // Boyutu güncellendi
            this.Controls.Add(this.encryptedTextLabel); // Yeni eklenen kontrol eklendi
            this.Controls.Add(this.successLabel);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.textBoxCaesarCode);
            this.Controls.Add(this.radioButtonCaesar);
            this.Controls.Add(this.radioButtonRot2);
            this.Controls.Add(this.textBoxPassword);
            this.Name = "Form1";
            this.Text = "Caesar Cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
