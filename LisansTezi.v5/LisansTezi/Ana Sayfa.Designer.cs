namespace LisansTezi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.kategoriler = new MetroFramework.Controls.MetroTile();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomDataGrid1 = new ns1.BunifuCustomDataGrid();
            this.metroCheckBox6 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox5 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox4 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.projedüzenle = new MetroFramework.Controls.MetroTile();
            this.görevlerim = new MetroFramework.Controls.MetroTile();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuCards4 = new ns1.BunifuCards();
            this.label7 = new ns1.BunifuCustomLabel();
            this.bunifuCards3 = new ns1.BunifuCards();
            this.label6 = new ns1.BunifuCustomLabel();
            this.bunifuCards2 = new ns1.BunifuCards();
            this.label5 = new ns1.BunifuCustomLabel();
            this.bunifuRating1 = new ns1.BunifuRating();
            this.bunifuCards1 = new ns1.BunifuCards();
            this.label4 = new ns1.BunifuCustomLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tezDataSet = new LisansTezi.tezDataSet();
            this.tblprojeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_projeTableAdapter = new LisansTezi.tezDataSetTableAdapters.tbl_projeTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.panel3.SuspendLayout();
            this.bunifuCards4.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tezDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblprojeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gunaControlBox2.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox2.IconSize = 15F;
            this.gunaControlBox2.Location = new System.Drawing.Point(1329, 0);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(44, 30);
            this.gunaControlBox2.TabIndex = 1;
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
            this.gunaControlBox1.Location = new System.Drawing.Point(1278, 1);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 2;
            // 
            // kategoriler
            // 
            this.kategoriler.BackColor = System.Drawing.Color.Transparent;
            this.kategoriler.Location = new System.Drawing.Point(245, 9);
            this.kategoriler.Name = "kategoriler";
            this.kategoriler.Size = new System.Drawing.Size(179, 117);
            this.kategoriler.TabIndex = 3;
            this.kategoriler.Text = "KATEGORİLER";
            this.kategoriler.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.kategoriler.TileImage = ((System.Drawing.Image)(resources.GetObject("kategoriler.TileImage")));
            this.kategoriler.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kategoriler.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.kategoriler.UseTileImage = true;
            this.kategoriler.Click += new System.EventHandler(this.kategoriler_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDay);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblSecond);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.metroTextBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 624);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 31);
            this.label1.TabIndex = 34;
            this.label1.Text = "ARA:";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.Black;
            this.lblDay.Location = new System.Drawing.Point(80, 591);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(107, 33);
            this.lblDay.TabIndex = 33;
            this.lblDay.Text = "PAZAR";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(16, 544);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(242, 39);
            this.lblDate.TabIndex = 32;
            this.lblDate.Text = "19 NİSAN 2020";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.ForeColor = System.Drawing.Color.Black;
            this.lblSecond.Location = new System.Drawing.Point(176, 503);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(41, 31);
            this.lblSecond.TabIndex = 31;
            this.lblSecond.Text = "22";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(41, 481);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(147, 57);
            this.lblTime.TabIndex = 30;
            this.lblTime.Text = "22:22";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.metroTextBox1.Location = new System.Drawing.Point(62, 188);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PromptText = "ARA";
            this.metroTextBox1.Size = new System.Drawing.Size(171, 25);
            this.metroTextBox1.TabIndex = 29;
            this.metroTextBox1.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            this.metroTextBox1.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1419, 223);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 20);
            this.textBox2.TabIndex = 30;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.bunifuCustomDataGrid1);
            this.panel2.Location = new System.Drawing.Point(245, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 480);
            this.panel2.TabIndex = 27;
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.DimGray;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn9});
            this.bunifuCustomDataGrid1.DataSource = this.tblprojeBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.Color.Black;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(881, 480);
            this.bunifuCustomDataGrid1.TabIndex = 54;
            // 
            // metroCheckBox6
            // 
            this.metroCheckBox6.AutoSize = true;
            this.metroCheckBox6.Location = new System.Drawing.Point(988, 132);
            this.metroCheckBox6.Name = "metroCheckBox6";
            this.metroCheckBox6.Size = new System.Drawing.Size(104, 15);
            this.metroCheckBox6.TabIndex = 60;
            this.metroCheckBox6.Text = "Tamamlananlar";
            this.metroCheckBox6.UseVisualStyleBackColor = true;
            this.metroCheckBox6.CheckedChanged += new System.EventHandler(this.metroCheckBox6_CheckedChanged);
            // 
            // metroCheckBox5
            // 
            this.metroCheckBox5.AutoSize = true;
            this.metroCheckBox5.Location = new System.Drawing.Point(846, 132);
            this.metroCheckBox5.Name = "metroCheckBox5";
            this.metroCheckBox5.Size = new System.Drawing.Size(94, 15);
            this.metroCheckBox5.TabIndex = 59;
            this.metroCheckBox5.Text = "İptal Edilenler";
            this.metroCheckBox5.UseVisualStyleBackColor = true;
            this.metroCheckBox5.CheckedChanged += new System.EventHandler(this.metroCheckBox5_CheckedChanged);
            // 
            // metroCheckBox4
            // 
            this.metroCheckBox4.AutoSize = true;
            this.metroCheckBox4.Location = new System.Drawing.Point(719, 132);
            this.metroCheckBox4.Name = "metroCheckBox4";
            this.metroCheckBox4.Size = new System.Drawing.Size(107, 15);
            this.metroCheckBox4.TabIndex = 58;
            this.metroCheckBox4.Text = "Askıya Alınanlar";
            this.metroCheckBox4.UseVisualStyleBackColor = true;
            this.metroCheckBox4.CheckedChanged += new System.EventHandler(this.metroCheckBox4_CheckedChanged);
            // 
            // metroCheckBox3
            // 
            this.metroCheckBox3.AutoSize = true;
            this.metroCheckBox3.Location = new System.Drawing.Point(572, 132);
            this.metroCheckBox3.Name = "metroCheckBox3";
            this.metroCheckBox3.Size = new System.Drawing.Size(93, 15);
            this.metroCheckBox3.TabIndex = 57;
            this.metroCheckBox3.Text = "Onaylananlar";
            this.metroCheckBox3.UseVisualStyleBackColor = true;
            this.metroCheckBox3.CheckedChanged += new System.EventHandler(this.metroCheckBox3_CheckedChanged);
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.Location = new System.Drawing.Point(398, 132);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(151, 15);
            this.metroCheckBox2.TabIndex = 56;
            this.metroCheckBox2.Text = "Hazırlık Aşamasındakiler";
            this.metroCheckBox2.UseVisualStyleBackColor = true;
            this.metroCheckBox2.CheckedChanged += new System.EventHandler(this.metroCheckBox2_CheckedChanged);
            this.metroCheckBox2.Click += new System.EventHandler(this.metroCheckBox2_Click);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(254, 132);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(94, 15);
            this.metroCheckBox1.TabIndex = 55;
            this.metroCheckBox1.Text = "Tüm Görevler";
            this.metroCheckBox1.UseVisualStyleBackColor = true;
            this.metroCheckBox1.CheckedChanged += new System.EventHandler(this.metroCheckBox1_CheckedChanged);
            // 
            // projedüzenle
            // 
            this.projedüzenle.BackColor = System.Drawing.Color.Transparent;
            this.projedüzenle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.projedüzenle.Location = new System.Drawing.Point(477, 9);
            this.projedüzenle.Name = "projedüzenle";
            this.projedüzenle.Size = new System.Drawing.Size(179, 117);
            this.projedüzenle.Style = MetroFramework.MetroColorStyle.Lime;
            this.projedüzenle.TabIndex = 30;
            this.projedüzenle.Text = "PROJE DÜZENLE";
            this.projedüzenle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.projedüzenle.TileImage = ((System.Drawing.Image)(resources.GetObject("projedüzenle.TileImage")));
            this.projedüzenle.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.projedüzenle.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.projedüzenle.UseTileImage = true;
            this.projedüzenle.Click += new System.EventHandler(this.projedüzenle_Click);
            // 
            // görevlerim
            // 
            this.görevlerim.BackColor = System.Drawing.Color.Transparent;
            this.görevlerim.Location = new System.Drawing.Point(708, 9);
            this.görevlerim.Name = "görevlerim";
            this.görevlerim.Size = new System.Drawing.Size(179, 117);
            this.görevlerim.Style = MetroFramework.MetroColorStyle.Silver;
            this.görevlerim.TabIndex = 31;
            this.görevlerim.Text = "İŞ PAKETLERİ";
            this.görevlerim.TileImage = ((System.Drawing.Image)(resources.GetObject("görevlerim.TileImage")));
            this.görevlerim.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.görevlerim.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.görevlerim.UseTileImage = true;
            this.görevlerim.Click += new System.EventHandler(this.görevlerim_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bunifuCards4);
            this.panel3.Controls.Add(this.bunifuCards3);
            this.panel3.Controls.Add(this.bunifuCards2);
            this.panel3.Controls.Add(this.bunifuRating1);
            this.panel3.Controls.Add(this.bunifuCards1);
            this.panel3.Location = new System.Drawing.Point(1132, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 589);
            this.panel3.TabIndex = 32;
            // 
            // bunifuCards4
            // 
            this.bunifuCards4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCards4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCards4.BackgroundImage")));
            this.bunifuCards4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuCards4.BorderRadius = 5;
            this.bunifuCards4.BottomSahddow = false;
            this.bunifuCards4.color = System.Drawing.Color.Snow;
            this.bunifuCards4.Controls.Add(this.label7);
            this.bunifuCards4.LeftSahddow = false;
            this.bunifuCards4.Location = new System.Drawing.Point(6, 461);
            this.bunifuCards4.Name = "bunifuCards4";
            this.bunifuCards4.RightSahddow = false;
            this.bunifuCards4.ShadowDepth = 0;
            this.bunifuCards4.Size = new System.Drawing.Size(233, 125);
            this.bunifuCards4.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 21);
            this.label7.TabIndex = 10;
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCards3.BackgroundImage")));
            this.bunifuCards3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = false;
            this.bunifuCards3.color = System.Drawing.Color.Snow;
            this.bunifuCards3.Controls.Add(this.label6);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(6, 324);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(233, 131);
            this.bunifuCards3.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 21);
            this.label6.TabIndex = 10;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCards2.BackgroundImage")));
            this.bunifuCards2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = false;
            this.bunifuCards2.color = System.Drawing.Color.Snow;
            this.bunifuCards2.Controls.Add(this.label5);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(3, 187);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(233, 131);
            this.bunifuCards2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 10;
            // 
            // bunifuRating1
            // 
            this.bunifuRating1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRating1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuRating1.Location = new System.Drawing.Point(3, 3);
            this.bunifuRating1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuRating1.Name = "bunifuRating1";
            this.bunifuRating1.Size = new System.Drawing.Size(227, 35);
            this.bunifuRating1.TabIndex = 1;
            this.bunifuRating1.Value = 0;
            this.bunifuRating1.onValueChanged += new System.EventHandler(this.bunifuRating1_onValueChanged);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCards1.BackgroundImage")));
            this.bunifuCards1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = false;
            this.bunifuCards1.color = System.Drawing.Color.Snow;
            this.bunifuCards1.Controls.Add(this.label4);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(3, 50);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(233, 131);
            this.bunifuCards1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1230, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 29);
            this.button1.TabIndex = 33;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1419, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 20);
            this.textBox1.TabIndex = 34;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // metroTile1
            // 
            this.metroTile1.BackColor = System.Drawing.Color.Transparent;
            this.metroTile1.Location = new System.Drawing.Point(935, 9);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(179, 117);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 35;
            this.metroTile1.Text = "İŞLERİM";
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1546, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 36;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1568, 304);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // tezDataSet
            // 
            this.tezDataSet.DataSetName = "tezDataSet";
            this.tezDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblprojeBindingSource
            // 
            this.tblprojeBindingSource.DataMember = "tbl_proje";
            this.tblprojeBindingSource.DataSource = this.tezDataSet;
            // 
            // tbl_projeTableAdapter
            // 
            this.tbl_projeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Proje Kodu";
            this.dataGridViewTextBoxColumn1.HeaderText = "Proje Kodu";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Proje Adı";
            this.dataGridViewTextBoxColumn2.HeaderText = "Proje Adı";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "kategoriid";
            this.dataGridViewTextBoxColumn3.HeaderText = "kategoriid";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Başlangıç";
            this.dataGridViewTextBoxColumn4.HeaderText = "Başlangıç";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Bitiş";
            this.dataGridViewTextBoxColumn5.HeaderText = "Bitiş";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Durum";
            this.dataGridViewTextBoxColumn6.HeaderText = "Durum";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Önem";
            this.dataGridViewTextBoxColumn7.HeaderText = "Önem";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "kalan gün";
            this.dataGridViewTextBoxColumn8.HeaderText = "kalan gün";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "bit";
            this.dataGridViewCheckBoxColumn1.HeaderText = "bit";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ispaketiıd";
            this.dataGridViewTextBoxColumn9.HeaderText = "ispaketiıd";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(1373, 626);
            this.Controls.Add(this.metroCheckBox6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.metroCheckBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.metroCheckBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.metroCheckBox3);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.metroCheckBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.görevlerim);
            this.Controls.Add(this.projedüzenle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kategoriler);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.gunaControlBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1373, 626);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.bunifuCards4.ResumeLayout(false);
            this.bunifuCards4.PerformLayout();
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tezDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblprojeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private MetroFramework.Controls.MetroTile kategoriler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTile projedüzenle;
        private MetroFramework.Controls.MetroTile görevlerim;
        private System.Windows.Forms.Panel panel3;
        private ns1.BunifuCustomDataGrid bunifuCustomDataGrid1;
       // private lisansteziDataSet20TableAdapters.tbl_projeTableAdapter tbl_projeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn projeKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projeAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn başlangıçDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitişDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn önemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalanGünDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bitDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ispaketiıdDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private ns1.BunifuCards bunifuCards4;
        private ns1.BunifuCards bunifuCards3;
        private ns1.BunifuCards bunifuCards2;
        private ns1.BunifuRating bunifuRating1;
        private ns1.BunifuCards bunifuCards1;
        private System.Windows.Forms.Button button1;
        private ns1.BunifuCustomLabel label7;
        private ns1.BunifuCustomLabel label6;
        private ns1.BunifuCustomLabel label5;
        private ns1.BunifuCustomLabel label4;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox6;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox5;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox4;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox3;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private tezDataSet tezDataSet;
        private System.Windows.Forms.BindingSource tblprojeBindingSource;
        private tezDataSetTableAdapters.tbl_projeTableAdapter tbl_projeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}

