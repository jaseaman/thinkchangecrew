﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STU.Shared.Model
{
    public class Announcement : BaseModel
    {
        public DateTime DateAndTime { get; set; }
        public string Content { get; set; }
    }
}
