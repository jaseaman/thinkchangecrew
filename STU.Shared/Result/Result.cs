﻿using System;
using System.Collections.Generic;
using System.Text;

namespace STU.Common.Result
{
    public class Result
    {
        public bool Success { get; set; }
        public string Message { get; set; }
    }

    public class Result<T> : Result
    {
        public T Data { get; set; }
    }
}
