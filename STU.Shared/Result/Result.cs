using System;
using System.Collections.Generic;
using System.Text;

namespace STU.Common.Result
{
    public class Result
    {
        bool Success { get; set; }
        string Message { get; set; }
    }

    public class Result<T> : Result
    {
        T Data { get; set; }
    }
}
