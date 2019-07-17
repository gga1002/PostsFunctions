using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Supreme
{
    public class PostsFunction
    {

        private readonly IPostsRepository _repository;
        public PostsFunction(IPostsRepository repository)
        {
            _repository = repository;
        }

        [FunctionName("GetPosts")]
        public async Task<IActionResult> Get([HttpTrigger(AuthorizationLevel.Function, "get", Route = "posts")] HttpRequest req, ILogger log)
        {
            var posts = await _repository.Get();
            return new OkObjectResult(posts);
        }
    }
}
