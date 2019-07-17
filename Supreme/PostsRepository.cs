using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Supreme
{
    public class PostsRepository : IPostsRepository
    {
        private readonly HttpClient _client;
        public PostsRepository(IHttpClientFactory httpClientFactory)
        {
            _client = httpClientFactory.CreateClient(); ;
        }

        public async Task<List<Post>> Get()
        {
            var response = await _client.GetAsync("https://jsonplaceholder.typicode.com/posts");
            var data = await response.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Post>>(data);
        }
    }
}
