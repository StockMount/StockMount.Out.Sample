using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockMount.Out.Sample.Models.ServicesModels
{
    public class UserMessages
    {
        public int MessageCount { get; set; }
        public List<UserMessage> Messages { get; set; }
    }

    public class UserMessage 
    {
        public int UserMessageId { get; set; }
        public string Code { get; set; }
        public string Subject { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int MessageTypeId { get; set; }
        public string Avatar { get; set; }
        public string Body { get; set; }
        public DateTime Time { get; set; }
        public bool Unread { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
    }

}