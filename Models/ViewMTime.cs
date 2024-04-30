using System;
using Crud_Sqlite.Data;
using System.Collections.Generic;
using Crud_Sqlite.Models;

namespace Crud_Sqlite.Models
{
    public class ViewMTime
    {
        public List<Tuple<DateTime, TimeSpan, TimeSpan>> timerange { get; set; }
        public List<CombineVM> combineVMlist { get; set; }

    }

}