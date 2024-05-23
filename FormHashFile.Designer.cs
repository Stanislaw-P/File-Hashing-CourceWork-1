namespace File_Hashing
{
    partial class FormHashFile
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
            this.buttonClearOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSelectedFile = new System.Windows.Forms.TextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonStartHash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClearOpen
            // 
            this.buttonClearOpen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearOpen.Location = new System.Drawing.Point(826, 42);
            this.buttonClearOpen.Name = "buttonClearOpen";
            this.buttonClearOpen.Size = new System.Drawing.Size(115, 40);
            this.buttonClearOpen.TabIndex = 9;
            this.buttonClearOpen.Text = "Очистить";
            this.buttonClearOpen.UseVisualStyleBackColor = true;
            this.buttonClearOpen.Click += new System.EventHandler(this.buttonClearOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Открыть файл:";
            // 
            // textBoxSelectedFile
            // 
            this.textBoxSelectedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSelectedFile.Location = new System.Drawing.Point(207, 42);
            this.textBoxSelectedFile.Multiline = true;
            this.textBoxSelectedFile.Name = "textBoxSelectedFile";
            this.textBoxSelectedFile.Size = new System.Drawing.Size(492, 40);
            this.textBoxSelectedFile.TabIndex = 6;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen.Location = new System.Drawing.Point(705, 42);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(115, 40);
            this.buttonOpen.TabIndex = 7;
            this.buttonOpen.Text = "Обзор";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // buttonStartHash
            // 
            this.buttonStartHash.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartHash.Location = new System.Drawing.Point(705, 110);
            this.buttonStartHash.Name = "buttonStartHash";
            this.buttonStartHash.Size = new System.Drawing.Size(236, 40);
            this.buttonStartHash.TabIndex = 10;
            this.buttonStartHash.Text = "Получить хеш сумму файла";
            this.buttonStartHash.UseVisualStyleBackColor = true;
            this.buttonStartHash.Click += new System.EventHandler(this.buttonStartHash_Click);
            // 
            // FormHashFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 437);
            this.Controls.Add(this.buttonStartHash);
            this.Controls.Add(this.buttonClearOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSelectedFile);
            this.Controls.Add(this.buttonOpen);
            this.Name = "FormHashFile";
            this.Text = "Хеш сумма файла";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClearOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSelectedFile;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonStartHash;
    }
}