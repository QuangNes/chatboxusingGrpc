using Grpc.Net.Client;
using GrpcService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientGrpcWFA
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            Register fomr2 = new Register();
            fomr2.Show();
            this.Hide();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            string usename = textBoxUsename.Text;
            string password = textBoxPassword.Text;
            var grpcChannel = GrpcChannel.ForAddress("https://localhost:7082");
            var greeterClient = new Greeter.GreeterClient(grpcChannel);
            var greeterReply = greeterClient.SignIn(new SignInRequest { 
                Username = usename,
                Password = password
            });
            MessageBox.Show(greeterReply.Message);

            if (greeterReply.Message == "Login success!") {
                SupportClient.GlobalVariables.nameOfUser = usename;
                Chat form3 = new Chat();
                form3.Show();
            }
            else
            {
                SupportClient.GlobalVariables.nameOfUser = "Null";
            }
        }
    }
}
