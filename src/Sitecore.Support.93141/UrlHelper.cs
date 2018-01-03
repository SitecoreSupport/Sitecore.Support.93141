using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Web;

namespace Sitecore.Support
{
  public class UrlHelper
  {
    public string StripPort(string url)
    {
      string serverUrlWithPort = WebUtil.GetServerUrl(true);
      
      if (url.Length - url.Replace(":", "").Length > 1)
      {
        string serverUrlNoPort = string.Empty;
        serverUrlNoPort = serverUrlWithPort.Substring(0, serverUrlWithPort.LastIndexOf(':'));
        return url.Replace(serverUrlWithPort, serverUrlNoPort);
      }
      return url;
    }
  }
}