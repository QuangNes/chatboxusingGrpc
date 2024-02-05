using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Google.Protobuf.WellKnownTypes;


namespace GrpcService.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }
        private bool IsStringInListString(string[] listBox, string test, int count_people)
        {
            for (int i = 0; i < count_people; i++)
            {
                if (listBox[i] == test)
                {
                    return true;
                }
            }
            return false;
        }

        public override Task<RegisterReply> Register(RegisterRequest request, ServerCallContext context)
        {
            if (Module.IsUserExist(request.Username) == false && request.Password == request.ConfirmPass)
            {
                if (request.Password != "" || request.ConfirmPass != "")
                {
                    Module.SaveUser(request.Username, request.Password);

                    return Task.FromResult(new RegisterReply
                    {
                        Message = "Sign up success!"
                    });
                }
                else
                {
                    return Task.FromResult(new RegisterReply
                    {
                        Message = "Password empty!"
                    });
                }
            }

            else if (Module.IsUserExist(request.Username) == true)
            {
                return Task.FromResult(new RegisterReply
                {
                    Message = "This account duplicates another account!"
                });
            }

            else
            {
                return Task.FromResult(new RegisterReply
                {
                    Message = "Confirm password different with password"
                });
            }
        }

        public override Task<SignInReply> SignIn(SignInRequest request, ServerCallContext context)
        {
            if (Module.IsUseName_PasswordCorrect(request.Username, request.Password) == true)
            {
                Module.GlobalVariables.nameOfUser = request.Username;
                return Task.FromResult(new SignInReply
                {
                    Message = "Login success!"
                });
            }
            else
            {
                if (Module.IsUserExist(request.Username) == false)
                {
                    return Task.FromResult(new SignInReply
                    {
                        Message = "Username is not Exist!"
                    });
                }
                else if (Module.IsPasswordCorrect(request.Password) == false)
                {
                    return Task.FromResult(new SignInReply
                    {
                        Message = "Password is not Correct!"
                    });
                }
                else
                {
                    return Task.FromResult(new SignInReply
                    {
                        Message = "System Eror!"
                    });
                }
            }
        }

        public override Task<AcceptIvteReply> CreateGroup(CreateGroupRequest request, ServerCallContext context)
        {
            bool flag = true;
            int count_people = 0;
            string[] another_usename = request.Invitemail.Split(' ');
            string[] listName = new string[10];

            Module.ReadFileToList(request.Username + ".txt", listName);

            foreach (string name in another_usename)
            {
                if (Module.IsUserExist(name) == true)
                {
                    count_people++;
                }
                else
                {
                    flag = false;
                    return Task.FromResult(new AcceptIvteReply
                    {
                        Message = "Username " + name + " is not Exist."
                    });
                }
            }
            if (flag != false)
            {

                if (IsStringInListString(listName, request.Invitemail, count_people) == true)
                {
                    return Task.FromResult(new AcceptIvteReply
                    {
                        Message = "Conversation is Exist."
                    });
                }
                else
                {
                    string group =  request.Invitemail;
                    foreach (string name in another_usename)
                    {
                        if (Module.IsUserExist(name) == true)
                        {
                            Module.WriteListToFile(name + ".txt", group);
                        }
                    }
                    return Task.FromResult(new AcceptIvteReply
                    {
                        Message = "Group Successfully Created!"
                    });
                }
            }
            else
            {
                return Task.FromResult(new AcceptIvteReply
                {
                    Message = "Create Group false"
                });
            }
        }

        public override Task<SendDataOfGroup> ServerSendDataOfGroup(ClientDownData request, ServerCallContext context)
        {
            string[] listName = new string[20];
            string namePath = request.Username + ".txt";
            string SourcName = "";
            int count = 0;
            if (File.Exists(namePath))
            {
                Module.ReadFileToList(namePath, listName);
            }
            foreach (string name in listName)
            {
                if (count != 0)
                {
                    SourcName += " ";
                }
                SourcName += name;
                count++;
            }
            return Task.FromResult(new SendDataOfGroup
            {
                Data = SourcName,
                Message = "Load File Group Successfully"
            });
        }

        public override Task<ServerReplyMess> SendMail(ClientSendMess request, ServerCallContext context)
        {

            string filePath = request.Group + "_mess.txt";
            string mess = request.Username + ": " + request.Mess;
            Module.GlobalVariables.receiveMess = true;
            Module.WriteListToFile(filePath, mess);

            return Task.FromResult(new ServerReplyMess
            {
                Message = "Send message successfully"
            });

            
        }

        public override Task<SendDataOfGroupMess> ServerSendDataMess(ClientDownDataNess request, ServerCallContext context)
        {

            string filepath = request.Group + "_mess.txt";
            string mess = Module.ReadFileMess(filepath);

            return Task.FromResult(new SendDataOfGroupMess
            {
                Message = mess
            });
        }


        public override Task<ClientRecieve> ServerReplyAll(ServerReply reply, ServerCallContext context)
        {
            if (Module.GlobalVariables.receiveMess == true && reply.Message == "Listning")
            {
                Module.GlobalVariables.receiveMess = false;
                return Task.FromResult(new ClientRecieve
                {
                    Message = "Server recieved mess!"
                });
            }
            else
            {
                return Task.FromResult(new ClientRecieve
                {
                    Message = "Server don`t recieve mess!"
                });
            }  
        }
    }
}
