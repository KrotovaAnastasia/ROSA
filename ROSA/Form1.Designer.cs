namespace ROSA
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
            this.buttonHelp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNameUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRequest = new System.Windows.Forms.Button();
            this.numericUpDownCountCertificate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxReason = new System.Windows.Forms.TextBox();
            this.listBoxNameCertificate = new System.Windows.Forms.ListBox();
            this.textBoxNameCertificate = new System.Windows.Forms.TextBox();
            this.groupBoxEmployee = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonOpenTable = new System.Windows.Forms.Button();
            this.tableEmployee = new System.Windows.Forms.DataGridView();
            this.radioButtonEmployee = new System.Windows.Forms.RadioButton();
            this.radioButtonAccountant = new System.Windows.Forms.RadioButton();
            this.buttonUpdateDate = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Certificate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountCertificate)).BeginInit();
            this.groupBoxEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(936, 9);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Род деятельности";
            // 
            // textBoxNameUser
            // 
            this.textBoxNameUser.Location = new System.Drawing.Point(6, 50);
            this.textBoxNameUser.Name = "textBoxNameUser";
            this.textBoxNameUser.Size = new System.Drawing.Size(198, 22);
            this.textBoxNameUser.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя работника";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Запрвшиваемая спавка";
            // 
            // buttonRequest
            // 
            this.buttonRequest.Location = new System.Drawing.Point(72, 361);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(155, 33);
            this.buttonRequest.TabIndex = 9;
            this.buttonRequest.Text = "Отправить";
            this.buttonRequest.UseVisualStyleBackColor = true;
            this.buttonRequest.Click += new System.EventHandler(this.ButtonRequest_Click);
            // 
            // numericUpDownCountCertificate
            // 
            this.numericUpDownCountCertificate.Location = new System.Drawing.Point(6, 238);
            this.numericUpDownCountCertificate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCountCertificate.Name = "numericUpDownCountCertificate";
            this.numericUpDownCountCertificate.Size = new System.Drawing.Size(62, 22);
            this.numericUpDownCountCertificate.TabIndex = 13;
            this.numericUpDownCountCertificate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Количество экземпляров";
            // 
            // textBoxReason
            // 
            this.textBoxReason.Location = new System.Drawing.Point(6, 295);
            this.textBoxReason.Name = "textBoxReason";
            this.textBoxReason.Size = new System.Drawing.Size(285, 22);
            this.textBoxReason.TabIndex = 15;
            // 
            // listBoxNameCertificate
            // 
            this.listBoxNameCertificate.FormattingEnabled = true;
            this.listBoxNameCertificate.ItemHeight = 16;
            this.listBoxNameCertificate.Items.AddRange(new object[] {
            "2-НДФЛ",
            "Место работы",
            "Средний заработок",
            "Другое"});
            this.listBoxNameCertificate.Location = new System.Drawing.Point(6, 105);
            this.listBoxNameCertificate.Name = "listBoxNameCertificate";
            this.listBoxNameCertificate.Size = new System.Drawing.Size(198, 84);
            this.listBoxNameCertificate.TabIndex = 16;
            this.listBoxNameCertificate.SelectedIndexChanged += new System.EventHandler(this.ListBoxNameCertificate_SelectedIndexChanged);
            // 
            // textBoxNameCertificate
            // 
            this.textBoxNameCertificate.Enabled = false;
            this.textBoxNameCertificate.Location = new System.Drawing.Point(6, 195);
            this.textBoxNameCertificate.Name = "textBoxNameCertificate";
            this.textBoxNameCertificate.Size = new System.Drawing.Size(198, 22);
            this.textBoxNameCertificate.TabIndex = 17;
            this.textBoxNameCertificate.Text = "Другое";
            // 
            // groupBoxEmployee
            // 
            this.groupBoxEmployee.Controls.Add(this.label5);
            this.groupBoxEmployee.Controls.Add(this.buttonOpenTable);
            this.groupBoxEmployee.Controls.Add(this.textBoxNameUser);
            this.groupBoxEmployee.Controls.Add(this.textBoxNameCertificate);
            this.groupBoxEmployee.Controls.Add(this.label2);
            this.groupBoxEmployee.Controls.Add(this.listBoxNameCertificate);
            this.groupBoxEmployee.Controls.Add(this.label3);
            this.groupBoxEmployee.Controls.Add(this.textBoxReason);
            this.groupBoxEmployee.Controls.Add(this.buttonRequest);
            this.groupBoxEmployee.Controls.Add(this.label4);
            this.groupBoxEmployee.Controls.Add(this.numericUpDownCountCertificate);
            this.groupBoxEmployee.Location = new System.Drawing.Point(12, 99);
            this.groupBoxEmployee.Name = "groupBoxEmployee";
            this.groupBoxEmployee.Size = new System.Drawing.Size(297, 409);
            this.groupBoxEmployee.TabIndex = 18;
            this.groupBoxEmployee.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Причина запроса";
            // 
            // buttonOpenTable
            // 
            this.buttonOpenTable.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonOpenTable.Location = new System.Drawing.Point(210, 40);
            this.buttonOpenTable.Name = "buttonOpenTable";
            this.buttonOpenTable.Size = new System.Drawing.Size(81, 42);
            this.buttonOpenTable.TabIndex = 18;
            this.buttonOpenTable.Text = "Смотреть \r\nзапросы";
            this.buttonOpenTable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOpenTable.UseVisualStyleBackColor = true;
            this.buttonOpenTable.Click += new System.EventHandler(this.ButtonOpenTable_Click);
            // 
            // tableEmployee
            // 
            this.tableEmployee.AllowUserToAddRows = false;
            this.tableEmployee.AllowUserToDeleteRows = false;
            this.tableEmployee.AllowUserToOrderColumns = true;
            this.tableEmployee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Certificate,
            this.Quantity,
            this.Reason,
            this.Status});
            this.tableEmployee.Location = new System.Drawing.Point(315, 69);
            this.tableEmployee.Name = "tableEmployee";
            this.tableEmployee.RowHeadersWidth = 51;
            this.tableEmployee.RowTemplate.Height = 24;
            this.tableEmployee.Size = new System.Drawing.Size(799, 424);
            this.tableEmployee.TabIndex = 19;
            // 
            // radioButtonEmployee
            // 
            this.radioButtonEmployee.AutoSize = true;
            this.radioButtonEmployee.Location = new System.Drawing.Point(15, 56);
            this.radioButtonEmployee.Name = "radioButtonEmployee";
            this.radioButtonEmployee.Size = new System.Drawing.Size(91, 20);
            this.radioButtonEmployee.TabIndex = 20;
            this.radioButtonEmployee.TabStop = true;
            this.radioButtonEmployee.Text = "Работник";
            this.radioButtonEmployee.UseVisualStyleBackColor = true;
            this.radioButtonEmployee.Click += new System.EventHandler(this.RadioButtonEmployee_Click);
            // 
            // radioButtonAccountant
            // 
            this.radioButtonAccountant.AutoSize = true;
            this.radioButtonAccountant.Location = new System.Drawing.Point(130, 56);
            this.radioButtonAccountant.Name = "radioButtonAccountant";
            this.radioButtonAccountant.Size = new System.Drawing.Size(96, 20);
            this.radioButtonAccountant.TabIndex = 21;
            this.radioButtonAccountant.TabStop = true;
            this.radioButtonAccountant.Text = "Бухгалтер";
            this.radioButtonAccountant.UseVisualStyleBackColor = true;
            this.radioButtonAccountant.Click += new System.EventHandler(this.RadioButtonAccountant_Click);
            // 
            // buttonUpdateDate
            // 
            this.buttonUpdateDate.Location = new System.Drawing.Point(70, 82);
            this.buttonUpdateDate.Name = "buttonUpdateDate";
            this.buttonUpdateDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonUpdateDate.Size = new System.Drawing.Size(169, 23);
            this.buttonUpdateDate.TabIndex = 20;
            this.buttonUpdateDate.Text = "Сохранить изменения";
            this.buttonUpdateDate.UseVisualStyleBackColor = true;
            this.buttonUpdateDate.Visible = false;
            this.buttonUpdateDate.Click += new System.EventHandler(this.ButtonUpdateDate_Click);
            // 
            // UserName
            // 
            this.UserName.HeaderText = "ФИО";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.Width = 125;
            // 
            // Certificate
            // 
            this.Certificate.HeaderText = "Вид справки";
            this.Certificate.MinimumWidth = 6;
            this.Certificate.Name = "Certificate";
            this.Certificate.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Колличество";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Reason
            // 
            this.Reason.HeaderText = "Причина";
            this.Reason.MinimumWidth = 6;
            this.Reason.Name = "Reason";
            this.Reason.Width = 125;
            // 
            // Status
            // 
            this.Status.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Status.HeaderText = "Статус";
            this.Status.Items.AddRange(new object[] {
            "Создан",
            "В работе",
            "Готов",
            "Закрыт"});
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 557);
            this.Controls.Add(this.buttonUpdateDate);
            this.Controls.Add(this.radioButtonAccountant);
            this.Controls.Add(this.radioButtonEmployee);
            this.Controls.Add(this.tableEmployee);
            this.Controls.Add(this.groupBoxEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonHelp);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountCertificate)).EndInit();
            this.groupBoxEmployee.ResumeLayout(false);
            this.groupBoxEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNameUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRequest;
        private System.Windows.Forms.NumericUpDown numericUpDownCountCertificate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxReason;
        private System.Windows.Forms.ListBox listBoxNameCertificate;
        private System.Windows.Forms.TextBox textBoxNameCertificate;
        private System.Windows.Forms.GroupBox groupBoxEmployee;
        private System.Windows.Forms.DataGridView tableEmployee;
        private System.Windows.Forms.Button buttonOpenTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonEmployee;
        private System.Windows.Forms.RadioButton radioButtonAccountant;
        private System.Windows.Forms.Button buttonUpdateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Certificate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewComboBoxColumn Status;
    }
}

