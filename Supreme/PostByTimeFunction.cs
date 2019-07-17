using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Supreme
{
    public class PostByTimeFunction
    {
        private readonly IPostsRepository _repository;
        public PostByTimeFunction(IPostsRepository repository)
        {
            _repository = repository;
        }

        [FunctionName("PostByTimeFunction")]
        public async Task Run([TimerTrigger("0 */1 * * * *")]TimerInfo myTimer, ILogger log)
        {
            var posts = await _repository.Get();
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            log.LogInformation(posts[0].Body);
        }
    }
}
