using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class IainSmith : IAmACommunityMember
    {
        public string FirstName => "Iain";
        public string LastName => "Smith";
        public string StateOrRegion => "Scotland, UK";
        public string EmailAddress => "b099l3@gmail.com";
        public string ShortBioOrTagLine => "Software Developer working with Xamarin, iOS, Android, UWP. Also likes to make/drink beer🍻";
        public Uri WebSite => new Uri("https://iainsmith.me");

        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://iainsmith.me/rss/"); }
        }

        public string TwitterHandle => "b099l3";
        public string GravatarHash => "5a2ab38220d6a23242d1f056a0870150";
        public string GitHubHandle => "b099l3";
        public GeoPosition Position => new GeoPosition(55.8642, 4.2518);
        public string FeedLanguageCode => "en";
    }
}
