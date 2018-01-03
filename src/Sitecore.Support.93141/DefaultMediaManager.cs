using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Abstractions;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Resources.Media;

namespace Sitecore.Support.Resources.Media
{
  public class DefaultMediaManager : Sitecore.Resources.Media.DefaultMediaManager
  {
    private UrlHelper helper = new UrlHelper();
    public DefaultMediaManager(BaseFactory factory, MediaProvider provider) : base(factory, provider)
    {

    }

    public override string GetMediaUrl(MediaItem item)
    {
      string url = base.GetMediaUrl(item);
      return helper.StripPort(url);
    }

    public override string GetMediaUrl(MediaItem item, MediaUrlOptions options)
    {
      string url = base.GetMediaUrl(item, options);
      return helper.StripPort(url);
    }
  }
}