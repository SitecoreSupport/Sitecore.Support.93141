using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;
using Sitecore.Links;
using Sitecore.Web;

namespace Sitecore.Support.Links
{
  public class LinkProvider : Sitecore.Links.LinkProvider
  {
    public override string GetItemUrl(Item item, UrlOptions options)
    {
      string url = base.GetItemUrl(item, options);

      if (options.AlwaysIncludeServerUrl)
      {
        UrlHelper helper = new UrlHelper();
        return helper.StripPort(url);
      }

      return url;
    }
  }
}