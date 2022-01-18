
namespace WinFormsApp05
{
    partial class Form1
    {
       
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelOccupation = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxOccupation = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(18, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(31, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Име";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(18, 73);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(40, 15);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "Aдрес";
            // 
            // labelOccupation
            // 
            this.labelOccupation.AutoSize = true;
            this.labelOccupation.Location = new System.Drawing.Point(18, 226);
            this.labelOccupation.Name = "labelOccupation";
            this.labelOccupation.Size = new System.Drawing.Size(64, 15);
            this.labelOccupation.TabIndex = 2;
            this.labelOccupation.Text = "Професия";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(18, 279);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(50, 15);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "Възраст";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(18, 324);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(61, 15);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.Text = "Резултати";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(360, 16);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp.CausesValidation = false;
            this.buttonHelp.Location = new System.Drawing.Point(360, 69);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 6;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(88, 17);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(242, 23);
            this.textBoxName.TabIndex = 8;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxOccupation
            // 
            this.textBoxOccupation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOccupation.Location = new System.Drawing.Point(88, 223);
            this.textBoxOccupation.Name = "textBoxOccupation";
            this.textBoxOccupation.Size = new System.Drawing.Size(242, 23);
            this.textBoxOccupation.TabIndex = 9;
            this.textBoxOccupation.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxOccupation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAge_KeyPress);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddress.Location = new System.Drawing.Point(88, 69);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAddress.Size = new System.Drawing.Size(242, 130);
            this.textBoxAddress.TabIndex = 10;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAge.Location = new System.Drawing.Point(98, 276);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(64, 23);
            this.textBoxAge.TabIndex = 11;
            this.textBoxAge.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAge_KeyPress);
            this.textBoxAge.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxAge_KeyUp);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Location = new System.Drawing.Point(23, 351);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(425, 62);
            this.textBoxOutput.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 464);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxOccupation);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelOccupation);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.MinimumSize = new System.Drawing.Size(466, 450);
            this.Name = "Form1";
            this.Text = "Въвеждане на лични данни";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelOccupation;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxOccupation;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxOutput;
    }
}

