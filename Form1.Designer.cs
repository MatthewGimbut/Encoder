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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.toEncode = new System.Windows.Forms.RichTextBox();
            this.encode = new System.Windows.Forms.Button();
            this.decode = new System.Windows.Forms.Button();
            this.toDecode = new System.Windows.Forms.RichTextBox();
            this.ReplaceZero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReplaceOne = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toEncode
            // 
            this.toEncode.BackColor = System.Drawing.Color.DimGray;
            this.toEncode.ForeColor = System.Drawing.Color.White;
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
            this.toDecode.BackColor = System.Drawing.Color.DimGray;
            this.toDecode.ForeColor = System.Drawing.Color.White;
            this.toDecode.Location = new System.Drawing.Point(338, 11);
            this.toDecode.Name = "toDecode";
            this.toDecode.Size = new System.Drawing.Size(238, 400);
            this.toDecode.TabIndex = 3;
            this.toDecode.Text = "";
            // 
            // ReplaceZero
            // 
            this.ReplaceZero.BackColor = System.Drawing.Color.DimGray;
            this.ReplaceZero.ForeColor = System.Drawing.Color.White;
            this.ReplaceZero.Location = new System.Drawing.Point(113, 438);
            this.ReplaceZero.Name = "ReplaceZero";
            this.ReplaceZero.Size = new System.Drawing.Size(130, 20);
            this.ReplaceZero.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Replacement for 0s:";
            // 
            // ReplaceOne
            // 
            this.ReplaceOne.BackColor = System.Drawing.Color.DimGray;
            this.ReplaceOne.ForeColor = System.Drawing.Color.White;
            this.ReplaceOne.Location = new System.Drawing.Point(113, 465);
            this.ReplaceOne.Name = "ReplaceOne";
            this.ReplaceOne.Size = new System.Drawing.Size(130, 20);
            this.ReplaceOne.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Replacement for 1s:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "If no text is entered, 0s and 1s default to l and I.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(599, 516);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 500);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReplaceOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReplaceZero);
            this.Controls.Add(this.toDecode);
            this.Controls.Add(this.decode);
            this.Controls.Add(this.encode);
            this.Controls.Add(this.toEncode);
            this.Controls.Add(this.pictureBox1);
            this.Name = "main";
            this.Text = "Encoder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox toEncode;
        private System.Windows.Forms.Button encode;
        private System.Windows.Forms.Button decode;
        private System.Windows.Forms.RichTextBox toDecode;
        private System.Windows.Forms.TextBox ReplaceZero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ReplaceOne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

