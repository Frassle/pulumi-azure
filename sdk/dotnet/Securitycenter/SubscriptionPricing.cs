// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Securitycenter {

	/// <summary>
	/// The set of arguments for constructing a SubscriptionPricing resource.
	/// </summary>
	public struct SubscriptionPricingArgs {
		/// <summary>
		/// The pricing tier to use. Possible values are `Free` and `Standard`.
		/// </summary>
		public Pulumi.IO<string> Tier { get; set; }

	} // SubscriptionPricingArgs

	/// <summary>
	/// Manages the Pricing Tier for Azure Security Center in the current subscription.
	/// 
	/// > **NOTE:** This resource requires the `Owner` permission on the Subscription.
	/// 
	/// > **NOTE:** Deletion of this resource does not change or reset the pricing tier to `Free`
	/// </summary>
	public class SubscriptionPricing : Pulumi.CustomResource {
		/// <summary>
		/// The pricing tier to use. Possible values are `Free` and `Standard`.
		/// </summary>
		public Pulumi.IO<string> Tier { get; set; }

		public SubscriptionPricing(string name, SubscriptionPricingArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:securitycenter/subscriptionPricing:SubscriptionPricing", name, SerialiseArgs(args), opts) {
			Tier = base.Outputs["tier"].Select(item => Protobuf.ToString(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(SubscriptionPricingArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["tier"] = Protobuf.ToProtobuf(args.Tier);
			return props;
		} // SerialiseArgs

	} // SubscriptionPricing
} // Pulumi.Azure.Securitycenter