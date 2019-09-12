﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApi.Model
{
    public class Mark
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public virtual ICollection<MarkObjective> Objectives { get; set; }

    }
}
