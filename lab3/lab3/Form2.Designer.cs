
namespace lab3
{
    partial class Form2
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
            this.roomsCount = new System.Windows.Forms.NumericUpDown();
            this.roomsCountLabel = new System.Windows.Forms.Label();
            this.buildDate = new System.Windows.Forms.DateTimePicker();
            this.buildDateLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.districtLabel = new System.Windows.Forms.Label();
            this.districtBox = new System.Windows.Forms.TextBox();
            this.infoTableAboutFlat = new System.Windows.Forms.DataGridView();
            this.countryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flatNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.squareFootageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitchenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToiletColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basementColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balconyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.roomsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoTableAboutFlat)).BeginInit();
            this.SuspendLayout();
            // 
            // roomsCount
            // 
            this.roomsCount.Location = new System.Drawing.Point(705, 41);
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
            this.roomsCount.Size = new System.Drawing.Size(222, 27);
            this.roomsCount.TabIndex = 43;
            this.roomsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.roomsCount.ValueChanged += new System.EventHandler(this.roomsCount_ValueChanged);
            // 
            // roomsCountLabel
            // 
            this.roomsCountLabel.AutoSize = true;
            this.roomsCountLabel.Location = new System.Drawing.Point(705, 18);
            this.roomsCountLabel.Name = "roomsCountLabel";
            this.roomsCountLabel.Size = new System.Drawing.Size(144, 20);
            this.roomsCountLabel.TabIndex = 42;
            this.roomsCountLabel.Text = "Количество комнат";
            // 
            // buildDate
            // 
            this.buildDate.Location = new System.Drawing.Point(705, 112);
            this.buildDate.MaxDate = new System.DateTime(2022, 3, 17, 0, 0, 0, 0);
            this.buildDate.Name = "buildDate";
            this.buildDate.Size = new System.Drawing.Size(222, 27);
            this.buildDate.TabIndex = 45;
            this.buildDate.Value = new System.DateTime(2022, 3, 10, 0, 0, 0, 0);
            this.buildDate.ValueChanged += new System.EventHandler(this.buildDate_ValueChanged);
            // 
            // buildDateLabel
            // 
            this.buildDateLabel.AutoSize = true;
            this.buildDateLabel.Location = new System.Drawing.Point(705, 89);
            this.buildDateLabel.Name = "buildDateLabel";
            this.buildDateLabel.Size = new System.Drawing.Size(111, 20);
            this.buildDateLabel.TabIndex = 44;
            this.buildDateLabel.Text = "Год постройки";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(705, 164);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(51, 20);
            this.cityLabel.TabIndex = 49;
            this.cityLabel.Text = "Город";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(705, 187);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(222, 27);
            this.cityBox.TabIndex = 48;
            this.cityBox.TextChanged += new System.EventHandler(this.cityBox_TextChanged);
            // 
            // districtLabel
            // 
            this.districtLabel.AutoSize = true;
            this.districtLabel.Location = new System.Drawing.Point(705, 238);
            this.districtLabel.Name = "districtLabel";
            this.districtLabel.Size = new System.Drawing.Size(52, 20);
            this.districtLabel.TabIndex = 47;
            this.districtLabel.Text = "Район";
            // 
            // districtBox
            // 
            this.districtBox.Location = new System.Drawing.Point(705, 261);
            this.districtBox.Name = "districtBox";
            this.districtBox.Size = new System.Drawing.Size(222, 27);
            this.districtBox.TabIndex = 46;
            this.districtBox.TextChanged += new System.EventHandler(this.districtBox_TextChanged);
            // 
            // infoTableAboutFlat
            // 
            this.infoTableAboutFlat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoTableAboutFlat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.countryColumn,
            this.CityColumn,
            this.streetColumn,
            this.districtColumn,
            this.houseColumn,
            this.flatNumberColumn,
            this.buildDateColumn,
            this.roomsCountColumn,
            this.squareFootageColumn,
            this.kitchenColumn,
            this.BathColumn,
            this.ToiletColumn,
            this.basementColumn,
            this.balconyColumn,
            this.PriceColumn});
            this.infoTableAboutFlat.Location = new System.Drawing.Point(12, 12);
            this.infoTableAboutFlat.Name = "infoTableAboutFlat";
            this.infoTableAboutFlat.RowHeadersWidth = 51;
            this.infoTableAboutFlat.RowTemplate.Height = 29;
            this.infoTableAboutFlat.Size = new System.Drawing.Size(665, 548);
            this.infoTableAboutFlat.TabIndex = 52;
            // 
            // countryColumn
            // 
            this.countryColumn.HeaderText = "Страна";
            this.countryColumn.MinimumWidth = 6;
            this.countryColumn.Name = "countryColumn";
            this.countryColumn.Width = 125;
            // 
            // CityColumn
            // 
            this.CityColumn.HeaderText = "Город";
            this.CityColumn.MinimumWidth = 6;
            this.CityColumn.Name = "CityColumn";
            this.CityColumn.Width = 125;
            // 
            // streetColumn
            // 
            this.streetColumn.HeaderText = "Улица";
            this.streetColumn.MinimumWidth = 6;
            this.streetColumn.Name = "streetColumn";
            this.streetColumn.Width = 125;
            // 
            // districtColumn
            // 
            this.districtColumn.HeaderText = "Район";
            this.districtColumn.MinimumWidth = 6;
            this.districtColumn.Name = "districtColumn";
            this.districtColumn.Width = 125;
            // 
            // houseColumn
            // 
            this.houseColumn.HeaderText = "Дом";
            this.houseColumn.MinimumWidth = 6;
            this.houseColumn.Name = "houseColumn";
            this.houseColumn.Width = 125;
            // 
            // flatNumberColumn
            // 
            this.flatNumberColumn.HeaderText = "Номер квартиры";
            this.flatNumberColumn.MinimumWidth = 6;
            this.flatNumberColumn.Name = "flatNumberColumn";
            this.flatNumberColumn.Width = 125;
            // 
            // buildDateColumn
            // 
            this.buildDateColumn.HeaderText = "Год постройки";
            this.buildDateColumn.MinimumWidth = 6;
            this.buildDateColumn.Name = "buildDateColumn";
            this.buildDateColumn.Width = 125;
            // 
            // roomsCountColumn
            // 
            this.roomsCountColumn.HeaderText = "Количество комнат";
            this.roomsCountColumn.MinimumWidth = 6;
            this.roomsCountColumn.Name = "roomsCountColumn";
            this.roomsCountColumn.Width = 125;
            // 
            // squareFootageColumn
            // 
            this.squareFootageColumn.HeaderText = "Метраж";
            this.squareFootageColumn.MinimumWidth = 6;
            this.squareFootageColumn.Name = "squareFootageColumn";
            this.squareFootageColumn.Width = 125;
            // 
            // kitchenColumn
            // 
            this.kitchenColumn.HeaderText = "Кухня";
            this.kitchenColumn.MinimumWidth = 6;
            this.kitchenColumn.Name = "kitchenColumn";
            this.kitchenColumn.Width = 125;
            // 
            // BathColumn
            // 
            this.BathColumn.HeaderText = "Ванна";
            this.BathColumn.MinimumWidth = 6;
            this.BathColumn.Name = "BathColumn";
            this.BathColumn.Width = 125;
            // 
            // ToiletColumn
            // 
            this.ToiletColumn.HeaderText = "Туалет";
            this.ToiletColumn.MinimumWidth = 6;
            this.ToiletColumn.Name = "ToiletColumn";
            this.ToiletColumn.Width = 125;
            // 
            // basementColumn
            // 
            this.basementColumn.HeaderText = "Подвал";
            this.basementColumn.MinimumWidth = 6;
            this.basementColumn.Name = "basementColumn";
            this.basementColumn.Width = 125;
            // 
            // balconyColumn
            // 
            this.balconyColumn.HeaderText = "Балкон";
            this.balconyColumn.MinimumWidth = 6;
            this.balconyColumn.Name = "balconyColumn";
            this.balconyColumn.Width = 125;
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Цена";
            this.PriceColumn.MinimumWidth = 6;
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 589);
            this.Controls.Add(this.infoTableAboutFlat);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.districtLabel);
            this.Controls.Add(this.districtBox);
            this.Controls.Add(this.buildDate);
            this.Controls.Add(this.buildDateLabel);
            this.Controls.Add(this.roomsCount);
            this.Controls.Add(this.roomsCountLabel);
            this.Name = "Form2";
            this.Text = "Поиск";
            ((System.ComponentModel.ISupportInitialize)(this.roomsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoTableAboutFlat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown roomsCount;
        private System.Windows.Forms.Label roomsCountLabel;
        private System.Windows.Forms.DateTimePicker buildDate;
        private System.Windows.Forms.Label buildDateLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label districtLabel;
        private System.Windows.Forms.TextBox districtBox;
        private System.Windows.Forms.DataGridView infoTableAboutFlat;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flatNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomsCountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn squareFootageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitchenColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BathColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToiletColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basementColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balconyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
    }
}