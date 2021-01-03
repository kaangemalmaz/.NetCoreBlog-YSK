using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;
using YSKProje.Business.Interfaces;
using YSKProje.Entities.Interfaces;

namespace YSKProje.API.CustomFilter
{
    public class ValidId<TEntity> : IActionFilter where TEntity : class, ITable, new()
    {
        private readonly IGenericService<TEntity> _genericService;

        public ValidId(IGenericService<TEntity> genericService)
        {
            _genericService = genericService;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var dictionary = context.ActionArguments.Where(i => i.Key == "id").FirstOrDefault();

            var id = int.Parse(dictionary.Value.ToString());

            var entity = _genericService.FindByIdAsync(id).Result;

            if (entity == null)
            {
                context.Result = new NotFoundObjectResult($"{id} değerine ait data bulunamamıştır.");
            }
        }
    }
}
