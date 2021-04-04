
namespace Crop_a_Portion_of_Image
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
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxXposition = new System.Windows.Forms.TextBox();
            this.labelXpostion = new System.Windows.Forms.Label();
            this.textBoxYposition = new System.Windows.Forms.TextBox();
            this.labelYpostion = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.listViewOfImages = new System.Windows.Forms.ListView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonCrop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWidth.Location = new System.Drawing.Point(104, 106);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(68, 26);
            this.labelWidth.TabIndex = 0;
            this.labelWidth.Text = "Width";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeight.Location = new System.Drawing.Point(242, 106);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(75, 26);
            this.labelHeight.TabIndex = 1;
            this.labelHeight.Text = "Height";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(88, 135);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxWidth.TabIndex = 2;
            this.textBoxWidth.Text = "1236";
            this.textBoxWidth.TextChanged += new System.EventHandler(this.textBoxWidth_TextChanged);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(228, 135);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeight.TabIndex = 3;
            this.textBoxHeight.Text = "1854";
            this.textBoxHeight.TextChanged += new System.EventHandler(this.textBoxWidth_TextChanged);
            // 
            // textBoxXposition
            // 
            this.textBoxXposition.Location = new System.Drawing.Point(88, 283);
            this.textBoxXposition.Name = "textBoxXposition";
            this.textBoxXposition.Size = new System.Drawing.Size(100, 20);
            this.textBoxXposition.TabIndex = 5;
            this.textBoxXposition.Text = "406";
            this.textBoxXposition.TextChanged += new System.EventHandler(this.textBoxWidth_TextChanged);
            // 
            // labelXpostion
            // 
            this.labelXpostion.AutoSize = true;
            this.labelXpostion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXpostion.Location = new System.Drawing.Point(83, 254);
            this.labelXpostion.Name = "labelXpostion";
            this.labelXpostion.Size = new System.Drawing.Size(108, 26);
            this.labelXpostion.TabIndex = 4;
            this.labelXpostion.Text = "X position";
            // 
            // textBoxYposition
            // 
            this.textBoxYposition.Location = new System.Drawing.Point(257, 283);
            this.textBoxYposition.Name = "textBoxYposition";
            this.textBoxYposition.Size = new System.Drawing.Size(100, 20);
            this.textBoxYposition.TabIndex = 7;
            this.textBoxYposition.Text = "97";
            this.textBoxYposition.TextChanged += new System.EventHandler(this.textBoxWidth_TextChanged);
            // 
            // labelYpostion
            // 
            this.labelYpostion.AutoSize = true;
            this.labelYpostion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYpostion.Location = new System.Drawing.Point(252, 254);
            this.labelYpostion.Name = "labelYpostion";
            this.labelYpostion.Size = new System.Drawing.Size(109, 26);
            this.labelYpostion.TabIndex = 6;
            this.labelYpostion.Text = "Y position";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(546, 254);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 8;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // listViewOfImages
            // 
            this.listViewOfImages.HideSelection = false;
            this.listViewOfImages.Location = new System.Drawing.Point(500, 25);
            this.listViewOfImages.Name = "listViewOfImages";
            this.listViewOfImages.Size = new System.Drawing.Size(171, 223);
            this.listViewOfImages.TabIndex = 9;
            this.listViewOfImages.UseCompatibleStateImageBehavior = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonCrop
            // 
            this.buttonCrop.Location = new System.Drawing.Point(228, 390);
            this.buttonCrop.Name = "buttonCrop";
            this.buttonCrop.Size = new System.Drawing.Size(75, 23);
            this.buttonCrop.TabIndex = 10;
            this.buttonCrop.Text = "Crop";
            this.buttonCrop.UseVisualStyleBackColor = true;
            this.buttonCrop.Click += new System.EventHandler(this.buttonCrop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCrop);
            this.Controls.Add(this.listViewOfImages);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxYposition);
            this.Controls.Add(this.labelYpostion);
            this.Controls.Add(this.textBoxXposition);
            this.Controls.Add(this.labelXpostion);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWidth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxXposition;
        private System.Windows.Forms.Label labelXpostion;
        private System.Windows.Forms.TextBox textBoxYposition;
        private System.Windows.Forms.Label labelYpostion;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.ListView listViewOfImages;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonCrop;
    }
}

