using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApi.Model
{
    public class MarkObjective
    {
        public int MarkId { get; set; }
        public Mark Mark { get; set; }
        public int ObjectiveId { get; set; }
        public Objective Objective { get; set; }
    }
}
