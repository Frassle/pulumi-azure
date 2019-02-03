// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Core {

	/// <summary>
	/// A collection of arguments for invoking getSubscription.
	/// </summary>
	public struct GetSubscriptionArgs {
		/// <summary>
		/// Specifies the ID of the subscription. If this argument is omitted, the subscription ID of the current Azure Resource Manager provider is used.
		/// </summary>
		public string SubscriptionId { get; set; }

	} // GetSubscriptionArgs

	/// <summary>
	/// A collection of values returned by getSubscription.
	/// </summary>
	public struct GetSubscriptionResult {
		/// <summary>
		/// The subscription display name.
		/// </summary>
		public string DisplayName { get; set; }

		/// <summary>
		/// The subscription location placement ID.
		/// </summary>
		public string LocationPlacementId { get; set; }

		/// <summary>
		/// The subscription quota ID.
		/// </summary>
		public string QuotaId { get; set; }

		/// <summary>
		/// The subscription spending limit.
		/// </summary>
		public string SpendingLimit { get; set; }

		/// <summary>
		/// The subscription state. Possible values are Enabled, Warned, PastDue, Disabled, and Deleted.
		/// </summary>
		public string State { get; set; }

		public string SubscriptionId { get; set; }

		/// <summary>
		/// id is the provider-assigned unique ID for this managed resource.
		/// </summary>
		public string Id { get; set; }

	} // GetSubscriptionResult

	public static partial class CoreModule {
		/// <summary>
		/// Use this data source to access information about an existing Subscription.
		/// </summary>
		public static System.Threading.Tasks.Task<GetSubscriptionResult> GetSubscription(GetSubscriptionArgs args, Pulumi.InvokeOptions opts = default(Pulumi.InvokeOptions)) {
			var invokeArgs = new Google.Protobuf.WellKnownTypes.Struct();
			invokeArgs.Fields["subscriptionId"] = Protobuf.ToProtobuf(args.SubscriptionId);

			var task = Pulumi.Runtime.InvokeAsync("azure:core/getSubscription:getSubscription", invokeArgs, opts);

			return task.ContinueWith(response => {
				var protobuf = response.Result;
				var result = new GetSubscriptionResult();
				if (protobuf.Fields.ContainsKey("displayName")) {
					result.DisplayName = Protobuf.ToString(protobuf.Fields["displayName"]);
				}
				if (protobuf.Fields.ContainsKey("locationPlacementId")) {
					result.LocationPlacementId = Protobuf.ToString(protobuf.Fields["locationPlacementId"]);
				}
				if (protobuf.Fields.ContainsKey("quotaId")) {
					result.QuotaId = Protobuf.ToString(protobuf.Fields["quotaId"]);
				}
				if (protobuf.Fields.ContainsKey("spendingLimit")) {
					result.SpendingLimit = Protobuf.ToString(protobuf.Fields["spendingLimit"]);
				}
				if (protobuf.Fields.ContainsKey("state")) {
					result.State = Protobuf.ToString(protobuf.Fields["state"]);
				}
				if (protobuf.Fields.ContainsKey("subscriptionId")) {
					result.SubscriptionId = Protobuf.ToString(protobuf.Fields["subscriptionId"]);
				}
				if (protobuf.Fields.ContainsKey("id")) {
					result.Id = Protobuf.ToString(protobuf.Fields["id"]);
				}
				return result;
			});
		} // GetSubscription

	} // CoreModule
} // Pulumi.Azure.Core
