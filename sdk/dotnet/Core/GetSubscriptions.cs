// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Core {

	public sealed class GetSubscriptionsSubscription : Pulumi.IProtobuf {
		public string DisplayName { get; set; }
		public string LocationPlacementId { get; set; }
		public string QuotaId { get; set; }
		public string SpendingLimit { get; set; }
		public string State { get; set; }
		public string SubscriptionId { get; set; }

		public Google.Protobuf.WellKnownTypes.Value ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("display_name", Protobuf.ToProtobuf(DisplayName)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("location_placement_id", Protobuf.ToProtobuf(LocationPlacementId)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("quota_id", Protobuf.ToProtobuf(QuotaId)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("spending_limit", Protobuf.ToProtobuf(SpendingLimit)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("state", Protobuf.ToProtobuf(State)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("subscription_id", Protobuf.ToProtobuf(SubscriptionId)));
		} // ToProtobuf

		public static GetSubscriptionsSubscription FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new GetSubscriptionsSubscription();
				if (obj.Fields.ContainsKey("display_name")) {
					result.DisplayName = Protobuf.ToString(obj.Fields["display_name"]);
				}
				if (obj.Fields.ContainsKey("location_placement_id")) {
					result.LocationPlacementId = Protobuf.ToString(obj.Fields["location_placement_id"]);
				}
				if (obj.Fields.ContainsKey("quota_id")) {
					result.QuotaId = Protobuf.ToString(obj.Fields["quota_id"]);
				}
				if (obj.Fields.ContainsKey("spending_limit")) {
					result.SpendingLimit = Protobuf.ToString(obj.Fields["spending_limit"]);
				}
				if (obj.Fields.ContainsKey("state")) {
					result.State = Protobuf.ToString(obj.Fields["state"]);
				}
				if (obj.Fields.ContainsKey("subscription_id")) {
					result.SubscriptionId = Protobuf.ToString(obj.Fields["subscription_id"]);
				}
			return result;
		} // FromProtobuf

	} // GetSubscriptionsSubscription

	/// <summary>
	/// A collection of arguments for invoking getSubscriptions.
	/// </summary>
	public struct GetSubscriptionsArgs {
		/// <summary>
		/// A case-insensitive value which must be contained within the `display_name` field, used to filter the results
		/// </summary>
		public string DisplayNameContains { get; set; }

		/// <summary>
		/// A case-insensitive prefix which can be used to filter on the `display_name` field
		/// </summary>
		public string DisplayNamePrefix { get; set; }

	} // GetSubscriptionsArgs

	/// <summary>
	/// A collection of values returned by getSubscriptions.
	/// </summary>
	public struct GetSubscriptionsResult {
		/// <summary>
		/// One or more `subscription` blocks as defined below.
		/// </summary>
		public GetSubscriptionsSubscription[] Subscriptions { get; set; }

		/// <summary>
		/// id is the provider-assigned unique ID for this managed resource.
		/// </summary>
		public string Id { get; set; }

	} // GetSubscriptionsResult

	public static partial class CoreModule {
		/// <summary>
		/// Use this data source to access information about all the Subscriptions currently available.
		/// </summary>
		public static System.Threading.Tasks.Task<GetSubscriptionsResult> GetSubscriptions(GetSubscriptionsArgs args, Pulumi.InvokeOptions opts = default(Pulumi.InvokeOptions)) {
			var invokeArgs = new Google.Protobuf.WellKnownTypes.Struct();
			invokeArgs.Fields["displayNameContains"] = Protobuf.ToProtobuf(args.DisplayNameContains);
			invokeArgs.Fields["displayNamePrefix"] = Protobuf.ToProtobuf(args.DisplayNamePrefix);

			var task = Pulumi.Runtime.InvokeAsync("azure:core/getSubscriptions:getSubscriptions", invokeArgs, opts);

			return task.ContinueWith(response => {
				var protobuf = response.Result;
				var result = new GetSubscriptionsResult();
				if (protobuf.Fields.ContainsKey("subscriptions")) {
					result.Subscriptions = Protobuf.ToList(protobuf.Fields["subscriptions"], item => GetSubscriptionsSubscription.FromProtobuf(item));
				}
				if (protobuf.Fields.ContainsKey("id")) {
					result.Id = Protobuf.ToString(protobuf.Fields["id"]);
				}
				return result;
			});
		} // GetSubscriptions

	} // CoreModule
} // Pulumi.Azure.Core