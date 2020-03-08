namespace WinFormsListView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listAuthors = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonList = new System.Windows.Forms.RadioButton();
            this.radioButtonDetails = new System.Windows.Forms.RadioButton();
            this.radioButtonLargeIcon = new System.Windows.Forms.RadioButton();
            this.radioButtonSmallIcon = new System.Windows.Forms.RadioButton();
            this.imagesLarge = new System.Windows.Forms.ImageList(this.components);
            this.imagesSmall = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listAuthors
            // 
            this.listAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listAuthors.HideSelection = false;
            this.listAuthors.Location = new System.Drawing.Point(13, 13);
            this.listAuthors.Name = "listAuthors";
            this.listAuthors.Size = new System.Drawing.Size(241, 336);
            this.listAuthors.TabIndex = 0;
            this.listAuthors.UseCompatibleStateImageBehavior = false;
            this.listAuthors.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listAuthors_ColumnClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButtonList);
            this.groupBox1.Controls.Add(this.radioButtonDetails);
            this.groupBox1.Controls.Add(this.radioButtonLargeIcon);
            this.groupBox1.Controls.Add(this.radioButtonSmallIcon);
            this.groupBox1.Location = new System.Drawing.Point(261, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View";
            // 
            // radioButtonList
            // 
            this.radioButtonList.AutoSize = true;
            this.radioButtonList.Location = new System.Drawing.Point(7, 89);
            this.radioButtonList.Name = "radioButtonList";
            this.radioButtonList.Size = new System.Drawing.Size(41, 17);
            this.radioButtonList.TabIndex = 3;
            this.radioButtonList.TabStop = true;
            this.radioButtonList.Text = "List";
            this.radioButtonList.UseVisualStyleBackColor = true;
            this.radioButtonList.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonDetails
            // 
            this.radioButtonDetails.AutoSize = true;
            this.radioButtonDetails.Location = new System.Drawing.Point(6, 66);
            this.radioButtonDetails.Name = "radioButtonDetails";
            this.radioButtonDetails.Size = new System.Drawing.Size(57, 17);
            this.radioButtonDetails.TabIndex = 2;
            this.radioButtonDetails.TabStop = true;
            this.radioButtonDetails.Text = "Details";
            this.radioButtonDetails.UseVisualStyleBackColor = true;
            this.radioButtonDetails.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonLargeIcon
            // 
            this.radioButtonLargeIcon.AutoSize = true;
            this.radioButtonLargeIcon.Location = new System.Drawing.Point(7, 43);
            this.radioButtonLargeIcon.Name = "radioButtonLargeIcon";
            this.radioButtonLargeIcon.Size = new System.Drawing.Size(73, 17);
            this.radioButtonLargeIcon.TabIndex = 1;
            this.radioButtonLargeIcon.TabStop = true;
            this.radioButtonLargeIcon.Text = "LargeIcon";
            this.radioButtonLargeIcon.UseVisualStyleBackColor = true;
            this.radioButtonLargeIcon.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButtonSmallIcon
            // 
            this.radioButtonSmallIcon.AutoSize = true;
            this.radioButtonSmallIcon.Location = new System.Drawing.Point(7, 20);
            this.radioButtonSmallIcon.Name = "radioButtonSmallIcon";
            this.radioButtonSmallIcon.Size = new System.Drawing.Size(71, 17);
            this.radioButtonSmallIcon.TabIndex = 0;
            this.radioButtonSmallIcon.TabStop = true;
            this.radioButtonSmallIcon.Text = "SmallIcon";
            this.radioButtonSmallIcon.UseVisualStyleBackColor = true;
            this.radioButtonSmallIcon.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // imagesLarge
            // 
            this.imagesLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagesLarge.ImageStream")));
            this.imagesLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imagesLarge.Images.SetKeyName(0, "open_32.png");
            // 
            // imagesSmall
            // 
            this.imagesSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagesSmall.ImageStream")));
            this.imagesSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imagesSmall.Images.SetKeyName(0, "open_16.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listAuthors);
            this.Name = "Form1";
            this.Text = "WinFormsListView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listAuthors;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonList;
        private System.Windows.Forms.RadioButton radioButtonDetails;
        private System.Windows.Forms.RadioButton radioButtonLargeIcon;
        private System.Windows.Forms.RadioButton radioButtonSmallIcon;
        private System.Windows.Forms.ImageList imagesLarge;
        private System.Windows.Forms.ImageList imagesSmall;
    }
}

