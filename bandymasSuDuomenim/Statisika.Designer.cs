namespace bandymasSuDuomenim
{
    partial class Statisika
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
            this.irasaiFoundListBox = new System.Windows.Forms.ListBox();
            this.rodytibutton = new System.Windows.Forms.Button();
            this.ieskotitextBox = new System.Windows.Forms.TextBox();
            this.VisaDatabutton = new System.Windows.Forms.Button();
            this.visosIslaidosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.visosIslaidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.visosIslaidosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visosIslaidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // irasaiFoundListBox
            // 
            this.irasaiFoundListBox.FormattingEnabled = true;
            this.irasaiFoundListBox.ItemHeight = 16;
            this.irasaiFoundListBox.Location = new System.Drawing.Point(48, 155);
            this.irasaiFoundListBox.Name = "irasaiFoundListBox";
            this.irasaiFoundListBox.Size = new System.Drawing.Size(593, 68);
            this.irasaiFoundListBox.TabIndex = 0;
            // 
            // rodytibutton
            // 
            this.rodytibutton.Location = new System.Drawing.Point(253, 92);
            this.rodytibutton.Name = "rodytibutton";
            this.rodytibutton.Size = new System.Drawing.Size(155, 42);
            this.rodytibutton.TabIndex = 1;
            this.rodytibutton.Text = "Rodyti";
            this.rodytibutton.UseVisualStyleBackColor = true;
            this.rodytibutton.Click += new System.EventHandler(this.rodytibutton_Click);
            // 
            // ieskotitextBox
            // 
            this.ieskotitextBox.Location = new System.Drawing.Point(72, 102);
            this.ieskotitextBox.Name = "ieskotitextBox";
            this.ieskotitextBox.Size = new System.Drawing.Size(162, 22);
            this.ieskotitextBox.TabIndex = 2;
            // 
            // VisaDatabutton
            // 
            this.VisaDatabutton.Location = new System.Drawing.Point(529, 92);
            this.VisaDatabutton.Name = "VisaDatabutton";
            this.VisaDatabutton.Size = new System.Drawing.Size(112, 42);
            this.VisaDatabutton.TabIndex = 3;
            this.VisaDatabutton.Text = "Visi";
            this.VisaDatabutton.UseVisualStyleBackColor = true;
            this.VisaDatabutton.Click += new System.EventHandler(this.VisaDatabutton_Click);
            // 
            // Statisika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 564);
            this.Controls.Add(this.VisaDatabutton);
            this.Controls.Add(this.ieskotitextBox);
            this.Controls.Add(this.rodytibutton);
            this.Controls.Add(this.irasaiFoundListBox);
            this.Name = "Statisika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statisika";
            ((System.ComponentModel.ISupportInitialize)(this.visosIslaidosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visosIslaidosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox irasaiFoundListBox;
        private System.Windows.Forms.Button rodytibutton;
        private System.Windows.Forms.TextBox ieskotitextBox;
        private System.Windows.Forms.Button VisaDatabutton;
        private System.Windows.Forms.BindingSource visosIslaidosBindingSource;
        private System.Windows.Forms.BindingSource visosIslaidosBindingSource1;
    }
}