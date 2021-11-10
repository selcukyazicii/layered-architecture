using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç.void metotları burada süslenecek
    public interface IResult
    {
        bool Success { get; } //get methodu return eder
        string Message { get; }
    }
}
