using System;
using System.Collections.Generic;
using System.Web.Http.Controllers;
using System.Web.Http.ModelBinding;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Core.Domain.Documents.Common;
using Core.Domain.Documents;

namespace WebApp.mine.ModelBinders
{
    public class DocumentBinder : IModelBinder
    {
        private static Dictionary<int, Type> _docTypes = new Dictionary<int, Type>()
        {
            { Квитанция.DocTypeStatic, typeof(Квитанция) },
            { ПлатежноеПоручение.DocTypeStatic, typeof(ПлатежноеПоручение) },
            { Счет.DocTypeStatic, typeof(Счет) }
        };

        public bool BindModel(HttpActionContext actionContext, ModelBindingContext bindingContext)
        {
            if (bindingContext.ModelType != typeof(Документ))
                return false;

            var json = actionContext.Request.Content.ReadAsStringAsync().Result;
            var jObject = JObject.Parse(json);
            var docType = jObject.Value<int>("DocType");

            if (!_docTypes.ContainsKey(docType))
            {
                bindingContext.ModelState.AddModelError("DocType", $"Ошибка биндинга. Неизвестный тип документа: {docType}");
                return false;
            }

            var document = JsonConvert.DeserializeObject(json, _docTypes[docType]);

            bindingContext.Model = document;

            // Это приведет только к заполнению ошибок в модели после валидации полей.
            // Проверку наличия ошибок и ответ клиенту, если они есть, - нужно писать отдельно.
            // Это можно сделать через ActionFilter, т.к. сперва выполняется биндинг, а потом - фильтры.
            bindingContext.ValidationNode.ValidateAllProperties = true;
            bindingContext.ValidationNode.Validate(actionContext);

            return true;
        }
    }
}