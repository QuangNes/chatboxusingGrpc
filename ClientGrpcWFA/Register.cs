using Grpc.Net.Client;
using GrpcService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientGrpcWFA
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private  void ButtonSignup2_Click(object sender, EventArgs e)
        {
            string usename = textBoxUsename2.Text;
            string password = textBoxPassword2.Text;
            string confirmpass = textBoxConfirmpassword.Text;

            var grpcChannel = GrpcChannel.ForAddress("https://localhost:7082");
            var greeterClient = new Greeter.GreeterClient(grpcChannel);
            var greeterReply =  greeterClient.Register(
                new RegisterRequest{
                Username = usename,
                Password = password,
                ConfirmPass = confirmpass
                });

            MessageBox.Show(greeterReply.Message);
        }

        private void buttonSignin2_Click(object sender, EventArgs e)
        {
            SignIn form1 = new SignIn();
            form1.Show();
            this.Close();
        }
    }
}
