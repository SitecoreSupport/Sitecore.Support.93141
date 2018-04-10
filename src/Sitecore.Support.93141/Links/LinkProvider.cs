namespace Sitecore.Support.Links
{
  using Sitecore.Data.Items;
  using Sitecore.Links;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Web;
  public class LinkProvider : Sitecore.Links.LinkProvider
  {
    public override string GetItemUrl(Item item, UrlOptions options)
    {
      string url = base.GetItemUrl(item, options);

      if (url.EndsWith(":443"))
        return url.Replace(":443", "");

      return url.Replace(":443/", "/");
    }
  }
}