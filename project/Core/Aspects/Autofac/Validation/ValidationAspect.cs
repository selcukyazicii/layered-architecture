using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception //Aspect

    //Validator type istiyor,attribute olarak bu class çağrılır.ValidatorType=ProductValidator
    //before gibi override metotlar burada ezilir 
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            //defensive coding
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değil");
            }

            _validatorType = validatorType;
        }


        protected override void OnBefore(IInvocation invocation)
        {
            //ProductValidator'un instance'ını oluştur,ProductValidator'un çalışma tipini bul
            //Onun generic çalıştığı tipi bul (Product),Sonra metot parametrelerini bul.
            //örn (Product product) gibi.Validatorun tipine eşit olan parametreleri bul.
            //her birini tek tek gez ve ValidationTool'u kullanarak Validate et.

            //Activator CreateIns
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
