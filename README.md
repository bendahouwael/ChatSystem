# C# Chat System

This project consists of a simple client-server chat system implemented in C# using sockets. The chat system allows multiple clients to connect to a central server, facilitating real-time communication between users.

## Server

### Setup

1. Open the server project in your preferred C# development environment.
2. Build and run the server application.
3. The server will listen on a specified IP address and port for incoming connections.

### Features

- Supports multiple simultaneous client connections.
- Relays messages between clients in real-time.
- Dynamic handling of client connections and disconnections.

## Client

### Setup

1. Open the client project in your preferred C# development environment.
2. Build and run the client application.
3. Connect to the running server by entering messages in the console.

### Usage

- Type messages in the console to send them to the server.
- To exit the client, type "q" in the console.

### Additional Notes

- The server and client communicate using TCP/IP sockets.
- Basic exception handling is implemented for network operations.
- Make sure to handle exceptions gracefully to ensure a stable user experience.

## Contributions

Feel free to contribute, report issues, or suggest improvements. Your feedback is valuable!
