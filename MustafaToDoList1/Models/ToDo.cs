using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MustafaToDoList1.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}