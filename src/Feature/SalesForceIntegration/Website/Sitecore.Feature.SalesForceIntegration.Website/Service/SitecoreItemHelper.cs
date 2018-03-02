using Sitecore.Data.Items;
using Sitecore.Links;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Feature.SalesForceIntegration.Website.Service
{
    public class SitecoreItemHelper
    {
        //	/sitecore/templates/System/Analytics/Goal 
        public static Sitecore.Data.ID GoalTemplateId = new Data.ID("{475E9026-333F-432D-A4DC-52E03B75CB6B}");

        public static List<Item> GetGoalReferers(Sitecore.Data.ID itemId)
        {
            var items = GetReferences(itemId).ToList();
            var result = items.Where(x => x.TemplateID == GoalTemplateId).ToList();

            return result;
        }

        //https://reasoncodeexample.com/tag/item-references/
        private static Item[] GetReferences(Sitecore.Data.ID itemId)
        {
            Item item = Sitecore.Data.Database.GetDatabase("master").GetItem(itemId);
            if (item == null)
                return null;

            ItemLink[] itemLinks = Globals.LinkDatabase.GetItemReferences(item, true);
            if (itemLinks == null)
            {
                return null;
            }
            else
            {
                ArrayList items = new ArrayList(itemLinks.Length);
                foreach (ItemLink itemLink in itemLinks)
                {
                    // comparing the database name of the linked Item
                    if (itemLink.SourceDatabaseName == "master")
                    {
                        Item linkItem = Sitecore.Data.Database.GetDatabase("master").Items[itemLink.TargetItemID];
                        if (linkItem != null)
                        {
                            items.Add(linkItem);
                        }
                    }
                }
                return (Item[])items.ToArray(typeof(Item));
            }
        }

        //http://www.bugdebugzone.com/2014/07/find-all-items-that-are-referring-to.html
        public static Item[] GetReferrers(Sitecore.Data.ID itemId)
        {
            Item item = Sitecore.Data.Database.GetDatabase("master").GetItem(itemId);
            // getting all linked Items that refer to the Item
            ItemLink[] itemLinks = Globals.LinkDatabase.GetReferrers(item);
            if (itemLinks == null)
            {
                return null;
            }
            else
            {
                ArrayList items = new ArrayList(itemLinks.Length);
                foreach (ItemLink itemLink in itemLinks)
                {
                    // comparing the database name of the linked Item
                    if (itemLink.SourceDatabaseName == "master")
                    {
                        Item linkItem = Sitecore.Data.Database.GetDatabase("master").Items[itemLink.SourceItemID];
                        if (linkItem != null)
                        {
                            items.Add(linkItem);
                        }
                    }
                }
                return (Item[])items.ToArray(typeof(Item));
            }
        }
    }
}