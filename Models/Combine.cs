using System;
using System.Collections.Generic;

namespace Crud_Sqlite.Models
{
    public class Combine
    {
        public XOffline xOffline {  get; set; }
        public XTicket xTicket { get; set; }
        public XItem xItem { get; set; }
        public XCard xCard { get; set; }
        public XFunction xFunction { get; set; }
        public XVip xVip { get; set; }

    }
}