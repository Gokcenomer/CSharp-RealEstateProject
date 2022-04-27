
namespace RealEstateProject
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CmbType = new System.Windows.Forms.ComboBox();
            this.CmbHType = new System.Windows.Forms.ComboBox();
            this.TxtSqrMt = new System.Windows.Forms.TextBox();
            this.CmbRooms = new System.Windows.Forms.ComboBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.TxtBAge = new System.Windows.Forms.TextBox();
            this.TxtFlrLoca = new System.Windows.Forms.TextBox();
            this.TxtNoFlr = new System.Windows.Forms.TextBox();
            this.TxtDoorNo = new System.Windows.Forms.TextBox();
            this.CmbFurnished = new System.Windows.Forms.ComboBox();
            this.RtbAdress = new System.Windows.Forms.RichTextBox();
            this.RtbNotes = new System.Windows.Forms.RichTextBox();
            this.TxtSName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.maskedTelNo = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.maskedID = new System.Windows.Forms.MaskedTextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.addsectionTableAdapter1 = new RealEstateProject.RealEstateDataSetTableAdapters.addsectionTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sqrMetersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flrLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfFlrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doorNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.furnishedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerTelNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addsectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.realEstateDataSet1 = new RealEstateProject.RealEstateDataSet1();
            this.addsectionTableAdapter = new RealEstateProject.RealEstateDataSet1TableAdapters.addsectionTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addsectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tür";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ev Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Metrekare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Odalar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fiyat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ev yaşı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Bina Katı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Kapı Numarası";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Eşya Durumu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(35, 380);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Adres";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(331, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 19);
            this.label12.TabIndex = 11;
            this.label12.Text = "Notlar";
            // 
            // CmbType
            // 
            this.CmbType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbType.FormattingEnabled = true;
            this.CmbType.Items.AddRange(new object[] {
            "Satılık",
            "Kiralık"});
            this.CmbType.Location = new System.Drawing.Point(149, 25);
            this.CmbType.Name = "CmbType";
            this.CmbType.Size = new System.Drawing.Size(121, 27);
            this.CmbType.TabIndex = 12;
            this.CmbType.Text = "Kiralık";
            this.CmbType.SelectedIndexChanged += new System.EventHandler(this.CmbType_SelectedIndexChanged);
            // 
            // CmbHType
            // 
            this.CmbHType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbHType.FormattingEnabled = true;
            this.CmbHType.Items.AddRange(new object[] {
            "Aparmant",
            "Müstakil Ev",
            "Bina",
            "Arazi",
            ""});
            this.CmbHType.Location = new System.Drawing.Point(149, 57);
            this.CmbHType.Name = "CmbHType";
            this.CmbHType.Size = new System.Drawing.Size(121, 27);
            this.CmbHType.TabIndex = 13;
            this.CmbHType.Text = "Bina";
            // 
            // TxtSqrMt
            // 
            this.TxtSqrMt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSqrMt.Location = new System.Drawing.Point(149, 90);
            this.TxtSqrMt.Name = "TxtSqrMt";
            this.TxtSqrMt.Size = new System.Drawing.Size(121, 27);
            this.TxtSqrMt.TabIndex = 14;
            // 
            // CmbRooms
            // 
            this.CmbRooms.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbRooms.FormattingEnabled = true;
            this.CmbRooms.Items.AddRange(new object[] {
            "1+0",
            "1+1",
            "2+1",
            "3+1",
            "4+1"});
            this.CmbRooms.Location = new System.Drawing.Point(149, 127);
            this.CmbRooms.Name = "CmbRooms";
            this.CmbRooms.Size = new System.Drawing.Size(121, 27);
            this.CmbRooms.TabIndex = 15;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrice.Location = new System.Drawing.Point(149, 160);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(121, 27);
            this.TxtPrice.TabIndex = 16;
            // 
            // TxtBAge
            // 
            this.TxtBAge.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBAge.Location = new System.Drawing.Point(149, 193);
            this.TxtBAge.Name = "TxtBAge";
            this.TxtBAge.Size = new System.Drawing.Size(121, 27);
            this.TxtBAge.TabIndex = 17;
            // 
            // TxtFlrLoca
            // 
            this.TxtFlrLoca.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFlrLoca.Location = new System.Drawing.Point(149, 230);
            this.TxtFlrLoca.Name = "TxtFlrLoca";
            this.TxtFlrLoca.Size = new System.Drawing.Size(121, 27);
            this.TxtFlrLoca.TabIndex = 18;
            // 
            // TxtNoFlr
            // 
            this.TxtNoFlr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNoFlr.Location = new System.Drawing.Point(149, 273);
            this.TxtNoFlr.Name = "TxtNoFlr";
            this.TxtNoFlr.Size = new System.Drawing.Size(121, 27);
            this.TxtNoFlr.TabIndex = 19;
            // 
            // TxtDoorNo
            // 
            this.TxtDoorNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDoorNo.Location = new System.Drawing.Point(149, 306);
            this.TxtDoorNo.Name = "TxtDoorNo";
            this.TxtDoorNo.Size = new System.Drawing.Size(121, 27);
            this.TxtDoorNo.TabIndex = 20;
            // 
            // CmbFurnished
            // 
            this.CmbFurnished.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFurnished.FormattingEnabled = true;
            this.CmbFurnished.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.CmbFurnished.Location = new System.Drawing.Point(149, 342);
            this.CmbFurnished.Name = "CmbFurnished";
            this.CmbFurnished.Size = new System.Drawing.Size(121, 27);
            this.CmbFurnished.TabIndex = 21;
            this.CmbFurnished.Text = "Evet";
            // 
            // RtbAdress
            // 
            this.RtbAdress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbAdress.Location = new System.Drawing.Point(149, 380);
            this.RtbAdress.Name = "RtbAdress";
            this.RtbAdress.Size = new System.Drawing.Size(121, 77);
            this.RtbAdress.TabIndex = 22;
            this.RtbAdress.Text = "";
            // 
            // RtbNotes
            // 
            this.RtbNotes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbNotes.Location = new System.Drawing.Point(445, 155);
            this.RtbNotes.Name = "RtbNotes";
            this.RtbNotes.Size = new System.Drawing.Size(121, 77);
            this.RtbNotes.TabIndex = 27;
            this.RtbNotes.Text = "";
            // 
            // TxtSName
            // 
            this.TxtSName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSName.Location = new System.Drawing.Point(445, 22);
            this.TxtSName.Name = "TxtSName";
            this.TxtSName.Size = new System.Drawing.Size(121, 27);
            this.TxtSName.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(331, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 19);
            this.label13.TabIndex = 25;
            this.label13.Text = "Satıcı İsmi";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(331, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 19);
            this.label14.TabIndex = 26;
            this.label14.Text = "Satıcı Tel No";
            // 
            // maskedTelNo
            // 
            this.maskedTelNo.Location = new System.Drawing.Point(445, 61);
            this.maskedTelNo.Mask = "(999) 000-0000";
            this.maskedTelNo.Name = "maskedTelNo";
            this.maskedTelNo.Size = new System.Drawing.Size(121, 20);
            this.maskedTelNo.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(331, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 19);
            this.label15.TabIndex = 28;
            this.label15.Text = "Satıcı TC";
            // 
            // maskedID
            // 
            this.maskedID.Location = new System.Drawing.Point(445, 107);
            this.maskedID.Mask = "0000000000";
            this.maskedID.Name = "maskedID";
            this.maskedID.Size = new System.Drawing.Size(121, 20);
            this.maskedID.TabIndex = 26;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(597, 20);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(110, 35);
            this.BtnAdd.TabIndex = 28;
            this.BtnAdd.Text = "Ekle";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // addsectionTableAdapter1
            // 
            this.addsectionTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(597, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 40);
            this.button1.TabIndex = 29;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(597, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 40);
            this.button2.TabIndex = 30;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.homeTypeDataGridViewTextBoxColumn,
            this.sqrMetersDataGridViewTextBoxColumn,
            this.roomsDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.buildingAgeDataGridViewTextBoxColumn,
            this.flrLocationDataGridViewTextBoxColumn,
            this.numberOfFlrDataGridViewTextBoxColumn,
            this.doorNumberDataGridViewTextBoxColumn,
            this.furnishedDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.sellerNameDataGridViewTextBoxColumn,
            this.sellerTelNoDataGridViewTextBoxColumn,
            this.sellerIDDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.addsectionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 464);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(783, 133);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // homeTypeDataGridViewTextBoxColumn
            // 
            this.homeTypeDataGridViewTextBoxColumn.DataPropertyName = "HomeType";
            this.homeTypeDataGridViewTextBoxColumn.HeaderText = "HomeType";
            this.homeTypeDataGridViewTextBoxColumn.Name = "homeTypeDataGridViewTextBoxColumn";
            // 
            // sqrMetersDataGridViewTextBoxColumn
            // 
            this.sqrMetersDataGridViewTextBoxColumn.DataPropertyName = "SqrMeters";
            this.sqrMetersDataGridViewTextBoxColumn.HeaderText = "SqrMeters";
            this.sqrMetersDataGridViewTextBoxColumn.Name = "sqrMetersDataGridViewTextBoxColumn";
            // 
            // roomsDataGridViewTextBoxColumn
            // 
            this.roomsDataGridViewTextBoxColumn.DataPropertyName = "Rooms";
            this.roomsDataGridViewTextBoxColumn.HeaderText = "Rooms";
            this.roomsDataGridViewTextBoxColumn.Name = "roomsDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // buildingAgeDataGridViewTextBoxColumn
            // 
            this.buildingAgeDataGridViewTextBoxColumn.DataPropertyName = "BuildingAge";
            this.buildingAgeDataGridViewTextBoxColumn.HeaderText = "BuildingAge";
            this.buildingAgeDataGridViewTextBoxColumn.Name = "buildingAgeDataGridViewTextBoxColumn";
            // 
            // flrLocationDataGridViewTextBoxColumn
            // 
            this.flrLocationDataGridViewTextBoxColumn.DataPropertyName = "FlrLocation";
            this.flrLocationDataGridViewTextBoxColumn.HeaderText = "FlrLocation";
            this.flrLocationDataGridViewTextBoxColumn.Name = "flrLocationDataGridViewTextBoxColumn";
            // 
            // numberOfFlrDataGridViewTextBoxColumn
            // 
            this.numberOfFlrDataGridViewTextBoxColumn.DataPropertyName = "NumberOfFlr";
            this.numberOfFlrDataGridViewTextBoxColumn.HeaderText = "NumberOfFlr";
            this.numberOfFlrDataGridViewTextBoxColumn.Name = "numberOfFlrDataGridViewTextBoxColumn";
            // 
            // doorNumberDataGridViewTextBoxColumn
            // 
            this.doorNumberDataGridViewTextBoxColumn.DataPropertyName = "DoorNumber";
            this.doorNumberDataGridViewTextBoxColumn.HeaderText = "DoorNumber";
            this.doorNumberDataGridViewTextBoxColumn.Name = "doorNumberDataGridViewTextBoxColumn";
            // 
            // furnishedDataGridViewTextBoxColumn
            // 
            this.furnishedDataGridViewTextBoxColumn.DataPropertyName = "Furnished";
            this.furnishedDataGridViewTextBoxColumn.HeaderText = "Furnished";
            this.furnishedDataGridViewTextBoxColumn.Name = "furnishedDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // sellerNameDataGridViewTextBoxColumn
            // 
            this.sellerNameDataGridViewTextBoxColumn.DataPropertyName = "SellerName";
            this.sellerNameDataGridViewTextBoxColumn.HeaderText = "SellerName";
            this.sellerNameDataGridViewTextBoxColumn.Name = "sellerNameDataGridViewTextBoxColumn";
            // 
            // sellerTelNoDataGridViewTextBoxColumn
            // 
            this.sellerTelNoDataGridViewTextBoxColumn.DataPropertyName = "SellerTelNo";
            this.sellerTelNoDataGridViewTextBoxColumn.HeaderText = "SellerTelNo";
            this.sellerTelNoDataGridViewTextBoxColumn.Name = "sellerTelNoDataGridViewTextBoxColumn";
            // 
            // sellerIDDataGridViewTextBoxColumn
            // 
            this.sellerIDDataGridViewTextBoxColumn.DataPropertyName = "SellerID";
            this.sellerIDDataGridViewTextBoxColumn.HeaderText = "SellerID";
            this.sellerIDDataGridViewTextBoxColumn.Name = "sellerIDDataGridViewTextBoxColumn";
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            // 
            // addsectionBindingSource
            // 
            this.addsectionBindingSource.DataMember = "addsection";
            this.addsectionBindingSource.DataSource = this.realEstateDataSet1;
            // 
            // realEstateDataSet1
            // 
            this.realEstateDataSet1.DataSetName = "RealEstateDataSet1";
            this.realEstateDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addsectionTableAdapter
            // 
            this.addsectionTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(185, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(597, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 40);
            this.button4.TabIndex = 35;
            this.button4.Text = "Listele\r\n";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button3;
            this.ClientSize = new System.Drawing.Size(807, 609);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.maskedID);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.maskedTelNo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtSName);
            this.Controls.Add(this.RtbNotes);
            this.Controls.Add(this.RtbAdress);
            this.Controls.Add(this.CmbFurnished);
            this.Controls.Add(this.TxtDoorNo);
            this.Controls.Add(this.TxtNoFlr);
            this.Controls.Add(this.TxtFlrLoca);
            this.Controls.Add(this.TxtBAge);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.CmbRooms);
            this.Controls.Add(this.TxtSqrMt);
            this.Controls.Add(this.CmbHType);
            this.Controls.Add(this.CmbType);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ev Ekleme";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addsectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CmbHType;
        private System.Windows.Forms.ComboBox CmbRooms;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.TextBox TxtBAge;
        private System.Windows.Forms.TextBox TxtFlrLoca;
        private System.Windows.Forms.TextBox TxtNoFlr;
        private System.Windows.Forms.TextBox TxtDoorNo;
        private System.Windows.Forms.ComboBox CmbFurnished;
        private System.Windows.Forms.RichTextBox RtbAdress;
        private System.Windows.Forms.RichTextBox RtbNotes;
        private System.Windows.Forms.TextBox TxtSName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox maskedTelNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BtnAdd;
        private RealEstateDataSetTableAdapters.addsectionTableAdapter addsectionTableAdapter1;
        public System.Windows.Forms.MaskedTextBox maskedID;
        private System.Windows.Forms.ComboBox CmbType;
        private System.Windows.Forms.TextBox TxtSqrMt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RealEstateDataSet1 realEstateDataSet1;
        private System.Windows.Forms.BindingSource addsectionBindingSource;
        private RealEstateDataSet1TableAdapters.addsectionTableAdapter addsectionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sqrMetersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flrLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfFlrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn furnishedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerTelNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}