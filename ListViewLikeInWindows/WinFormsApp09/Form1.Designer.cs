
namespace WinFormsApp09
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.labelCurrentPath = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDetails = new System.Windows.Forms.RadioButton();
            this.radioButtonTile = new System.Windows.Forms.RadioButton();
            this.radioButtonList = new System.Windows.Forms.RadioButton();
            this.radioButtonSmallICon = new System.Windows.Forms.RadioButton();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.radioButtonLargeIcon = new System.Windows.Forms.RadioButton();
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.listViewFilesAndFolders = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текуща директория:";
            // 
            // labelCurrentPath
            // 
            this.labelCurrentPath.AutoSize = true;
            this.labelCurrentPath.Location = new System.Drawing.Point(185, 23);
            this.labelCurrentPath.Name = "labelCurrentPath";
            this.labelCurrentPath.Size = new System.Drawing.Size(96, 15);
            this.labelCurrentPath.TabIndex = 1;
            this.labelCurrentPath.Text = "labelCurrentPath";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDetails);
            this.groupBox1.Controls.Add(this.radioButtonTile);
            this.groupBox1.Controls.Add(this.radioButtonList);
            this.groupBox1.Controls.Add(this.radioButtonSmallICon);
            this.groupBox1.Controls.Add(this.radioButtonLargeIcon);
            this.groupBox1.Location = new System.Drawing.Point(579, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 298);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Опции";
            // 
            // radioButtonDetails
            // 
            this.radioButtonDetails.AutoSize = true;
            this.radioButtonDetails.Checked = true;
            this.radioButtonDetails.Location = new System.Drawing.Point(17, 98);
            this.radioButtonDetails.Name = "radioButtonDetails";
            this.radioButtonDetails.Size = new System.Drawing.Size(78, 19);
            this.radioButtonDetails.TabIndex = 4;
            this.radioButtonDetails.TabStop = true;
            this.radioButtonDetails.Text = "Детайлно";
            this.radioButtonDetails.UseVisualStyleBackColor = true;
            this.radioButtonDetails.CheckedChanged += new System.EventHandler(this.radioButtonDetails_CheckedChanged);
            // 
            // radioButtonTile
            // 
            this.radioButtonTile.AutoSize = true;
            this.radioButtonTile.Location = new System.Drawing.Point(17, 123);
            this.radioButtonTile.Name = "radioButtonTile";
            this.radioButtonTile.Size = new System.Drawing.Size(119, 19);
            this.radioButtonTile.TabIndex = 3;
            this.radioButtonTile.Text = "Детайлен списък";
            this.radioButtonTile.UseVisualStyleBackColor = true;
            this.radioButtonTile.CheckedChanged += new System.EventHandler(this.radioButtonTile_CheckedChanged);
            // 
            // radioButtonList
            // 
            this.radioButtonList.AutoSize = true;
            this.radioButtonList.Location = new System.Drawing.Point(17, 73);
            this.radioButtonList.Name = "radioButtonList";
            this.radioButtonList.Size = new System.Drawing.Size(66, 19);
            this.radioButtonList.TabIndex = 2;
            this.radioButtonList.Text = "Списък";
            this.radioButtonList.UseVisualStyleBackColor = true;
            this.radioButtonList.CheckedChanged += new System.EventHandler(this.radioButtonList_CheckedChanged);
            // 
            // radioButtonSmallICon
            // 
            this.radioButtonSmallICon.AutoSize = true;
            this.radioButtonSmallICon.ImageList = this.imageListSmall;
            this.radioButtonSmallICon.Location = new System.Drawing.Point(17, 48);
            this.radioButtonSmallICon.Name = "radioButtonSmallICon";
            this.radioButtonSmallICon.Size = new System.Drawing.Size(99, 19);
            this.radioButtonSmallICon.TabIndex = 1;
            this.radioButtonSmallICon.Text = "Малки икони";
            this.radioButtonSmallICon.UseVisualStyleBackColor = true;
            this.radioButtonSmallICon.CheckedChanged += new System.EventHandler(this.radioButtonSmallICon_CheckedChanged);
            // 
            // imageListSmall
            // 
            this.imageListSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "Folder.ico");
            this.imageListSmall.Images.SetKeyName(1, "List-16.ico");
            // 
            // radioButtonLargeIcon
            // 
            this.radioButtonLargeIcon.AutoSize = true;
            this.radioButtonLargeIcon.ImageList = this.imageListLarge;
            this.radioButtonLargeIcon.Location = new System.Drawing.Point(17, 23);
            this.radioButtonLargeIcon.Name = "radioButtonLargeIcon";
            this.radioButtonLargeIcon.Size = new System.Drawing.Size(104, 19);
            this.radioButtonLargeIcon.TabIndex = 0;
            this.radioButtonLargeIcon.Text = "Големи икони";
            this.radioButtonLargeIcon.UseVisualStyleBackColor = true;
            this.radioButtonLargeIcon.CheckedChanged += new System.EventHandler(this.radioButtonLargeIcon_CheckedChanged);
            // 
            // imageListLarge
            // 
            this.imageListLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "Folder-32.png");
            this.imageListLarge.Images.SetKeyName(1, "List-32.png");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewFilesAndFolders
            // 
            this.listViewFilesAndFolders.HideSelection = false;
            this.listViewFilesAndFolders.LargeImageList = this.imageListLarge;
            this.listViewFilesAndFolders.Location = new System.Drawing.Point(12, 61);
            this.listViewFilesAndFolders.Name = "listViewFilesAndFolders";
            this.listViewFilesAndFolders.Size = new System.Drawing.Size(552, 298);
            this.listViewFilesAndFolders.SmallImageList = this.imageListSmall;
            this.listViewFilesAndFolders.TabIndex = 5;
            this.listViewFilesAndFolders.UseCompatibleStateImageBehavior = false;
            this.listViewFilesAndFolders.View = System.Windows.Forms.View.Details;
            this.listViewFilesAndFolders.ItemActivate += new System.EventHandler(this.listViewFilesAndFolders_ItemActivate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewFilesAndFolders);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelCurrentPath);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Изобразяване на папки и файлове";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCurrentPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDetails;
        private System.Windows.Forms.RadioButton radioButtonTile;
        private System.Windows.Forms.RadioButton radioButtonList;
        private System.Windows.Forms.RadioButton radioButtonSmallICon;
        private System.Windows.Forms.RadioButton radioButtonLargeIcon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listViewFilesAndFolders;
        public System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ImageList imageListLarge;
    }
}

