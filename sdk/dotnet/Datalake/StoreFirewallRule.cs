// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Datalake {

	/// <summary>
	/// The set of arguments for constructing a StoreFirewallRule resource.
	/// </summary>
	public struct StoreFirewallRuleArgs {
		/// <summary>
		/// Specifies the name of the Data Lake Store for which the Firewall Rule should take effect.
		/// </summary>
		public Pulumi.IO<string> AccountName { get; set; }

		/// <summary>
		/// The End IP Address for the firewall rule.
		/// </summary>
		public Pulumi.IO<string> EndIpAddress { get; set; }

		/// <summary>
		/// Specifies the name of the Data Lake Store. Changing this forces a new resource to be created. Has to be between 3 to 24 characters.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The name of the resource group in which to create the Data Lake Store.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// The Start IP address for the firewall rule.
		/// </summary>
		public Pulumi.IO<string> StartIpAddress { get; set; }

	} // StoreFirewallRuleArgs

	/// <summary>
	/// Manage a Azure Data Lake Store Firewall Rule.
	/// </summary>
	public class StoreFirewallRule : Pulumi.CustomResource {
		/// <summary>
		/// Specifies the name of the Data Lake Store for which the Firewall Rule should take effect.
		/// </summary>
		public Pulumi.IO<string> AccountName { get; set; }

		/// <summary>
		/// The End IP Address for the firewall rule.
		/// </summary>
		public Pulumi.IO<string> EndIpAddress { get; set; }

		/// <summary>
		/// Specifies the name of the Data Lake Store. Changing this forces a new resource to be created. Has to be between 3 to 24 characters.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The name of the resource group in which to create the Data Lake Store.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// The Start IP address for the firewall rule.
		/// </summary>
		public Pulumi.IO<string> StartIpAddress { get; set; }

		public StoreFirewallRule(string name, StoreFirewallRuleArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:datalake/storeFirewallRule:StoreFirewallRule", name, SerialiseArgs(args), opts) {
			AccountName = base.Outputs["accountName"].Select(item => Protobuf.ToString(item));
			EndIpAddress = base.Outputs["endIpAddress"].Select(item => Protobuf.ToString(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			StartIpAddress = base.Outputs["startIpAddress"].Select(item => Protobuf.ToString(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(StoreFirewallRuleArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["accountName"] = Protobuf.ToProtobuf(args.AccountName);
			props["endIpAddress"] = Protobuf.ToProtobuf(args.EndIpAddress);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["startIpAddress"] = Protobuf.ToProtobuf(args.StartIpAddress);
			return props;
		} // SerialiseArgs

	} // StoreFirewallRule
} // Pulumi.Azure.Datalake
