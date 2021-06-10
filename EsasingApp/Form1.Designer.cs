namespace EsasingApp
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
            this.txtBoxFilePath = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dtPickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dtPickerTo = new System.Windows.Forms.DateTimePicker();
            this.Range = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxFilePath
            // 
            this.txtBoxFilePath.Location = new System.Drawing.Point(120, 29);
            this.txtBoxFilePath.Name = "txtBoxFilePath";
            this.txtBoxFilePath.Size = new System.Drawing.Size(564, 20);
            this.txtBoxFilePath.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "FilePath";
            // 
            // dtPickerFrom
            // 
            this.dtPickerFrom.Location = new System.Drawing.Point(120, 77);
            this.dtPickerFrom.Name = "dtPickerFrom";
            this.dtPickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dtPickerFrom.TabIndex = 3;
            // 
            // dtPickerTo
            // 
            this.dtPickerTo.Location = new System.Drawing.Point(409, 77);
            this.dtPickerTo.Name = "dtPickerTo";
            this.dtPickerTo.Size = new System.Drawing.Size(200, 20);
            this.dtPickerTo.TabIndex = 3;
            // 
            // Range
            // 
            this.Range.AutoSize = true;
            this.Range.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Range.Location = new System.Drawing.Point(12, 77);
            this.Range.Name = "Range";
            this.Range.Size = new System.Drawing.Size(67, 20);
            this.Range.TabIndex = 2;
            this.Range.Text = "FilePath";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(652, 179);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "This soft deletes every sub-folder between date range.\r\nSub-folder name format mu" +
    "st be YYMMDD";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 249);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dtPickerTo);
            this.Controls.Add(this.dtPickerFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Range);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxFilePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxFilePath;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPickerFrom;
        private System.Windows.Forms.DateTimePicker dtPickerTo;
        private System.Windows.Forms.Label Range;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
    }
}

