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
    public partial class Chat : Form
    {
        private Timer timer = new Timer();

        static bool KiemTraChuoi(string chuoi, string chuoiCanKiemTra)
        {
            // Sử dụng phương thức Contains để kiểm tra
            return chuoi.Contains(chuoiCanKiemTra);
        }

        public Chat()
        {
            InitializeComponent();
            NameUser.Text = SupportClient.GlobalVariables.nameOfUser;

            //Download data of group

            var grpcChannel = GrpcChannel.ForAddress("https://localhost:7082");
            var greeterClient = new Greeter.GreeterClient(grpcChannel);
            var greeterReply = greeterClient.ServerSendDataOfGroup(new ClientDownData
            {
                Username = NameUser.Text
            });
            MessageBox.Show(greeterReply.Message);
            string inputString = greeterReply.Data;

            string[] listGroup = inputString.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            if (listGroup.Length > 0)
            {
                Array.Resize(ref listGroup, listGroup.Length - 1);
            }

            foreach (string group in listGroup)
            {
                listBoxGroup.Items.Add("Group: " + group);
            }
            InitializeTimer();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSendInvite_Click(object sender, EventArgs e)
        {
            string group = textBoxInvite.Text;
            var grpcChannel = GrpcChannel.ForAddress("https://localhost:7082");
            var greeterClient = new Greeter.GreeterClient(grpcChannel);
            var greeterReply = greeterClient.CreateGroup(new CreateGroupRequest { 
                Invitemail = group,
                Username = NameUser.Text
            });

            MessageBox.Show(greeterReply.Message);
            if (greeterReply.Message == "Group Successfully Created!")
            {
                listBoxGroup.Items.Add("Group: " + group);
            }
        }

        private void buttonSendMess_Click(object sender, EventArgs e)
        {
            if (listBoxGroup.SelectedIndex == -1)
            {
                MessageBox.Show("Please Let`s choose group chat !");
            }
            else
            {
                int selectedIndex = listBoxGroup.SelectedIndex;
                string mess = textBoxMessage.Text;
                string name_group = listBoxGroup.Items[selectedIndex].ToString();
                name_group = name_group.Replace("Group: ", "");
                var grpcChannel = GrpcChannel.ForAddress("https://localhost:7082");
                var greeterClient = new Greeter.GreeterClient(grpcChannel);
                var greeterReply = greeterClient.SendMail(new ClientSendMess
                {
                    Group = name_group,
                    Mess = mess,
                    Username = NameUser.Text
                });
                if (greeterReply.Message == "Send message successfully")
                {
                    listBoxMessage.Items.Add(NameUser.Text + ": " + mess);
                }
            }
        }

        private void listBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxMessage.Items.Clear();
            int selectedIndex = listBoxGroup.SelectedIndex;
            if (selectedIndex != -1)
            {
                string name_group = listBoxGroup.Items[selectedIndex].ToString();
                name_group = name_group.Replace("Group: ", "");
                var grpcChannel = GrpcChannel.ForAddress("https://localhost:7082");
                var greeterClient = new Greeter.GreeterClient(grpcChannel);
                var greeterReply = greeterClient.ServerSendDataMess(new ClientDownDataNess
                {
                    Group = name_group
                });

                string StringMess = greeterReply.Message;

                string[] listMess = StringMess.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string mess in listMess)
                {
                    listBoxMessage.Items.Add(mess);
                }
            }   
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            var grpcChannel = GrpcChannel.ForAddress("https://localhost:7082");
            var greeterClient = new Greeter.GreeterClient(grpcChannel);
            //Download data of group

            listBoxGroup.Items.Clear();
            var greeterReply = greeterClient.ServerSendDataOfGroup(new ClientDownData
            {
                Username = NameUser.Text
            });

            string inputString = greeterReply.Data;

            string[] listGroup = inputString.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            if (listGroup.Length > 0)
            {
                Array.Resize(ref listGroup, listGroup.Length - 1);
            }

            foreach (string group in listGroup)
            {
                listBoxGroup.Items.Add("Group: " + group);
            }
    
        }

        private void Chat_Load(object sender, EventArgs e)
        {
     
        }

        private void InitializeTimer()
        {
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
            var grpcChannel = GrpcChannel.ForAddress("https://localhost:7082");
            var greeterClient = new Greeter.GreeterClient(grpcChannel);
            var greeterReply = greeterClient.ServerReplyAll(new ServerReply { Message = "Listning" });
            if (greeterReply.Message == "Server recieved mess!")
            {
                int selectedIndex = listBoxGroup.SelectedIndex;
                if (selectedIndex != -1)
                {
                    string name_group = listBoxGroup.Items[selectedIndex].ToString();
                    name_group = name_group.Replace("Group: ", "");

                    if (KiemTraChuoi(name_group, NameUser.Text) == true)
                    {

                        listBoxGroup_SelectedIndexChanged(sender, e);
                    }
                }
            }
        }
    }
}
