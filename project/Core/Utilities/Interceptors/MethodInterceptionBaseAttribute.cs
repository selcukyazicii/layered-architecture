using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{


    //Bu Attribute'u classlara ve methotlara ekleyebilirsin,birden fazla ekleyebilir ve inherit edilen noktada
    //çalışabilir.
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; } //hangi attribute'un önce çalışacağını seçer

        public virtual void Intercept(IInvocation invocation)
        {

        }
    }
}
