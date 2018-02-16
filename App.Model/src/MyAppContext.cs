using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Model
{
    public class RssFeedItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Excerpt { get; set; }
    }

    public class RssFeedService 
    {
        public async Task<List<RssFeedItem>> Load()
        {
            return null;
        }
    }

    public class MyAppContext
    {
        public static readonly RssFeedService FeedService = new RssFeedService();
    }
}
