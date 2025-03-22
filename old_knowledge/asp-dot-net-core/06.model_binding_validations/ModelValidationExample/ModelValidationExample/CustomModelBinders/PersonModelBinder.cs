using Microsoft.AspNetCore.Mvc.ModelBinding;
using ModelValidationExample.models;

namespace ModelValidationExample.CustomModelBinders {
    public class PersonModelBinder : IModelBinder {
        public Task BindModelAsync(ModelBindingContext bindingContext) {
            Person person = new Person();
            // FirstName and LastName
            if (bindingContext.ValueProvider.GetValue("FirstName").Length > 0) {

                string? firstName = bindingContext.ValueProvider.GetValue("FirstName").FirstValue;

                if (bindingContext.ValueProvider.GetValue("LastName").Length > 0) {
                    person.PersonName += " " + bindingContext.ValueProvider.GetValue("FirstName").FirstValue;
                }
            }
            bindingContext.Result = ModelBindingResult.Success(person);
        }
    }
}
