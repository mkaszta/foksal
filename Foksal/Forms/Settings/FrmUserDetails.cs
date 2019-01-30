using BLL;
using BLL.Entities;
using System.Windows.Forms;

namespace Foksal.Forms.Settings
{
    public partial class FrmUserDetails : Form
    {
        private User user;
        public string Login { get; set; }
        public string Password { get; set; }

        public FrmUserDetails(User user)
        {
            InitializeComponent();
            this.user = user;

            txtLogin.Text = this.user.Login;

            if (this.user.Id == 1)
                txtLogin.Enabled = false;
        }

        private bool IsDataVerified()
        {
            if (txtLogin.Text == "")
            {
                MessageBox.Show("Podaj login!", "Popraw dane", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtNewPassword.Text != txtRepeatPassword.Text)
            {
                MessageBox.Show("Hasła nie zgadzają się!", "Popraw dane", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (this.IsDataVerified())
            {
                this.Login = txtLogin.Text;
                this.Password = RSACoder.Encryption(txtNewPassword.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
