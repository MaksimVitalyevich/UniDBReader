namespace UniDataReader
{
    partial class TimeoutForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Button_RetryConnection = new System.Windows.Forms.Button();
            this.TimeoutTimer = new System.Windows.Forms.Timer(this.components);
            this.TimedMark = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(606, 205);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Сбой работы Сервера. Соединение было потеряно! Попробуйте подключиться снова чере" +
    "з:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Button_RetryConnection
            // 
            this.Button_RetryConnection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_RetryConnection.Location = new System.Drawing.Point(164, 169);
            this.Button_RetryConnection.Name = "Button_RetryConnection";
            this.Button_RetryConnection.Size = new System.Drawing.Size(330, 39);
            this.Button_RetryConnection.TabIndex = 1;
            this.Button_RetryConnection.Text = "Попробовать переподключиться...";
            this.Button_RetryConnection.UseVisualStyleBackColor = true;
            this.Button_RetryConnection.Click += new System.EventHandler(this.Button_RetryConnection_Click);
            // 
            // TimeoutTimer
            // 
            this.TimeoutTimer.Tick += new System.EventHandler(this.TimeoutTimer_Tick);
            // 
            // TimedMark
            // 
            this.TimedMark.AutoSize = true;
            this.TimedMark.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimedMark.Location = new System.Drawing.Point(232, 110);
            this.TimedMark.Name = "TimedMark";
            this.TimedMark.Size = new System.Drawing.Size(0, 32);
            this.TimedMark.TabIndex = 2;
            // 
            // TimeoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 231);
            this.Controls.Add(this.TimedMark);
            this.Controls.Add(this.Button_RetryConnection);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimeoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проблема с подключением";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Button_RetryConnection;
        private System.Windows.Forms.Timer TimeoutTimer;
        private System.Windows.Forms.Label TimedMark;
    }
}