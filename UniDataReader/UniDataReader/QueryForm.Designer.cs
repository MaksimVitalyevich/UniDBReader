namespace UniDataReader
{
    partial class QueryForm
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
            this.TabMain = new System.Windows.Forms.TabControl();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.Button_ShowTable = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ConnectionTextBox = new System.Windows.Forms.TextBox();
            this.Button_ExecuteNonQuery = new System.Windows.Forms.Button();
            this.MultiQueryBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataTablePage = new System.Windows.Forms.TabPage();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.AdditivePage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.TabMain.SuspendLayout();
            this.MainPage.SuspendLayout();
            this.DataTablePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.AdditivePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabMain
            // 
            this.TabMain.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.TabMain.Controls.Add(this.MainPage);
            this.TabMain.Controls.Add(this.DataTablePage);
            this.TabMain.Controls.Add(this.AdditivePage);
            this.TabMain.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabMain.Location = new System.Drawing.Point(12, 12);
            this.TabMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabMain.Multiline = true;
            this.TabMain.Name = "TabMain";
            this.TabMain.SelectedIndex = 0;
            this.TabMain.Size = new System.Drawing.Size(776, 426);
            this.TabMain.TabIndex = 0;
            // 
            // MainPage
            // 
            this.MainPage.Controls.Add(this.Button_ShowTable);
            this.MainPage.Controls.Add(this.label3);
            this.MainPage.Controls.Add(this.ConnectionTextBox);
            this.MainPage.Controls.Add(this.Button_ExecuteNonQuery);
            this.MainPage.Controls.Add(this.MultiQueryBox);
            this.MainPage.Controls.Add(this.label1);
            this.MainPage.Location = new System.Drawing.Point(4, 29);
            this.MainPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPage.Size = new System.Drawing.Size(768, 393);
            this.MainPage.TabIndex = 0;
            this.MainPage.Text = "Основное Окно";
            this.MainPage.UseVisualStyleBackColor = true;
            // 
            // Button_ShowTable
            // 
            this.Button_ShowTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_ShowTable.Location = new System.Drawing.Point(7, 343);
            this.Button_ShowTable.Margin = new System.Windows.Forms.Padding(4);
            this.Button_ShowTable.Name = "Button_ShowTable";
            this.Button_ShowTable.Size = new System.Drawing.Size(264, 41);
            this.Button_ShowTable.TabIndex = 5;
            this.Button_ShowTable.Text = "Показать Результат";
            this.Button_ShowTable.UseVisualStyleBackColor = true;
            this.Button_ShowTable.Click += new System.EventHandler(this.Button_ShowTable_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(107, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(563, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Строка подключения (из уже настроенного списка провайдеров):";
            // 
            // ConnectionTextBox
            // 
            this.ConnectionTextBox.AcceptsReturn = true;
            this.ConnectionTextBox.AcceptsTab = true;
            this.ConnectionTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnectionTextBox.Location = new System.Drawing.Point(5, 34);
            this.ConnectionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConnectionTextBox.Multiline = true;
            this.ConnectionTextBox.Name = "ConnectionTextBox";
            this.ConnectionTextBox.ReadOnly = true;
            this.ConnectionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ConnectionTextBox.Size = new System.Drawing.Size(754, 46);
            this.ConnectionTextBox.TabIndex = 3;
            // 
            // Button_ExecuteNonQuery
            // 
            this.Button_ExecuteNonQuery.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_ExecuteNonQuery.Location = new System.Drawing.Point(409, 343);
            this.Button_ExecuteNonQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_ExecuteNonQuery.Name = "Button_ExecuteNonQuery";
            this.Button_ExecuteNonQuery.Size = new System.Drawing.Size(352, 44);
            this.Button_ExecuteNonQuery.TabIndex = 2;
            this.Button_ExecuteNonQuery.Text = "Выполнить запрос/транзакцию";
            this.Button_ExecuteNonQuery.UseVisualStyleBackColor = true;
            this.Button_ExecuteNonQuery.Click += new System.EventHandler(this.Button_ExecuteNonQueryAsync_Click);
            // 
            // MultiQueryBox
            // 
            this.MultiQueryBox.AcceptsReturn = true;
            this.MultiQueryBox.AcceptsTab = true;
            this.MultiQueryBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultiQueryBox.Location = new System.Drawing.Point(3, 110);
            this.MultiQueryBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MultiQueryBox.Multiline = true;
            this.MultiQueryBox.Name = "MultiQueryBox";
            this.MultiQueryBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MultiQueryBox.Size = new System.Drawing.Size(756, 228);
            this.MultiQueryBox.TabIndex = 1;
            this.MultiQueryBox.TextChanged += new System.EventHandler(this.MultiQueryBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(292, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поле для запросов:";
            // 
            // DataTablePage
            // 
            this.DataTablePage.Controls.Add(this.DataGridView);
            this.DataTablePage.Location = new System.Drawing.Point(4, 29);
            this.DataTablePage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataTablePage.Name = "DataTablePage";
            this.DataTablePage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataTablePage.Size = new System.Drawing.Size(768, 393);
            this.DataTablePage.TabIndex = 1;
            this.DataTablePage.Text = "Окно таблицы данных";
            this.DataTablePage.UseVisualStyleBackColor = true;
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(3, 2);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(762, 389);
            this.DataGridView.TabIndex = 0;
            // 
            // AdditivePage
            // 
            this.AdditivePage.Controls.Add(this.label2);
            this.AdditivePage.Location = new System.Drawing.Point(4, 29);
            this.AdditivePage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdditivePage.Name = "AdditivePage";
            this.AdditivePage.Size = new System.Drawing.Size(768, 393);
            this.AdditivePage.TabIndex = 2;
            this.AdditivePage.Text = "Дополнительное Окно";
            this.AdditivePage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(53, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(633, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "*Здесь можно добавить расширенный функционал для формы запросов!";
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 444);
            this.Controls.Add(this.TabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QueryForm";
            this.Text = "Форма для работы с запросами";
            this.TabMain.ResumeLayout(false);
            this.MainPage.ResumeLayout(false);
            this.MainPage.PerformLayout();
            this.DataTablePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.AdditivePage.ResumeLayout(false);
            this.AdditivePage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabMain;
        private System.Windows.Forms.TabPage MainPage;
        private System.Windows.Forms.TabPage DataTablePage;
        private System.Windows.Forms.TextBox MultiQueryBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_ExecuteNonQuery;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TabPage AdditivePage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ConnectionTextBox;
        private System.Windows.Forms.Button Button_ShowTable;
    }
}