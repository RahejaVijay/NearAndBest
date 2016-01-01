namespace NearAndBest.Facade.Admin
{
    using AutoMapper;
    using NearAndBest.Database;
    using NearAndBest.DTOs.Admin;
    using NearAndBest.DTOs.Common;
    using NearAndBest.Entities.Admin;
    using NearAndBest.IFacade;
    using NearAndBest.IFacade.Admin;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RoleFacade : Facade,IRoleFacade
    {
        RoleDTO IFacade<RoleDTO>.GetById(int id)
        {
            RoleDTO role = null;
            using (NearAndBestContext context = new NearAndBestContext())
            {
                var roleDB = context.Roles.Where(r => r.Id == id && r.IsDeleted == false).FirstOrDefault();

                if (roleDB != null)
                {
                    role = Mapper.Map<Role, RoleDTO>(roleDB);
                }
            }
            return role;
        }

        IEnumerable<RoleDTO> IFacade<RoleDTO>.GetAll()
        {
            IEnumerable<RoleDTO> roles = null;
            using (NearAndBestContext context = new NearAndBestContext())
            {
                var dbRoles = context.Roles.Where(r => r.IsDeleted == false).ToList();

                if (dbRoles != null)
                {
                    roles = Mapper.Map<IEnumerable<Role>, IEnumerable<RoleDTO>>(dbRoles);
                }
            }

            return roles;
        }

        public RoleDTO Insert(RoleDTO dto)
        {
            using (NearAndBestContext context = new NearAndBestContext())
            {
                var entity = Mapper.Map<RoleDTO, Role>(dto);
                AddInsertionDetail(entity);
                context.Roles.Add(entity);

                context.SaveChanges();
                dto.Id = entity.Id;
            }

            return dto;
        }

        public void Insert(IEnumerable<RoleDTO> dtos)
        {
            using (NearAndBestContext context = new NearAndBestContext())
            {
                var entities = Mapper.Map<IEnumerable<RoleDTO>, IEnumerable<Role>>(dtos);

                AddInsertionDetail(entities);
                context.Roles.AddRange(entities);

                context.SaveChanges();
            }
        }

        public RoleDTO Update(RoleDTO dto)
        {
            using (NearAndBestContext context = new NearAndBestContext())
            {
                var roles =  context.Roles.Where(r => r.Id == dto.Id);
                foreach (var role in roles)
                {
                    Mapper.Map<RoleDTO, Role>(dto, role);
                    AddUpdationDetail(role);
                }
               context.SaveChanges();
               
            }

            return dto;
        }

        public void Update(IEnumerable<RoleDTO> dtos)
        {
            using (NearAndBestContext context = new NearAndBestContext())
            {
                var roles = from r in context.Roles
                            join d in dtos on r.Id equals d.Id
                            select new { entity = r, dto= d};

                foreach (var role in roles)
                {
                    Mapper.Map<RoleDTO, Role>(role.dto, role.entity);
                    AddUpdationDetail(role.entity);
                }
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (NearAndBestContext context = new NearAndBestContext())
            {
                var roles = context.Roles.Where(r => r.Id == id);
                foreach (var role in roles)
                {
                    AddUDeletionDetail(role);
                }

                context.SaveChanges();
            }
        }

        public void Delete(IEnumerable<int> ids)
        {
            using (NearAndBestContext context = new NearAndBestContext())
            {
                var roles = (from r in context.Roles
                            join id in ids on r.Id equals id
                            select r).AsEnumerable();

                AddUDeletionDetail(roles);
                
                context.SaveChanges();
            }
        }

        public void Purge(int id)
        {
            using (NearAndBestContext context = new NearAndBestContext())
            {
                var roles = context.Roles.Where(r => r.Id == id);
                foreach (var role in roles)
                {
                    context.Roles.Remove(role);
                }

                context.SaveChanges();
            }
        }

        public void Purge(IEnumerable<int> ids)
        {
            using (NearAndBestContext context = new NearAndBestContext())
            {
                var roles = (from r in context.Roles
                             join id in ids on r.Id equals id
                             select r).AsEnumerable();

                context.Roles.RemoveRange(roles);

                context.SaveChanges();
            }
        }
    }
}
