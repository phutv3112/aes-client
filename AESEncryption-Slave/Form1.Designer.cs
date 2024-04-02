
namespace AESEncryptionSlave
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
            textBoxInput = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            buttonExit = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            textBoxEncryptPassword = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            textBoxDcryptPassword = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            textBoxEncrypted = new System.Windows.Forms.TextBox();
            buttonDecrypt = new System.Windows.Forms.Button();
            buttonEncrypt = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            textBoxEncryptedOutput = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            textBoxDecryptOutput = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            textBoxDebug = new System.Windows.Forms.TextBox();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            button5 = new System.Windows.Forms.Button();
            textTimeEncrypt = new System.Windows.Forms.TextBox();
            textTimeDecrypt = new System.Windows.Forms.TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxInput.Location = new System.Drawing.Point(8, 48);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new System.Drawing.Size(523, 27);
            textBoxInput.TabIndex = 0;
            textBoxInput.TextChanged += textBoxInput_TextChanged;
            textBoxInput.MouseDoubleClick += textBoxInput_MouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(8, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(147, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter plain input text";
            // 
            // buttonExit
            // 
            buttonExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonExit.Location = new System.Drawing.Point(694, 531);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new System.Drawing.Size(94, 29);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(8, 92);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(335, 20);
            label2.TabIndex = 4;
            label2.Text = "Provide password to use for encryption (16 chars)";
            // 
            // textBoxEncryptPassword
            // 
            textBoxEncryptPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxEncryptPassword.Location = new System.Drawing.Point(8, 115);
            textBoxEncryptPassword.MaxLength = 16;
            textBoxEncryptPassword.Name = "textBoxEncryptPassword";
            textBoxEncryptPassword.Size = new System.Drawing.Size(390, 27);
            textBoxEncryptPassword.TabIndex = 3;
            textBoxEncryptPassword.TextChanged += textBoxEncryptPassword_TextChanged;
            textBoxEncryptPassword.Leave += textBoxEncryptPassword_Leave;
            textBoxEncryptPassword.MouseDoubleClick += textBoxEncryptPassword_MouseDoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textTimeEncrypt);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxEncryptPassword);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxInput);
            groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox1.Location = new System.Drawing.Point(13, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(775, 219);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Encryption";
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(568, 111);
            button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(115, 31);
            button2.TabIndex = 6;
            button2.Text = "Generate Key";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(568, 48);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(115, 31);
            button1.TabIndex = 5;
            button1.Text = "Plaintext";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textTimeDecrypt);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBoxDcryptPassword);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBoxEncrypted);
            groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            groupBox2.Location = new System.Drawing.Point(13, 267);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(775, 229);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Decryption";
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(568, 116);
            button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(115, 31);
            button4.TabIndex = 8;
            button4.Text = "Key File";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(568, 48);
            button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(115, 31);
            button3.TabIndex = 7;
            button3.Text = "Encrypt file";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(8, 93);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(336, 20);
            label3.TabIndex = 4;
            label3.Text = "Provide password to use for decryption (16 chars)";
            // 
            // textBoxDcryptPassword
            // 
            textBoxDcryptPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxDcryptPassword.Location = new System.Drawing.Point(8, 117);
            textBoxDcryptPassword.MaxLength = 16;
            textBoxDcryptPassword.Name = "textBoxDcryptPassword";
            textBoxDcryptPassword.Size = new System.Drawing.Size(390, 27);
            textBoxDcryptPassword.TabIndex = 3;
            textBoxDcryptPassword.TextChanged += textBoxDcryptPassword_TextChanged;
            textBoxDcryptPassword.MouseDoubleClick += textBoxDcryptPassword_MouseDoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(8, 25);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(244, 20);
            label4.TabIndex = 1;
            label4.Text = "Enter encrypted text (base64 string)";
            // 
            // textBoxEncrypted
            // 
            textBoxEncrypted.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxEncrypted.Location = new System.Drawing.Point(8, 48);
            textBoxEncrypted.Name = "textBoxEncrypted";
            textBoxEncrypted.Size = new System.Drawing.Size(523, 27);
            textBoxEncrypted.TabIndex = 0;
            textBoxEncrypted.TextChanged += textBoxEncrypted_TextChanged;
            textBoxEncrypted.MouseDoubleClick += textBoxEncrypted_MouseDoubleClick;
            // 
            // buttonDecrypt
            // 
            buttonDecrypt.Enabled = false;
            buttonDecrypt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonDecrypt.Location = new System.Drawing.Point(567, 531);
            buttonDecrypt.Name = "buttonDecrypt";
            buttonDecrypt.Size = new System.Drawing.Size(94, 29);
            buttonDecrypt.TabIndex = 7;
            buttonDecrypt.Text = "Decrypt";
            buttonDecrypt.UseVisualStyleBackColor = true;
            buttonDecrypt.Click += buttonDecrypt_Click;
            // 
            // buttonEncrypt
            // 
            buttonEncrypt.Enabled = false;
            buttonEncrypt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonEncrypt.Location = new System.Drawing.Point(440, 531);
            buttonEncrypt.Name = "buttonEncrypt";
            buttonEncrypt.Size = new System.Drawing.Size(94, 29);
            buttonEncrypt.TabIndex = 8;
            buttonEncrypt.Text = "Encrypt";
            buttonEncrypt.UseVisualStyleBackColor = true;
            buttonEncrypt.Click += buttonEncrypt_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(23, 184);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(206, 20);
            label5.TabIndex = 10;
            label5.Text = "Encrypted text (base64 string)";
            // 
            // textBoxEncryptedOutput
            // 
            textBoxEncryptedOutput.Location = new System.Drawing.Point(23, 207);
            textBoxEncryptedOutput.Name = "textBoxEncryptedOutput";
            textBoxEncryptedOutput.ReadOnly = true;
            textBoxEncryptedOutput.Size = new System.Drawing.Size(521, 27);
            textBoxEncryptedOutput.TabIndex = 9;
            textBoxEncryptedOutput.TextChanged += textBoxEncryptedOutput_TextChanged;
            textBoxEncryptedOutput.MouseDoubleClick += textBoxEncryptedOutput_MouseDoubleClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(22, 428);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(107, 20);
            label6.TabIndex = 12;
            label6.Text = "Decrypted text";
            // 
            // textBoxDecryptOutput
            // 
            textBoxDecryptOutput.Location = new System.Drawing.Point(22, 451);
            textBoxDecryptOutput.Name = "textBoxDecryptOutput";
            textBoxDecryptOutput.ReadOnly = true;
            textBoxDecryptOutput.Size = new System.Drawing.Size(522, 27);
            textBoxDecryptOutput.TabIndex = 11;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxDebug);
            groupBox3.Location = new System.Drawing.Point(13, 600);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(775, 77);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Double click inside any field above to see its value in bytes";
            // 
            // textBoxDebug
            // 
            textBoxDebug.Location = new System.Drawing.Point(10, 35);
            textBoxDebug.Name = "textBoxDebug";
            textBoxDebug.ReadOnly = true;
            textBoxDebug.Size = new System.Drawing.Size(747, 27);
            textBoxDebug.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button5
            // 
            button5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button5.Location = new System.Drawing.Point(318, 531);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(94, 29);
            button5.TabIndex = 14;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textTimeEncrypt
            // 
            textTimeEncrypt.Location = new System.Drawing.Point(568, 179);
            textTimeEncrypt.Name = "textTimeEncrypt";
            textTimeEncrypt.ReadOnly = true;
            textTimeEncrypt.Size = new System.Drawing.Size(189, 27);
            textTimeEncrypt.TabIndex = 7;
            textTimeEncrypt.TextChanged += textBox1_TextChanged;
            // 
            // textTimeDecrypt
            // 
            textTimeDecrypt.Location = new System.Drawing.Point(568, 184);
            textTimeDecrypt.Name = "textTimeDecrypt";
            textTimeDecrypt.ReadOnly = true;
            textTimeDecrypt.Size = new System.Drawing.Size(189, 27);
            textTimeDecrypt.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 691);
            Controls.Add(button5);
            Controls.Add(groupBox3);
            Controls.Add(label6);
            Controls.Add(textBoxDecryptOutput);
            Controls.Add(label5);
            Controls.Add(textBoxEncryptedOutput);
            Controls.Add(buttonEncrypt);
            Controls.Add(buttonDecrypt);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(buttonExit);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Encryption/Decryption AES";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEncryptPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDcryptPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEncrypted;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEncryptedOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDecryptOutput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxDebug;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textTimeEncrypt;
        private System.Windows.Forms.TextBox textTimeDecrypt;
    }
}

