namespace NearAndBest.WebServices.Controllers
{
    using AutoMapper;
    using NearAndBest.DTOs.Admin;
    using NearAndBest.Facade.Admin;
    using NearAndBest.IFacade.Admin;
    using Models.Admin;
    using Models.Common;
    using System;
    using System.Collections.Generic;
  
    using System.Web.Http;

    public class RolesController : ApiController
        , IControllerActions<RoleModel>
    {
        IRoleFacade roleFacade = new RoleFacade();

        [HttpGet]
        public ResponseResult<RoleModel> GetById(int id)
        {
            ResponseResult<RoleModel> result = null;
            try
            {
                var data = roleFacade.GetById(id);
                result = ResponseResult<RoleModel>.CreateSuccessResult(Mapper.Map<RoleDTO, RoleModel>(data), string.Empty);
            }
            catch (Exception ex)
            {
                result = ResponseResult<RoleModel>.CreateErrorResult(string.Empty);
            }

            return result;
        }


        [HttpGet]
        public ResponseResult<RoleModel> GetAll()
        {
            ResponseResult<RoleModel> result = null;
            try
            {
                var data = roleFacade.GetAll();
                result =ResponseResult<RoleModel>.CreateSuccessResult(
                    Mapper.Map<IEnumerable<RoleDTO>, IEnumerable<RoleModel>>(data), string.Empty);
            }
            catch (Exception ex)
            {
                result = ResponseResult<RoleModel>.CreateErrorResult(string.Empty);
            }

            return result;
        }

        [HttpPost]
        public ResponseResult<RoleModel> Insert(RoleModel model)
        {
            ResponseResult<RoleModel> result = null;
            try
            {
                var dto = roleFacade.Insert(Mapper.Map<RoleModel, RoleDTO>(model));
                result = ResponseResult<RoleModel>.CreateSuccessResult(
                   Mapper.Map<RoleDTO, RoleModel>(dto), string.Empty);
            }
            catch (Exception ex)
            {
                result = ResponseResult<RoleModel>.CreateErrorResult(string.Empty);
            }

            return result;
        }

        [HttpPut]
        public ResponseResult<RoleModel> Update(RoleModel model)
        {
            ResponseResult<RoleModel> result = null;
            try
            {
                var dto = roleFacade.Update(Mapper.Map<RoleModel, RoleDTO>(model));
                result = ResponseResult<RoleModel>.CreateSuccessResult(
                   Mapper.Map<RoleDTO, RoleModel>(dto), string.Empty);
            }
            catch (Exception ex)
            {
                result = ResponseResult<RoleModel>.CreateErrorResult(string.Empty);
            }

            return result;
        }

        [HttpPut]
        public ResponseResult<bool> Delete(int id)
        {
            ResponseResult<bool> result = null;
            try
            {
                roleFacade.Delete(id);
                result = ResponseResult<bool>.CreateSuccessResult(
                   true, string.Empty);
            }
            catch (Exception ex)
            {
                result = ResponseResult<bool>.CreateErrorResult(string.Empty);
            }

            return result;
        }

        [HttpDelete]
        public ResponseResult<bool> Purge(int id)
        {
            ResponseResult<bool> result = null;
            try
            {
                roleFacade.Purge(id);
                result = ResponseResult<bool>.CreateSuccessResult(
                   true, string.Empty);
            }
            catch (Exception ex)
            {
                result = ResponseResult<bool>.CreateErrorResult(string.Empty);
            }

            return result;
        }
    }
}
