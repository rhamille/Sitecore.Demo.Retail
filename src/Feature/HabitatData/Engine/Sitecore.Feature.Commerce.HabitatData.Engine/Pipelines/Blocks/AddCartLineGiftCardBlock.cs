// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddCartLineGiftCardBlock.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2017
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sitecore.Feature.Commerce.HabitatData.Engine.Pipelines.Blocks
{
    using System;
    
    using Sitecore.Commerce.Core;
    using Sitecore.Commerce.Plugin.Carts;
    using Sitecore.Framework.Pipelines;

    /// <summary>
    /// Defines a block which adds a gift card line to a cart.
    /// </summary>
    /// <seealso>
    ///     <cref>
    ///         Sitecore.Framework.Pipelines.PipelineBlock{Sitecore.Commerce.Plugin.Carts.Cart,
    ///         Sitecore.Commerce.Plugin.Carts.Cart, Sitecore.Commerce.Core.CommercePipelineExecutionContext}
    ///     </cref>
    /// </seealso>
    [PipelineDisplayName(HabitatDataConstants.Pipelines.Blocks.AddCartLineGiftCardBlock)]
    public class AddCartLineGiftCardBlock : Sitecore.Commerce.Plugin.GiftCards.AddCartLineGiftCardBlock
    {
        /// <summary>
        /// Determines whether the specified added line is digital.
        /// </summary>
        /// <param name="addedLine">The added line.</param>
        /// <param name="context">The context.</param>
        /// <returns>
        /// <c>true</c> if the specified added line is digital; otherwise, <c>false</c>.
        /// </returns>
        protected override bool IsDigital(CartLineComponent addedLine, CommercePipelineExecutionContext context)
        {
            var productComponent = addedLine.GetComponent<CartProductComponent>();
            return productComponent.ItemTemplate.Equals("GiftCardV2", StringComparison.OrdinalIgnoreCase);
        }
    }
}
