namespace File_Hashing
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpen = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonStartHash = new System.Windows.Forms.Button();
            this.textBoxSelectedFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClearOpen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSavePath = new System.Windows.Forms.TextBox();
            this.buttonClearSave = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHashSumFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHashWord = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen.Location = new System.Drawing.Point(705, 42);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(115, 40);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Обзор";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = ".txt";
            // 
            // buttonStartHash
            // 
            this.buttonStartHash.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonStartHash.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartHash.Location = new System.Drawing.Point(705, 198);
            this.buttonStartHash.Name = "buttonStartHash";
            this.buttonStartHash.Size = new System.Drawing.Size(236, 40);
            this.buttonStartHash.TabIndex = 4;
            this.buttonStartHash.Text = "Хешировать файл";
            this.buttonStartHash.UseVisualStyleBackColor = false;
            this.buttonStartHash.Click += new System.EventHandler(this.buttonStartHash_Click);
            // 
            // textBoxSelectedFile
            // 
            this.textBoxSelectedFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSelectedFile.Location = new System.Drawing.Point(207, 42);
            this.textBoxSelectedFile.Multiline = true;
            this.textBoxSelectedFile.Name = "textBoxSelectedFile";
            this.textBoxSelectedFile.Size = new System.Drawing.Size(492, 40);
            this.textBoxSelectedFile.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Открыть файл:";
            // 
            // buttonClearOpen
            // 
            this.buttonClearOpen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearOpen.Location = new System.Drawing.Point(826, 42);
            this.buttonClearOpen.Name = "buttonClearOpen";
            this.buttonClearOpen.Size = new System.Drawing.Size(115, 40);
            this.buttonClearOpen.TabIndex = 5;
            this.buttonClearOpen.Text = "Очистить";
            this.buttonClearOpen.UseVisualStyleBackColor = true;
            this.buttonClearOpen.Click += new System.EventHandler(this.buttonClearOpen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(60, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Сохранить в:";
            // 
            // textBoxSavePath
            // 
            this.textBoxSavePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSavePath.Location = new System.Drawing.Point(207, 120);
            this.textBoxSavePath.Multiline = true;
            this.textBoxSavePath.Name = "textBoxSavePath";
            this.textBoxSavePath.Size = new System.Drawing.Size(492, 40);
            this.textBoxSavePath.TabIndex = 2;
            // 
            // buttonClearSave
            // 
            this.buttonClearSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearSave.Location = new System.Drawing.Point(826, 120);
            this.buttonClearSave.Name = "buttonClearSave";
            this.buttonClearSave.Size = new System.Drawing.Size(115, 40);
            this.buttonClearSave.TabIndex = 6;
            this.buttonClearSave.Text = "Очистить";
            this.buttonClearSave.UseVisualStyleBackColor = true;
            this.buttonClearSave.Click += new System.EventHandler(this.buttonClearSave_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(705, 120);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(115, 40);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Обзор";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.CreatePrompt = true;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemHashSumFile,
            this.toolStripMenuItemHashWord,
            this.toolStripMenuItemTest});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(134, 25);
            this.toolStripMenuItem1.Text = "Дополнительно";
            // 
            // toolStripMenuItemHashSumFile
            // 
            this.toolStripMenuItemHashSumFile.Name = "toolStripMenuItemHashSumFile";
            this.toolStripMenuItemHashSumFile.Size = new System.Drawing.Size(237, 26);
            this.toolStripMenuItemHashSumFile.Text = "Хеш сумма файла";
            this.toolStripMenuItemHashSumFile.Click += new System.EventHandler(this.toolStripMenuItemHashSumFile_Click);
            // 
            // toolStripMenuItemHashWord
            // 
            this.toolStripMenuItemHashWord.Name = "toolStripMenuItemHashWord";
            this.toolStripMenuItemHashWord.Size = new System.Drawing.Size(237, 26);
            this.toolStripMenuItemHashWord.Text = "Захешировать слово";
            this.toolStripMenuItemHashWord.Click += new System.EventHandler(this.toolStripMenuItemHashWord_Click);
            // 
            // toolStripMenuItemTest
            // 
            this.toolStripMenuItemTest.Name = "toolStripMenuItemTest";
            this.toolStripMenuItemTest.Size = new System.Drawing.Size(237, 26);
            this.toolStripMenuItemTest.Text = "Тесты";
            this.toolStripMenuItemTest.Click += new System.EventHandler(this.toolStripMenuItemTest_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1053, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // buttonInfo
            // 
            this.buttonInfo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo.Location = new System.Drawing.Point(12, 395);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(127, 30);
            this.buttonInfo.TabIndex = 8;
            this.buttonInfo.Text = "Информация";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 437);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonClearSave);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSavePath);
            this.Controls.Add(this.buttonClearOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSelectedFile);
            this.Controls.Add(this.buttonStartHash);
            this.Controls.Add(this.buttonOpen);
            this.Name = "FormMain";
            this.Text = "Хеширование файла";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonStartHash;
        private System.Windows.Forms.TextBox textBoxSelectedFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClearOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSavePath;
        private System.Windows.Forms.Button buttonClearSave;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHashSumFile;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHashWord;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTest;
        private System.Windows.Forms.Button buttonInfo;
    }
}

