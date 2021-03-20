﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace EShopMultilayered.DataAccess.Interfaces
{
    public interface IRepository<T> where T : IBaseEntity
    {
        T GetById(int id);
        IEnumerable<T> List();
        IEnumerable<T> List(Expression<Func<T, bool>> predicate);
        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
