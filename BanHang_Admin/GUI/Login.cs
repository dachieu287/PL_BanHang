using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            AccountBUS bus = new AccountBUS();
            LoginStatus status = bus.Login(email, password);
            switch (status)
            {
                case LoginStatus.WRONG_EMAIL:
                    MessageBox.Show("Email không tồn tại");
                    return;
                case LoginStatus.WRONG_PASSWORD:
                    MessageBox.Show("Mật khẩu không chính xác");
                    return;
                case LoginStatus.LOCKED:
                    MessageBox.Show("Tài khoản đã bị khóa");
                    return;
                case LoginStatus.NO_PERMISSION:
                    MessageBox.Show("Không đủ quyền hạn");
                    return;
                case LoginStatus.SUCCESS:
                    this.Hide();
                    Manage frmManage = new Manage();
                    frmManage.ShowDialog();
                    this.Show();
                    return;
            }
        }
    }
}
