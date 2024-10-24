using ADOLibrary.ADORepository;
using ADOLibrary.Interface;
using ADOLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryWork
{
    public partial class MainForm : Form
    {
        IRepositoryModel<Book> booksRep = new BookRepository();
        //IRepositoryModel<Author> authorsRep = new AuthorRepository();
        //IRepositoryModel<Genre> genresRep = new GenreRepository();
        IRepositoryModel<Hall> hallsRep = new HallRepository();
        IRepositoryModel<Staff> staffsRep = new StaffRepository();
        public MainForm()
        {
            InitializeComponent();

            pictureBox7.Visible = true;
            //Size size = new Size(Height = 415, Width = 747);
            // pictureBox7.Size = size;
            pictureBox7.BringToFront();
            //panelMainForm.BringToFront();
        }

        private void buttonBooksAll_Click(object sender, EventArgs e)
        {
            panelMainForm.SendToBack();
            panel2.Visible = true;
            panel2.BringToFront();
            panelMainForm.SendToBack();
            panelHall.SendToBack();
            panelMemberStaffClient.SendToBack();
            panelOnlyMyBook.SendToBack();
            //pictureBox7.Visible=false;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            //panelMainForm.BringToFront();
            pictureBox7.Visible = true;
            pictureBox7.BringToFront();

            panel2.SendToBack();
            panelOnlyMyBook.Visible = false;

            panelOnlyMyBook.SendToBack();
            panelMemberStaffClient.SendToBack();
            panelHall.SendToBack();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //panel2.Visible = true;
            //panel2.BringToFront();
            //panelMainForm.SendToBack();
            //panelOnlyMyBook.SendToBack();
            //panelMemberStaffClient.SendToBack();
            //panelHall.SendToBack();
        }

        private void buttonRefreshDataBooks_Click(object sender, EventArgs e)
        {
            this.clientTableAdapter.Fill(this.libraryDataSet.Client);
            this.staffTableAdapter.Fill(this.libraryDataSet.Staff);
            this.hallTableAdapter.Fill(this.libraryDataSet.Hall);
            this.hallStaffTableAdapter.Fill(this.libraryDataSet2.HallStaff);
            this.bookGenreAuthorTableAdapter.Fill(this.libraryDataSet1.BookGenreAuthor);
            this.authorTableAdapter.Fill(this.libraryDataSet.Author);
            this.genreTableAdapter.Fill(this.libraryDataSet.Genre);
            this.bookTableAdapter.Fill(this.libraryDataSet.Book);


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet2.HallStaff' table. You can move, or remove it, as needed.
            this.hallStaffTableAdapter.Fill(this.libraryDataSet2.HallStaff);
            // TODO: This line of code loads data into the 'libraryDataSet1.BookGenreAuthor' table. You can move, or remove it, as needed.
            this.bookGenreAuthorTableAdapter.Fill(this.libraryDataSet1.BookGenreAuthor);
            // TODO: This line of code loads data into the 'libraryDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.libraryDataSet.Client);
            // TODO: This line of code loads data into the 'libraryDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.libraryDataSet.Staff);
            // TODO: This line of code loads data into the 'libraryDataSet.Hall' table. You can move, or remove it, as needed.
            this.hallTableAdapter.Fill(this.libraryDataSet.Hall);
            // TODO: This line of code loads data into the 'libraryDataSet.Author' table. You can move, or remove it, as needed.
            this.authorTableAdapter.Fill(this.libraryDataSet.Author);
            // TODO: This line of code loads data into the 'libraryDataSet.Genre' table. You can move, or remove it, as needed.
            this.genreTableAdapter.Fill(this.libraryDataSet.Genre);
            // TODO: This line of code loads data into the 'libraryDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.libraryDataSet.Book);

        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {

            try
            {
                Book newBook = new Book();
                newBook.Name = textBoxNameBook.Text;
                newBook.AuthorId = Convert.ToInt32(textBoxAuthor.Text);
                newBook.Price = Convert.ToInt32(textBoxPrice.Text);
                newBook.GenreId = Convert.ToInt32(textBoxGenre.Text);
                newBook.Rating = Convert.ToInt32(textBoxRating.Text);
                this.bookTableAdapter.Insert(newBook.Name, newBook.AuthorId, newBook.Price, newBook.GenreId, newBook.Rating, null);
                this.bookTableAdapter.Fill(this.libraryDataSet.Book);
                MessageBox.Show("Success add a book!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //booksRep.AddObj(newBook);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddHall_Click(object sender, EventArgs e)
        {
            try
            {
                Hall newHall = new Hall();
                newHall.Name = textBoxNameHall.Text;
                newHall.GenreId = Convert.ToInt32(textBoxGenreHall.Text);
                newHall.PersonId = Convert.ToInt32(textBoxPersonHall.Text);
                this.hallTableAdapter.Insert(newHall.Name, newHall.GenreId, newHall.PersonId);
                this.hallTableAdapter.Fill(this.libraryDataSet.Hall);
                MessageBox.Show("Success add a hall!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteHallId_Click(object sender, EventArgs e)
        {
            try
            {
                int idT = Convert.ToInt32(textBoxDeleteHall.Text);
                var temp = hallsRep.GetObj(idT);
                hallTableAdapter.Delete(idT, temp.Name, temp.GenreId, temp.PersonId);
                this.hallTableAdapter.Fill(this.libraryDataSet.Hall);
                MessageBox.Show("Already delete", "Great!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddStaff_Click(object sender, EventArgs e)
        {
            try
            {
                Staff newStaff = new Staff();
                newStaff.Name = textBoxNameStaff.Text;
                newStaff.Rating = Convert.ToInt32(textBoxRatingStaff.Text);
                newStaff.Role = textBoxRoleStaff.Text;
                this.staffTableAdapter.Insert(newStaff.Name, newStaff.Rating, newStaff.Role);
                this.staffTableAdapter.Fill(this.libraryDataSet.Staff);
                MessageBox.Show("Success add a person!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void buttonDaleteStaff_Click(object sender, EventArgs e)
        {
            try
            {
                int idT = Convert.ToInt32(textBoxIdStaff.Text);
                var temp = staffsRep.GetObj(idT);

                staffTableAdapter.Delete(idT, temp.Name, temp.Rating, temp.Role);
                MessageBox.Show("Already delete", "Great!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonHall_Click(object sender, EventArgs e)
        {
            panelMainForm.SendToBack();
            panel2.SendToBack();
            panelMainForm.SendToBack();
            panelHall.BringToFront();
            panelMemberStaffClient.SendToBack();
            panelOnlyMyBook.SendToBack();
            pictureBox7.Visible = false;
            panel2.Visible = false;

        }

        private void buttonBooksOwn_Click(object sender, EventArgs e)
        {
            panelMainForm.SendToBack();
            panel2.SendToBack();
            //panel2.Visible = false;
            panelMainForm.SendToBack();
            panelHall.SendToBack();
            panelMemberStaffClient.SendToBack();
            panelOnlyMyBook.Visible = true;
            panelOnlyMyBook.BringToFront();
            pictureBox7.Visible = false;
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            panelMainForm.SendToBack();
            panel2.SendToBack();
            // panel2.Visible = false;
            panelMainForm.SendToBack();
            panelHall.SendToBack();
            panelMemberStaffClient.BringToFront();
            panelOnlyMyBook.SendToBack();
            pictureBox7.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                Author newAct = new Author();
                newAct.Firstname = textBoxAuthorName.Text;
                newAct.Lastname = textBoxAuthorSecondName.Text;
                newAct.DateOfBirthd = dateTimePickerAuthor.Value;
                this.authorTableAdapter.Insert(newAct.Firstname, newAct.Lastname, newAct.DateOfBirthd);

                this.authorTableAdapter.Fill(this.libraryDataSet.Author);
                MessageBox.Show("Success add a person!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bookTableAdapter.FillBy(this.libraryDataSet.Book); // було FillBy1
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void buttonMakeDickount_Click(object sender, EventArgs e)
        {
            booksRep.ChangeValueObj(1, "-");

        }

        private void buttonRatingUp_Click(object sender, EventArgs e)
        {

        }

        private void buttonIncreasePrice_Click(object sender, EventArgs e)
        {
            booksRep.ChangeValueObj(1, "+");
        }

    }
}
