namespace Sitecore.Support.Commerce.XA.Foundation.Catalog.Pipelines
{
  using Sitecore.Data.Items;
  using Sitecore.Links;

  public class CatalogLinkProvider : Sitecore.Commerce.XA.Foundation.Catalog.Pipelines.CatalogLinkProvider
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