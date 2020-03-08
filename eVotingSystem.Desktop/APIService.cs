using System.Threading.Tasks;
using System.Windows.Forms;
using eVotingSystem.CORE.Helpers;
using System.Collections.Generic;
using System.Text;
using Flurl.Http;
using eVotingSystem.CORE.Requests;
using System;

namespace eVotingSystem.Desktop
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static  Guid Token { get; set; }
        public static UserDTO CurrentUser { get; set; }
        private readonly string _route = null;
        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {
            var URL = $"{Properties.Resources.APIUrl}/{_route}";

            try
            {
                if (search != null)
                {
                    URL += "?";
                    URL += await search.ToQueryStringAsync();
                }
                return await URL.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Niste autentificirani");
                }
                throw;
            }
        }
        public async Task<T> GetById<T>(object id)
        {
            var url = $"{Properties.Resources.APIUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }


        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Resources.APIUrl}/{_route}";

            try
            {
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }


        }

        public async Task<T> Update<T>(int id, object request)
        {
            try
            {
                var url = $"{Properties.Resources.APIUrl}/{_route}/{id}";

                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }

        }
        public async Task<FileDTO> UploadFile<T>(string a, string b,byte[] c)
        {
            var url = $"{Properties.Resources.APIUrl}/FileSystemUpload";
            try
            {
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(new KeyValuePair<string,byte[]>(b,c)).ReceiveJson<FileDTO>();
            }
            catch (FlurlHttpException ex)
            {
                return default(FileDTO);

            }
        }
    }
}
