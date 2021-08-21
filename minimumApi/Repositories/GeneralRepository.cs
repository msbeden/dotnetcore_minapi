using minimumApi.Extensions;
using minimumApi.Models;
using minimumApi.Models.Abstractions;
using minimumApi.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace minimumApi.Repositories
{
    public class GeneralRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly minimumApiDbContext _ankaDbContext;
        private DbSet<T> _entities;
        protected virtual DbSet<T> Entities => this._entities ??= this._ankaDbContext.Set<T>();
        public GeneralRepository(minimumApiDbContext ankaDbContext)
        {
            this._ankaDbContext = ankaDbContext;
            this._entities = ankaDbContext.Set<T>();
        }
        public IQueryable<T> Table => this.Entities;

        public IQueryable<T> TableNoTracking => this.Entities.AsNoTracking();

        public long Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            Entities.Remove(entity);
            long result = this._ankaDbContext.SaveChanges();
            return result;
        }

        public virtual long Delete(IEnumerable<T> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            foreach (var entity in entities)
            {
                this.Entities.Remove(entity);
            }
            long result = this._ankaDbContext.SaveChanges();
            return result;
        }

        public T GetById(object id)
        {
            return this.Entities.Find(id);
        }

        public IEnumerable<T> GetSql(string sql)
        {
            return this.Entities.FromSqlRaw(sql);
        }

        public IQueryable<T> IncludeMany(params Expression<Func<T, object>>[] includes)
        {
            return this.TableNoTracking.IncludeMultiple(includes);
        }

        public long Insert(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            this._entities.Add(entity);
            this._ankaDbContext.SaveChanges();

            PropertyValues entityData = this._ankaDbContext.Entry(entity).GetDatabaseValues();
            IProperty primaryKeyProp = entityData.Properties.FirstOrDefault(x => x.IsKey());
            object result = entityData.GetValue<object>(propertyName: primaryKeyProp.Name);
            long response = Convert.ToInt64(result);
            return response;
        }

        public virtual long Insert(IEnumerable<T> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            foreach (var entity in entities)
            {
                this.Entities.Add(entity);
            }

            long result = this._ankaDbContext.SaveChanges();
            return result;
        }

        public long Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            this._ankaDbContext.Update(entity);
            this._ankaDbContext.SaveChanges();

            PropertyValues entityData = this._ankaDbContext.Entry(entity).GetDatabaseValues();
            IProperty primaryKeyProp = entityData.Properties.FirstOrDefault(x => x.IsKey());
            object result = entityData.GetValue<object>(propertyName: primaryKeyProp.Name);
            long response = Convert.ToInt64(result);
            return response;
        }

        public virtual long Update(IEnumerable<T> entities)
        {
            if (entities == null)
                throw new ArgumentNullException(nameof(entities));

            long result = this._ankaDbContext.SaveChanges();
            return result;
        }
    }
}
