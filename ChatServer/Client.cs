using System;
using System.Net.Sockets;

namespace ChatClient
{
    public class Client
    {
        // pour stoker les infos du client 
        // proprité pour le client
        public Socket Socket {get; set;}
        public string Nom {get; set;}

        public Guid Id {get; set;}
    }
}
