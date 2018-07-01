using BLL;
using System.Windows.Forms;

namespace Foksal.Forms.Settings
{
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();

            lblHello.Text = string.Format("Witaj, {0}!", AppUser.Instance.UserName);
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (txtOldPassword.Text == RSACoder.Decryption(AppUser.Instance.Password))
            {
                if (txtNewPassword.Text == txtRepeatPassword.Text)
                {
                    if (AppUser.Instance.ChangePassword(txtOldPassword.Text, txtNewPassword.Text))
                    {
                        MessageBox.Show("Hasło zostało zmienione.", "Zmiana hasła", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Nie udało sie zmienić hasła, spróbuj ponownie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nowe hasła nie zgadzają się!", "Niepoprawne hasło", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Niepoprawne hasło!\r\nPodaj stare hasło ponownie.", "Niepoprawne hasło", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
