using ePozoriste.Model;
using Flurl.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePozoriste.WinUI
{
    public class APIService
    {
        private string _route = null;
        public string _endpoint = Properties.Settings.Default.ApiURL;

        public static string KorisnickoIme { get; set; }
        public static string Lozinka { get; set; }
        public static int LogiraniKorisnikId { get; set; }


        public APIService(string route)
        {
            _route = route;
        }
        public async Task<T> Get<T>(object request = null)
        {
            var url = $"{_endpoint}/{_route}";
            if (request != null)
            {
                url += "?";
                url += await request.ToQueryString();
            }

            var list = await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();

            return list;
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_endpoint}/{_route}/{id}";
            
            return await url.WithBasicAuth(KorisnickoIme, Lozinka).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{_endpoint}/{_route}";
            try
            {
                return await url.WithBasicAuth(KorisnickoIme, Lozinka).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<ErrorResponse>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors.Errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, error: {string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{_endpoint}/{_route}/{id}";
            try
            {
                return await url.WithBasicAuth(KorisnickoIme, Lozinka).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<ErrorResponse>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors.Errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, error: {string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

        public async Task<T> Delete<T>(object id)
        {
            var url = $"{_endpoint}/{_route}/{id}";
            try
            {
                return await url.WithBasicAuth(KorisnickoIme, Lozinka).DeleteAsync().ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<ErrorResponse>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors.Errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, error: {string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // return false;
                return default(T);
            }
        }
    }

    public class ErrorResponse
    {
        public Dictionary<string, List<string>> Errors { get; set; }
    }
}
