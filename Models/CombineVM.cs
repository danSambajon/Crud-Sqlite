using System;
using Crud_Sqlite.Data;
using System.Collections.Generic;
using Crud_Sqlite.Models;

namespace Crud_Sqlite.Models
{
    public class CombineVM
    {
        public XOffline xOfflines { get; set; }
        public XTicket xTickets { get; set; }
        public XItem xItems { get; set; }
        public XCard xCards { get; set; }
        public XFunction xFunctions { get; set; }
        public XVip xVips { get; set; }
        public List<Tuple<TimeSpan, TimeSpan>> timeranges
        {
            get; set;
        }
    }
}