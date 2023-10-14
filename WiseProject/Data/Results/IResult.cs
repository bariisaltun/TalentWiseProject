using System;
using System.Collections.Generic;
using System.Text;

namespace WiseProject.Data.Results
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
