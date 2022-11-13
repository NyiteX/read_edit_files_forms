namespace WindowsFormsApp9
{
    partial class Basic_Window
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
            this.X_Button = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Minimize_Button = new System.Windows.Forms.Label();
            this.load_Button = new System.Windows.Forms.Button();
            this.edit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // X_Button
            // 
            this.X_Button.AutoSize = true;
            this.X_Button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.X_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.X_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.X_Button.Location = new System.Drawing.Point(783, 9);
            this.X_Button.Name = "X_Button";
            this.X_Button.Size = new System.Drawing.Size(23, 22);
            this.X_Button.TabIndex = 0;
            this.X_Button.Text = "X";
            this.X_Button.Click += new System.EventHandler(this.X_Button_Click);
            this.X_Button.MouseEnter += new System.EventHandler(this.X_Button_MouseEnter);
            this.X_Button.MouseLeave += new System.EventHandler(this.X_Button_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(12, 44);
            this.textBox1.MaxLength = 9999999;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(787, 273);
            this.textBox1.TabIndex = 1;
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.AutoSize = true;
            this.Minimize_Button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Minimize_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minimize_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Minimize_Button.Location = new System.Drawing.Point(754, 9);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.Size = new System.Drawing.Size(21, 22);
            this.Minimize_Button.TabIndex = 5;
            this.Minimize_Button.Text = "_";
            this.Minimize_Button.Click += new System.EventHandler(this.label1_Click);
            this.Minimize_Button.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.Minimize_Button.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // load_Button
            // 
            this.load_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.load_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.load_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_Button.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.load_Button.ForeColor = System.Drawing.Color.DimGray;
            this.load_Button.Location = new System.Drawing.Point(102, 367);
            this.load_Button.Name = "load_Button";
            this.load_Button.Size = new System.Drawing.Size(214, 66);
            this.load_Button.TabIndex = 6;
            this.load_Button.Text = "Загрузить";
            this.load_Button.UseVisualStyleBackColor = true;
            this.load_Button.Click += new System.EventHandler(this.load_Button_Click);
            // 
            // edit_Button
            // 
            this.edit_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.edit_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_Button.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_Button.ForeColor = System.Drawing.Color.DimGray;
            this.edit_Button.Location = new System.Drawing.Point(483, 367);
            this.edit_Button.Name = "edit_Button";
            this.edit_Button.Size = new System.Drawing.Size(214, 66);
            this.edit_Button.TabIndex = 7;
            this.edit_Button.Text = "Редактировать";
            this.edit_Button.UseVisualStyleBackColor = true;
            this.edit_Button.Click += new System.EventHandler(this.edit_Button_Click);
            // 
            // Basic_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp9.Properties.Resources._016;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 479);
            this.Controls.Add(this.edit_Button);
            this.Controls.Add(this.load_Button);
            this.Controls.Add(this.Minimize_Button);
            this.Controls.Add(this.X_Button);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Basic_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic_Window";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Basic_Window_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Basic_Window_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label X_Button;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Minimize_Button;
        private System.Windows.Forms.Button load_Button;
        private System.Windows.Forms.Button edit_Button;
    }
}

