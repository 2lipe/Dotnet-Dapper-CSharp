using Blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Repositories
{
    public abstract class Repository<TModel> where TModel : Base
    {
        private readonly SqlConnection _connection;

        public Repository(SqlConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<TModel> GetAll()
        {
            return _connection.GetAll<TModel>();
        }

        public TModel GetById(int id)
        {
            var model = _connection.Get<TModel>(id);

            return model;
        }

        public void Create(TModel model)
        {
            model.Id = 0;

            _connection.Insert<TModel>(model);
        }

        public void Update(TModel model)
        {
            if (model.Id != 0)
            {
                _connection.Update<TModel>(model);
            }
        }

        public void Delete(TModel model)
        {
            if (model.Id != 0)
            {
                _connection.Delete<TModel>(model);
            }
        }

        public void Delete(int id)
        {
            if (id != 0)
            {
                return;
            }

            var model = _connection.Get<TModel>(id);

            _connection.Delete<TModel>(model);
        }
    }
}
