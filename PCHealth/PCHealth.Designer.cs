namespace PCHealth
{
    partial class PCHealth
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
            this.listBox_DriveInfo = new System.Windows.Forms.ListBox();
            this.checkedListBox_Drives = new System.Windows.Forms.CheckedListBox();
            this.button_getDrives = new System.Windows.Forms.Button();
            this.checkBox_askDrives = new System.Windows.Forms.CheckBox();
            this.label_wait = new System.Windows.Forms.Label();
            this.numericUpDown_wait = new System.Windows.Forms.NumericUpDown();
            this.label_Cspace = new System.Windows.Forms.Label();
            this.label_State = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_wait)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_DriveInfo
            // 
            this.listBox_DriveInfo.ItemHeight = 24;
            this.listBox_DriveInfo.Location = new System.Drawing.Point(137, 117);
            this.listBox_DriveInfo.Name = "listBox_DriveInfo";
            this.listBox_DriveInfo.Size = new System.Drawing.Size(432, 172);
            this.listBox_DriveInfo.TabIndex = 4;
            // 
            // checkedListBox_Drives
            // 
            this.checkedListBox_Drives.FormattingEnabled = true;
            this.checkedListBox_Drives.Location = new System.Drawing.Point(9, 117);
            this.checkedListBox_Drives.Name = "checkedListBox_Drives";
            this.checkedListBox_Drives.Size = new System.Drawing.Size(122, 196);
            this.checkedListBox_Drives.TabIndex = 6;
            this.checkedListBox_Drives.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_Drives_SelectedIndexChanged);
            // 
            // button_getDrives
            // 
            this.button_getDrives.Location = new System.Drawing.Point(12, 44);
            this.button_getDrives.Name = "button_getDrives";
            this.button_getDrives.Size = new System.Drawing.Size(119, 67);
            this.button_getDrives.TabIndex = 7;
            this.button_getDrives.Text = "Обновить";
            this.button_getDrives.UseVisualStyleBackColor = true;
            this.button_getDrives.Click += new System.EventHandler(this.button_getDrives_Click);
            // 
            // checkBox_askDrives
            // 
            this.checkBox_askDrives.AutoSize = true;
            this.checkBox_askDrives.Location = new System.Drawing.Point(9, 9);
            this.checkBox_askDrives.Name = "checkBox_askDrives";
            this.checkBox_askDrives.Size = new System.Drawing.Size(337, 29);
            this.checkBox_askDrives.TabIndex = 8;
            this.checkBox_askDrives.Text = "Опрашивать помеченные диски";
            this.checkBox_askDrives.UseVisualStyleBackColor = true;
            this.checkBox_askDrives.CheckedChanged += new System.EventHandler(this.checkBox_askDrives_CheckedChanged);
            // 
            // label_wait
            // 
            this.label_wait.AutoSize = true;
            this.label_wait.Location = new System.Drawing.Point(492, 9);
            this.label_wait.Name = "label_wait";
            this.label_wait.Size = new System.Drawing.Size(275, 25);
            this.label_wait.TabIndex = 10;
            this.label_wait.Text = "период опроса дисков, мсек";
            // 
            // numericUpDown_wait
            // 
            this.numericUpDown_wait.Location = new System.Drawing.Point(366, 9);
            this.numericUpDown_wait.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_wait.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_wait.Name = "numericUpDown_wait";
            this.numericUpDown_wait.Size = new System.Drawing.Size(120, 29);
            this.numericUpDown_wait.TabIndex = 11;
            this.numericUpDown_wait.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label_Cspace
            // 
            this.label_Cspace.AutoSize = true;
            this.label_Cspace.Location = new System.Drawing.Point(391, -36);
            this.label_Cspace.Name = "label_Cspace";
            this.label_Cspace.Size = new System.Drawing.Size(0, 25);
            this.label_Cspace.TabIndex = 12;
            // 
            // label_State
            // 
            this.label_State.AutoSize = true;
            this.label_State.Location = new System.Drawing.Point(12, 316);
            this.label_State.Name = "label_State";
            this.label_State.Size = new System.Drawing.Size(64, 25);
            this.label_State.TabIndex = 13;
            this.label_State.Text = "label1";
            // 
            // PCHealth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 1022);
            this.Controls.Add(this.label_State);
            this.Controls.Add(this.label_Cspace);
            this.Controls.Add(this.numericUpDown_wait);
            this.Controls.Add(this.label_wait);
            this.Controls.Add(this.checkBox_askDrives);
            this.Controls.Add(this.button_getDrives);
            this.Controls.Add(this.checkedListBox_Drives);
            this.Controls.Add(this.listBox_DriveInfo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PCHealth";
            this.Text = "Состояние ПК";
            this.Load += new System.EventHandler(this.PCHealth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_wait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_DriveInfo;
        private System.Windows.Forms.CheckedListBox checkedListBox_Drives;
        private System.Windows.Forms.Button button_getDrives;
        private System.Windows.Forms.CheckBox checkBox_askDrives;
        private System.Windows.Forms.Label label_wait;
        private System.Windows.Forms.NumericUpDown numericUpDown_wait;
        private System.Windows.Forms.Label label_Cspace;
        private System.Windows.Forms.Label label_State;
    }
}

