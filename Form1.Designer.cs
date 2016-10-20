namespace Encoder
{
    partial class main
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
            this.toEncode = new System.Windows.Forms.RichTextBox();
            this.encode = new System.Windows.Forms.Button();
            this.decode = new System.Windows.Forms.Button();
            this.toDecode = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // toEncode
            // 
            this.toEncode.Location = new System.Drawing.Point(12, 12);
            this.toEncode.Name = "toEncode";
            this.toEncode.Size = new System.Drawing.Size(238, 400);
            this.toEncode.TabIndex = 0;
            this.toEncode.Text = "";
            // 
            // encode
            // 
            this.encode.Location = new System.Drawing.Point(256, 176);
            this.encode.Name = "encode";
            this.encode.Size = new System.Drawing.Size(75, 23);
            this.encode.TabIndex = 1;
            this.encode.Text = "Encode ->";
            this.encode.UseVisualStyleBackColor = true;
            this.encode.Click += new System.EventHandler(this.encode_Click);
            // 
            // decode
            // 
            this.decode.Location = new System.Drawing.Point(256, 205);
            this.decode.Name = "decode";
            this.decode.Size = new System.Drawing.Size(75, 23);
            this.decode.TabIndex = 2;
            this.decode.Text = "<- Decode";
            this.decode.UseVisualStyleBackColor = true;
            this.decode.Click += new System.EventHandler(this.decode_Click);
            // 
            // toDecode
            // 
            this.toDecode.Location = new System.Drawing.Point(338, 11);
            this.toDecode.Name = "toDecode";
            this.toDecode.Size = new System.Drawing.Size(238, 400);
            this.toDecode.TabIndex = 3;
            this.toDecode.Text = "";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 424);
            this.Controls.Add(this.toDecode);
            this.Controls.Add(this.decode);
            this.Controls.Add(this.encode);
            this.Controls.Add(this.toEncode);
            this.Name = "main";
            this.Text = "Encoder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox toEncode;
        private System.Windows.Forms.Button encode;
        private System.Windows.Forms.Button decode;
        private System.Windows.Forms.RichTextBox toDecode;
    }
}

