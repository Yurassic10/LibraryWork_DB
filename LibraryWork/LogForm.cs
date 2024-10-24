using ADOLibrary.ADORepository;
using ADOLibrary.Interface;
using ADOLibrary.Model;

namespace LibraryWork
{
    public partial class LogForm : Form
    {
        IRepositoryModel<Client> clientsRep = null;
        public LogForm()
        {
            InitializeComponent();
            clientsRep = new ClientRepository();
        }

        private void LogForm_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void singInButton_Click(object sender, EventArgs e)
        {
            String loginUser = textBox1.Text;
            String passUser = textBox2.Text;
            bool hasAccount = false;

            foreach (var client in clientsRep.GetProducts())
            {
                if (loginUser == client.Email && passUser == client.Password)
                {
                    hasAccount = true;
                }
            }

            if (hasAccount == true)
            {
                MessageBox.Show("¬х≥д зд≥йснено усп≥шно", "”сп≥х", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();

            }
            else
            {
                MessageBox.Show("Incorrect password or login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
