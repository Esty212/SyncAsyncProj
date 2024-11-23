using System;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEngine;

namespace DefaultNamespace
{
    /// <summary>
    /// REMINDER: the methods of this class are static.
    /// To use this class from any other class you  don't need to create an instance, as the methods sit on the type itself, for example:
    /// WikipediaRandomArticleGenerator.GetRandomArticle();
    /// or
    /// WikipediaRandomArticleGenerator.GetRandomArticleAsync();
    /// </summary>
    public static class WikipediaRandomArticleGenerator
    {
        private static  string _url = "https://en.wikipedia.org/wiki/Special:Random";
        private static HttpClient _client = new HttpClient();
        
        
        
        //not good code, here just for an example for sync vs async code
        public static string GetRandomArticle()
        {
            var task =  Task.Run(() =>
            {
                Task.Delay(TimeSpan.FromSeconds(1));
                return _client.GetAsync(_url);
            });
            task.Wait();
            return task.Result.RequestMessage.RequestUri.ToString();
        }
        
        public static async Task<string> GetRandomArticleAsync()
        {
            var response = await _client.GetAsync(_url);
            return response.RequestMessage.RequestUri.ToString();
        }
        
    }
}