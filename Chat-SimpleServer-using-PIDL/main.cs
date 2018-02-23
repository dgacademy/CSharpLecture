using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Nettention.Proud;

namespace SimpleServer
{
    class Program
    {
        // RMI stub instance
        // For details, check client source code first.
        static Simple.Stub g_Stub = new Simple.Stub();

        // RMI proxy
        static Simple.Proxy g_Proxy = new Simple.Proxy();

        // a P2P group where all clients are in.
        static HostID g_groupHostID = HostID.HostID_None;

        static void InitStub()
        {
            g_Stub.RequestChat = (Nettention.Proud.HostID remote, Nettention.Proud.RmiContext rmiContext, String message) =>
                {
                    Console.Write("[Server] chat message received :");
                    Console.Write(" message={0}\n", message);

                    // Echo chatting message which received from server to client.
                    string replyMessage = "ServerToClient: " + message;
                    g_Proxy.ReplyChat(remote, RmiContext.ReliableSend, replyMessage);

                    return true;
                };
        }

        internal static void StartServer(NetServer server, Nettention.Proud.StartServerParameter param)
        {
            if ((server == null) || (param == null))
            {
                throw new NullReferenceException();
            }

            try
            {
                server.Start(param);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Failed to start server~!!" + ex.ToString());
            }

            Console.WriteLine("Succeed to start server~!!\n");
        }

        static void Main(string[] args)
        {
            // Network server instance.
            NetServer srv = new NetServer();


            // set a routine which is executed when a client is joining.
            // clientInfo has the client info including its HostID.
            srv.ClientJoinHandler = (clientInfo) =>
            {
                Console.WriteLine("#clients: {0}", srv.GetClientHostIDs().Length);
                Console.WriteLine("Client {0} connected.\n", clientInfo.hostID);
            };
            // set a routine for client leave event.
            srv.ClientLeaveHandler = (clientInfo, errorInfo, comment) =>
            {
                Console.WriteLine("Client {0} disconnected.\n", clientInfo.hostID);
            };

            InitStub();

            // Associate RMI proxy and stub instances to network object.
            srv.AttachStub(g_Stub);
            srv.AttachProxy(g_Proxy);

            var p1 = new StartServerParameter();
            p1.protocolVersion = new Nettention.Proud.Guid(Vars.m_Version); // This must be the same to the client.
            p1.tcpPorts.Add(Vars.m_serverPort); // TCP listening endpoint

            srv.ReceiveUserMessageHandler = (sender, rmiContext, payload) =>
            {
                Console.Write(payload.data.Length);
                Console.Write(System.Text.Encoding.Default.GetString(payload.data));
            };

            try
            {
                /* Starts the server.
                This function throws an exception on failure.
                Note: As we specify nothing for threading model,
                RMI function by message receive and event callbacks are
                called in a separate thread pool.
                You can change the thread model. Check out the help pages for details. */
                srv.Start(p1);
            }
            catch (Exception e)
            {
                Console.Write("Server start failed: {0}\n", e.ToString());
                return;
            }

            Console.Write("Server started. Enterable commands:\n");
            Console.Write("q: Quit.\n");

            string userInput;

            while (true)
            {
                // get user input
                userInput = Console.ReadLine();

                if (userInput == "q")
                {
                    // exit program.
                    break;
                }
                else if (userInput == "m")
                {
                }

            }

            srv.Stop();
        }
    }
}
