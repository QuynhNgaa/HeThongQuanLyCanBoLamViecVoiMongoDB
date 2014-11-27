using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;

namespace Login
{
    class Log
    {
        public ObjectId _id { get; set; }
        public DateTime time { get; set; }
        public String task { get; set; }
        public String Admin { get; set; }
        public String detail { get; set; }

        public Log(DateTime time, String task, String Admin, String detail)
        {
            this.time = time;
            this.task = task;
            this.Admin = Admin;
            this.detail = detail;
        }

    }
}
