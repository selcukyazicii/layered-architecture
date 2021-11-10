using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult  //Datayı aldıktan sonra IResult üzerinden x mesajını al.
    {
        T Data { get;}
    }
}
