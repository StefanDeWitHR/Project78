using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;



namespace TamTamTracker
{
    public static partial class API
    {
        public static string BasePath;
        //public static string Username;
        //public static string Password;
        //public static string ClientID;
       // public static FetchTokenResponse TokenInfo;


        public static void Init()
        {
            BasePath = "localhost:900";
        }

    
        public static async Task<string> Post<T>(T DTO ,string url)
        {
            try
            {
                string Aurl = BasePath + url;
                HttpClient HC = new HttpClient();

                //if (TokenInfo != null)
                //{
                //    HC.DefaultRequestHeaders.Add("Authorization", "Bearer " + TokenInfo.access_token);
                //}
                string Params = JsonConvert.SerializeObject(DTO);
                StringContent S = new StringContent(Params, Encoding.UTF8, "application/json");

                HttpResponseMessage HR = await HC.PostAsync(Aurl, S);

                string LResult = await HR.Content.ReadAsStringAsync();

                
                return LResult;
            }
            catch (Exception E)
            {
                throw E;
            }
        }
        public static async Task<T> Get<T>(string url)
        {
            try
            {
                string FullUrl = BasePath + url;

                HttpClient HC = new HttpClient();

                //if (TokenInfo != null)
                //{
                //    HC.DefaultRequestHeaders.Add("Authorization", "Bearer " + TokenInfo.access_token);
                //}

                HttpResponseMessage HR = await HC.GetAsync(FullUrl);

                string LResult = await HR.Content.ReadAsStringAsync();
                T Result = JsonConvert.DeserializeObject<T>(LResult);

       
                return Result;
            }
            catch (Exception E)
            {
                throw E;
            }
        }
        public static async Task<List<T>> GetList<T>(string url)
        {
            try
            {
                string FullUrl = BasePath + url;

                HttpClient HC = new HttpClient();

                //if (TokenInfo != null)
                //{
                //    HC.DefaultRequestHeaders.Add("Authorization", "Bearer " + TokenInfo.access_token);
                //}

                HttpResponseMessage HR = await HC.GetAsync(FullUrl);
                string LResult = await HR.Content.ReadAsStringAsync();
                List<T> Result = JsonConvert.DeserializeObject<List<T>>(LResult);
                
                return Result;
            }
            catch (Exception E)
            {
                throw E;
            }
        }

        // puts
        public static async Task<bool> Put<T>(T DTO, string url)
        {
            bool LResult = false;

            string FullUrl = BasePath + url;

            try
            {
                HttpClient HC = new HttpClient();

                //if (TokenInfo != null)
                //{
                //    HC.DefaultRequestHeaders.Add("Authorization", "Bearer " + TokenInfo.access_token);
                //}
                string Params = JsonConvert.SerializeObject(DTO);
                StringContent S = new StringContent(Params, Encoding.UTF8, "application/json");

                HttpResponseMessage HR = await HC.PutAsync(FullUrl, S);

                string result = await HR.Content.ReadAsStringAsync();
                LResult = (result != "");

                return LResult;
            }
            catch (Exception E)
            {
                throw E;
            }
        }
    }
}

