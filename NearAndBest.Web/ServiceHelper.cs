

namespace NearAndBest.Web
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using NearAndBest.Models.Common;

    public static class ServiceHelper<T>
    {
        #region Public Methods

        public static ResponseResult<T> GetResource(string requestUrl)
        {
            // create client for server request
            using (var client = CreateClient())
            {
                // make request
                HttpResponseMessage response = client.GetAsync(requestUrl).Result;
                ResponseResult<T> resourceData = default(ResponseResult<T>);
                if (response.IsSuccessStatusCode)
                {
                    resourceData = response.Content.ReadAsAsync<ResponseResult<T>>().Result;
                }

                return resourceData;
            }
        }

        public static ResponseResult<T> PostResource(string requestUrl, T data)
        {
            // create client for server request
            using (var client = CreateClient())
            {
                // make request
                HttpResponseMessage response = client.PostAsJsonAsync(requestUrl, data).Result;

                ResponseResult<T> resourceData = default(ResponseResult<T>);

                if (response.IsSuccessStatusCode)
                {
                    resourceData = response.Content.ReadAsAsync<ResponseResult<T>>().Result;
                }

                return resourceData;
            }
        }

        public static ResponseResult<T> PutResource(string requestUrl, T data)
        {
            // create client for server request
            using (var client = CreateClient())
            {
                // make request
                HttpResponseMessage response = client.PutAsJsonAsync(requestUrl, data).Result;

                ResponseResult<T> resourceData = default(ResponseResult<T>);

                if (response.IsSuccessStatusCode)
                {
                    resourceData = response.Content.ReadAsAsync<ResponseResult<T>>().Result;
                }

                return resourceData;
            }
        }

        public static ResponseResult<bool> DeleteResource(string requestUrl, int id)
        {
            // create client for server request
            using (var client = CreateClient())
            {
                // make request
                HttpResponseMessage response = client.PutAsJsonAsync(requestUrl, id).Result;

                ResponseResult<bool> resourceData = default(ResponseResult<bool>);

                if (response.IsSuccessStatusCode)
                {
                    resourceData = response.Content.ReadAsAsync<ResponseResult<bool>>().Result;
                }

                return resourceData;
            }
        }

        public static ResponseResult<bool> PurgeResource(string requestUrl)
        {
            // create client for server request
            using (var client = CreateClient())
            {
                // make request
                HttpResponseMessage response = client.DeleteAsync(requestUrl).Result;

                ResponseResult<bool> resourceData = default(ResponseResult<bool>);

                if (response.IsSuccessStatusCode)
                {
                    resourceData = response.Content.ReadAsAsync<ResponseResult<bool>>().Result;
                }

                return resourceData;
            }
        }

        #endregion

        #region Private Methods


        private static HttpClient CreateClient()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationHelper.ServiceUrl);

            // add header informaiton
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Constants.ContentTypes.ApplicationJson));

            return client;
        }
        #endregion
    }
}