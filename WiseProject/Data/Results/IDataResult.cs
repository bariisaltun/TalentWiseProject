using System;
using System.Collections.Generic;
using System.Text;

namespace WiseProject.Data.Results
{
    public interface IDataResult<out T>:IResult
    {
        T Data { get; }
    }
}
