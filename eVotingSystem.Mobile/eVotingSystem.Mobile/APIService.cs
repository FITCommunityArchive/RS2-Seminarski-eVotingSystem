using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using eVotingSystem.CORE.Helpers;
using eVotingSystem.CORE.Requests;
using System.IO;

namespace eVotingSystem.Mobile
{
    public class APIService
    {
        #region props
        public static string Username { get; set; } = "demo.client";
        public static string Password { get; set; } = "demo";

        private readonly string _route;
        #endregion

#if DEBUG
        public static string _apiUrl = "http://localhost:57086/api";
#endif

#if RELEASE
        public static string _apiUrl = "https://mywebsite.azure.com/api";
#endif
        public static UserDTO CurrentUser { get; set; }
        public APIService(string route)
        {
            _route = route;
        }
        public async Task<byte[]> GetFile(string p)
        {
            var url = $"{_apiUrl}/{_route}/GetFile?p="+p;
            try
            {
                return await url.WithBasicAuth(Username, Password).GetJsonAsync<byte[]>();
            }
            catch (FlurlHttpException ex)
            {

            }
            return default(byte[]);
        }
        public async Task<T> Get<T>(object search=null)
        {
            var url = $"{_apiUrl}/{_route}";

            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryStringAsync();
                }

                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    //MessageBox.Show("Niste authentificirani");
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");
                }
                    await Application.Current.MainPage.DisplayAlert("Greška", "Greska", "OK");
                throw;
            }
        }
        public async Task<bool> SupposeVote(int id, string token,int listId)
        {
            var url = $"{_apiUrl}/{_route}/GetRecommendedVotes?electionOptionId=" +id+"&voterToken="+token+"&electiveListId="+listId;

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<bool>();
        }
        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}";

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

                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                return default(T);
            }

        }

        public async Task<T> Update<T>(int id, object request)
        {
            try
            {
                var url = $"{_apiUrl}/{_route}/{id}";

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

                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                return default(T);
            }

        }
    }
}
