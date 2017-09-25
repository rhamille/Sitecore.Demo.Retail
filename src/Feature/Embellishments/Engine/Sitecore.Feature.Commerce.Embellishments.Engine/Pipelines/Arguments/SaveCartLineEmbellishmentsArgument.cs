using Sitecore.Commerce.Core;
using Sitecore.Commerce.Plugin.Carts;
using Sitecore.Feature.Commerce.Embellishments.Engine.Components;
using Sitecore.Framework.Conditions;
using System.Collections.Generic;

namespace Sitecore.Feature.Commerce.Embellishments.Engine.Pipelines.Arguments
{
    public class SaveCartLineEmbellishmentsArgument : PipelineArgument
    {
        //public string ItemId { get; set; }
        //public string ExternalId { get; set; }
        //public uint Quantity { get; set; }
        //public string Type { get; set; }
        //public string Value { get; set; }

        public Cart Cart { get; set; }

        public CartLineComponent CartLine { get; set; }
        public EmbellishmentComponent Embellishment { get; set; }

        public SaveCartLineEmbellishmentsArgument(CartLineArgument cartArgs, EmbellishmentComponent embellishment)
            : base()
        {
            //this.ItemId = itemId;
            //this.ExternalId = externalId;
            //this.Quantity = quantity;
            //this.Type = type;
            //this.Value = value;
            this.Cart = cartArgs.Cart;
            this.CartLine = cartArgs.Line;
            this.Embellishment = embellishment;
        }
    }
}