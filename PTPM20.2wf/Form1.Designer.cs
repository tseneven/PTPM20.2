namespace PTPM20._2wf
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SanatoriumRadioButton = new RadioButton();
            Tourist_VoucherRadioButton = new RadioButton();
            NameTextBox = new TextBox();
            DurationTextBox = new TextBox();
            PriceTextBox = new TextBox();
            RouteCategoryTextBox = new TextBox();
            AvailabilityOfExcursionsСomboBox = new ComboBox();
            CertificateTextBox = new TextBox();
            NameLabel = new Label();
            DurationLabel = new Label();
            PriceLabel = new Label();
            AvailabilityOfExcursionsLabel3 = new Label();
            RouteCategoryLabel = new Label();
            CertificateLabel = new Label();
            DiseaseLabel = new Label();
            DiseaseTextBox = new TextBox();
            SaveSanatoriumButton = new Button();
            SaveTuristButton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SanatoriumRadioButton
            // 
            SanatoriumRadioButton.AutoSize = true;
            SanatoriumRadioButton.Location = new Point(12, 322);
            SanatoriumRadioButton.Name = "SanatoriumRadioButton";
            SanatoriumRadioButton.Size = new Size(85, 19);
            SanatoriumRadioButton.TabIndex = 0;
            SanatoriumRadioButton.TabStop = true;
            SanatoriumRadioButton.Text = "Санаторий";
            SanatoriumRadioButton.UseVisualStyleBackColor = true;
            SanatoriumRadioButton.CheckedChanged += SanatoriumRadioButton_CheckedChanged;
            // 
            // Tourist_VoucherRadioButton
            // 
            Tourist_VoucherRadioButton.AutoSize = true;
            Tourist_VoucherRadioButton.Location = new Point(12, 347);
            Tourist_VoucherRadioButton.Name = "Tourist_VoucherRadioButton";
            Tourist_VoucherRadioButton.Size = new Size(152, 19);
            Tourist_VoucherRadioButton.TabIndex = 1;
            Tourist_VoucherRadioButton.TabStop = true;
            Tourist_VoucherRadioButton.Text = "Туристическая путевка";
            Tourist_VoucherRadioButton.UseVisualStyleBackColor = true;
            Tourist_VoucherRadioButton.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(12, 44);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(196, 23);
            NameTextBox.TabIndex = 2;
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(12, 92);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(196, 23);
            DurationTextBox.TabIndex = 3;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(12, 136);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(196, 23);
            PriceTextBox.TabIndex = 4;
            // 
            // RouteCategoryTextBox
            // 
            RouteCategoryTextBox.Location = new Point(12, 226);
            RouteCategoryTextBox.Name = "RouteCategoryTextBox";
            RouteCategoryTextBox.Size = new Size(196, 23);
            RouteCategoryTextBox.TabIndex = 5;
            RouteCategoryTextBox.Visible = false;
            // 
            // AvailabilityOfExcursionsСomboBox
            // 
            AvailabilityOfExcursionsСomboBox.FormattingEnabled = true;
            AvailabilityOfExcursionsСomboBox.Items.AddRange(new object[] { "Да", "Нет" });
            AvailabilityOfExcursionsСomboBox.Location = new Point(12, 180);
            AvailabilityOfExcursionsСomboBox.Name = "AvailabilityOfExcursionsСomboBox";
            AvailabilityOfExcursionsСomboBox.Size = new Size(196, 23);
            AvailabilityOfExcursionsСomboBox.TabIndex = 6;
            // 
            // CertificateTextBox
            // 
            CertificateTextBox.Location = new Point(12, 269);
            CertificateTextBox.Name = "CertificateTextBox";
            CertificateTextBox.Size = new Size(196, 23);
            CertificateTextBox.TabIndex = 7;
            CertificateTextBox.Visible = false;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameLabel.Location = new Point(12, 26);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(63, 15);
            NameLabel.TabIndex = 8;
            NameLabel.Text = "Название";
            // 
            // DurationLabel
            // 
            DurationLabel.AutoSize = true;
            DurationLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DurationLabel.Location = new Point(12, 74);
            DurationLabel.Name = "DurationLabel";
            DurationLabel.Size = new Size(230, 15);
            DurationLabel.TabIndex = 9;
            DurationLabel.Text = "Продолжительность (От 1 до 14 суток)";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PriceLabel.Location = new Point(12, 118);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(37, 15);
            PriceLabel.TabIndex = 10;
            PriceLabel.Text = "Цена";
            // 
            // AvailabilityOfExcursionsLabel3
            // 
            AvailabilityOfExcursionsLabel3.AutoSize = true;
            AvailabilityOfExcursionsLabel3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AvailabilityOfExcursionsLabel3.Location = new Point(12, 162);
            AvailabilityOfExcursionsLabel3.Name = "AvailabilityOfExcursionsLabel3";
            AvailabilityOfExcursionsLabel3.Size = new Size(116, 15);
            AvailabilityOfExcursionsLabel3.TabIndex = 11;
            AvailabilityOfExcursionsLabel3.Text = "Наличие эксурсии";
            // 
            // RouteCategoryLabel
            // 
            RouteCategoryLabel.AutoSize = true;
            RouteCategoryLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RouteCategoryLabel.Location = new Point(12, 208);
            RouteCategoryLabel.Name = "RouteCategoryLabel";
            RouteCategoryLabel.Size = new Size(126, 15);
            RouteCategoryLabel.TabIndex = 12;
            RouteCategoryLabel.Text = "Категория маршрута";
            RouteCategoryLabel.Visible = false;
            // 
            // CertificateLabel
            // 
            CertificateLabel.AutoSize = true;
            CertificateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CertificateLabel.Location = new Point(12, 252);
            CertificateLabel.Name = "CertificateLabel";
            CertificateLabel.Size = new Size(154, 15);
            CertificateLabel.TabIndex = 13;
            CertificateLabel.Text = "Наличие сравки от врача";
            CertificateLabel.Visible = false;
            // 
            // DiseaseLabel
            // 
            DiseaseLabel.AutoSize = true;
            DiseaseLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiseaseLabel.Location = new Point(12, 208);
            DiseaseLabel.Name = "DiseaseLabel";
            DiseaseLabel.Size = new Size(83, 15);
            DiseaseLabel.TabIndex = 15;
            DiseaseLabel.Text = "Заболевание";
            DiseaseLabel.Visible = false;
            // 
            // DiseaseTextBox
            // 
            DiseaseTextBox.Location = new Point(12, 226);
            DiseaseTextBox.Name = "DiseaseTextBox";
            DiseaseTextBox.Size = new Size(196, 23);
            DiseaseTextBox.TabIndex = 14;
            DiseaseTextBox.Visible = false;
            // 
            // SaveSanatoriumButton
            // 
            SaveSanatoriumButton.Location = new Point(12, 385);
            SaveSanatoriumButton.Name = "SaveSanatoriumButton";
            SaveSanatoriumButton.Size = new Size(173, 53);
            SaveSanatoriumButton.TabIndex = 16;
            SaveSanatoriumButton.Text = "Сохранить";
            SaveSanatoriumButton.UseVisualStyleBackColor = true;
            SaveSanatoriumButton.Visible = false;
            SaveSanatoriumButton.Click += SaveSanatoriumButton_Click;
            // 
            // SaveTuristButton
            // 
            SaveTuristButton.Location = new Point(12, 385);
            SaveTuristButton.Name = "SaveTuristButton";
            SaveTuristButton.Size = new Size(173, 53);
            SaveTuristButton.TabIndex = 17;
            SaveTuristButton.Text = "Сохранить";
            SaveTuristButton.UseVisualStyleBackColor = true;
            SaveTuristButton.Visible = false;
            SaveTuristButton.Click += SaveTuristButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(330, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(831, 426);
            dataGridView1.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 450);
            Controls.Add(dataGridView1);
            Controls.Add(SaveTuristButton);
            Controls.Add(SaveSanatoriumButton);
            Controls.Add(DiseaseLabel);
            Controls.Add(DiseaseTextBox);
            Controls.Add(CertificateLabel);
            Controls.Add(RouteCategoryLabel);
            Controls.Add(AvailabilityOfExcursionsLabel3);
            Controls.Add(PriceLabel);
            Controls.Add(DurationLabel);
            Controls.Add(NameLabel);
            Controls.Add(CertificateTextBox);
            Controls.Add(AvailabilityOfExcursionsСomboBox);
            Controls.Add(RouteCategoryTextBox);
            Controls.Add(PriceTextBox);
            Controls.Add(DurationTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(Tourist_VoucherRadioButton);
            Controls.Add(SanatoriumRadioButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton SanatoriumRadioButton;
        private RadioButton Tourist_VoucherRadioButton;
        private TextBox NameTextBox;
        private TextBox DurationTextBox;
        private TextBox PriceTextBox;
        private TextBox RouteCategoryTextBox;
        private ComboBox AvailabilityOfExcursionsСomboBox;
        private TextBox CertificateTextBox;
        private Label NameLabel;
        private Label DurationLabel;
        private Label PriceLabel;
        private Label AvailabilityOfExcursionsLabel3;
        private Label RouteCategoryLabel;
        private Label CertificateLabel;
        private Label DiseaseLabel;
        private TextBox DiseaseTextBox;
        private Button SaveSanatoriumButton;
        private Button SaveTuristButton;
        private DataGridView dataGridView1;
    }
}
