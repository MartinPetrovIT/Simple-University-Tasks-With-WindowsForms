
namespace WinFormsApp06
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
            this.labelAge = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.checkBoxAreYouAProgrammer = new System.Windows.Forms.CheckBox();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.groupBoxGender.SuspendLayout();
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
            this.labelAddress.Location = new System.Drawing.Point(18, 66);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(40, 15);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "Aдрес";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(18, 342);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(50, 15);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "Възраст";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(12, 376);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(61, 15);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.Text = "Резултати";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(453, 16);
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
            this.buttonHelp.Location = new System.Drawing.Point(453, 69);
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
            this.textBoxName.Size = new System.Drawing.Size(335, 23);
            this.textBoxName.TabIndex = 8;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddress.Location = new System.Drawing.Point(88, 66);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAddress.Size = new System.Drawing.Size(335, 96);
            this.textBoxAddress.TabIndex = 10;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAge.Location = new System.Drawing.Point(97, 342);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(128, 23);
            this.textBoxAge.TabIndex = 11;
            this.textBoxAge.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxAge.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxAge_KeyUp);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput.Location = new System.Drawing.Point(18, 405);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(526, 100);
            this.textBoxOutput.TabIndex = 12;
            // 
            // checkBoxAreYouAProgrammer
            // 
            this.checkBoxAreYouAProgrammer.AutoSize = true;
            this.checkBoxAreYouAProgrammer.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAreYouAProgrammer.Location = new System.Drawing.Point(61, 182);
            this.checkBoxAreYouAProgrammer.Name = "checkBoxAreYouAProgrammer";
            this.checkBoxAreYouAProgrammer.Size = new System.Drawing.Size(94, 19);
            this.checkBoxAreYouAProgrammer.TabIndex = 13;
            this.checkBoxAreYouAProgrammer.Text = "Програмист";
            this.checkBoxAreYouAProgrammer.UseVisualStyleBackColor = true;
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButtonFemale);
            this.groupBoxGender.Controls.Add(this.radioButtonMale);
            this.groupBoxGender.Location = new System.Drawing.Point(18, 216);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(373, 100);
            this.groupBoxGender.TabIndex = 14;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Пол";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(113, 22);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(52, 19);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Мъж";
            this.radioButtonMale.UseVisualStyleBackColor = true;
           
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(113, 59);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(55, 19);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Жена";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 554);
            this.Controls.Add(this.groupBoxGender);
            this.Controls.Add(this.checkBoxAreYouAProgrammer);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.MinimumSize = new System.Drawing.Size(466, 450);
            this.Name = "Form1";
            this.Text = "Въвеждане на лични данни";
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.CheckBox checkBoxAreYouAProgrammer;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
    }
}

