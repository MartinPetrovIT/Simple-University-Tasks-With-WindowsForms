
namespace WinFormsApp07
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.buttonCenter = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUnderline = new System.Windows.Forms.Button();
            this.buttonItalic = new System.Windows.Forms.Button();
            this.buttonBold = new System.Windows.Forms.Button();
            this.richTextBoxText = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxSize);
            this.splitContainer1.Panel1.Controls.Add(this.labelSize);
            this.splitContainer1.Panel1.Controls.Add(this.buttonCenter);
            this.splitContainer1.Panel1.Controls.Add(this.buttonLoad);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSave);
            this.splitContainer1.Panel1.Controls.Add(this.buttonUnderline);
            this.splitContainer1.Panel1.Controls.Add(this.buttonItalic);
            this.splitContainer1.Panel1.Controls.Add(this.buttonBold);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxText);
            this.splitContainer1.Size = new System.Drawing.Size(700, 450);
            this.splitContainer1.SplitterDistance = 45;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(402, 10);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(81, 23);
            this.textBoxSize.TabIndex = 2;
            this.textBoxSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSize_KeyPress);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(347, 14);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(47, 15);
            this.labelSize.TabIndex = 2;
            this.labelSize.Text = "Размер";
            // 
            // buttonCenter
            // 
            this.buttonCenter.Location = new System.Drawing.Point(263, 8);
            this.buttonCenter.Name = "buttonCenter";
            this.buttonCenter.Size = new System.Drawing.Size(75, 23);
            this.buttonCenter.TabIndex = 1;
            this.buttonCenter.Text = "Center";
            this.buttonCenter.UseVisualStyleBackColor = true;
            this.buttonCenter.Click += new System.EventHandler(this.buttonCenter_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(490, 8);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Отвори";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(582, 8);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Запиши";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonUnderline
            // 
            this.buttonUnderline.Location = new System.Drawing.Point(93, 8);
            this.buttonUnderline.Name = "buttonUnderline";
            this.buttonUnderline.Size = new System.Drawing.Size(75, 23);
            this.buttonUnderline.TabIndex = 1;
            this.buttonUnderline.Text = "Underline";
            this.buttonUnderline.UseVisualStyleBackColor = true;
            this.buttonUnderline.Click += new System.EventHandler(this.buttonUnderline_Click);
            // 
            // buttonItalic
            // 
            this.buttonItalic.Location = new System.Drawing.Point(178, 8);
            this.buttonItalic.Name = "buttonItalic";
            this.buttonItalic.Size = new System.Drawing.Size(75, 23);
            this.buttonItalic.TabIndex = 2;
            this.buttonItalic.Text = "Italic";
            this.buttonItalic.UseVisualStyleBackColor = true;
            this.buttonItalic.Click += new System.EventHandler(this.buttonItalic_Click);
            // 
            // buttonBold
            // 
            this.buttonBold.Location = new System.Drawing.Point(8, 8);
            this.buttonBold.Name = "buttonBold";
            this.buttonBold.Size = new System.Drawing.Size(75, 23);
            this.buttonBold.TabIndex = 1;
            this.buttonBold.Text = "Bold";
            this.buttonBold.UseVisualStyleBackColor = true;
            this.buttonBold.Click += new System.EventHandler(this.buttonBold_Click);
            // 
            // richTextBoxText
            // 
            this.richTextBoxText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxText.Location = new System.Drawing.Point(0, 3);
            this.richTextBoxText.Name = "richTextBoxText";
            this.richTextBoxText.Size = new System.Drawing.Size(700, 398);
            this.richTextBoxText.TabIndex = 2;
            this.richTextBoxText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Елементарен текстов редактор";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Button buttonCenter;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUnderline;
        private System.Windows.Forms.Button buttonItalic;
        private System.Windows.Forms.Button buttonBold;
        private System.Windows.Forms.RichTextBox richTextBoxText;
        const string MyFile = "Test.rtf";

    }
}

