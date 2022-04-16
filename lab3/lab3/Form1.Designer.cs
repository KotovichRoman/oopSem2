
namespace lab3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flats));
            this.squareFootageBox = new System.Windows.Forms.TextBox();
            this.squareFootageLabel = new System.Windows.Forms.Label();
            this.roomsCountLabel = new System.Windows.Forms.Label();
            this.roomsCount = new System.Windows.Forms.NumericUpDown();
            this.flatLabel = new System.Windows.Forms.Label();
            this.addresLabel = new System.Windows.Forms.Label();
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
            this.buildDateLabel = new System.Windows.Forms.Label();
            this.groupBoxRooms = new System.Windows.Forms.GroupBox();
            this.balconyCheckBox = new System.Windows.Forms.CheckBox();
            this.basementCheckBox = new System.Windows.Forms.CheckBox();
            this.toiletCheckBox = new System.Windows.Forms.CheckBox();
            this.bathCheckBox = new System.Windows.Forms.CheckBox();
            this.kitchenCheckBox = new System.Windows.Forms.CheckBox();
            this.buildDate = new System.Windows.Forms.DateTimePicker();
            this.serializableButton = new System.Windows.Forms.Button();
            this.deserializableButton = new System.Windows.Forms.Button();
            this.countryBox = new System.Windows.Forms.ComboBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.searchStripButton = new System.Windows.Forms.ToolStripButton();
            this.sortStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.поПлощадиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поКоличествукомнатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поГородуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backwardButton = new System.Windows.Forms.ToolStripButton();
            this.forewardButton = new System.Windows.Forms.ToolStripButton();
            this.hideButton = new System.Windows.Forms.ToolStripButton();
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
            this.searchButton = new System.Windows.Forms.Button();
            this.sortBySquareButton = new System.Windows.Forms.Button();
            this.sortByRoomsCountButton = new System.Windows.Forms.Button();
            this.sortByCityButton = new System.Windows.Forms.Button();
            this.indexBox = new System.Windows.Forms.TextBox();
            this.indexLabel = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.objectCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.objectsValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.lastEvent = new System.Windows.Forms.ToolStripStatusLabel();
            this.last = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.date = new System.Windows.Forms.ToolStripStatusLabel();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roomsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatNumber)).BeginInit();
            this.groupBoxRooms.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoTableAboutFlat)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // squareFootageBox
            // 
            this.squareFootageBox.Location = new System.Drawing.Point(39, 143);
            this.squareFootageBox.Name = "squareFootageBox";
            this.squareFootageBox.Size = new System.Drawing.Size(150, 27);
            this.squareFootageBox.TabIndex = 1;
            this.squareFootageBox.Text = "0";
            this.squareFootageBox.TextChanged += new System.EventHandler(this.squareFootageBox_TextChanged);
            // 
            // squareFootageLabel
            // 
            this.squareFootageLabel.AutoSize = true;
            this.squareFootageLabel.Location = new System.Drawing.Point(39, 120);
            this.squareFootageLabel.Name = "squareFootageLabel";
            this.squareFootageLabel.Size = new System.Drawing.Size(64, 20);
            this.squareFootageLabel.TabIndex = 2;
            this.squareFootageLabel.Text = "Метраж";
            // 
            // roomsCountLabel
            // 
            this.roomsCountLabel.AutoSize = true;
            this.roomsCountLabel.Location = new System.Drawing.Point(39, 186);
            this.roomsCountLabel.Name = "roomsCountLabel";
            this.roomsCountLabel.Size = new System.Drawing.Size(144, 20);
            this.roomsCountLabel.TabIndex = 3;
            this.roomsCountLabel.Text = "Количество комнат";
            // 
            // roomsCount
            // 
            this.roomsCount.Location = new System.Drawing.Point(39, 209);
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
            // 
            // flatLabel
            // 
            this.flatLabel.AutoSize = true;
            this.flatLabel.Location = new System.Drawing.Point(159, 86);
            this.flatLabel.Name = "flatLabel";
            this.flatLabel.Size = new System.Drawing.Size(75, 20);
            this.flatLabel.TabIndex = 6;
            this.flatLabel.Text = "Квартира";
            // 
            // addresLabel
            // 
            this.addresLabel.AutoSize = true;
            this.addresLabel.Location = new System.Drawing.Point(183, 323);
            this.addresLabel.Name = "addresLabel";
            this.addresLabel.Size = new System.Drawing.Size(51, 20);
            this.addresLabel.TabIndex = 8;
            this.addresLabel.Text = "Адрес";
            // 
            // houseLabel
            // 
            this.houseLabel.AutoSize = true;
            this.houseLabel.Location = new System.Drawing.Point(246, 417);
            this.houseLabel.Name = "houseLabel";
            this.houseLabel.Size = new System.Drawing.Size(39, 20);
            this.houseLabel.TabIndex = 20;
            this.houseLabel.Text = "Дом";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(246, 352);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(52, 20);
            this.streetLabel.TabIndex = 24;
            this.streetLabel.Text = "Улица";
            // 
            // streetBox
            // 
            this.streetBox.Location = new System.Drawing.Point(246, 375);
            this.streetBox.Name = "streetBox";
            this.streetBox.Size = new System.Drawing.Size(150, 27);
            this.streetBox.TabIndex = 23;
            this.streetBox.TextChanged += new System.EventHandler(this.streetBox_TextChanged);
            // 
            // districtLabel
            // 
            this.districtLabel.AutoSize = true;
            this.districtLabel.Location = new System.Drawing.Point(33, 483);
            this.districtLabel.Name = "districtLabel";
            this.districtLabel.Size = new System.Drawing.Size(52, 20);
            this.districtLabel.TabIndex = 26;
            this.districtLabel.Text = "Район";
            // 
            // districtBox
            // 
            this.districtBox.Location = new System.Drawing.Point(33, 506);
            this.districtBox.Name = "districtBox";
            this.districtBox.Size = new System.Drawing.Size(150, 27);
            this.districtBox.TabIndex = 25;
            this.districtBox.TextChanged += new System.EventHandler(this.districtBox_TextChanged);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(33, 417);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(51, 20);
            this.cityLabel.TabIndex = 28;
            this.cityLabel.Text = "Город";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(33, 440);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(150, 27);
            this.cityBox.TabIndex = 27;
            this.cityBox.TextChanged += new System.EventHandler(this.cityBox_TextChanged);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(33, 352);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(58, 20);
            this.countryLabel.TabIndex = 30;
            this.countryLabel.Text = "Страна";
            // 
            // flatNumberLabel
            // 
            this.flatNumberLabel.AutoSize = true;
            this.flatNumberLabel.Location = new System.Drawing.Point(246, 483);
            this.flatNumberLabel.Name = "flatNumberLabel";
            this.flatNumberLabel.Size = new System.Drawing.Size(128, 20);
            this.flatNumberLabel.TabIndex = 32;
            this.flatNumberLabel.Text = "Номер квартиры";
            // 
            // houseNumber
            // 
            this.houseNumber.Location = new System.Drawing.Point(246, 440);
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
            this.houseNumber.ValueChanged += new System.EventHandler(this.houseNumber_ValueChanged);
            // 
            // flatNumber
            // 
            this.flatNumber.Location = new System.Drawing.Point(246, 506);
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
            // buildDateLabel
            // 
            this.buildDateLabel.AutoSize = true;
            this.buildDateLabel.Location = new System.Drawing.Point(39, 250);
            this.buildDateLabel.Name = "buildDateLabel";
            this.buildDateLabel.Size = new System.Drawing.Size(111, 20);
            this.buildDateLabel.TabIndex = 36;
            this.buildDateLabel.Text = "Год постройки";
            // 
            // groupBoxRooms
            // 
            this.groupBoxRooms.Controls.Add(this.balconyCheckBox);
            this.groupBoxRooms.Controls.Add(this.basementCheckBox);
            this.groupBoxRooms.Controls.Add(this.toiletCheckBox);
            this.groupBoxRooms.Controls.Add(this.bathCheckBox);
            this.groupBoxRooms.Controls.Add(this.kitchenCheckBox);
            this.groupBoxRooms.Location = new System.Drawing.Point(238, 120);
            this.groupBoxRooms.Name = "groupBoxRooms";
            this.groupBoxRooms.Size = new System.Drawing.Size(174, 180);
            this.groupBoxRooms.TabIndex = 37;
            this.groupBoxRooms.TabStop = false;
            this.groupBoxRooms.Text = "Наличие";
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
            this.buildDate.Location = new System.Drawing.Point(22, 273);
            this.buildDate.MaxDate = new System.DateTime(2022, 3, 17, 0, 0, 0, 0);
            this.buildDate.Name = "buildDate";
            this.buildDate.Size = new System.Drawing.Size(186, 27);
            this.buildDate.TabIndex = 38;
            this.buildDate.Value = new System.DateTime(2022, 3, 10, 0, 0, 0, 0);
            // 
            // serializableButton
            // 
            this.serializableButton.Location = new System.Drawing.Point(431, 430);
            this.serializableButton.Name = "serializableButton";
            this.serializableButton.Size = new System.Drawing.Size(153, 46);
            this.serializableButton.TabIndex = 41;
            this.serializableButton.Text = "Сериализация";
            this.serializableButton.UseVisualStyleBackColor = true;
            this.serializableButton.Click += new System.EventHandler(this.serializableButton_Click);
            // 
            // deserializableButton
            // 
            this.deserializableButton.Location = new System.Drawing.Point(431, 495);
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
            this.countryBox.Location = new System.Drawing.Point(33, 374);
            this.countryBox.Name = "countryBox";
            this.countryBox.Size = new System.Drawing.Size(151, 28);
            this.countryBox.TabIndex = 43;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(431, 352);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(45, 20);
            this.priceLabel.TabIndex = 48;
            this.priceLabel.Text = "Цена";
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(431, 375);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.ReadOnly = true;
            this.PriceBox.Size = new System.Drawing.Size(153, 27);
            this.PriceBox.TabIndex = 47;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgram});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1251, 28);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutProgram
            // 
            this.aboutProgram.Name = "aboutProgram";
            this.aboutProgram.Size = new System.Drawing.Size(128, 24);
            this.aboutProgram.Text = "О приложении";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchStripButton,
            this.sortStripDropDownButton,
            this.backwardButton,
            this.forewardButton,
            this.hideButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1251, 27);
            this.toolStrip.TabIndex = 50;
            this.toolStrip.Text = "toolStrip1";
            // 
            // searchStripButton
            // 
            this.searchStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchStripButton.Image = ((System.Drawing.Image)(resources.GetObject("searchStripButton.Image")));
            this.searchStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchStripButton.Name = "searchStripButton";
            this.searchStripButton.Size = new System.Drawing.Size(56, 24);
            this.searchStripButton.Text = "Поиск";
            // 
            // sortStripDropDownButton
            // 
            this.sortStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.sortStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поПлощадиToolStripMenuItem,
            this.поКоличествукомнатToolStripMenuItem,
            this.поГородуToolStripMenuItem});
            this.sortStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("sortStripDropDownButton.Image")));
            this.sortStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sortStripDropDownButton.Name = "sortStripDropDownButton";
            this.sortStripDropDownButton.Size = new System.Drawing.Size(106, 24);
            this.sortStripDropDownButton.Text = "Сортировка";
            // 
            // поПлощадиToolStripMenuItem
            // 
            this.поПлощадиToolStripMenuItem.Name = "поПлощадиToolStripMenuItem";
            this.поПлощадиToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.поПлощадиToolStripMenuItem.Text = "По площади";
            // 
            // поКоличествукомнатToolStripMenuItem
            // 
            this.поКоличествукомнатToolStripMenuItem.Name = "поКоличествукомнатToolStripMenuItem";
            this.поКоличествукомнатToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.поКоличествукомнатToolStripMenuItem.Text = "По количеству комнат";
            // 
            // поГородуToolStripMenuItem
            // 
            this.поГородуToolStripMenuItem.Name = "поГородуToolStripMenuItem";
            this.поГородуToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.поГородуToolStripMenuItem.Text = "По городу";
            // 
            // backwardButton
            // 
            this.backwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.backwardButton.Image = ((System.Drawing.Image)(resources.GetObject("backwardButton.Image")));
            this.backwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backwardButton.Name = "backwardButton";
            this.backwardButton.Size = new System.Drawing.Size(55, 24);
            this.backwardButton.Text = "Назад";
            // 
            // forewardButton
            // 
            this.forewardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.forewardButton.Image = ((System.Drawing.Image)(resources.GetObject("forewardButton.Image")));
            this.forewardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forewardButton.Name = "forewardButton";
            this.forewardButton.Size = new System.Drawing.Size(64, 24);
            this.forewardButton.Text = "Вперёд";
            // 
            // hideButton
            // 
            this.hideButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.hideButton.Image = ((System.Drawing.Image)(resources.GetObject("hideButton.Image")));
            this.hideButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(63, 24);
            this.hideButton.Text = "Скрыть";
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
            this.infoTableAboutFlat.Location = new System.Drawing.Point(608, 86);
            this.infoTableAboutFlat.Name = "infoTableAboutFlat";
            this.infoTableAboutFlat.RowHeadersWidth = 51;
            this.infoTableAboutFlat.RowTemplate.Height = 29;
            this.infoTableAboutFlat.Size = new System.Drawing.Size(631, 492);
            this.infoTableAboutFlat.TabIndex = 51;
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
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(852, 659);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(186, 58);
            this.searchButton.TabIndex = 52;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // sortBySquareButton
            // 
            this.sortBySquareButton.Location = new System.Drawing.Point(1053, 596);
            this.sortBySquareButton.Name = "sortBySquareButton";
            this.sortBySquareButton.Size = new System.Drawing.Size(186, 58);
            this.sortBySquareButton.TabIndex = 53;
            this.sortBySquareButton.Text = "Сортировка по метражу";
            this.sortBySquareButton.UseVisualStyleBackColor = true;
            this.sortBySquareButton.Click += new System.EventHandler(this.sortBySquareButton_Click);
            // 
            // sortByRoomsCountButton
            // 
            this.sortByRoomsCountButton.Location = new System.Drawing.Point(1053, 660);
            this.sortByRoomsCountButton.Name = "sortByRoomsCountButton";
            this.sortByRoomsCountButton.Size = new System.Drawing.Size(186, 57);
            this.sortByRoomsCountButton.TabIndex = 54;
            this.sortByRoomsCountButton.Text = "Сортировка по количеству комнат";
            this.sortByRoomsCountButton.UseVisualStyleBackColor = true;
            this.sortByRoomsCountButton.Click += new System.EventHandler(this.sortByRoomsCountButton_Click);
            // 
            // sortByCityButton
            // 
            this.sortByCityButton.Location = new System.Drawing.Point(852, 597);
            this.sortByCityButton.Name = "sortByCityButton";
            this.sortByCityButton.Size = new System.Drawing.Size(186, 57);
            this.sortByCityButton.TabIndex = 55;
            this.sortByCityButton.Text = "Сортировка по городу";
            this.sortByCityButton.UseVisualStyleBackColor = true;
            this.sortByCityButton.Click += new System.EventHandler(this.sortByCityButton_Click);
            // 
            // indexBox
            // 
            this.indexBox.Location = new System.Drawing.Point(431, 316);
            this.indexBox.Name = "indexBox";
            this.indexBox.Size = new System.Drawing.Size(153, 27);
            this.indexBox.TabIndex = 56;
            // 
            // indexLabel
            // 
            this.indexLabel.AutoSize = true;
            this.indexLabel.Location = new System.Drawing.Point(431, 293);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(59, 20);
            this.indexLabel.TabIndex = 57;
            this.indexLabel.Text = "Индекс";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objectCount,
            this.objectsValue,
            this.lastEvent,
            this.last,
            this.dateStatus,
            this.date});
            this.statusStrip.Location = new System.Drawing.Point(0, 779);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1251, 26);
            this.statusStrip.TabIndex = 58;
            this.statusStrip.Text = "statusStrip1";
            // 
            // objectCount
            // 
            this.objectCount.Name = "objectCount";
            this.objectCount.Size = new System.Drawing.Size(162, 20);
            this.objectCount.Text = "Количество объектов:";
            // 
            // objectsValue
            // 
            this.objectsValue.Name = "objectsValue";
            this.objectsValue.Size = new System.Drawing.Size(0, 20);
            // 
            // lastEvent
            // 
            this.lastEvent.Name = "lastEvent";
            this.lastEvent.Size = new System.Drawing.Size(152, 20);
            this.lastEvent.Text = "Последнее действие";
            // 
            // last
            // 
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(0, 20);
            // 
            // dateStatus
            // 
            this.dateStatus.Name = "dateStatus";
            this.dateStatus.Size = new System.Drawing.Size(44, 20);
            this.dateStatus.Text = "Дата:";
            // 
            // date
            // 
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(0, 20);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(651, 597);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(186, 57);
            this.clearButton.TabIndex = 59;
            this.clearButton.Text = "Очистка";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Flats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1251, 805);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.indexLabel);
            this.Controls.Add(this.indexBox);
            this.Controls.Add(this.sortByCityButton);
            this.Controls.Add(this.sortByRoomsCountButton);
            this.Controls.Add(this.sortBySquareButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.infoTableAboutFlat);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.countryBox);
            this.Controls.Add(this.deserializableButton);
            this.Controls.Add(this.serializableButton);
            this.Controls.Add(this.buildDate);
            this.Controls.Add(this.groupBoxRooms);
            this.Controls.Add(this.buildDateLabel);
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
            this.Controls.Add(this.addresLabel);
            this.Controls.Add(this.flatLabel);
            this.Controls.Add(this.roomsCount);
            this.Controls.Add(this.roomsCountLabel);
            this.Controls.Add(this.squareFootageLabel);
            this.Controls.Add(this.squareFootageBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Flats";
            this.Text = "Комната";
            this.Load += new System.EventHandler(this.Flats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.houseNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatNumber)).EndInit();
            this.groupBoxRooms.ResumeLayout(false);
            this.groupBoxRooms.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoTableAboutFlat)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox squareFootageBox;
        private System.Windows.Forms.Label squareFootageLabel;
        private System.Windows.Forms.Label roomsCountLabel;
        private System.Windows.Forms.NumericUpDown roomsCount;
        private System.Windows.Forms.Label flatLabel;
        private System.Windows.Forms.Label addresLabel;
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
        private System.Windows.Forms.Label buildDateLabel;
        private System.Windows.Forms.GroupBox groupBoxRooms;
        private System.Windows.Forms.CheckBox balconyCheckBox;
        private System.Windows.Forms.CheckBox basementCheckBox;
        private System.Windows.Forms.CheckBox toiletCheckBox;
        private System.Windows.Forms.CheckBox bathCheckBox;
        private System.Windows.Forms.CheckBox kitchenCheckBox;
        private System.Windows.Forms.DateTimePicker buildDate;
        private System.Windows.Forms.Button serializableButton;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button deserializableButton;
        private System.Windows.Forms.ComboBox countryBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutProgram;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton searchStripButton;
        private System.Windows.Forms.ToolStripDropDownButton sortStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem поПлощадиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поКоличествукомнатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поГородуToolStripMenuItem;
        private System.Windows.Forms.DataGridView infoTableAboutFlat;
        private System.Windows.Forms.ToolStripButton backwardButton;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button sortBySquareButton;
        private System.Windows.Forms.Button sortByRoomsCountButton;
        private System.Windows.Forms.Button sortByCityButton;
        private System.Windows.Forms.TextBox indexBox;
        private System.Windows.Forms.Label indexLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel objectCount;
        private System.Windows.Forms.ToolStripStatusLabel dateStatus;
        private System.Windows.Forms.ToolStripStatusLabel lastEvent;
        private System.Windows.Forms.ToolStripStatusLabel objectsValue;
        private System.Windows.Forms.ToolStripStatusLabel last;
        private System.Windows.Forms.ToolStripStatusLabel date;
        private System.Windows.Forms.ToolStripButton forewardButton;
        private System.Windows.Forms.ToolStripButton t;
        private System.Windows.Forms.ToolStripButton hideButton;
        private System.Windows.Forms.Button clearButton;
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

