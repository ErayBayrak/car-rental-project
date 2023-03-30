using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{
    //Inherited=true => kalıtım yapılan yerde de çalışmasını sağlar
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority { get; set; }

        public virtual void Intercept(IInvocation invocation)
        {

        }
    }
}
