using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace LanguageFeatures.Models
{
        public class MyAsyncMethods
        {
        public static Task<long?> GetPageLength()
        {
            HttpClient client = new HttpClient();
            var httpTask = client.GetAsync("http://facebook.com");
            return httpTask.ContinueWith((Task<HttpResponseMessage> antecedent) =>
               antecedent.Result.Content.Headers.ContentLength);
        }
    }
 
}
