using System;
using System.Collections.Generic;
using System.Net;

namespace ServerListener.ServerModel
{
    public class ClientsRequest
    {
        public EndPoint EndPoint { get; set; } //Клиент
        public List<DateTime> Request { get; set; } //Время запросов
    }
}
