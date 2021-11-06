﻿
namespace FormsToKeyboard
{
    partial class MainWindow
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
            this.ClearBtn = new System.Windows.Forms.Button();
            this.InputText = new System.Windows.Forms.RichTextBox();
            this.ProcessList = new System.Windows.Forms.ComboBox();
            this.ClipboardBtn = new System.Windows.Forms.Button();
            this.DelayPicker = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ImagePreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DelayPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(12, 135);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(146, 23);
            this.ClearBtn.TabIndex = 2;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // InputText
            // 
            this.InputText.Location = new System.Drawing.Point(164, 12);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(300, 175);
            this.InputText.TabIndex = 3;
            this.InputText.Text = "";
            // 
            // ProcessList
            // 
            this.ProcessList.FormattingEnabled = true;
            this.ProcessList.Location = new System.Drawing.Point(12, 34);
            this.ProcessList.Name = "ProcessList";
            this.ProcessList.Size = new System.Drawing.Size(146, 23);
            this.ProcessList.TabIndex = 4;
            // 
            // ClipboardBtn
            // 
            this.ClipboardBtn.Location = new System.Drawing.Point(12, 164);
            this.ClipboardBtn.Name = "ClipboardBtn";
            this.ClipboardBtn.Size = new System.Drawing.Size(146, 23);
            this.ClipboardBtn.TabIndex = 5;
            this.ClipboardBtn.Text = "Copy Clipboard";
            this.ClipboardBtn.UseVisualStyleBackColor = true;
            this.ClipboardBtn.Click += new System.EventHandler(this.ClipboardBtn_Click);
            // 
            // DelayPicker
            // 
            this.DelayPicker.Location = new System.Drawing.Point(12, 78);
            this.DelayPicker.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.DelayPicker.Name = "DelayPicker";
            this.DelayPicker.Size = new System.Drawing.Size(146, 23);
            this.DelayPicker.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Attach To Process";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Delay (ms)";
            // 
            // ImagePreview
            // 
            this.ImagePreview.Location = new System.Drawing.Point(520, 12);
            this.ImagePreview.Name = "ImagePreview";
            this.ImagePreview.Size = new System.Drawing.Size(300, 175);
            this.ImagePreview.TabIndex = 9;
            this.ImagePreview.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 196);
            this.Controls.Add(this.ImagePreview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DelayPicker);
            this.Controls.Add(this.ClipboardBtn);
            this.Controls.Add(this.ProcessList);
            this.Controls.Add(this.InputText);
            this.Controls.Add(this.ClearBtn);
            this.Name = "MainWindow";
            this.Text = "Image OCR Helper";
            ((System.ComponentModel.ISupportInitialize)(this.DelayPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.RichTextBox InputText;
        private System.Windows.Forms.ComboBox ProcessList;
        private System.Windows.Forms.Button ClipboardBtn;
        private System.Windows.Forms.NumericUpDown DelayPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ImagePreview;
    }
}

