﻿using System;
using GameServer.Servers;
namespace GameServer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 启动
            Server server = new Server("127.0.0.1",4869);
            server.Start();
            Console.ReadKey(); // 服务器暂停
        }
    }
}