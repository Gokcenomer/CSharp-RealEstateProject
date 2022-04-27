
namespace RealEstateProject
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
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
            this.realEstateDataSet2 = new RealEstateProject.RealEstateDataSet2();
            this.realEstateDataSet = new RealEstateProject.RealEstateDataSet();
            this.realEstateDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addsectionTableAdapter = new RealEstateProject.RealEstateDataSet2TableAdapters.addsectionTableAdapter();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtSName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addsectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(850, 283);
            this.dataGridView1.TabIndex = 0;
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
            this.addsectionBindingSource.DataSource = this.realEstateDataSet2;
            // 
            // realEstateDataSet2
            // 
            this.realEstateDataSet2.DataSetName = "RealEstateDataSet2";
            this.realEstateDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // realEstateDataSet
            // 
            this.realEstateDataSet.DataSetName = "RealEstateDataSet";
            this.realEstateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // realEstateDataSetBindingSource
            // 
            this.realEstateDataSetBindingSource.DataSource = this.realEstateDataSet;
            this.realEstateDataSetBindingSource.Position = 0;
            // 
            // addsectionTableAdapter
            // 
            this.addsectionTableAdapter.ClearBeforeFill = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(24, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 19);
            this.label13.TabIndex = 31;
            this.label13.Text = "Satıcı İsmine Göre Arama";
            // 
            // TxtSName
            // 
            this.TxtSName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSName.Location = new System.Drawing.Point(209, 33);
            this.TxtSName.Name = "TxtSName";
            this.TxtSName.Size = new System.Drawing.Size(121, 27);
            this.TxtSName.TabIndex = 29;
            this.TxtSName.TextChanged += new System.EventHandler(this.TxtSName_TextChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 374);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TxtSName);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listeleme Bölümü";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addsectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realEstateDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource realEstateDataSetBindingSource;
        private RealEstateDataSet realEstateDataSet;
        private RealEstateDataSet2 realEstateDataSet2;
        private System.Windows.Forms.BindingSource addsectionBindingSource;
        private RealEstateDataSet2TableAdapters.addsectionTableAdapter addsectionTableAdapter;
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtSName;
    }
}