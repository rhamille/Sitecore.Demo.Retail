using Sitecore.Commerce.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sitecore.Feature.Commerce.SubLines.Engine.Entities
{
    public class CartLineInputModel : CommerceEntity
    {
        public string CartId { get; set; }
        public string ItemId { get; set; }
        public uint Quantity { get; set; }
        public string ParentItemId { get; set; }

    }

    //public class CartLineWithSubLinesInputModel : CommerceEntity
    //{

    //    public CartLineWithSubLinesInputModel(CartLineInputModel cartLine, IList<CartLineInputModel> subLines)
    //    {
    //        //this.Id = string.Format("{0}{1}", IdPrefix<CartLineWithSubLinesInputModel>(), "CartLineWithSubLinesInputModel");
    //        this.CartLine = cartLine ?? new CartLineInputModel();
    //        this.SubLines = subLines ?? new List<CartLineInputModel>();
    //    }

    //    public CartLineInputModel CartLine { get; set; }
    //    public IList<CartLineInputModel> SubLines { get; set; }
    //}
}
