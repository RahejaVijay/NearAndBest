namespace NearAndBest.Facade
{
    using Entities.Common;
    using System;
    using System.Collections.Generic;

    public class Facade
    {
        public void AddInsertionDetail<T>(T entity)
            where T : BaseEntity
        {
            // fill id via taking from user
            entity.CreatedBy = 1;
            entity.CreatedDate = DateTime.Now;
            entity.ModifiedBy = 1;
            entity.ModifiedDate = DateTime.Now;
            entity.IsDeleted = false; 
        }

        public void AddInsertionDetail<T>(IEnumerable<T> entities)
           where T : BaseEntity
        {
            // fill id via taking from user
            foreach (var entity in entities)
            {
                entity.CreatedBy = 1;
                entity.CreatedDate = DateTime.Now;
                entity.ModifiedBy = 1;
                entity.ModifiedDate = DateTime.Now;
                entity.IsDeleted = false;
            }
        }

        public void AddUpdationDetail<T>(T entity)
         where T : BaseEntity
        {
            entity.CreatedBy = 1;
            entity.CreatedDate = DateTime.Now;
            entity.ModifiedBy = 1;
            entity.ModifiedDate = DateTime.Now;
            entity.IsDeleted = false;
        }

        public void AddUpdationDetail<T>(IEnumerable<T> entities)
         where T : BaseEntity
        {
            foreach (var entity in entities)
            {
                entity.CreatedBy = 1;
                entity.CreatedDate = DateTime.Now;
                entity.ModifiedBy = 1;
                entity.ModifiedDate = DateTime.Now;
                entity.IsDeleted = false;
            }
        }

        public void AddUDeletionDetail<T>(T entity)
                where T : BaseEntity
        {
            entity.IsDeleted = true;
            entity.ModifiedBy = 1;
            entity.ModifiedDate = DateTime.Now;
        }

        public void AddUDeletionDetail<T>(IEnumerable<T> entities)
             where T : BaseEntity
        {
            foreach (var entity in entities)
            {
                entity.IsDeleted = true;
                entity.ModifiedBy = 1;
                entity.ModifiedDate = DateTime.Now;
            }
        }
    }
}
