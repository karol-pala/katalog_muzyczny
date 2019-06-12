namespace Katalog_Muzyczny
{
    partial class Form1
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.msiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.msiView = new System.Windows.Forms.ToolStripMenuItem();
            this.msiCosts = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAddAlbum = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.tbFormat = new System.Windows.Forms.ComboBox();
            this.tbStyle = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddAlbum = new System.Windows.Forms.Button();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.tbLabel = new System.Windows.Forms.TextBox();
            this.tbAlbumArtist = new System.Windows.Forms.TextBox();
            this.tbAlbumName = new System.Windows.Forms.TextBox();
            this.gbShortAlbumList = new System.Windows.Forms.GroupBox();
            this.dgvShortAlbumList = new System.Windows.Forms.DataGridView();
            this.gbEditAlbum = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbEditCost = new System.Windows.Forms.TextBox();
            this.tbEditFormat = new System.Windows.Forms.ComboBox();
            this.tbEditStyle = new System.Windows.Forms.ComboBox();
            this.btnDeleteAlbum = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnEditAlbum = new System.Windows.Forms.Button();
            this.tbEditCountry = new System.Windows.Forms.TextBox();
            this.tbEditYear = new System.Windows.Forms.TextBox();
            this.tbEditLabel = new System.Windows.Forms.TextBox();
            this.tbEditArtist = new System.Windows.Forms.TextBox();
            this.tbEditName = new System.Windows.Forms.TextBox();
            this.gbAlbumList = new System.Windows.Forms.GroupBox();
            this.dgvAlbumList = new System.Windows.Forms.DataGridView();
            this.gbFiltres = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.gbCosts = new System.Windows.Forms.GroupBox();
            this.lblCostResult = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnCountMiddleCost = new System.Windows.Forms.Button();
            this.cbCostSearch = new System.Windows.Forms.ComboBox();
            this.tbCostSearch = new System.Windows.Forms.TextBox();
            this.btnShowAllCost = new System.Windows.Forms.Button();
            this.msMenu.SuspendLayout();
            this.gbAddAlbum.SuspendLayout();
            this.gbShortAlbumList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShortAlbumList)).BeginInit();
            this.gbEditAlbum.SuspendLayout();
            this.gbAlbumList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumList)).BeginInit();
            this.gbFiltres.SuspendLayout();
            this.gbCosts.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiAdd,
            this.msiView,
            this.msiCosts});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(951, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "Menu";
            // 
            // msiAdd
            // 
            this.msiAdd.Name = "msiAdd";
            this.msiAdd.Size = new System.Drawing.Size(87, 20);
            this.msiAdd.Text = "Dodaj album";
            this.msiAdd.Click += new System.EventHandler(this.msiAdd_Click);
            // 
            // msiView
            // 
            this.msiView.Name = "msiView";
            this.msiView.Size = new System.Drawing.Size(63, 20);
            this.msiView.Text = "Podgląd";
            this.msiView.Click += new System.EventHandler(this.msiView_Click);
            // 
            // msiCosts
            // 
            this.msiCosts.Name = "msiCosts";
            this.msiCosts.Size = new System.Drawing.Size(46, 20);
            this.msiCosts.Text = "Ceny";
            this.msiCosts.Click += new System.EventHandler(this.msiCosts_Click);
            // 
            // gbAddAlbum
            // 
            this.gbAddAlbum.Controls.Add(this.label16);
            this.gbAddAlbum.Controls.Add(this.tbCost);
            this.gbAddAlbum.Controls.Add(this.tbFormat);
            this.gbAddAlbum.Controls.Add(this.tbStyle);
            this.gbAddAlbum.Controls.Add(this.label7);
            this.gbAddAlbum.Controls.Add(this.label6);
            this.gbAddAlbum.Controls.Add(this.label5);
            this.gbAddAlbum.Controls.Add(this.label4);
            this.gbAddAlbum.Controls.Add(this.label3);
            this.gbAddAlbum.Controls.Add(this.label2);
            this.gbAddAlbum.Controls.Add(this.label1);
            this.gbAddAlbum.Controls.Add(this.btnAddAlbum);
            this.gbAddAlbum.Controls.Add(this.tbCountry);
            this.gbAddAlbum.Controls.Add(this.tbYear);
            this.gbAddAlbum.Controls.Add(this.tbLabel);
            this.gbAddAlbum.Controls.Add(this.tbAlbumArtist);
            this.gbAddAlbum.Controls.Add(this.tbAlbumName);
            this.gbAddAlbum.Location = new System.Drawing.Point(13, 28);
            this.gbAddAlbum.Name = "gbAddAlbum";
            this.gbAddAlbum.Size = new System.Drawing.Size(494, 389);
            this.gbAddAlbum.TabIndex = 1;
            this.gbAddAlbum.TabStop = false;
            this.gbAddAlbum.Text = "Dodaj Album";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 284);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Cena";
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(143, 281);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(179, 20);
            this.tbCost.TabIndex = 7;
            // 
            // tbFormat
            // 
            this.tbFormat.FormattingEnabled = true;
            this.tbFormat.Items.AddRange(new object[] {
            "Winyl",
            "Kaseta",
            "CD",
            "DVD",
            "VHS",
            "Cyfrowy"});
            this.tbFormat.Location = new System.Drawing.Point(143, 200);
            this.tbFormat.Name = "tbFormat";
            this.tbFormat.Size = new System.Drawing.Size(180, 21);
            this.tbFormat.TabIndex = 4;
            // 
            // tbStyle
            // 
            this.tbStyle.FormattingEnabled = true;
            this.tbStyle.Items.AddRange(new object[] {
            "Rock",
            "Electronic",
            "Pop",
            "Folk, World & Country",
            "Jazz",
            "Funk / Soul",
            "Classical",
            "Hip Hop",
            "Latin",
            "Reggae",
            "Stage & Screen",
            "Blues"});
            this.tbStyle.Location = new System.Drawing.Point(142, 145);
            this.tbStyle.Name = "tbStyle";
            this.tbStyle.Size = new System.Drawing.Size(180, 21);
            this.tbStyle.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Kraj";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rok wydania";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nośnik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Wydawnictwo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Styl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Artysta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nazwa albumu";
            // 
            // btnAddAlbum
            // 
            this.btnAddAlbum.Location = new System.Drawing.Point(143, 332);
            this.btnAddAlbum.Name = "btnAddAlbum";
            this.btnAddAlbum.Size = new System.Drawing.Size(180, 23);
            this.btnAddAlbum.TabIndex = 8;
            this.btnAddAlbum.Text = "Dodaj";
            this.btnAddAlbum.UseVisualStyleBackColor = true;
            this.btnAddAlbum.Click += new System.EventHandler(this.btnAddAlbum_Click);
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(143, 254);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(180, 20);
            this.tbCountry.TabIndex = 6;
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(143, 227);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(180, 20);
            this.tbYear.TabIndex = 5;
            // 
            // tbLabel
            // 
            this.tbLabel.Location = new System.Drawing.Point(143, 173);
            this.tbLabel.Name = "tbLabel";
            this.tbLabel.Size = new System.Drawing.Size(180, 20);
            this.tbLabel.TabIndex = 3;
            // 
            // tbAlbumArtist
            // 
            this.tbAlbumArtist.Location = new System.Drawing.Point(143, 119);
            this.tbAlbumArtist.Name = "tbAlbumArtist";
            this.tbAlbumArtist.Size = new System.Drawing.Size(180, 20);
            this.tbAlbumArtist.TabIndex = 1;
            // 
            // tbAlbumName
            // 
            this.tbAlbumName.Location = new System.Drawing.Point(143, 92);
            this.tbAlbumName.Name = "tbAlbumName";
            this.tbAlbumName.Size = new System.Drawing.Size(180, 20);
            this.tbAlbumName.TabIndex = 0;
            // 
            // gbShortAlbumList
            // 
            this.gbShortAlbumList.Controls.Add(this.dgvShortAlbumList);
            this.gbShortAlbumList.Location = new System.Drawing.Point(513, 27);
            this.gbShortAlbumList.Name = "gbShortAlbumList";
            this.gbShortAlbumList.Size = new System.Drawing.Size(426, 410);
            this.gbShortAlbumList.TabIndex = 2;
            this.gbShortAlbumList.TabStop = false;
            this.gbShortAlbumList.Text = "Lista Albumów";
            // 
            // dgvShortAlbumList
            // 
            this.dgvShortAlbumList.AllowUserToAddRows = false;
            this.dgvShortAlbumList.AllowUserToDeleteRows = false;
            this.dgvShortAlbumList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShortAlbumList.Location = new System.Drawing.Point(7, 20);
            this.dgvShortAlbumList.Name = "dgvShortAlbumList";
            this.dgvShortAlbumList.ReadOnly = true;
            this.dgvShortAlbumList.Size = new System.Drawing.Size(413, 384);
            this.dgvShortAlbumList.TabIndex = 0;
            this.dgvShortAlbumList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvShortAlbumList_RowHeaderMouseClick);
            this.dgvShortAlbumList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvShortAlbumList_RowHeaderMouseDoubleClick);
            // 
            // gbEditAlbum
            // 
            this.gbEditAlbum.Controls.Add(this.label17);
            this.gbEditAlbum.Controls.Add(this.tbEditCost);
            this.gbEditAlbum.Controls.Add(this.tbEditFormat);
            this.gbEditAlbum.Controls.Add(this.tbEditStyle);
            this.gbEditAlbum.Controls.Add(this.btnDeleteAlbum);
            this.gbEditAlbum.Controls.Add(this.label8);
            this.gbEditAlbum.Controls.Add(this.label9);
            this.gbEditAlbum.Controls.Add(this.label10);
            this.gbEditAlbum.Controls.Add(this.label11);
            this.gbEditAlbum.Controls.Add(this.label12);
            this.gbEditAlbum.Controls.Add(this.label13);
            this.gbEditAlbum.Controls.Add(this.label14);
            this.gbEditAlbum.Controls.Add(this.btnEditAlbum);
            this.gbEditAlbum.Controls.Add(this.tbEditCountry);
            this.gbEditAlbum.Controls.Add(this.tbEditYear);
            this.gbEditAlbum.Controls.Add(this.tbEditLabel);
            this.gbEditAlbum.Controls.Add(this.tbEditArtist);
            this.gbEditAlbum.Controls.Add(this.tbEditName);
            this.gbEditAlbum.Location = new System.Drawing.Point(12, 29);
            this.gbEditAlbum.Name = "gbEditAlbum";
            this.gbEditAlbum.Size = new System.Drawing.Size(495, 389);
            this.gbEditAlbum.TabIndex = 3;
            this.gbEditAlbum.TabStop = false;
            this.gbEditAlbum.Text = "Edytuj Album";
            this.gbEditAlbum.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 283);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Cena";
            // 
            // tbEditCost
            // 
            this.tbEditCost.Enabled = false;
            this.tbEditCost.Location = new System.Drawing.Point(144, 279);
            this.tbEditCost.Name = "tbEditCost";
            this.tbEditCost.Size = new System.Drawing.Size(179, 20);
            this.tbEditCost.TabIndex = 7;
            // 
            // tbEditFormat
            // 
            this.tbEditFormat.FormattingEnabled = true;
            this.tbEditFormat.Items.AddRange(new object[] {
            "Winyl",
            "Kaseta",
            "CD",
            "DVD",
            "CDV",
            "VHS",
            "Cyfrowy"});
            this.tbEditFormat.Location = new System.Drawing.Point(144, 198);
            this.tbEditFormat.Name = "tbEditFormat";
            this.tbEditFormat.Size = new System.Drawing.Size(180, 21);
            this.tbEditFormat.TabIndex = 4;
            // 
            // tbEditStyle
            // 
            this.tbEditStyle.FormattingEnabled = true;
            this.tbEditStyle.Items.AddRange(new object[] {
            "Rock",
            "Electronic",
            "Pop",
            "Folk, World & Country",
            "Jazz",
            "Funk / Soul",
            "Classical",
            "Hip Hop",
            "Latin",
            "Reggae",
            "Stage & Screen",
            "Blues"});
            this.tbEditStyle.Location = new System.Drawing.Point(143, 146);
            this.tbEditStyle.Name = "tbEditStyle";
            this.tbEditStyle.Size = new System.Drawing.Size(180, 21);
            this.tbEditStyle.TabIndex = 2;
            // 
            // btnDeleteAlbum
            // 
            this.btnDeleteAlbum.Enabled = false;
            this.btnDeleteAlbum.Location = new System.Drawing.Point(143, 362);
            this.btnDeleteAlbum.Name = "btnDeleteAlbum";
            this.btnDeleteAlbum.Size = new System.Drawing.Size(180, 23);
            this.btnDeleteAlbum.TabIndex = 15;
            this.btnDeleteAlbum.Text = "Usuń";
            this.btnDeleteAlbum.UseVisualStyleBackColor = true;
            this.btnDeleteAlbum.Click += new System.EventHandler(this.btnDeleteAlbum_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Kraj";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Rok wydania";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Nośnik";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Wydawnictwo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Styl";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Artysta";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Nazwa albumu";
            // 
            // btnEditAlbum
            // 
            this.btnEditAlbum.Enabled = false;
            this.btnEditAlbum.Location = new System.Drawing.Point(143, 332);
            this.btnEditAlbum.Name = "btnEditAlbum";
            this.btnEditAlbum.Size = new System.Drawing.Size(180, 23);
            this.btnEditAlbum.TabIndex = 8;
            this.btnEditAlbum.Text = "Edytuj";
            this.btnEditAlbum.UseVisualStyleBackColor = true;
            this.btnEditAlbum.Click += new System.EventHandler(this.btnEditAlbum_Click);
            // 
            // tbEditCountry
            // 
            this.tbEditCountry.Enabled = false;
            this.tbEditCountry.Location = new System.Drawing.Point(143, 254);
            this.tbEditCountry.Name = "tbEditCountry";
            this.tbEditCountry.Size = new System.Drawing.Size(180, 20);
            this.tbEditCountry.TabIndex = 6;
            // 
            // tbEditYear
            // 
            this.tbEditYear.Enabled = false;
            this.tbEditYear.Location = new System.Drawing.Point(143, 227);
            this.tbEditYear.Name = "tbEditYear";
            this.tbEditYear.Size = new System.Drawing.Size(180, 20);
            this.tbEditYear.TabIndex = 5;
            // 
            // tbEditLabel
            // 
            this.tbEditLabel.Enabled = false;
            this.tbEditLabel.Location = new System.Drawing.Point(143, 173);
            this.tbEditLabel.Name = "tbEditLabel";
            this.tbEditLabel.Size = new System.Drawing.Size(180, 20);
            this.tbEditLabel.TabIndex = 3;
            // 
            // tbEditArtist
            // 
            this.tbEditArtist.Enabled = false;
            this.tbEditArtist.Location = new System.Drawing.Point(143, 119);
            this.tbEditArtist.Name = "tbEditArtist";
            this.tbEditArtist.Size = new System.Drawing.Size(180, 20);
            this.tbEditArtist.TabIndex = 1;
            // 
            // tbEditName
            // 
            this.tbEditName.Enabled = false;
            this.tbEditName.Location = new System.Drawing.Point(143, 92);
            this.tbEditName.Name = "tbEditName";
            this.tbEditName.Size = new System.Drawing.Size(180, 20);
            this.tbEditName.TabIndex = 0;
            // 
            // gbAlbumList
            // 
            this.gbAlbumList.Controls.Add(this.dgvAlbumList);
            this.gbAlbumList.Location = new System.Drawing.Point(12, 29);
            this.gbAlbumList.Name = "gbAlbumList";
            this.gbAlbumList.Size = new System.Drawing.Size(927, 356);
            this.gbAlbumList.TabIndex = 4;
            this.gbAlbumList.TabStop = false;
            this.gbAlbumList.Text = "Lista albumów";
            this.gbAlbumList.Visible = false;
            // 
            // dgvAlbumList
            // 
            this.dgvAlbumList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbumList.Location = new System.Drawing.Point(8, 19);
            this.dgvAlbumList.Name = "dgvAlbumList";
            this.dgvAlbumList.Size = new System.Drawing.Size(913, 331);
            this.dgvAlbumList.TabIndex = 0;
            // 
            // gbFiltres
            // 
            this.gbFiltres.Controls.Add(this.btnShowAll);
            this.gbFiltres.Controls.Add(this.cbSearch);
            this.gbFiltres.Controls.Add(this.btnSearch);
            this.gbFiltres.Controls.Add(this.label15);
            this.gbFiltres.Controls.Add(this.tbSearch);
            this.gbFiltres.Location = new System.Drawing.Point(13, 385);
            this.gbFiltres.Name = "gbFiltres";
            this.gbFiltres.Size = new System.Drawing.Size(926, 53);
            this.gbFiltres.TabIndex = 5;
            this.gbFiltres.TabStop = false;
            this.gbFiltres.Text = "Filtry";
            this.gbFiltres.Visible = false;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(602, 17);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(132, 23);
            this.btnShowAll.TabIndex = 4;
            this.btnShowAll.Text = "Pokaż wszystkie";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Nazwa",
            "Artysta",
            "Styl",
            "Wydawnictwo",
            "Format",
            "Rok",
            "Kraj"});
            this.cbSearch.Location = new System.Drawing.Point(283, 19);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(156, 21);
            this.cbSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(445, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Szukaj";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Szukana fraza";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(142, 19);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(135, 20);
            this.tbSearch.TabIndex = 0;
            // 
            // gbCosts
            // 
            this.gbCosts.Controls.Add(this.btnShowAllCost);
            this.gbCosts.Controls.Add(this.lblCostResult);
            this.gbCosts.Controls.Add(this.label18);
            this.gbCosts.Controls.Add(this.btnCountMiddleCost);
            this.gbCosts.Controls.Add(this.cbCostSearch);
            this.gbCosts.Controls.Add(this.tbCostSearch);
            this.gbCosts.Location = new System.Drawing.Point(12, 389);
            this.gbCosts.Name = "gbCosts";
            this.gbCosts.Size = new System.Drawing.Size(891, 58);
            this.gbCosts.TabIndex = 6;
            this.gbCosts.TabStop = false;
            this.gbCosts.Text = "Ceny";
            this.gbCosts.Visible = false;
            // 
            // lblCostResult
            // 
            this.lblCostResult.AutoSize = true;
            this.lblCostResult.Location = new System.Drawing.Point(502, 28);
            this.lblCostResult.Name = "lblCostResult";
            this.lblCostResult.Size = new System.Drawing.Size(0, 13);
            this.lblCostResult.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(427, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Średni koszt:";
            // 
            // btnCountMiddleCost
            // 
            this.btnCountMiddleCost.Location = new System.Drawing.Point(277, 25);
            this.btnCountMiddleCost.Name = "btnCountMiddleCost";
            this.btnCountMiddleCost.Size = new System.Drawing.Size(134, 23);
            this.btnCountMiddleCost.TabIndex = 2;
            this.btnCountMiddleCost.Text = "Oblicz średnią cenę";
            this.btnCountMiddleCost.UseVisualStyleBackColor = true;
            this.btnCountMiddleCost.Click += new System.EventHandler(this.btnCountMiddleCost_Click);
            // 
            // cbCostSearch
            // 
            this.cbCostSearch.FormattingEnabled = true;
            this.cbCostSearch.Items.AddRange(new object[] {
            "Nazwa",
            "Artysta",
            "Styl",
            "Wydawnictwo",
            "Format",
            "Rok",
            "Kraj"});
            this.cbCostSearch.Location = new System.Drawing.Point(137, 25);
            this.cbCostSearch.Name = "cbCostSearch";
            this.cbCostSearch.Size = new System.Drawing.Size(121, 21);
            this.cbCostSearch.TabIndex = 1;
            // 
            // tbCostSearch
            // 
            this.tbCostSearch.Location = new System.Drawing.Point(18, 25);
            this.tbCostSearch.Name = "tbCostSearch";
            this.tbCostSearch.Size = new System.Drawing.Size(100, 20);
            this.tbCostSearch.TabIndex = 0;
            // 
            // btnShowAllCost
            // 
            this.btnShowAllCost.Location = new System.Drawing.Point(692, 24);
            this.btnShowAllCost.Name = "btnShowAllCost";
            this.btnShowAllCost.Size = new System.Drawing.Size(159, 23);
            this.btnShowAllCost.TabIndex = 5;
            this.btnShowAllCost.Text = "Pokaż wszystkie";
            this.btnShowAllCost.UseVisualStyleBackColor = true;
            this.btnShowAllCost.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.gbCosts);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.gbFiltres);
            this.Controls.Add(this.gbAddAlbum);
            this.Controls.Add(this.gbAlbumList);
            this.Controls.Add(this.gbEditAlbum);
            this.Controls.Add(this.gbShortAlbumList);
            this.MainMenuStrip = this.msMenu;
            this.Name = "Form1";
            this.Text = "Katalog Muzyczny";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.gbAddAlbum.ResumeLayout(false);
            this.gbAddAlbum.PerformLayout();
            this.gbShortAlbumList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShortAlbumList)).EndInit();
            this.gbEditAlbum.ResumeLayout(false);
            this.gbEditAlbum.PerformLayout();
            this.gbAlbumList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumList)).EndInit();
            this.gbFiltres.ResumeLayout(false);
            this.gbFiltres.PerformLayout();
            this.gbCosts.ResumeLayout(false);
            this.gbCosts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem msiAdd;
        private System.Windows.Forms.GroupBox gbAddAlbum;
        private System.Windows.Forms.TextBox tbAlbumArtist;
        private System.Windows.Forms.TextBox tbAlbumName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAlbum;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.TextBox tbLabel;
        private System.Windows.Forms.GroupBox gbShortAlbumList;
        private System.Windows.Forms.DataGridView dgvShortAlbumList;
        private System.Windows.Forms.GroupBox gbEditAlbum;
        private System.Windows.Forms.Button btnDeleteAlbum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnEditAlbum;
        private System.Windows.Forms.TextBox tbEditCountry;
        private System.Windows.Forms.TextBox tbEditYear;
        private System.Windows.Forms.TextBox tbEditLabel;
        private System.Windows.Forms.TextBox tbEditArtist;
        private System.Windows.Forms.TextBox tbEditName;
        private System.Windows.Forms.ToolStripMenuItem msiView;
        private System.Windows.Forms.GroupBox gbAlbumList;
        private System.Windows.Forms.GroupBox gbFiltres;
        private System.Windows.Forms.DataGridView dgvAlbumList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ComboBox tbStyle;
        private System.Windows.Forms.ComboBox tbFormat;
        private System.Windows.Forms.ComboBox tbEditFormat;
        private System.Windows.Forms.ComboBox tbEditStyle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbEditCost;
        private System.Windows.Forms.GroupBox gbCosts;
        private System.Windows.Forms.ToolStripMenuItem msiCosts;
        private System.Windows.Forms.ComboBox cbCostSearch;
        private System.Windows.Forms.TextBox tbCostSearch;
        private System.Windows.Forms.Button btnCountMiddleCost;
        private System.Windows.Forms.Label lblCostResult;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnShowAllCost;
    }
}

