using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExam.Hubs
{
    public class ChatHub : Hub
    {
        private string _prefix = "echo: ";

        public void Send(string message)
        {
            Clients.All.addNewMessage(_prefix + message);
        }
    }
}