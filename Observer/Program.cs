// See https://aka.ms/new-console-template for more information

using Observer.Models;

Shop shop = new Shop("Samsung stooooore");

Client client1 = new Client("Client1");
Client client2 = new Client("Client2");
Client client3 = new Client("Client3");

shop.Attach(client2);
shop.Attach(client1);

shop.Notify();