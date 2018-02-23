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


namespace SimpleServer
{
    public class Vars
    {
        public static System.Guid m_Version = new System.Guid("{ 0x3ae33249, 0xecc6, 0x4980, { 0xbc, 0x5d, 0x7b, 0xa, 0x99, 0x9c, 0x7, 0x39 } }");
        public static int m_serverPort = 33334;
    }
}

