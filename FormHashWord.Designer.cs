namespace File_Hashing
{
    partial class FormHashWord
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
            this.textBoxGetWord = new System.Windows.Forms.TextBox();
            this.buttonClearWord = new System.Windows.Forms.Button();
            this.buttonStartHashWord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHashWord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxGetWord
            // 
            this.textBoxGetWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxGetWord.Location = new System.Drawing.Point(207, 42);
            this.textBoxGetWord.Multiline = true;
            this.textBoxGetWord.Name = "textBoxGetWord";
            this.textBoxGetWord.Size = new System.Drawing.Size(492, 40);
            this.textBoxGetWord.TabIndex = 0;
            // 
            // buttonClearWord
            // 
            this.buttonClearWord.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearWord.Location = new System.Drawing.Point(705, 42);
            this.buttonClearWord.Name = "buttonClearWord";
            this.buttonClearWord.Size = new System.Drawing.Size(115, 40);
            this.buttonClearWord.TabIndex = 2;
            this.buttonClearWord.Text = "Очистить";
            this.buttonClearWord.UseVisualStyleBackColor = true;
            this.buttonClearWord.Click += new System.EventHandler(this.buttonClearWord_Click);
            // 
            // buttonStartHashWord
            // 
            this.buttonStartHashWord.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartHashWord.Location = new System.Drawing.Point(705, 97);
            this.buttonStartHashWord.Name = "buttonStartHashWord";
            this.buttonStartHashWord.Size = new System.Drawing.Size(236, 40);
            this.buttonStartHashWord.TabIndex = 1;
            this.buttonStartHashWord.Text = "Хешировать слово";
            this.buttonStartHashWord.UseVisualStyleBackColor = true;
            this.buttonStartHashWord.Click += new System.EventHandler(this.buttonStartHashWord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Введите одно слово:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(98, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Результат:";
            // 
            // labelHashWord
            // 
            this.labelHashWord.AutoSize = true;
            this.labelHashWord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHashWord.Location = new System.Drawing.Point(202, 101);
            this.labelHashWord.Name = "labelHashWord";
            this.labelHashWord.Size = new System.Drawing.Size(0, 28);
            this.labelHashWord.TabIndex = 11;
            // 
            // FormHashWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 437);
            this.Controls.Add(this.labelHashWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStartHashWord);
            this.Controls.Add(this.buttonClearWord);
            this.Controls.Add(this.textBoxGetWord);
            this.Name = "FormHashWord";
            this.Text = "Хеширование слова";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGetWord;
        private System.Windows.Forms.Button buttonClearWord;
        private System.Windows.Forms.Button buttonStartHashWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHashWord;
    }
}