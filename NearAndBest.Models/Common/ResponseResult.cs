namespace NearAndBest.Models.Common
{
    using System.Collections.Generic;
    using System.Linq;

    public partial class ResponseResult<T> : Result
       
    {
        public IEnumerable<T> Data { get; set; }
        public T First { get; set; }

        private ResponseResult()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="successMessage"></param>
        /// <returns></returns>
        public static ResponseResult<T> CreateSuccessResult(IEnumerable<T> data, string successMessage)
        {
            ResponseResult<T> response = new ResponseResult<T>
            {
                Data = data,
                IsSuccess = true,
                ResponseMessage = successMessage
            };

            if (response.Data != null && response.Data.Count() > 0)
            {
                response.First = data.First();
            }

            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="successMessage"></param>
        /// <returns></returns>
        public static ResponseResult<T> CreateSuccessResult(T first, string successMessage)
        {
            ResponseResult<T> response = new ResponseResult<T>
            {
                First = first,
                IsSuccess = true,
                ResponseMessage = successMessage
            };

            if (response.First != null)
            {
                response.Data = new List<T> { first };
            }

            return response;
        }

        public static ResponseResult<T> CreateErrorResult(string errorMessage)
        {
            ResponseResult<T> response = new ResponseResult<T>
            {
                IsSuccess = true,
                ResponseMessage = errorMessage
            };

            return response;
        }
    }

}