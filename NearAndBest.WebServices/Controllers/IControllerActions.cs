namespace NearAndBest.WebServices.Controllers
{
    using Models.Common;
    using NearAndBest.DTOs.Common;

    public interface IControllerActions<TModel>
        where TModel : BaseModel
    {
        ResponseResult<TModel> GetById(int id);
        ResponseResult<TModel> GetAll();
        ResponseResult<TModel> Insert(TModel model);
        ResponseResult<TModel> Update(TModel model);
        ResponseResult<bool> Delete(int id);
        ResponseResult<bool> Purge(int id);
    }
}
