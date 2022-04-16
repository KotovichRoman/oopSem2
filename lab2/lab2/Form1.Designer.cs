
namespace lab2
{
    partial class Flats
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
            this.squareFootageBox = new System.Windows.Forms.TextBox();
            this.squareLabel = new System.Windows.Forms.Label();
            this.roomsCountLabel = new System.Windows.Forms.Label();
            this.roomsCount = new System.Windows.Forms.NumericUpDown();
            this.flatLabel = new System.Windows.Forms.Label();
            this.addresLabel = new System.Windows.Forms.Label();
            this.roomLabel = new System.Windows.Forms.Label();
            this.houseLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.streetBox = new System.Windows.Forms.TextBox();
            this.districtLabel = new System.Windows.Forms.Label();
            this.districtBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.flatNumberLabel = new System.Windows.Forms.Label();
            this.houseNumber = new System.Windows.Forms.NumericUpDown();
            this.flatNumber = new System.Windows.Forms.NumericUpDown();
            this.BuildDateLabel = new System.Windows.Forms.Label();
            this.roomsGroupBox = new System.Windows.Forms.GroupBox();
            this.balconyCheckBox = new System.Windows.Forms.CheckBox();
            this.basementCheckBox = new System.Windows.Forms.CheckBox();
            this.toiletCheckBox = new System.Windows.Forms.CheckBox();
            this.bathCheckBox = new System.Windows.Forms.CheckBox();
            this.kitchenCheckBox = new System.Windows.Forms.CheckBox();
            this.buildDate = new System.Windows.Forms.DateTimePicker();
            this.infoTableAboutFlat = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.squareFootageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ванна = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Туалет = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Балкон = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serializableButton = new System.Windows.Forms.Button();
            this.deserializableButton = new System.Windows.Forms.Button();
            this.countryBox = new System.Windows.Forms.ComboBox();
            this.infoAboutRooms = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.squareColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windowValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceLabel = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.roomsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatNumber)).BeginInit();
            this.roomsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoTableAboutFlat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoAboutRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // squareFootageBox
            // 
            this.squareFootageBox.Location = new System.Drawing.Point(39, 74);
            this.squareFootageBox.Name = "squareFootageBox";
            this.squareFootageBox.Size = new System.Drawing.Size(150, 27);
            this.squareFootageBox.TabIndex = 1;
            this.squareFootageBox.Text = "0";
            this.squareFootageBox.TextChanged += new System.EventHandler(this.squareFootageBox_TextChanged);
            // 
            // squareLabel
            // 
            this.squareLabel.AutoSize = true;
            this.squareLabel.Location = new System.Drawing.Point(39, 51);
            this.squareLabel.Name = "squareLabel";
            this.squareLabel.Size = new System.Drawing.Size(64, 20);
            this.squareLabel.TabIndex = 2;
            this.squareLabel.Text = "Метраж";
            // 
            // roomsCountLabel
            // 
            this.roomsCountLabel.AutoSize = true;
            this.roomsCountLabel.Location = new System.Drawing.Point(39, 117);
            this.roomsCountLabel.Name = "roomsCountLabel";
            this.roomsCountLabel.Size = new System.Drawing.Size(144, 20);
            this.roomsCountLabel.TabIndex = 3;
            this.roomsCountLabel.Text = "Количество комнат";
            // 
            // roomsCount
            // 
            this.roomsCount.Location = new System.Drawing.Point(39, 140);
            this.roomsCount.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.roomsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.roomsCount.Name = "roomsCount";
            this.roomsCount.Size = new System.Drawing.Size(150, 27);
            this.roomsCount.TabIndex = 4;
            this.roomsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.roomsCount.ValueChanged += new System.EventHandler(this.roomsCounter_ValueChanged);
            // 
            // flatLabel
            // 
            this.flatLabel.AutoSize = true;
            this.flatLabel.Location = new System.Drawing.Point(159, 17);
            this.flatLabel.Name = "flatLabel";
            this.flatLabel.Size = new System.Drawing.Size(75, 20);
            this.flatLabel.TabIndex = 6;
            this.flatLabel.Text = "Квартира";
            // 
            // addresLabel
            // 
            this.addresLabel.AutoSize = true;
            this.addresLabel.Location = new System.Drawing.Point(183, 254);
            this.addresLabel.Name = "addresLabel";
            this.addresLabel.Size = new System.Drawing.Size(51, 20);
            this.addresLabel.TabIndex = 8;
            this.addresLabel.Text = "Адрес";
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Location = new System.Drawing.Point(271, 489);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(72, 20);
            this.roomLabel.TabIndex = 10;
            this.roomLabel.Text = "Комнаты";
            // 
            // houseLabel
            // 
            this.houseLabel.AutoSize = true;
            this.houseLabel.Location = new System.Drawing.Point(246, 348);
            this.houseLabel.Name = "houseLabel";
            this.houseLabel.Size = new System.Drawing.Size(39, 20);
            this.houseLabel.TabIndex = 20;
            this.houseLabel.Text = "Дом";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(246, 283);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(52, 20);
            this.streetLabel.TabIndex = 24;
            this.streetLabel.Text = "Улица";
            // 
            // streetBox
            // 
            this.streetBox.Location = new System.Drawing.Point(246, 306);
            this.streetBox.Name = "streetBox";
            this.streetBox.Size = new System.Drawing.Size(150, 27);
            this.streetBox.TabIndex = 23;
            // 
            // districtLabel
            // 
            this.districtLabel.AutoSize = true;
            this.districtLabel.Location = new System.Drawing.Point(33, 414);
            this.districtLabel.Name = "districtLabel";
            this.districtLabel.Size = new System.Drawing.Size(52, 20);
            this.districtLabel.TabIndex = 26;
            this.districtLabel.Text = "Район";
            // 
            // districtBox
            // 
            this.districtBox.Location = new System.Drawing.Point(33, 437);
            this.districtBox.Name = "districtBox";
            this.districtBox.Size = new System.Drawing.Size(150, 27);
            this.districtBox.TabIndex = 25;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(33, 348);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(51, 20);
            this.cityLabel.TabIndex = 28;
            this.cityLabel.Text = "Город";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(33, 371);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(150, 27);
            this.cityBox.TabIndex = 27;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(33, 283);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(58, 20);
            this.countryLabel.TabIndex = 30;
            this.countryLabel.Text = "Страна";
            // 
            // flatNumberLabel
            // 
            this.flatNumberLabel.AutoSize = true;
            this.flatNumberLabel.Location = new System.Drawing.Point(246, 414);
            this.flatNumberLabel.Name = "flatNumberLabel";
            this.flatNumberLabel.Size = new System.Drawing.Size(128, 20);
            this.flatNumberLabel.TabIndex = 32;
            this.flatNumberLabel.Text = "Номер квартиры";
            // 
            // houseNumber
            // 
            this.houseNumber.Location = new System.Drawing.Point(246, 371);
            this.houseNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.houseNumber.Name = "houseNumber";
            this.houseNumber.Size = new System.Drawing.Size(150, 27);
            this.houseNumber.TabIndex = 33;
            this.houseNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // flatNumber
            // 
            this.flatNumber.Location = new System.Drawing.Point(246, 437);
            this.flatNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.flatNumber.Name = "flatNumber";
            this.flatNumber.Size = new System.Drawing.Size(150, 27);
            this.flatNumber.TabIndex = 35;
            this.flatNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BuildDateLabel
            // 
            this.BuildDateLabel.AutoSize = true;
            this.BuildDateLabel.Location = new System.Drawing.Point(39, 181);
            this.BuildDateLabel.Name = "BuildDateLabel";
            this.BuildDateLabel.Size = new System.Drawing.Size(111, 20);
            this.BuildDateLabel.TabIndex = 36;
            this.BuildDateLabel.Text = "Год постройки";
            // 
            // roomsGroupBox
            // 
            this.roomsGroupBox.Controls.Add(this.balconyCheckBox);
            this.roomsGroupBox.Controls.Add(this.basementCheckBox);
            this.roomsGroupBox.Controls.Add(this.toiletCheckBox);
            this.roomsGroupBox.Controls.Add(this.bathCheckBox);
            this.roomsGroupBox.Controls.Add(this.kitchenCheckBox);
            this.roomsGroupBox.Location = new System.Drawing.Point(238, 51);
            this.roomsGroupBox.Name = "roomsGroupBox";
            this.roomsGroupBox.Size = new System.Drawing.Size(174, 180);
            this.roomsGroupBox.TabIndex = 37;
            this.roomsGroupBox.TabStop = false;
            this.roomsGroupBox.Text = "Наличие";
            this.roomsGroupBox.Enter += new System.EventHandler(this.roomsGroupBox_Enter);
            // 
            // balconyCheckBox
            // 
            this.balconyCheckBox.AutoSize = true;
            this.balconyCheckBox.Location = new System.Drawing.Point(8, 147);
            this.balconyCheckBox.Name = "balconyCheckBox";
            this.balconyCheckBox.Size = new System.Drawing.Size(81, 24);
            this.balconyCheckBox.TabIndex = 4;
            this.balconyCheckBox.Text = "Балкон";
            this.balconyCheckBox.UseVisualStyleBackColor = true;
            // 
            // basementCheckBox
            // 
            this.basementCheckBox.AutoSize = true;
            this.basementCheckBox.Location = new System.Drawing.Point(7, 117);
            this.basementCheckBox.Name = "basementCheckBox";
            this.basementCheckBox.Size = new System.Drawing.Size(83, 24);
            this.basementCheckBox.TabIndex = 3;
            this.basementCheckBox.Text = "Подвал";
            this.basementCheckBox.UseVisualStyleBackColor = true;
            // 
            // toiletCheckBox
            // 
            this.toiletCheckBox.AutoSize = true;
            this.toiletCheckBox.Location = new System.Drawing.Point(7, 87);
            this.toiletCheckBox.Name = "toiletCheckBox";
            this.toiletCheckBox.Size = new System.Drawing.Size(76, 24);
            this.toiletCheckBox.TabIndex = 2;
            this.toiletCheckBox.Text = "Туалет";
            this.toiletCheckBox.UseVisualStyleBackColor = true;
            // 
            // bathCheckBox
            // 
            this.bathCheckBox.AutoSize = true;
            this.bathCheckBox.Location = new System.Drawing.Point(7, 57);
            this.bathCheckBox.Name = "bathCheckBox";
            this.bathCheckBox.Size = new System.Drawing.Size(74, 24);
            this.bathCheckBox.TabIndex = 1;
            this.bathCheckBox.Text = "Ванна";
            this.bathCheckBox.UseVisualStyleBackColor = true;
            // 
            // kitchenCheckBox
            // 
            this.kitchenCheckBox.AutoSize = true;
            this.kitchenCheckBox.Location = new System.Drawing.Point(7, 27);
            this.kitchenCheckBox.Name = "kitchenCheckBox";
            this.kitchenCheckBox.Size = new System.Drawing.Size(71, 24);
            this.kitchenCheckBox.TabIndex = 0;
            this.kitchenCheckBox.Text = "Кухня";
            this.kitchenCheckBox.UseVisualStyleBackColor = true;
            // 
            // buildDate
            // 
            this.buildDate.Location = new System.Drawing.Point(22, 204);
            this.buildDate.MaxDate = new System.DateTime(2022, 3, 10, 0, 0, 0, 0);
            this.buildDate.Name = "buildDate";
            this.buildDate.Size = new System.Drawing.Size(186, 27);
            this.buildDate.TabIndex = 38;
            this.buildDate.Value = new System.DateTime(2022, 3, 10, 0, 0, 0, 0);
            // 
            // infoTableAboutFlat
            // 
            this.infoTableAboutFlat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoTableAboutFlat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.CityColumn,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.buildDateColumn,
            this.Column4,
            this.squareFootageColumn,
            this.Column1,
            this.Ванна,
            this.Туалет,
            this.Column2,
            this.Балкон});
            this.infoTableAboutFlat.Location = new System.Drawing.Point(600, 17);
            this.infoTableAboutFlat.Name = "infoTableAboutFlat";
            this.infoTableAboutFlat.RowHeadersWidth = 51;
            this.infoTableAboutFlat.RowTemplate.Height = 29;
            this.infoTableAboutFlat.Size = new System.Drawing.Size(639, 683);
            this.infoTableAboutFlat.TabIndex = 40;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Страна";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // CityColumn
            // 
            this.CityColumn.HeaderText = "Город";
            this.CityColumn.MinimumWidth = 6;
            this.CityColumn.Name = "CityColumn";
            this.CityColumn.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Улица";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Район";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Дом";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Номер квартиры";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // buildDateColumn
            // 
            this.buildDateColumn.HeaderText = "Год постройки";
            this.buildDateColumn.MinimumWidth = 6;
            this.buildDateColumn.Name = "buildDateColumn";
            this.buildDateColumn.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Количество комнат";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // squareFootageColumn
            // 
            this.squareFootageColumn.HeaderText = "Метраж";
            this.squareFootageColumn.MinimumWidth = 6;
            this.squareFootageColumn.Name = "squareFootageColumn";
            this.squareFootageColumn.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Кухня";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Ванна
            // 
            this.Ванна.HeaderText = "Ванна";
            this.Ванна.MinimumWidth = 6;
            this.Ванна.Name = "Ванна";
            this.Ванна.Width = 125;
            // 
            // Туалет
            // 
            this.Туалет.HeaderText = "Туалет";
            this.Туалет.MinimumWidth = 6;
            this.Туалет.Name = "Туалет";
            this.Туалет.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Подвал";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Балкон
            // 
            this.Балкон.HeaderText = "Балкон";
            this.Балкон.MinimumWidth = 6;
            this.Балкон.Name = "Балкон";
            this.Балкон.Width = 125;
            // 
            // serializableButton
            // 
            this.serializableButton.Location = new System.Drawing.Point(431, 361);
            this.serializableButton.Name = "serializableButton";
            this.serializableButton.Size = new System.Drawing.Size(153, 46);
            this.serializableButton.TabIndex = 41;
            this.serializableButton.Text = "Сериализация";
            this.serializableButton.UseVisualStyleBackColor = true;
            this.serializableButton.Click += new System.EventHandler(this.serializableButton_Click);
            // 
            // deserializableButton
            // 
            this.deserializableButton.Location = new System.Drawing.Point(431, 426);
            this.deserializableButton.Name = "deserializableButton";
            this.deserializableButton.Size = new System.Drawing.Size(153, 46);
            this.deserializableButton.TabIndex = 42;
            this.deserializableButton.Text = "Десериализация";
            this.deserializableButton.UseVisualStyleBackColor = true;
            this.deserializableButton.Click += new System.EventHandler(this.deserializableButton_Click);
            // 
            // countryBox
            // 
            this.countryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryBox.FormattingEnabled = true;
            this.countryBox.Items.AddRange(new object[] {
            "Беларусь",
            "Россия"});
            this.countryBox.Location = new System.Drawing.Point(33, 305);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(151, 28);
            this.countryBox.TabIndex = 43;
            // 
            // infoAboutRooms
            // 
            this.infoAboutRooms.AllowUserToAddRows = false;
            this.infoAboutRooms.AllowUserToDeleteRows = false;
            this.infoAboutRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoAboutRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.squareColumn,
            this.windowValueColumn,
            this.Column11});
            this.infoAboutRooms.Location = new System.Drawing.Point(33, 512);
            this.infoAboutRooms.Name = "infoAboutRooms";
            this.infoAboutRooms.RowHeadersWidth = 51;
            this.infoAboutRooms.RowTemplate.Height = 29;
            this.infoAboutRooms.Size = new System.Drawing.Size(551, 188);
            this.infoAboutRooms.TabIndex = 46;
            // 
            // Column9
            // 
            this.Column9.Frozen = true;
            this.Column9.HeaderText = "Номер комнаты";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // squareColumn
            // 
            this.squareColumn.HeaderText = "Площадь";
            this.squareColumn.MinimumWidth = 6;
            this.squareColumn.Name = "squareColumn";
            this.squareColumn.Width = 125;
            // 
            // windowValueColumn
            // 
            this.windowValueColumn.HeaderText = "Количество окон";
            this.windowValueColumn.MinimumWidth = 6;
            this.windowValueColumn.Name = "windowValueColumn";
            this.windowValueColumn.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Сторона Окон";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(431, 283);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(45, 20);
            this.priceLabel.TabIndex = 48;
            this.priceLabel.Text = "Цена";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(431, 306);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.ReadOnly = true;
            this.PriceBox.Size = new System.Drawing.Size(153, 27);
            this.PriceBox.TabIndex = 47;
            // 
            // Flats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1251, 723);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.infoAboutRooms);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.deserializableButton);
            this.Controls.Add(this.serializableButton);
            this.Controls.Add(this.infoTableAboutFlat);
            this.Controls.Add(this.buildDate);
            this.Controls.Add(this.roomsGroupBox);
            this.Controls.Add(this.BuildDateLabel);
            this.Controls.Add(this.flatNumber);
            this.Controls.Add(this.houseNumber);
            this.Controls.Add(this.flatNumberLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.districtLabel);
            this.Controls.Add(this.districtBox);
            this.Controls.Add(this.streetLabel);
            this.Controls.Add(this.streetBox);
            this.Controls.Add(this.houseLabel);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.addresLabel);
            this.Controls.Add(this.flatLabel);
            this.Controls.Add(this.roomsCount);
            this.Controls.Add(this.roomsCountLabel);
            this.Controls.Add(this.squareLabel);
            this.Controls.Add(this.squareFootageBox);
            this.Name = "Flats";
            this.Text = "Комната";
            this.Load += new System.EventHandler(this.Flats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatNumber)).EndInit();
            this.roomsGroupBox.ResumeLayout(false);
            this.roomsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoTableAboutFlat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoAboutRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox squareFootageBox;
        private System.Windows.Forms.Label squareLabel;
        private System.Windows.Forms.Label roomsCountLabel;
        private System.Windows.Forms.NumericUpDown roomsCount;
        private System.Windows.Forms.Label flatLabel;
        private System.Windows.Forms.Label addresLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label houseLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.TextBox streetBox;
        private System.Windows.Forms.Label districtLabel;
        private System.Windows.Forms.TextBox districtBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label flatNumberLabel;
        private System.Windows.Forms.NumericUpDown houseNumber;
        private System.Windows.Forms.NumericUpDown flatNumber;
        private System.Windows.Forms.Label BuildDateLabel;
        private System.Windows.Forms.GroupBox roomsGroupBox;
        private System.Windows.Forms.CheckBox balconyCheckBox;
        private System.Windows.Forms.CheckBox basementCheckBox;
        private System.Windows.Forms.CheckBox toiletCheckBox;
        private System.Windows.Forms.CheckBox bathCheckBox;
        private System.Windows.Forms.CheckBox kitchenCheckBox;
        private System.Windows.Forms.DateTimePicker buildDate;
        private System.Windows.Forms.DataGridView infoTableAboutFlat;
        private System.Windows.Forms.Button serializableButton;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button deserializableButton;
        private System.Windows.Forms.ComboBox countryBox;
        private System.Windows.Forms.DataGridView infoAboutRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn squareFootageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ванна;
        private System.Windows.Forms.DataGridViewTextBoxColumn Туалет;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Балкон;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn squareColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn windowValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Label roomLabel;
    }
}

