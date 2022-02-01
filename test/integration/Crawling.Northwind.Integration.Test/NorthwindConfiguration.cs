using System.Collections.Generic;
using CluedIn.Crawling.Northwind.Core;

namespace CluedIn.Crawling.Northwind.Integration.Test
{
  public static class NorthwindConfiguration
  {
    public static Dictionary<string, object> Create()
    {
      return new Dictionary<string, object>
            {
                { NorthwindConstants.KeyName.ApiKey, "demo" }
            };
    }
  }
}
