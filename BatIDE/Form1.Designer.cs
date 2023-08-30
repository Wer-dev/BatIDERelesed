namespace BatIDE
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Create = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Label();
            this.CloseForms = new System.Windows.Forms.Label();
            this.HideForms = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.AutoSize = true;
            this.Create.Font = new System.Drawing.Font("Source Code Pro", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Create.Location = new System.Drawing.Point(71, 131);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(152, 46);
            this.Create.TabIndex = 0;
            this.Create.Text = "Create";
            this.Create.Click += new System.EventHandler(this.Create_Click);
            this.Create.MouseEnter += new System.EventHandler(this.Create_MouseEnter);
            this.Create.MouseLeave += new System.EventHandler(this.Create_MouseLeave);
            // 
            // Open
            // 
            this.Open.AutoSize = true;
            this.Open.Font = new System.Drawing.Font("Source Code Pro", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Open.Location = new System.Drawing.Point(88, 198);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(108, 46);
            this.Open.TabIndex = 1;
            this.Open.Text = "Open";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            this.Open.MouseEnter += new System.EventHandler(this.Open_MouseEnter);
            this.Open.MouseLeave += new System.EventHandler(this.Open_MouseLeave);
            // 
            // CloseForms
            // 
            this.CloseForms.AutoSize = true;
            this.CloseForms.Font = new System.Drawing.Font("Source Code Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseForms.Location = new System.Drawing.Point(259, 9);
            this.CloseForms.Name = "CloseForms";
            this.CloseForms.Size = new System.Drawing.Size(27, 29);
            this.CloseForms.TabIndex = 3;
            this.CloseForms.Text = "X";
            this.CloseForms.Click += new System.EventHandler(this.CloseForms_Click);
            this.CloseForms.MouseEnter += new System.EventHandler(this.CloseForms_MouseEnter_1);
            this.CloseForms.MouseLeave += new System.EventHandler(this.CloseForms_MouseLeave_1);
            // 
            // HideForms
            // 
            this.HideForms.AutoSize = true;
            this.HideForms.Font = new System.Drawing.Font("Source Code Pro", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HideForms.Location = new System.Drawing.Point(232, 9);
            this.HideForms.Name = "HideForms";
            this.HideForms.Size = new System.Drawing.Size(27, 29);
            this.HideForms.TabIndex = 4;
            this.HideForms.Text = "-";
            this.HideForms.Click += new System.EventHandler(this.HideForms_Click_1);
            this.HideForms.MouseEnter += new System.EventHandler(this.HideForms_MouseEnter_1);
            this.HideForms.MouseLeave += new System.EventHandler(this.HideForms_MouseLeave_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(292, 373);
            this.Controls.Add(this.HideForms);
            this.Controls.Add(this.CloseForms);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Create);
            this.Font = new System.Drawing.Font("Source Code Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BatIDE(Main)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Create;
        private System.Windows.Forms.Label Open;
        private System.Windows.Forms.Label CloseForms;
        private System.Windows.Forms.Label HideForms;
    }
}

