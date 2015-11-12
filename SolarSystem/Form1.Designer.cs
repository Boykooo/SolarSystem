namespace SolarSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.OrbitCheck = new System.Windows.Forms.CheckBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.SpeedText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(829, 803);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OrbitCheck
            // 
            this.OrbitCheck.AutoSize = true;
            this.OrbitCheck.Checked = true;
            this.OrbitCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OrbitCheck.Location = new System.Drawing.Point(839, 12);
            this.OrbitCheck.Name = "OrbitCheck";
            this.OrbitCheck.Size = new System.Drawing.Size(129, 17);
            this.OrbitCheck.TabIndex = 1;
            this.OrbitCheck.Text = "Показывать орбиты";
            this.OrbitCheck.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(839, 35);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(129, 26);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Запустить";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SpeedText
            // 
            this.SpeedText.Location = new System.Drawing.Point(923, 69);
            this.SpeedText.Name = "SpeedText";
            this.SpeedText.Size = new System.Drawing.Size(35, 20);
            this.SpeedText.TabIndex = 3;
            this.SpeedText.Text = "0,08";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(862, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Скорость";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 792);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpeedText);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.OrbitCheck);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Солнечная система";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox OrbitCheck;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox SpeedText;
        private System.Windows.Forms.Label label1;
    }
}

