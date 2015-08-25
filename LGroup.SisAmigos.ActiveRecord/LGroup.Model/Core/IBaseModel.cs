using System;
using System.Collections.Generic;

namespace LGroup.Model.Core
{
    public interface IBaseModel<TModel> where  TModel : class
    {
        void Add();

        void Update();

        void Remove();

        IEnumerable<TModel> GetAll();
    }
}
