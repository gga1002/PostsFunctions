using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Supreme
{
    public interface IPostsRepository
    {
        Task<List<Post>> Get();
    }
}
