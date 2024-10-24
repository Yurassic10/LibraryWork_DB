
using System.Windows.Forms;

namespace LibraryWork
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            panelMainForm = new Panel();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonStaff = new Button();
            buttonBooksOwn = new Button();
            buttonHall = new Button();
            buttonBooksAll = new Button();
            buttonHome = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            bookNameDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            genreTypeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            authorFnameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            authorSnameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            bookGenreAuthorBindingSource = new BindingSource(components);
            libraryDataSet1 = new LibraryDataSet1();
            dateTimePickerAuthor = new DateTimePicker();
            label11 = new Label();
            textBox1 = new TextBox();
            textBoxAuthorSecondName = new TextBox();
            textBoxAuthorName = new TextBox();
            label10 = new Label();
            label9 = new Label();
            buttonAddAuthor = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dataGridViewAuthor = new DataGridView();
            authorIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            authorFnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorSnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorBindingSource = new BindingSource(components);
            libraryDataSet = new LibraryDataSet();
            dataGridViewGenreAll = new DataGridView();
            genreIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            genreTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genreBindingSource = new BindingSource(components);
            dataGridViewBookAll = new DataGridView();
            genreIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ratingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookBindingSource = new BindingSource(components);
            buttonAddBook = new Button();
            textBoxRating = new TextBox();
            textBoxGenre = new TextBox();
            textBoxPrice = new TextBox();
            textBoxAuthor = new TextBox();
            textBoxNameBook = new TextBox();
            pictureBox7 = new PictureBox();
            panelHall = new Panel();
            dataGridView2 = new DataGridView();
            hallNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genreTypeDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            personNameDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            personRoleDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ratingDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            hallStaffBindingSource = new BindingSource(components);
            libraryDataSet2 = new LibraryDataSet2();
            buttonDeleteHallId = new Button();
            label15 = new Label();
            textBoxDeleteHall = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            textBoxPersonHall = new TextBox();
            textBoxGenreHall = new TextBox();
            textBoxNameHall = new TextBox();
            buttonAddHall = new Button();
            dataGridViewStaffHall = new DataGridView();
            personIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            personNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personRoleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            staffBindingSource = new BindingSource(components);
            dataGridViewHall = new DataGridView();
            hallIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hallBindingSource = new BindingSource(components);
            panelOnlyMyBook = new Panel();
            buttonIncreasePrice = new Button();
            buttonMakeDickount = new Button();
            dataGridViewMyBook = new DataGridView();
            bookIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            bookNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            authorIdDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            genreIdDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ratingDataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            clientIdDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            panelMemberStaffClient = new Panel();
            label22 = new Label();
            buttonDaleteStaff = new Button();
            label21 = new Label();
            label20 = new Label();
            textBoxIdStaff = new TextBox();
            textBoxPasswordToDeleteStaff = new TextBox();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            buttonAddStaff = new Button();
            textBoxRoleStaff = new TextBox();
            textBoxRatingStaff = new TextBox();
            textBoxNameStaff = new TextBox();
            dataGridViewClientAll = new DataGridView();
            clientIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            clientFirstnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientArrivingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientLastnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientBindingSource = new BindingSource(components);
            dataGridViewStaffAll = new DataGridView();
            personIdDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            personNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ratingDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            personRoleDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            buttonRefreshDataBooks = new Button();
            fKBookGenreBindingSource = new BindingSource(components);
            bookGenreAuthorTableAdapter = new LibraryDataSet1TableAdapters.BookGenreAuthorTableAdapter();
            hallStaffTableAdapter = new LibraryDataSet2TableAdapters.HallStaffTableAdapter();
            bookTableAdapter = new LibraryDataSetTableAdapters.BookTableAdapter();
            genreTableAdapter = new LibraryDataSetTableAdapters.GenreTableAdapter();
            authorTableAdapter = new LibraryDataSetTableAdapters.AuthorTableAdapter();
            hallTableAdapter = new LibraryDataSetTableAdapters.HallTableAdapter();
            staffTableAdapter = new LibraryDataSetTableAdapters.StaffTableAdapter();
            clientTableAdapter = new LibraryDataSetTableAdapters.ClientTableAdapter();
            bookBindingSource1 = new BindingSource(components);
            panelMainForm.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookGenreAuthorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)libraryDataSet1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAuthor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)authorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)libraryDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenreAll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)genreBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookAll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panelHall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hallStaffBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)libraryDataSet2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaffHall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)staffBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hallBindingSource).BeginInit();
            panelOnlyMyBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMyBook).BeginInit();
            panelMemberStaffClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientAll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaffAll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fKBookGenreBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panelMainForm
            // 
            panelMainForm.BackColor = Color.SandyBrown;
            panelMainForm.Controls.Add(label2);
            panelMainForm.Controls.Add(label1);
            panelMainForm.Controls.Add(button1);
            panelMainForm.Controls.Add(panel1);
            panelMainForm.Controls.Add(panel2);
            panelMainForm.Controls.Add(panelHall);
            panelMainForm.Controls.Add(panelOnlyMyBook);
            panelMainForm.Controls.Add(panelMemberStaffClient);
            panelMainForm.Controls.Add(buttonRefreshDataBooks);
            panelMainForm.Dock = DockStyle.Fill;
            panelMainForm.Location = new Point(0, 0);
            panelMainForm.Margin = new Padding(4, 3, 4, 3);
            panelMainForm.Name = "panelMainForm";
            panelMainForm.Size = new Size(1246, 678);
            panelMainForm.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(898, 96);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(238, 27);
            label2.TabIndex = 4;
            label2.Text = "management system";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(489, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(326, 76);
            label1.TabIndex = 3;
            label1.Text = "Library ";
            // 
            // button1
            // 
            button1.BackColor = Color.Chocolate;
            button1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(1127, 32);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(108, 43);
            button1.TabIndex = 2;
            button1.Text = "Exite";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Chocolate;
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(buttonStaff);
            panel1.Controls.Add(buttonBooksOwn);
            panel1.Controls.Add(buttonHall);
            panel1.Controls.Add(buttonBooksAll);
            panel1.Controls.Add(buttonHome);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 2);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 680);
            panel1.TabIndex = 0;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(40, 584);
            pictureBox6.Margin = new Padding(4, 3, 4, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(65, 55);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(40, 492);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(65, 57);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(40, 384);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(65, 58);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(40, 294);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(65, 59);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(40, 208);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(66, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // buttonStaff
            // 
            buttonStaff.BackColor = Color.SandyBrown;
            buttonStaff.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonStaff.Location = new Point(132, 583);
            buttonStaff.Margin = new Padding(4, 3, 4, 3);
            buttonStaff.Name = "buttonStaff";
            buttonStaff.Size = new Size(158, 68);
            buttonStaff.TabIndex = 5;
            buttonStaff.Text = "Member";
            buttonStaff.UseVisualStyleBackColor = false;
            buttonStaff.Click += buttonStaff_Click;
            // 
            // buttonBooksOwn
            // 
            buttonBooksOwn.BackColor = Color.SandyBrown;
            buttonBooksOwn.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonBooksOwn.Location = new Point(134, 486);
            buttonBooksOwn.Margin = new Padding(4, 3, 4, 3);
            buttonBooksOwn.Name = "buttonBooksOwn";
            buttonBooksOwn.Size = new Size(156, 74);
            buttonBooksOwn.TabIndex = 4;
            buttonBooksOwn.Text = "Clients' book";
            buttonBooksOwn.UseVisualStyleBackColor = false;
            buttonBooksOwn.Click += buttonBooksOwn_Click;
            // 
            // buttonHall
            // 
            buttonHall.BackColor = Color.SandyBrown;
            buttonHall.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonHall.Location = new Point(134, 378);
            buttonHall.Margin = new Padding(4, 3, 4, 3);
            buttonHall.Name = "buttonHall";
            buttonHall.Size = new Size(156, 76);
            buttonHall.TabIndex = 3;
            buttonHall.Text = "Hall";
            buttonHall.UseVisualStyleBackColor = false;
            buttonHall.Click += buttonHall_Click;
            // 
            // buttonBooksAll
            // 
            buttonBooksAll.BackColor = Color.SandyBrown;
            buttonBooksAll.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonBooksAll.Location = new Point(133, 287);
            buttonBooksAll.Margin = new Padding(4, 3, 4, 3);
            buttonBooksAll.Name = "buttonBooksAll";
            buttonBooksAll.Size = new Size(158, 67);
            buttonBooksAll.TabIndex = 2;
            buttonBooksAll.Text = "Books";
            buttonBooksAll.UseVisualStyleBackColor = false;
            buttonBooksAll.Click += buttonBooksAll_Click;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.SandyBrown;
            buttonHome.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonHome.Location = new Point(132, 196);
            buttonHome.Margin = new Padding(4, 3, 4, 3);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(160, 65);
            buttonHome.TabIndex = 1;
            buttonHome.Text = "Home";
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(4, 3);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(306, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(dateTimePickerAuthor);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(textBoxAuthorSecondName);
            panel2.Controls.Add(textBoxAuthorName);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(buttonAddAuthor);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dataGridViewAuthor);
            panel2.Controls.Add(dataGridViewGenreAll);
            panel2.Controls.Add(dataGridViewBookAll);
            panel2.Controls.Add(buttonAddBook);
            panel2.Controls.Add(textBoxRating);
            panel2.Controls.Add(textBoxGenre);
            panel2.Controls.Add(textBoxPrice);
            panel2.Controls.Add(textBoxAuthor);
            panel2.Controls.Add(textBoxNameBook);
            panel2.Controls.Add(pictureBox7);
            panel2.Location = new Point(327, 180);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(911, 498);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(518, 347);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 16);
            label3.TabIndex = 26;
            label3.Text = "Join create VIEW";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { bookNameDataGridViewTextBoxColumn2, genreTypeDataGridViewTextBoxColumn1, authorFnameDataGridViewTextBoxColumn1, authorSnameDataGridViewTextBoxColumn1 });
            dataGridView1.DataSource = bookGenreAuthorBindingSource;
            dataGridView1.Location = new Point(293, 372);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(556, 122);
            dataGridView1.TabIndex = 25;
            // 
            // bookNameDataGridViewTextBoxColumn2
            // 
            bookNameDataGridViewTextBoxColumn2.DataPropertyName = "BookName";
            bookNameDataGridViewTextBoxColumn2.HeaderText = "BookName";
            bookNameDataGridViewTextBoxColumn2.Name = "bookNameDataGridViewTextBoxColumn2";
            // 
            // genreTypeDataGridViewTextBoxColumn1
            // 
            genreTypeDataGridViewTextBoxColumn1.DataPropertyName = "GenreType";
            genreTypeDataGridViewTextBoxColumn1.HeaderText = "GenreType";
            genreTypeDataGridViewTextBoxColumn1.Name = "genreTypeDataGridViewTextBoxColumn1";
            // 
            // authorFnameDataGridViewTextBoxColumn1
            // 
            authorFnameDataGridViewTextBoxColumn1.DataPropertyName = "AuthorFname";
            authorFnameDataGridViewTextBoxColumn1.HeaderText = "AuthorFname";
            authorFnameDataGridViewTextBoxColumn1.Name = "authorFnameDataGridViewTextBoxColumn1";
            // 
            // authorSnameDataGridViewTextBoxColumn1
            // 
            authorSnameDataGridViewTextBoxColumn1.DataPropertyName = "AuthorSname";
            authorSnameDataGridViewTextBoxColumn1.HeaderText = "AuthorSname";
            authorSnameDataGridViewTextBoxColumn1.Name = "authorSnameDataGridViewTextBoxColumn1";
            // 
            // bookGenreAuthorBindingSource
            // 
            bookGenreAuthorBindingSource.DataMember = "BookGenreAuthor";
            bookGenreAuthorBindingSource.DataSource = libraryDataSet1;
            // 
            // libraryDataSet1
            // 
            libraryDataSet1.DataSetName = "LibraryDataSet1";
            libraryDataSet1.Namespace = "http://tempuri.org/LibraryDataSet1.xsd";
            libraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePickerAuthor
            // 
            dateTimePickerAuthor.Location = new Point(34, 384);
            dateTimePickerAuthor.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerAuthor.Name = "dateTimePickerAuthor";
            dateTimePickerAuthor.Size = new Size(233, 23);
            dateTimePickerAuthor.TabIndex = 24;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(91, 365);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(92, 15);
            label11.TabIndex = 23;
            label11.Text = "Date of birthday";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 414);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(98, 23);
            textBox1.TabIndex = 22;
            // 
            // textBoxAuthorSecondName
            // 
            textBoxAuthorSecondName.Location = new Point(94, 343);
            textBoxAuthorSecondName.Margin = new Padding(4, 3, 4, 3);
            textBoxAuthorSecondName.Name = "textBoxAuthorSecondName";
            textBoxAuthorSecondName.Size = new Size(178, 23);
            textBoxAuthorSecondName.TabIndex = 21;
            // 
            // textBoxAuthorName
            // 
            textBoxAuthorName.Location = new Point(94, 313);
            textBoxAuthorName.Margin = new Padding(4, 3, 4, 3);
            textBoxAuthorName.Name = "textBoxAuthorName";
            textBoxAuthorName.Size = new Size(178, 23);
            textBoxAuthorName.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 346);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(76, 15);
            label10.TabIndex = 19;
            label10.Text = "Secondname";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 317);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 18;
            label9.Text = "Firstname";
            // 
            // buttonAddAuthor
            // 
            buttonAddAuthor.BackColor = Color.Chocolate;
            buttonAddAuthor.Location = new Point(84, 442);
            buttonAddAuthor.Margin = new Padding(4, 3, 4, 3);
            buttonAddAuthor.Name = "buttonAddAuthor";
            buttonAddAuthor.Size = new Size(149, 36);
            buttonAddAuthor.TabIndex = 17;
            buttonAddAuthor.Text = "Add author";
            buttonAddAuthor.UseVisualStyleBackColor = false;
            buttonAddAuthor.Click += buttonAddAuthor_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 177);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 16;
            label8.Text = "Rating";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 151);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 15;
            label7.Text = "GenreID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 113);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 14;
            label6.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 77);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 13;
            label5.Text = "AuthorID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 39);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 12;
            label4.Text = "Name";
            // 
            // dataGridViewAuthor
            // 
            dataGridViewAuthor.AutoGenerateColumns = false;
            dataGridViewAuthor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAuthor.Columns.AddRange(new DataGridViewColumn[] { authorIdDataGridViewTextBoxColumn1, authorFnameDataGridViewTextBoxColumn, authorSnameDataGridViewTextBoxColumn, dateOfBirthDataGridViewTextBoxColumn });
            dataGridViewAuthor.DataSource = authorBindingSource;
            dataGridViewAuthor.Location = new Point(559, 204);
            dataGridViewAuthor.Margin = new Padding(4, 3, 4, 3);
            dataGridViewAuthor.Name = "dataGridViewAuthor";
            dataGridViewAuthor.Size = new Size(338, 128);
            dataGridViewAuthor.TabIndex = 11;
            // 
            // authorIdDataGridViewTextBoxColumn1
            // 
            authorIdDataGridViewTextBoxColumn1.DataPropertyName = "AuthorId";
            authorIdDataGridViewTextBoxColumn1.HeaderText = "AuthorId";
            authorIdDataGridViewTextBoxColumn1.Name = "authorIdDataGridViewTextBoxColumn1";
            authorIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // authorFnameDataGridViewTextBoxColumn
            // 
            authorFnameDataGridViewTextBoxColumn.DataPropertyName = "AuthorFname";
            authorFnameDataGridViewTextBoxColumn.HeaderText = "AuthorFname";
            authorFnameDataGridViewTextBoxColumn.Name = "authorFnameDataGridViewTextBoxColumn";
            // 
            // authorSnameDataGridViewTextBoxColumn
            // 
            authorSnameDataGridViewTextBoxColumn.DataPropertyName = "AuthorSname";
            authorSnameDataGridViewTextBoxColumn.HeaderText = "AuthorSname";
            authorSnameDataGridViewTextBoxColumn.Name = "authorSnameDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // authorBindingSource
            // 
            authorBindingSource.DataMember = "Author";
            authorBindingSource.DataSource = libraryDataSet;
            // 
            // libraryDataSet
            // 
            libraryDataSet.DataSetName = "LibraryDataSet";
            libraryDataSet.Namespace = "http://tempuri.org/LibraryDataSet.xsd";
            libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewGenreAll
            // 
            dataGridViewGenreAll.AutoGenerateColumns = false;
            dataGridViewGenreAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGenreAll.Columns.AddRange(new DataGridViewColumn[] { genreIdDataGridViewTextBoxColumn1, genreTypeDataGridViewTextBoxColumn });
            dataGridViewGenreAll.DataSource = genreBindingSource;
            dataGridViewGenreAll.Location = new Point(289, 204);
            dataGridViewGenreAll.Margin = new Padding(4, 3, 4, 3);
            dataGridViewGenreAll.Name = "dataGridViewGenreAll";
            dataGridViewGenreAll.Size = new Size(248, 132);
            dataGridViewGenreAll.TabIndex = 10;
            // 
            // genreIdDataGridViewTextBoxColumn1
            // 
            genreIdDataGridViewTextBoxColumn1.DataPropertyName = "GenreId";
            genreIdDataGridViewTextBoxColumn1.HeaderText = "GenreId";
            genreIdDataGridViewTextBoxColumn1.Name = "genreIdDataGridViewTextBoxColumn1";
            genreIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // genreTypeDataGridViewTextBoxColumn
            // 
            genreTypeDataGridViewTextBoxColumn.DataPropertyName = "GenreType";
            genreTypeDataGridViewTextBoxColumn.HeaderText = "GenreType";
            genreTypeDataGridViewTextBoxColumn.Name = "genreTypeDataGridViewTextBoxColumn";
            // 
            // genreBindingSource
            // 
            genreBindingSource.DataMember = "Genre";
            genreBindingSource.DataSource = libraryDataSet;
            // 
            // dataGridViewBookAll
            // 
            dataGridViewBookAll.AutoGenerateColumns = false;
            dataGridViewBookAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBookAll.Columns.AddRange(new DataGridViewColumn[] { genreIdDataGridViewTextBoxColumn, bookIdDataGridViewTextBoxColumn, bookNameDataGridViewTextBoxColumn, authorIdDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, ratingDataGridViewTextBoxColumn, clientIdDataGridViewTextBoxColumn });
            dataGridViewBookAll.DataSource = bookBindingSource;
            dataGridViewBookAll.Location = new Point(289, 32);
            dataGridViewBookAll.Margin = new Padding(4, 3, 4, 3);
            dataGridViewBookAll.Name = "dataGridViewBookAll";
            dataGridViewBookAll.Size = new Size(612, 157);
            dataGridViewBookAll.TabIndex = 9;
            // 
            // genreIdDataGridViewTextBoxColumn
            // 
            genreIdDataGridViewTextBoxColumn.DataPropertyName = "GenreId";
            genreIdDataGridViewTextBoxColumn.HeaderText = "GenreId";
            genreIdDataGridViewTextBoxColumn.Name = "genreIdDataGridViewTextBoxColumn";
            genreIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            bookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId";
            bookIdDataGridViewTextBoxColumn.HeaderText = "BookId";
            bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            bookIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            bookNameDataGridViewTextBoxColumn.HeaderText = "BookName";
            bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            // 
            // authorIdDataGridViewTextBoxColumn
            // 
            authorIdDataGridViewTextBoxColumn.DataPropertyName = "AuthorId";
            authorIdDataGridViewTextBoxColumn.HeaderText = "AuthorId";
            authorIdDataGridViewTextBoxColumn.Name = "authorIdDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            // 
            // bookBindingSource
            // 
            bookBindingSource.DataMember = "Book";
            bookBindingSource.DataSource = libraryDataSet;
            // 
            // buttonAddBook
            // 
            buttonAddBook.BackColor = Color.Chocolate;
            buttonAddBook.Location = new Point(94, 201);
            buttonAddBook.Margin = new Padding(4, 3, 4, 3);
            buttonAddBook.Name = "buttonAddBook";
            buttonAddBook.Size = new Size(134, 28);
            buttonAddBook.TabIndex = 7;
            buttonAddBook.Text = "Add book";
            buttonAddBook.UseVisualStyleBackColor = false;
            buttonAddBook.Click += buttonAddBook_Click;
            // 
            // textBoxRating
            // 
            textBoxRating.Location = new Point(75, 173);
            textBoxRating.Margin = new Padding(4, 3, 4, 3);
            textBoxRating.Name = "textBoxRating";
            textBoxRating.Size = new Size(190, 23);
            textBoxRating.TabIndex = 5;
            // 
            // textBoxGenre
            // 
            textBoxGenre.Location = new Point(75, 143);
            textBoxGenre.Margin = new Padding(4, 3, 4, 3);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(188, 23);
            textBoxGenre.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(75, 110);
            textBoxPrice.Margin = new Padding(4, 3, 4, 3);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(188, 23);
            textBoxPrice.TabIndex = 3;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(75, 74);
            textBoxAuthor.Margin = new Padding(4, 3, 4, 3);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(190, 23);
            textBoxAuthor.TabIndex = 2;
            // 
            // textBoxNameBook
            // 
            textBoxNameBook.Location = new Point(75, 36);
            textBoxNameBook.Margin = new Padding(4, 3, 4, 3);
            textBoxNameBook.Name = "textBoxNameBook";
            textBoxNameBook.Size = new Size(191, 23);
            textBoxNameBook.TabIndex = 1;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(-2, 0);
            pictureBox7.Margin = new Padding(4, 3, 4, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(920, 511);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // panelHall
            // 
            panelHall.Controls.Add(dataGridView2);
            panelHall.Controls.Add(buttonDeleteHallId);
            panelHall.Controls.Add(label15);
            panelHall.Controls.Add(textBoxDeleteHall);
            panelHall.Controls.Add(label14);
            panelHall.Controls.Add(label13);
            panelHall.Controls.Add(label12);
            panelHall.Controls.Add(textBoxPersonHall);
            panelHall.Controls.Add(textBoxGenreHall);
            panelHall.Controls.Add(textBoxNameHall);
            panelHall.Controls.Add(buttonAddHall);
            panelHall.Controls.Add(dataGridViewStaffHall);
            panelHall.Controls.Add(dataGridViewHall);
            panelHall.Location = new Point(324, 198);
            panelHall.Margin = new Padding(4, 3, 4, 3);
            panelHall.Name = "panelHall";
            panelHall.Size = new Size(912, 480);
            panelHall.TabIndex = 6;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { hallNameDataGridViewTextBoxColumn, genreTypeDataGridViewTextBoxColumn2, personNameDataGridViewTextBoxColumn2, personRoleDataGridViewTextBoxColumn2, ratingDataGridViewTextBoxColumn1 });
            dataGridView2.DataSource = hallStaffBindingSource;
            dataGridView2.Location = new Point(26, 258);
            dataGridView2.Margin = new Padding(4, 3, 4, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(629, 202);
            dataGridView2.TabIndex = 12;
            // 
            // hallNameDataGridViewTextBoxColumn
            // 
            hallNameDataGridViewTextBoxColumn.DataPropertyName = "HallName";
            hallNameDataGridViewTextBoxColumn.HeaderText = "HallName";
            hallNameDataGridViewTextBoxColumn.Name = "hallNameDataGridViewTextBoxColumn";
            // 
            // genreTypeDataGridViewTextBoxColumn2
            // 
            genreTypeDataGridViewTextBoxColumn2.DataPropertyName = "GenreType";
            genreTypeDataGridViewTextBoxColumn2.HeaderText = "GenreType";
            genreTypeDataGridViewTextBoxColumn2.Name = "genreTypeDataGridViewTextBoxColumn2";
            // 
            // personNameDataGridViewTextBoxColumn2
            // 
            personNameDataGridViewTextBoxColumn2.DataPropertyName = "PersonName";
            personNameDataGridViewTextBoxColumn2.HeaderText = "PersonName";
            personNameDataGridViewTextBoxColumn2.Name = "personNameDataGridViewTextBoxColumn2";
            // 
            // personRoleDataGridViewTextBoxColumn2
            // 
            personRoleDataGridViewTextBoxColumn2.DataPropertyName = "PersonRole";
            personRoleDataGridViewTextBoxColumn2.HeaderText = "PersonRole";
            personRoleDataGridViewTextBoxColumn2.Name = "personRoleDataGridViewTextBoxColumn2";
            // 
            // ratingDataGridViewTextBoxColumn1
            // 
            ratingDataGridViewTextBoxColumn1.DataPropertyName = "Rating";
            ratingDataGridViewTextBoxColumn1.HeaderText = "Rating";
            ratingDataGridViewTextBoxColumn1.Name = "ratingDataGridViewTextBoxColumn1";
            // 
            // hallStaffBindingSource
            // 
            hallStaffBindingSource.DataMember = "HallStaff";
            hallStaffBindingSource.DataSource = libraryDataSet2;
            // 
            // libraryDataSet2
            // 
            libraryDataSet2.DataSetName = "LibraryDataSet2";
            libraryDataSet2.Namespace = "http://tempuri.org/LibraryDataSet2.xsd";
            libraryDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonDeleteHallId
            // 
            buttonDeleteHallId.BackColor = Color.Chocolate;
            buttonDeleteHallId.Location = new Point(706, 365);
            buttonDeleteHallId.Margin = new Padding(4, 3, 4, 3);
            buttonDeleteHallId.Name = "buttonDeleteHallId";
            buttonDeleteHallId.Size = new Size(146, 28);
            buttonDeleteHallId.TabIndex = 11;
            buttonDeleteHallId.Text = "delete hall";
            buttonDeleteHallId.UseVisualStyleBackColor = false;
            buttonDeleteHallId.Click += buttonDeleteHallId_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(705, 316);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(144, 15);
            label15.TabIndex = 10;
            label15.Text = "Input id of hall to remove:";
            label15.Click += label15_Click;
            // 
            // textBoxDeleteHall
            // 
            textBoxDeleteHall.Location = new Point(737, 335);
            textBoxDeleteHall.Margin = new Padding(4, 3, 4, 3);
            textBoxDeleteHall.Name = "textBoxDeleteHall";
            textBoxDeleteHall.Size = new Size(89, 23);
            textBoxDeleteHall.TabIndex = 9;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(14, 99);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(43, 15);
            label14.TabIndex = 8;
            label14.Text = "person";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(13, 63);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(59, 15);
            label13.TabIndex = 7;
            label13.Text = "genre hall";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 20);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(59, 15);
            label12.TabIndex = 6;
            label12.Text = "name hall";
            // 
            // textBoxPersonHall
            // 
            textBoxPersonHall.Location = new Point(91, 91);
            textBoxPersonHall.Margin = new Padding(4, 3, 4, 3);
            textBoxPersonHall.Name = "textBoxPersonHall";
            textBoxPersonHall.Size = new Size(160, 23);
            textBoxPersonHall.TabIndex = 5;
            // 
            // textBoxGenreHall
            // 
            textBoxGenreHall.Location = new Point(91, 55);
            textBoxGenreHall.Margin = new Padding(4, 3, 4, 3);
            textBoxGenreHall.Name = "textBoxGenreHall";
            textBoxGenreHall.Size = new Size(160, 23);
            textBoxGenreHall.TabIndex = 4;
            // 
            // textBoxNameHall
            // 
            textBoxNameHall.Location = new Point(91, 16);
            textBoxNameHall.Margin = new Padding(4, 3, 4, 3);
            textBoxNameHall.Name = "textBoxNameHall";
            textBoxNameHall.Size = new Size(160, 23);
            textBoxNameHall.TabIndex = 3;
            // 
            // buttonAddHall
            // 
            buttonAddHall.BackColor = Color.Chocolate;
            buttonAddHall.Location = new Point(65, 168);
            buttonAddHall.Margin = new Padding(4, 3, 4, 3);
            buttonAddHall.Name = "buttonAddHall";
            buttonAddHall.Size = new Size(154, 30);
            buttonAddHall.TabIndex = 2;
            buttonAddHall.Text = "Add hall";
            buttonAddHall.UseVisualStyleBackColor = false;
            buttonAddHall.Click += buttonAddHall_Click;
            // 
            // dataGridViewStaffHall
            // 
            dataGridViewStaffHall.AutoGenerateColumns = false;
            dataGridViewStaffHall.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStaffHall.Columns.AddRange(new DataGridViewColumn[] { personIdDataGridViewTextBoxColumn1, personNameDataGridViewTextBoxColumn, personRoleDataGridViewTextBoxColumn });
            dataGridViewStaffHall.DataSource = staffBindingSource;
            dataGridViewStaffHall.Location = new Point(516, 16);
            dataGridViewStaffHall.Margin = new Padding(4, 3, 4, 3);
            dataGridViewStaffHall.Name = "dataGridViewStaffHall";
            dataGridViewStaffHall.Size = new Size(379, 219);
            dataGridViewStaffHall.TabIndex = 1;
            // 
            // personIdDataGridViewTextBoxColumn1
            // 
            personIdDataGridViewTextBoxColumn1.DataPropertyName = "PersonId";
            personIdDataGridViewTextBoxColumn1.HeaderText = "PersonId";
            personIdDataGridViewTextBoxColumn1.Name = "personIdDataGridViewTextBoxColumn1";
            personIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // personNameDataGridViewTextBoxColumn
            // 
            personNameDataGridViewTextBoxColumn.DataPropertyName = "PersonName";
            personNameDataGridViewTextBoxColumn.HeaderText = "PersonName";
            personNameDataGridViewTextBoxColumn.Name = "personNameDataGridViewTextBoxColumn";
            // 
            // personRoleDataGridViewTextBoxColumn
            // 
            personRoleDataGridViewTextBoxColumn.DataPropertyName = "PersonRole";
            personRoleDataGridViewTextBoxColumn.HeaderText = "PersonRole";
            personRoleDataGridViewTextBoxColumn.Name = "personRoleDataGridViewTextBoxColumn";
            // 
            // staffBindingSource
            // 
            staffBindingSource.DataMember = "Staff";
            staffBindingSource.DataSource = libraryDataSet;
            // 
            // dataGridViewHall
            // 
            dataGridViewHall.AutoGenerateColumns = false;
            dataGridViewHall.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHall.Columns.AddRange(new DataGridViewColumn[] { hallIdDataGridViewTextBoxColumn, personIdDataGridViewTextBoxColumn });
            dataGridViewHall.DataSource = hallBindingSource;
            dataGridViewHall.Location = new Point(259, 16);
            dataGridViewHall.Margin = new Padding(4, 3, 4, 3);
            dataGridViewHall.Name = "dataGridViewHall";
            dataGridViewHall.Size = new Size(250, 219);
            dataGridViewHall.TabIndex = 0;
            // 
            // hallIdDataGridViewTextBoxColumn
            // 
            hallIdDataGridViewTextBoxColumn.DataPropertyName = "Hall_Id";
            hallIdDataGridViewTextBoxColumn.HeaderText = "Hall_Id";
            hallIdDataGridViewTextBoxColumn.Name = "hallIdDataGridViewTextBoxColumn";
            hallIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personIdDataGridViewTextBoxColumn
            // 
            personIdDataGridViewTextBoxColumn.DataPropertyName = "PersonId";
            personIdDataGridViewTextBoxColumn.HeaderText = "PersonId";
            personIdDataGridViewTextBoxColumn.Name = "personIdDataGridViewTextBoxColumn";
            // 
            // hallBindingSource
            // 
            hallBindingSource.DataMember = "Hall";
            hallBindingSource.DataSource = libraryDataSet;
            // 
            // panelOnlyMyBook
            // 
            panelOnlyMyBook.Controls.Add(buttonIncreasePrice);
            panelOnlyMyBook.Controls.Add(buttonMakeDickount);
            panelOnlyMyBook.Controls.Add(dataGridViewMyBook);
            panelOnlyMyBook.Location = new Point(329, 198);
            panelOnlyMyBook.Margin = new Padding(4, 3, 4, 3);
            panelOnlyMyBook.Name = "panelOnlyMyBook";
            panelOnlyMyBook.Size = new Size(918, 479);
            panelOnlyMyBook.TabIndex = 8;
            // 
            // buttonIncreasePrice
            // 
            buttonIncreasePrice.BackColor = Color.Chocolate;
            buttonIncreasePrice.Location = new Point(818, 46);
            buttonIncreasePrice.Margin = new Padding(4, 3, 4, 3);
            buttonIncreasePrice.Name = "buttonIncreasePrice";
            buttonIncreasePrice.Size = new Size(66, 63);
            buttonIncreasePrice.TabIndex = 3;
            buttonIncreasePrice.Text = "Increase price";
            buttonIncreasePrice.UseVisualStyleBackColor = false;
            buttonIncreasePrice.Click += buttonIncreasePrice_Click;
            // 
            // buttonMakeDickount
            // 
            buttonMakeDickount.BackColor = Color.Chocolate;
            buttonMakeDickount.Location = new Point(814, 117);
            buttonMakeDickount.Margin = new Padding(4, 3, 4, 3);
            buttonMakeDickount.Name = "buttonMakeDickount";
            buttonMakeDickount.Size = new Size(70, 62);
            buttonMakeDickount.TabIndex = 1;
            buttonMakeDickount.Text = "Discount";
            buttonMakeDickount.UseVisualStyleBackColor = false;
            buttonMakeDickount.Click += buttonMakeDickount_Click;
            // 
            // dataGridViewMyBook
            // 
            dataGridViewMyBook.AutoGenerateColumns = false;
            dataGridViewMyBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMyBook.Columns.AddRange(new DataGridViewColumn[] { bookIdDataGridViewTextBoxColumn1, bookNameDataGridViewTextBoxColumn1, authorIdDataGridViewTextBoxColumn2, priceDataGridViewTextBoxColumn1, genreIdDataGridViewTextBoxColumn2, ratingDataGridViewTextBoxColumn3, clientIdDataGridViewTextBoxColumn2 });
            dataGridViewMyBook.DataSource = bookBindingSource;
            dataGridViewMyBook.Location = new Point(27, 35);
            dataGridViewMyBook.Margin = new Padding(4, 3, 4, 3);
            dataGridViewMyBook.Name = "dataGridViewMyBook";
            dataGridViewMyBook.Size = new Size(751, 387);
            dataGridViewMyBook.TabIndex = 0;
            // 
            // bookIdDataGridViewTextBoxColumn1
            // 
            bookIdDataGridViewTextBoxColumn1.DataPropertyName = "BookId";
            bookIdDataGridViewTextBoxColumn1.HeaderText = "BookId";
            bookIdDataGridViewTextBoxColumn1.Name = "bookIdDataGridViewTextBoxColumn1";
            bookIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bookNameDataGridViewTextBoxColumn1
            // 
            bookNameDataGridViewTextBoxColumn1.DataPropertyName = "BookName";
            bookNameDataGridViewTextBoxColumn1.HeaderText = "BookName";
            bookNameDataGridViewTextBoxColumn1.Name = "bookNameDataGridViewTextBoxColumn1";
            // 
            // authorIdDataGridViewTextBoxColumn2
            // 
            authorIdDataGridViewTextBoxColumn2.DataPropertyName = "AuthorId";
            authorIdDataGridViewTextBoxColumn2.HeaderText = "AuthorId";
            authorIdDataGridViewTextBoxColumn2.Name = "authorIdDataGridViewTextBoxColumn2";
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            // 
            // genreIdDataGridViewTextBoxColumn2
            // 
            genreIdDataGridViewTextBoxColumn2.DataPropertyName = "GenreId";
            genreIdDataGridViewTextBoxColumn2.HeaderText = "GenreId";
            genreIdDataGridViewTextBoxColumn2.Name = "genreIdDataGridViewTextBoxColumn2";
            // 
            // ratingDataGridViewTextBoxColumn3
            // 
            ratingDataGridViewTextBoxColumn3.DataPropertyName = "Rating";
            ratingDataGridViewTextBoxColumn3.HeaderText = "Rating";
            ratingDataGridViewTextBoxColumn3.Name = "ratingDataGridViewTextBoxColumn3";
            // 
            // clientIdDataGridViewTextBoxColumn2
            // 
            clientIdDataGridViewTextBoxColumn2.DataPropertyName = "ClientId";
            clientIdDataGridViewTextBoxColumn2.HeaderText = "ClientId";
            clientIdDataGridViewTextBoxColumn2.Name = "clientIdDataGridViewTextBoxColumn2";
            // 
            // panelMemberStaffClient
            // 
            panelMemberStaffClient.Controls.Add(label22);
            panelMemberStaffClient.Controls.Add(buttonDaleteStaff);
            panelMemberStaffClient.Controls.Add(label21);
            panelMemberStaffClient.Controls.Add(label20);
            panelMemberStaffClient.Controls.Add(textBoxIdStaff);
            panelMemberStaffClient.Controls.Add(textBoxPasswordToDeleteStaff);
            panelMemberStaffClient.Controls.Add(label19);
            panelMemberStaffClient.Controls.Add(label18);
            panelMemberStaffClient.Controls.Add(label17);
            panelMemberStaffClient.Controls.Add(label16);
            panelMemberStaffClient.Controls.Add(buttonAddStaff);
            panelMemberStaffClient.Controls.Add(textBoxRoleStaff);
            panelMemberStaffClient.Controls.Add(textBoxRatingStaff);
            panelMemberStaffClient.Controls.Add(textBoxNameStaff);
            panelMemberStaffClient.Controls.Add(dataGridViewClientAll);
            panelMemberStaffClient.Controls.Add(dataGridViewStaffAll);
            panelMemberStaffClient.Location = new Point(326, 198);
            panelMemberStaffClient.Margin = new Padding(4, 3, 4, 3);
            panelMemberStaffClient.Name = "panelMemberStaffClient";
            panelMemberStaffClient.Size = new Size(910, 479);
            panelMemberStaffClient.TabIndex = 7;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(568, 239);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(90, 15);
            label22.TabIndex = 15;
            label22.Text = "Only for admin:";
            // 
            // buttonDaleteStaff
            // 
            buttonDaleteStaff.BackColor = Color.Chocolate;
            buttonDaleteStaff.Location = new Point(631, 373);
            buttonDaleteStaff.Margin = new Padding(4, 3, 4, 3);
            buttonDaleteStaff.Name = "buttonDaleteStaff";
            buttonDaleteStaff.Size = new Size(195, 25);
            buttonDaleteStaff.TabIndex = 14;
            buttonDaleteStaff.Text = "delete staff";
            buttonDaleteStaff.UseVisualStyleBackColor = false;
            buttonDaleteStaff.Click += buttonDaleteStaff_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(635, 331);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(43, 15);
            label21.TabIndex = 13;
            label21.Text = "Id staff";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(595, 293);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(57, 15);
            label20.TabIndex = 12;
            label20.Text = "Password";
            label20.Click += label20_Click;
            // 
            // textBoxIdStaff
            // 
            textBoxIdStaff.Location = new Point(728, 327);
            textBoxIdStaff.Margin = new Padding(4, 3, 4, 3);
            textBoxIdStaff.Name = "textBoxIdStaff";
            textBoxIdStaff.Size = new Size(70, 23);
            textBoxIdStaff.TabIndex = 11;
            // 
            // textBoxPasswordToDeleteStaff
            // 
            textBoxPasswordToDeleteStaff.Location = new Point(676, 290);
            textBoxPasswordToDeleteStaff.Margin = new Padding(4, 3, 4, 3);
            textBoxPasswordToDeleteStaff.Name = "textBoxPasswordToDeleteStaff";
            textBoxPasswordToDeleteStaff.Size = new Size(151, 23);
            textBoxPasswordToDeleteStaff.TabIndex = 10;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(568, 254);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(309, 15);
            label19.TabIndex = 9;
            label19.Text = "Input index of person to delete(whish u dont want to see)";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(82, 99);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(30, 15);
            label18.TabIndex = 8;
            label18.Text = "Role";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(75, 63);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(41, 15);
            label17.TabIndex = 7;
            label17.Text = "Rating";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(75, 35);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(39, 15);
            label16.TabIndex = 6;
            label16.Text = "Name";
            // 
            // buttonAddStaff
            // 
            buttonAddStaff.BackColor = Color.Chocolate;
            buttonAddStaff.Location = new Point(173, 135);
            buttonAddStaff.Margin = new Padding(4, 3, 4, 3);
            buttonAddStaff.Name = "buttonAddStaff";
            buttonAddStaff.Size = new Size(118, 27);
            buttonAddStaff.TabIndex = 5;
            buttonAddStaff.Text = "Be part of dtaff";
            buttonAddStaff.UseVisualStyleBackColor = false;
            buttonAddStaff.Click += buttonAddStaff_Click;
            // 
            // textBoxRoleStaff
            // 
            textBoxRoleStaff.Location = new Point(147, 91);
            textBoxRoleStaff.Margin = new Padding(4, 3, 4, 3);
            textBoxRoleStaff.Name = "textBoxRoleStaff";
            textBoxRoleStaff.Size = new Size(163, 23);
            textBoxRoleStaff.TabIndex = 4;
            // 
            // textBoxRatingStaff
            // 
            textBoxRatingStaff.Location = new Point(147, 61);
            textBoxRatingStaff.Margin = new Padding(4, 3, 4, 3);
            textBoxRatingStaff.Name = "textBoxRatingStaff";
            textBoxRatingStaff.Size = new Size(163, 23);
            textBoxRatingStaff.TabIndex = 3;
            // 
            // textBoxNameStaff
            // 
            textBoxNameStaff.Location = new Point(145, 31);
            textBoxNameStaff.Margin = new Padding(4, 3, 4, 3);
            textBoxNameStaff.Name = "textBoxNameStaff";
            textBoxNameStaff.Size = new Size(166, 23);
            textBoxNameStaff.TabIndex = 2;
            // 
            // dataGridViewClientAll
            // 
            dataGridViewClientAll.AutoGenerateColumns = false;
            dataGridViewClientAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientAll.Columns.AddRange(new DataGridViewColumn[] { clientIdDataGridViewTextBoxColumn1, clientFirstnameDataGridViewTextBoxColumn, clientArrivingDataGridViewTextBoxColumn, clientLastnameDataGridViewTextBoxColumn });
            dataGridViewClientAll.DataSource = clientBindingSource;
            dataGridViewClientAll.Location = new Point(24, 225);
            dataGridViewClientAll.Margin = new Padding(4, 3, 4, 3);
            dataGridViewClientAll.Name = "dataGridViewClientAll";
            dataGridViewClientAll.Size = new Size(520, 219);
            dataGridViewClientAll.TabIndex = 1;
            // 
            // clientIdDataGridViewTextBoxColumn1
            // 
            clientIdDataGridViewTextBoxColumn1.DataPropertyName = "ClientId";
            clientIdDataGridViewTextBoxColumn1.HeaderText = "ClientId";
            clientIdDataGridViewTextBoxColumn1.Name = "clientIdDataGridViewTextBoxColumn1";
            clientIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // clientFirstnameDataGridViewTextBoxColumn
            // 
            clientFirstnameDataGridViewTextBoxColumn.DataPropertyName = "ClientFirstname";
            clientFirstnameDataGridViewTextBoxColumn.HeaderText = "ClientFirstname";
            clientFirstnameDataGridViewTextBoxColumn.Name = "clientFirstnameDataGridViewTextBoxColumn";
            // 
            // clientArrivingDataGridViewTextBoxColumn
            // 
            clientArrivingDataGridViewTextBoxColumn.DataPropertyName = "ClientArriving";
            clientArrivingDataGridViewTextBoxColumn.HeaderText = "ClientArriving";
            clientArrivingDataGridViewTextBoxColumn.Name = "clientArrivingDataGridViewTextBoxColumn";
            // 
            // clientLastnameDataGridViewTextBoxColumn
            // 
            clientLastnameDataGridViewTextBoxColumn.DataPropertyName = "ClientLastname";
            clientLastnameDataGridViewTextBoxColumn.HeaderText = "ClientLastname";
            clientLastnameDataGridViewTextBoxColumn.Name = "clientLastnameDataGridViewTextBoxColumn";
            // 
            // clientBindingSource
            // 
            clientBindingSource.DataMember = "Client";
            clientBindingSource.DataSource = libraryDataSet;
            // 
            // dataGridViewStaffAll
            // 
            dataGridViewStaffAll.AutoGenerateColumns = false;
            dataGridViewStaffAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStaffAll.Columns.AddRange(new DataGridViewColumn[] { personIdDataGridViewTextBoxColumn2, personNameDataGridViewTextBoxColumn1, ratingDataGridViewTextBoxColumn2, personRoleDataGridViewTextBoxColumn1 });
            dataGridViewStaffAll.DataSource = staffBindingSource;
            dataGridViewStaffAll.Location = new Point(382, 18);
            dataGridViewStaffAll.Margin = new Padding(4, 3, 4, 3);
            dataGridViewStaffAll.Name = "dataGridViewStaffAll";
            dataGridViewStaffAll.Size = new Size(517, 180);
            dataGridViewStaffAll.TabIndex = 0;
            // 
            // personIdDataGridViewTextBoxColumn2
            // 
            personIdDataGridViewTextBoxColumn2.DataPropertyName = "PersonId";
            personIdDataGridViewTextBoxColumn2.HeaderText = "PersonId";
            personIdDataGridViewTextBoxColumn2.Name = "personIdDataGridViewTextBoxColumn2";
            personIdDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // personNameDataGridViewTextBoxColumn1
            // 
            personNameDataGridViewTextBoxColumn1.DataPropertyName = "PersonName";
            personNameDataGridViewTextBoxColumn1.HeaderText = "PersonName";
            personNameDataGridViewTextBoxColumn1.Name = "personNameDataGridViewTextBoxColumn1";
            // 
            // ratingDataGridViewTextBoxColumn2
            // 
            ratingDataGridViewTextBoxColumn2.DataPropertyName = "Rating";
            ratingDataGridViewTextBoxColumn2.HeaderText = "Rating";
            ratingDataGridViewTextBoxColumn2.Name = "ratingDataGridViewTextBoxColumn2";
            // 
            // personRoleDataGridViewTextBoxColumn1
            // 
            personRoleDataGridViewTextBoxColumn1.DataPropertyName = "PersonRole";
            personRoleDataGridViewTextBoxColumn1.HeaderText = "PersonRole";
            personRoleDataGridViewTextBoxColumn1.Name = "personRoleDataGridViewTextBoxColumn1";
            // 
            // buttonRefreshDataBooks
            // 
            buttonRefreshDataBooks.BackColor = Color.Chocolate;
            buttonRefreshDataBooks.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRefreshDataBooks.Location = new Point(980, 130);
            buttonRefreshDataBooks.Margin = new Padding(4, 3, 4, 3);
            buttonRefreshDataBooks.Name = "buttonRefreshDataBooks";
            buttonRefreshDataBooks.Size = new Size(248, 43);
            buttonRefreshDataBooks.TabIndex = 8;
            buttonRefreshDataBooks.Text = "Refresh data";
            buttonRefreshDataBooks.UseVisualStyleBackColor = false;
            buttonRefreshDataBooks.Click += buttonRefreshDataBooks_Click;
            // 
            // fKBookGenreBindingSource
            // 
            fKBookGenreBindingSource.DataMember = "FK_Book_Genre";
            fKBookGenreBindingSource.DataSource = genreBindingSource;
            // 
            // bookGenreAuthorTableAdapter
            // 
            bookGenreAuthorTableAdapter.ClearBeforeFill = true;
            // 
            // hallStaffTableAdapter
            // 
            hallStaffTableAdapter.ClearBeforeFill = true;
            // 
            // bookTableAdapter
            // 
            bookTableAdapter.ClearBeforeFill = true;
            // 
            // genreTableAdapter
            // 
            genreTableAdapter.ClearBeforeFill = true;
            // 
            // authorTableAdapter
            // 
            authorTableAdapter.ClearBeforeFill = true;
            // 
            // hallTableAdapter
            // 
            hallTableAdapter.ClearBeforeFill = true;
            // 
            // staffTableAdapter
            // 
            staffTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            clientTableAdapter.ClearBeforeFill = true;
            // 
            // bookBindingSource1
            // 
            bookBindingSource1.DataMember = "Book";
            bookBindingSource1.DataSource = libraryDataSet;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 678);
            Controls.Add(panelMainForm);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panelMainForm.ResumeLayout(false);
            panelMainForm.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookGenreAuthorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)libraryDataSet1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAuthor).EndInit();
            ((System.ComponentModel.ISupportInitialize)authorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)libraryDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenreAll).EndInit();
            ((System.ComponentModel.ISupportInitialize)genreBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBookAll).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panelHall.ResumeLayout(false);
            panelHall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)hallStaffBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)libraryDataSet2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaffHall).EndInit();
            ((System.ComponentModel.ISupportInitialize)staffBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHall).EndInit();
            ((System.ComponentModel.ISupportInitialize)hallBindingSource).EndInit();
            panelOnlyMyBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMyBook).EndInit();
            panelMemberStaffClient.ResumeLayout(false);
            panelMemberStaffClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientAll).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStaffAll).EndInit();
            ((System.ComponentModel.ISupportInitialize)fKBookGenreBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMainForm;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonStaff;
        private System.Windows.Forms.Button buttonBooksOwn;
        private System.Windows.Forms.Button buttonHall;
        private System.Windows.Forms.Button buttonBooksAll;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxNameBook;
        private System.Windows.Forms.Button buttonRefreshDataBooks;
        private System.Windows.Forms.DataGridView dataGridViewBookAll;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private LibraryDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewGenreAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private LibraryDataSetTableAdapters.GenreTableAdapter genreTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private LibraryDataSetTableAdapters.AuthorTableAdapter authorTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorFnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorSnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxAuthorSecondName;
        private System.Windows.Forms.TextBox textBoxAuthorName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.Panel panelHall;
        private System.Windows.Forms.DataGridView dataGridViewHall;
        private System.Windows.Forms.BindingSource hallBindingSource;
        private LibraryDataSetTableAdapters.HallTableAdapter hallTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewStaffHall;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private LibraryDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.Button buttonDeleteHallId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxDeleteHall;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxPersonHall;
        private System.Windows.Forms.TextBox textBoxGenreHall;
        private System.Windows.Forms.TextBox textBoxNameHall;
        private System.Windows.Forms.Button buttonAddHall;
        private System.Windows.Forms.Panel panelMemberStaffClient;
        private System.Windows.Forms.DataGridView dataGridViewClientAll;
        private System.Windows.Forms.DataGridView dataGridViewStaffAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn personNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn personRoleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private LibraryDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientFirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientArrivingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientLastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonAddStaff;
        private System.Windows.Forms.TextBox textBoxRoleStaff;
        private System.Windows.Forms.TextBox textBoxRatingStaff;
        private System.Windows.Forms.TextBox textBoxNameStaff;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxIdStaff;
        private System.Windows.Forms.TextBox textBoxPasswordToDeleteStaff;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button buttonDaleteStaff;
        private System.Windows.Forms.Panel panelOnlyMyBook;
        private System.Windows.Forms.DataGridView dataGridViewMyBook;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker dateTimePickerAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fKBookGenreBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LibraryDataSet1 libraryDataSet1;
        private System.Windows.Forms.BindingSource bookGenreAuthorBindingSource;
        private LibraryDataSet1TableAdapters.BookGenreAuthorTableAdapter bookGenreAuthorTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreTypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorFnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorSnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private LibraryDataSet2 libraryDataSet2;
        private System.Windows.Forms.BindingSource hallStaffBindingSource;
        private LibraryDataSet2TableAdapters.HallStaffTableAdapter hallStaffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreTypeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn personNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn personRoleDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button buttonMakeDickount;
        private System.Windows.Forms.Button buttonIncreasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource bookBindingSource1;
    }
}

