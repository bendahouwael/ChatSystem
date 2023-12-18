using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

var socket = new Socket(
    AddressFamily.InterNetwork,
    SocketType.Stream,
    ProtocolType.Tcp
);
// loopback sur local host address de mon pc  
var endPoint = new IPEndPoint(
    IPAddress.Loopback,
    2345
);

try
{
    socket.Connect(endPoint);

    Thread t = new Thread(LireMessage);
    t.IsBackground = true;
    t.Start(socket);

    while (true)
    {
        string? message = Console.ReadLine();
        if (message == "q")
        {
            break;
        }
        if (!string.IsNullOrEmpty(message))
        {
            var buffer = Encoding.UTF8.GetBytes(message);
            socket.Send(buffer);
        }
    }
}
catch
{
    Console.WriteLine("Le serveur est injoinable");
}
finally
{
    if (socket.Connected)
    {
        socket.Shutdown(SocketShutdown.Both);
    }

    socket.Close();
}

void LireMessage(object? obj)
{
    if(obj is Socket socket)
    {
        while(true)
        {
            byte[] buffer = new byte[4096];
            int read = socket.Receive(buffer);
            if(read > 0)
            {
                var message = Encoding.UTF8.GetString(buffer, 0, read);
                System.Console.WriteLine(message);
            }
        }
    }
}