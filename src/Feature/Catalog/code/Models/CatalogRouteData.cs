﻿using Sitecore.Data.Items;
using Sitecore.Demo.Retail.Foundation.Commerce.Website.Models;

namespace Sitecore.Feature.Commerce.Catalog.Models
{
    public class CatalogRouteData : ICatalogItemContext
    {
        public CatalogItemType? ItemType { get; set; }
        public string Id { get; set; }
        public string Catalog { get; set; }
        public string CategoryId { get; set; }
        public Item Item { get; set; }
    }
}