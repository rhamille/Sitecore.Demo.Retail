// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Proxy.cs" company="Sitecore Corporation">
//   Copyright (c) Sitecore Corporation 1999-2017
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sitecore.Foundation.Commerce.ServiceProxy
{
	using System;
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.Linq;
	using System.Threading;

	using Sitecore.Commerce.Core.Commands;

	using Microsoft.OData.Client;

	using Sitecore.Commerce.Core;
	using Sitecore.Commerce.Engine;
	using Sitecore.Foundation.Commerce.ServiceProxy.Exceptions;

	/// <summary>
	/// Defines the proxy.
	/// </summary>
	public class Proxy
	{
		/// <summary>
		/// Gets the container.
		/// </summary>
		/// <returns>The container</returns>
		//public static Container GetContainer()
		//{
		//    // TODO MOVE URL TO CONFIG
		//    var container = new Container(new Uri("http://localhost:5000/api/"))
		//    {
		//        MergeOption = MergeOption.OverwriteChanges,
		//        DisableInstanceAnnotationMaterialization = true
		//    };

		//    return container;
		//}

		/// <summary>
		/// Gets the value.
		/// </summary>
		/// <typeparam name="T">The type.</typeparam>
		/// <param name="query">The query.</param>
		/// <returns>A value</returns>
		public static T GetValue<T>(DataServiceQuerySingle<T> query)
		{
			var tries = 0;
			var maxTries = 3;

			var watch = new Stopwatch();
			watch.Start();

			while (tries < maxTries)
			{
				try
				{
					var result = query.GetValueAsync().Result;

					watch.Stop();
					return result;
				}
				catch (DataServiceQueryException ex)
				{
					return default(T);
				}
				catch (AggregateException ex)
				{
					var exception = ex.InnerException as DataServiceQueryException;
					if (exception != null)
					{
						var dataserviceQueryException = exception;

						switch (dataserviceQueryException.Response.StatusCode)
						{
							case 404:
								// If the item is not found, we return a null.
								// That is easier to code for than throwing an exception
								return default(T);
							default:
								throw dataserviceQueryException;
						}
					}
				}

				tries++;
				Thread.Sleep(100);
			}

			throw new CommerceServiceQuerySingleException(query.RequestUri.ToString());
		}

		/// <summary>
		/// Gets the value.
		/// </summary>
		/// <typeparam name="T">The type.</typeparam>
		/// <param name="query">The query.</param>
		/// <returns>A value</returns>
		public static T GetValue<T>(DataServiceActionQuerySingle<T> query)
		{
			var watch = new Stopwatch();
			watch.Start();

			try
			{
				var result = query.GetValueAsync().Result;

				watch.Stop();

				return result;
			}
			catch (DataServiceQueryException ex)
			{
				throw;
			}
			catch (AggregateException ex)
			{
				if (ex.InnerException is DataServiceQueryException)
				{
					var queryException = ex.InnerException as DataServiceQueryException;
					var realException = queryException.InnerException as DataServiceClientException;
					throw realException;

				}

				throw;
			}
		}

		/// <summary>
		/// Executes the specified query.
		/// </summary>
		/// <typeparam name="T">The type.</typeparam>
		/// <param name="query">The query.</param>
		/// <returns>A collection</returns>
		public static IEnumerable<T> Execute<T>(DataServiceActionQuery<T> query)
		{
			var watch = new Stopwatch();
			watch.Start();

			var result = query.ExecuteAsync().Result;

			watch.Stop();

			return result;
		}

		/// <summary>
		/// Executes the specified query.
		/// </summary>
		/// <typeparam name="T">The type.</typeparam>
		/// <param name="query">The query.</param>
		/// <returns>A collection</returns>
		public static IEnumerable<T> Execute<T>(DataServiceQuery<T> query)
		{
			var watch = new Stopwatch();
			watch.Start();

			try
			{
				var result = query.ExecuteAsync().Result;

				watch.Stop();

				return result;
			}
			catch (DataServiceQueryException ex)
			{
				throw;
			}
			catch (AggregateException ex)
			{
				throw;
			}
			catch (Exception ex)
			{
				throw;
			}
		}

		/// <summary>
		/// Sends a query expecting a CommandResponse back.
		/// </summary>
		/// <typeparam name="T">The type.</typeparam>
		/// <param name="query">The query.</param>
		/// <returns>A value</returns>
		public static CommerceCommand DoCommand<T>(DataServiceActionQuerySingle<T> query)
		{
			var response = query.GetValueAsync().Result;
			var commandResponse = response as CommerceCommand;
			
			return commandResponse;
		}

		/// <summary>
		/// Sends a query expecting a CommandResponse back.
		/// </summary>
		/// <typeparam name="T">The type.</typeparam>
		/// <param name="query">The query.</param>
		/// <returns>A value</returns>
		public static CommerceOps.Sitecore.Commerce.Core.Commands.CommerceCommand DoOpsCommand<T>(DataServiceActionQuerySingle<T> query)
		{
			var response = query.GetValueAsync().Result;
			var commandResponse = response as CommerceOps.Sitecore.Commerce.Core.Commands.CommerceCommand;
			return commandResponse;
		}

		/// <summary>
		/// Gets the entity view.
		/// </summary>
		/// <param name="container">The container.</param>
		/// <param name="entityId">The entity identifier.</param>
		/// <param name="viewName">Name of the view.</param>
		/// <param name="forAction">For action.</param>
		/// <param name="itemId">The item identifier.</param>
		/// <returns>A <see cref="Sitecore.Commerce.EntityViews.EntityView"/></returns>
		/// <exception cref="CommerceServiceQuerySingleException"></exception>
		public static Sitecore.Commerce.EntityViews.EntityView GetEntityView(Container container, string entityId, string viewName, string forAction, string itemId)
		{
			var watch = new Stopwatch();
			watch.Start();

			var tries = 0;
			var maxTries = 3;
			while (tries < maxTries)
			{
				try
				{
					var query = container.GetEntityView(entityId, viewName, forAction, itemId);
					var entityView = query.GetValueAsync().Result;
					watch.Stop();

					return entityView;
				}
				catch (AggregateException ex)
				{
					var exception = ex.InnerException as DataServiceQueryException;
					if (exception != null)
					{
						var dataserviceQueryException = exception;

						switch (dataserviceQueryException.Response.StatusCode)
						{
							default:
								throw dataserviceQueryException;
						}
					}
				}

				tries++;
				Thread.Sleep(100);
			}

			throw new CommerceServiceQuerySingleException(string.Empty);
		}
	}
}