using Microsoft.Extensions.Logging;
using Sitecore.Commerce.Core;
using Sitecore.Framework.Conditions;
using Sitecore.Framework.Pipelines;
using System;
using System.Linq;
using System.Threading.Tasks;

using Sitecore.Commerce.Plugin.SQL;

namespace Sitecore.Feature.Commerce.Entitlements.Engine.Pipelines.Blocks
{
    public class FindEntityBlockExtension : ConditionalPipelineBlock<FindEntityArgument, FindEntityArgument, CommercePipelineExecutionContext>
    {
        private readonly GetEntityCommand _getEntityCommand;

        public FindEntityBlockExtension(GetEntityCommand getEntityCommand)
        {
            this._getEntityCommand = getEntityCommand;
            this.BlockCondition = new Predicate<IPipelineExecutionContext>(this.ValidatePolicy);
        }

        public override Task<FindEntityArgument> ContinueTask(FindEntityArgument arg, CommercePipelineExecutionContext context)
        {
            return Task.FromResult<FindEntityArgument>(arg);
        }

        public override async Task<FindEntityArgument> Run(FindEntityArgument arg, CommercePipelineExecutionContext context)
        {
            Condition.Requires<FindEntityArgument>(arg).IsNotNull<FindEntityArgument>(string.Format("{0}: the argument cannot be null.", (object)this.Name));
            if (!string.IsNullOrEmpty(arg.SerializedEntity) || arg.Entity != null)
                return arg;
            FoundEntity foundEntity = context.CommerceContext.GetObjects<FoundEntity>().FirstOrDefault<FoundEntity>((Func<FoundEntity, bool>)(p => p.EntityId.Equals(arg.EntityId, StringComparison.OrdinalIgnoreCase)));
            FoundEntity foundEntity1 = foundEntity;
            if (!string.IsNullOrEmpty(foundEntity1 != null ? foundEntity1.SerializedEntity : (string)null))
            {
                context.Logger.LogDebug(string.Format("SQL.FindEntity.InCtx.{0}: EntityId={1}", (object)arg.EntityType.Name, (object)arg.EntityId), Array.Empty<object>());
                arg.SerializedEntity = foundEntity.SerializedEntity;
                return arg;
            }
            int num = 0;
            object obj;
            try
            {
                context.Logger.LogDebug(string.Format("SQL.FindEntity.{0}: EntityId={1}", (object)arg.EntityType.Name, (object)arg.EntityId), Array.Empty<object>());
                FindEntityArgument findEntityArgument = arg;
                CommerceEntity commerceEntity = await this._getEntityCommand.Process(context.CommerceContext, arg, 0);
                findEntityArgument.Entity = commerceEntity;
                findEntityArgument = (FindEntityArgument)null;
                if (foundEntity == null)
                {
                    FoundEntity foundEntity2 = new FoundEntity();
                    foundEntity2.EntityId = arg.EntityId;
                    foundEntity2.Entity = (object)arg.Entity;
                    int num1 = 0;
                    foundEntity2.FoundInCache = num1 != 0;
                    int num2 = 0;
                    foundEntity2.CachedAsEntity = num2 != 0;
                    foundEntity = foundEntity2;
                    context.CommerceContext.AddObject((object)foundEntity);
                }
                else
                    foundEntity.Entity = (object)arg.Entity;
                return arg;
            }
            catch (Exception ex)
            {
                obj = (object)ex;
                num = 1;
            }
            if (num == 1)
            {
                Exception exception = (Exception)obj;
                string str = await context.CommerceContext.AddMessage(context.GetPolicy<KnownResultCodes>().Error, this.Name, new object[1]
                {
          (object) exception
                }, string.Format("{0}.Exception: {1}", (object)this.Name, (object)exception.Message));
                return arg;
            }
            obj = (object)null;
            foundEntity = (FoundEntity)null;
            FindEntityArgument findEntityArgument1 = null;
            return findEntityArgument1;
        }

        private bool ValidatePolicy(IPipelineExecutionContext obj)
        {
            return ((CommercePipelineExecutionContext)obj).CommerceContext.Environment.HasPolicy<EntityStoreSqlPolicy>();
        }
    }
}
