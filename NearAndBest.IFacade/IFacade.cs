namespace NearAndBest.IFacade
{
    using DTOs.Common;
    using System.Collections.Generic;

    public interface IFacade<TDto> where TDto : BaseDTO
    {
        TDto GetById(int id);
        IEnumerable<TDto> GetAll();
        TDto Insert(TDto dto);
        void Insert(IEnumerable<TDto> dtos);
        TDto Update(TDto dto);
        void Update(IEnumerable<TDto> dtos);
        void Delete(int id);
        void Delete(IEnumerable<int> ids);
        void Purge(int id);
        void Purge(IEnumerable<int> ids);
    }
}
