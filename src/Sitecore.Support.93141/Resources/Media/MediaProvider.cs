namespace Sitecore.Support.Resources.Media
{
  using Sitecore.Data.Items;
  using Sitecore.Resources.Media;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Web;
  public class MediaProvider : Sitecore.Resources.Media.MediaProvider
  {
    public override string GetMediaUrl(MediaItem item)
    {
      string url = base.GetMediaUrl(item);
      return url.Replace(":443/", "/");
    }

    public override string GetMediaUrl(MediaItem item, MediaUrlOptions options)
    {
      string url = base.GetMediaUrl(item, options);
      return url.Replace(":443/", "/");
    }
  }
}