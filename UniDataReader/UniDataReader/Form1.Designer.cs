namespace UniDataReader
{
    partial class ProviderConnForm
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
            this.ProviderListBox = new System.Windows.Forms.ComboBox();
            this.ConnectionTextBox = new System.Windows.Forms.TextBox();
            this.Button_ConnectAsync = new System.Windows.Forms.Button();
            this.Button_Disconnect = new System.Windows.Forms.Button();
            this.Button_LoadAvailableProviders = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProviderLoadFailure = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProviderListBox
            // 
            this.ProviderListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProviderListBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProviderListBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProviderListBox.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ProviderListBox.FormattingEnabled = true;
            this.ProviderListBox.Location = new System.Drawing.Point(12, 86);
            this.ProviderListBox.MaxDropDownItems = 16;
            this.ProviderListBox.Name = "ProviderListBox";
            this.ProviderListBox.Size = new System.Drawing.Size(341, 45);
            this.ProviderListBox.TabIndex = 0;
            this.ProviderListBox.SelectedIndexChanged += new System.EventHandler(this.ProviderListBox_SelectedIndexChanged);
            // 
            // ConnectionTextBox
            // 
            this.ConnectionTextBox.AcceptsReturn = true;
            this.ConnectionTextBox.AcceptsTab = true;
            this.ConnectionTextBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnectionTextBox.Location = new System.Drawing.Point(12, 165);
            this.ConnectionTextBox.Multiline = true;
            this.ConnectionTextBox.Name = "ConnectionTextBox";
            this.ConnectionTextBox.ReadOnly = true;
            this.ConnectionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ConnectionTextBox.Size = new System.Drawing.Size(756, 77);
            this.ConnectionTextBox.TabIndex = 1;
            this.ConnectionTextBox.TextChanged += new System.EventHandler(this.ConnectionTextBox_TextChanged);
            // 
            // Button_ConnectAsync
            // 
            this.Button_ConnectAsync.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_ConnectAsync.Location = new System.Drawing.Point(575, 57);
            this.Button_ConnectAsync.Name = "Button_ConnectAsync";
            this.Button_ConnectAsync.Size = new System.Drawing.Size(175, 37);
            this.Button_ConnectAsync.TabIndex = 2;
            this.Button_ConnectAsync.Text = "Подключение";
            this.Button_ConnectAsync.UseVisualStyleBackColor = true;
            this.Button_ConnectAsync.Click += new System.EventHandler(this.Button_ConnectAsync_Click);
            // 
            // Button_Disconnect
            // 
            this.Button_Disconnect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Disconnect.Location = new System.Drawing.Point(6, 57);
            this.Button_Disconnect.Name = "Button_Disconnect";
            this.Button_Disconnect.Size = new System.Drawing.Size(165, 37);
            this.Button_Disconnect.TabIndex = 3;
            this.Button_Disconnect.Text = "Отсоединение";
            this.Button_Disconnect.UseVisualStyleBackColor = true;
            this.Button_Disconnect.Click += new System.EventHandler(this.Button_Disconnect_Click);
            // 
            // Button_LoadAvailableProviders
            // 
            this.Button_LoadAvailableProviders.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_LoadAvailableProviders.Location = new System.Drawing.Point(359, 86);
            this.Button_LoadAvailableProviders.Name = "Button_LoadAvailableProviders";
            this.Button_LoadAvailableProviders.Size = new System.Drawing.Size(409, 45);
            this.Button_LoadAvailableProviders.TabIndex = 4;
            this.Button_LoadAvailableProviders.Text = "Загрузить список доступных провайдеров";
            this.Button_LoadAvailableProviders.UseVisualStyleBackColor = true;
            this.Button_LoadAvailableProviders.Click += new System.EventHandler(this.Button_LoadAvailableProviders_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Доступные провайдеры подключения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Строка подключения:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Button_ConnectAsync);
            this.groupBox1.Controls.Add(this.Button_Disconnect);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Действия:";
            // 
            // ProviderLoadFailure
            // 
            this.ProviderLoadFailure.AutoSize = true;
            this.ProviderLoadFailure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProviderLoadFailure.Location = new System.Drawing.Point(14, 35);
            this.ProviderLoadFailure.Name = "ProviderLoadFailure";
            this.ProviderLoadFailure.Size = new System.Drawing.Size(597, 20);
            this.ProviderLoadFailure.TabIndex = 8;
            this.ProviderLoadFailure.Text = "*Чтобы выбрать тип провайдера, сначала загрузите всех доступных!";
            // 
            // ProviderConnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 357);
            this.Controls.Add(this.ProviderLoadFailure);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_LoadAvailableProviders);
            this.Controls.Add(this.ConnectionTextBox);
            this.Controls.Add(this.ProviderListBox);
            this.Name = "ProviderConnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подключение к типу провайдера";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProviderListBox;
        private System.Windows.Forms.TextBox ConnectionTextBox;
        private System.Windows.Forms.Button Button_ConnectAsync;
        private System.Windows.Forms.Button Button_Disconnect;
        private System.Windows.Forms.Button Button_LoadAvailableProviders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ProviderLoadFailure;
    }
}

