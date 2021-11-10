using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        //işlem başarılı class'ı olduğu için true döndürüyoruz
        public SuccessResult(string message) : base(true, message)
        {

        }
        public SuccessResult():base(true) //base'in tek parametreli olanını çalıştır
        {

        }
    }
}
