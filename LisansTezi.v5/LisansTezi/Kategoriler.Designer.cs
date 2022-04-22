namespace LisansTezi
{
    partial class Kategoriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kategoriler));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.btngüncelle = new ns1.BunifuFlatButton();
            this.btnsil = new ns1.BunifuFlatButton();
            this.btnkategoriekle = new ns1.BunifuFlatButton();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.bunifuCustomDataGrid2 = new ns1.BunifuCustomDataGrid();
            this.labelıd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tblkategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tezDataSet1 = new LisansTezi.tezDataSet1();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbl_kategoriTableAdapter1 = new LisansTezi.tezDataSet1TableAdapters.tbl_kategoriTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblkategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tezDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategoriler:";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(326, 45);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PromptText = "Kategori Ekle";
            this.metroTextBox1.Size = new System.Drawing.Size(232, 23);
            this.metroTextBox1.TabIndex = 2;
            // 
            // btngüncelle
            // 
            this.btngüncelle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btngüncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btngüncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btngüncelle.BorderRadius = 0;
            this.btngüncelle.ButtonText = "              Güncelle";
            this.btngüncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngüncelle.DisabledColor = System.Drawing.Color.Gray;
            this.btngüncelle.Iconcolor = System.Drawing.Color.Transparent;
            this.btngüncelle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btngüncelle.Iconimage")));
            this.btngüncelle.Iconimage_right = null;
            this.btngüncelle.Iconimage_right_Selected = null;
            this.btngüncelle.Iconimage_Selected = null;
            this.btngüncelle.IconMarginLeft = 0;
            this.btngüncelle.IconMarginRight = 0;
            this.btngüncelle.IconRightVisible = true;
            this.btngüncelle.IconRightZoom = 0D;
            this.btngüncelle.IconVisible = true;
            this.btngüncelle.IconZoom = 90D;
            this.btngüncelle.IsTab = false;
            this.btngüncelle.Location = new System.Drawing.Point(385, 86);
            this.btngüncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btngüncelle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btngüncelle.OnHoverTextColor = System.Drawing.Color.White;
            this.btngüncelle.selected = false;
            this.btngüncelle.Size = new System.Drawing.Size(173, 48);
            this.btngüncelle.TabIndex = 46;
            this.btngüncelle.Text = "              Güncelle";
            this.btngüncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btngüncelle.Textcolor = System.Drawing.Color.White;
            this.btngüncelle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnsil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnsil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsil.BorderRadius = 0;
            this.btnsil.ButtonText = "              Sil";
            this.btnsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsil.DisabledColor = System.Drawing.Color.Gray;
            this.btnsil.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsil.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnsil.Iconimage")));
            this.btnsil.Iconimage_right = null;
            this.btnsil.Iconimage_right_Selected = null;
            this.btnsil.Iconimage_Selected = null;
            this.btnsil.IconMarginLeft = 0;
            this.btnsil.IconMarginRight = 0;
            this.btnsil.IconRightVisible = true;
            this.btnsil.IconRightZoom = 0D;
            this.btnsil.IconVisible = true;
            this.btnsil.IconZoom = 90D;
            this.btnsil.IsTab = false;
            this.btnsil.Location = new System.Drawing.Point(200, 86);
            this.btnsil.Margin = new System.Windows.Forms.Padding(4);
            this.btnsil.Name = "btnsil";
            this.btnsil.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnsil.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnsil.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsil.selected = false;
            this.btnsil.Size = new System.Drawing.Size(159, 48);
            this.btnsil.TabIndex = 45;
            this.btnsil.Text = "              Sil";
            this.btnsil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsil.Textcolor = System.Drawing.Color.White;
            this.btnsil.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkategoriekle
            // 
            this.btnkategoriekle.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnkategoriekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnkategoriekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnkategoriekle.BorderRadius = 0;
            this.btnkategoriekle.ButtonText = "               Kategori ekle";
            this.btnkategoriekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkategoriekle.DisabledColor = System.Drawing.Color.Gray;
            this.btnkategoriekle.Iconcolor = System.Drawing.Color.Transparent;
            this.btnkategoriekle.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnkategoriekle.Iconimage")));
            this.btnkategoriekle.Iconimage_right = null;
            this.btnkategoriekle.Iconimage_right_Selected = null;
            this.btnkategoriekle.Iconimage_Selected = null;
            this.btnkategoriekle.IconMarginLeft = 0;
            this.btnkategoriekle.IconMarginRight = 0;
            this.btnkategoriekle.IconRightVisible = true;
            this.btnkategoriekle.IconRightZoom = 0D;
            this.btnkategoriekle.IconVisible = true;
            this.btnkategoriekle.IconZoom = 90D;
            this.btnkategoriekle.IsTab = false;
            this.btnkategoriekle.Location = new System.Drawing.Point(16, 86);
            this.btnkategoriekle.Margin = new System.Windows.Forms.Padding(4);
            this.btnkategoriekle.Name = "btnkategoriekle";
            this.btnkategoriekle.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnkategoriekle.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnkategoriekle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnkategoriekle.selected = false;
            this.btnkategoriekle.Size = new System.Drawing.Size(156, 48);
            this.btnkategoriekle.TabIndex = 44;
            this.btnkategoriekle.Text = "               Kategori ekle";
            this.btnkategoriekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkategoriekle.Textcolor = System.Drawing.Color.White;
            this.btnkategoriekle.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkategoriekle.Click += new System.EventHandler(this.btnkategoriekle_Click);
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gunaControlBox1.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(557, 3);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 48;
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(608, 2);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(44, 30);
            this.gunaControlBox2.TabIndex = 47;
            // 
            // bunifuCustomDataGrid2
            // 
            this.bunifuCustomDataGrid2.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid2.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.bunifuCustomDataGrid2.DataSource = this.tblkategoriBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid2.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomDataGrid2.DoubleBuffered = true;
            this.bunifuCustomDataGrid2.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid2.GridColor = System.Drawing.Color.Black;
            this.bunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.ReadOnly = true;
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(652, 218);
            this.bunifuCustomDataGrid2.TabIndex = 50;
            this.bunifuCustomDataGrid2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid2_CellClick);
            this.bunifuCustomDataGrid2.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid2_CellEnter);
            // 
            // labelıd
            // 
            this.labelıd.AutoSize = true;
            this.labelıd.Location = new System.Drawing.Point(1463, 135);
            this.labelıd.Name = "labelıd";
            this.labelıd.Size = new System.Drawing.Size(37, 13);
            this.labelıd.TabIndex = 51;
            this.labelıd.Text = "labelıd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1463, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCustomDataGrid2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(652, 218);
            this.panel1.TabIndex = 55;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.tblkategoriBindingSource;
            this.comboBox2.DisplayMember = "Kategori";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(129, 42);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(179, 21);
            this.comboBox2.TabIndex = 56;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // tblkategoriBindingSource
            // 
            this.tblkategoriBindingSource.DataMember = "tbl_kategori";
            this.tblkategoriBindingSource.DataSource = this.tezDataSet1;
            // 
            // tezDataSet1
            // 
            this.tezDataSet1.DataSetName = "tezDataSet1";
            this.tezDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1076, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(30, 27);
            this.dataGridView1.TabIndex = 57;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(916, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbl_kategoriTableAdapter1
            // 
            this.tbl_kategoriTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "kategoriıd";
            this.dataGridViewTextBoxColumn1.HeaderText = "kategoriıd";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Kategori";
            this.dataGridViewTextBoxColumn2.HeaderText = "Kategori";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Kategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(652, 393);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelıd);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.gunaControlBox2);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnkategoriekle);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kategoriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategoriler";
            this.Load += new System.EventHandler(this.Kategoriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblkategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tezDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private ns1.BunifuFlatButton btngüncelle;
        private ns1.BunifuFlatButton btnsil;
        private ns1.BunifuFlatButton btnkategoriekle;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private ns1.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private System.Windows.Forms.Label labelıd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
       // private tez_v2DataSet3 tez_v2DataSet3;
       // private tez_v2DataSet3TableAdapters.tbl_kategoriTableAdapter tbl_kategoriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
       // private lisansteziDataSet22TableAdapters.tbl_projeTableAdapter tbl_projeTableAdapter;
       // private lisansteziDataSet22 lisansteziDataSet22;
        private tezDataSet1 tezDataSet1;
        private System.Windows.Forms.BindingSource tblkategoriBindingSource;
        private tezDataSet1TableAdapters.tbl_kategoriTableAdapter tbl_kategoriTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}