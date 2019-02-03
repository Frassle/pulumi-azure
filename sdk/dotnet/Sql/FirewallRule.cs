// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Sql {

	/// <summary>
	/// The set of arguments for constructing a FirewallRule resource.
	/// </summary>
	public struct FirewallRuleArgs {
		/// <summary>
		/// The ending IP address to allow through the firewall for this rule.
		/// </summary>
		public Pulumi.IO<string> EndIpAddress { get; set; }

		/// <summary>
		/// The name of the firewall rule.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The name of the resource group in which to
		/// create the sql server.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// The name of the SQL Server on which to create the Firewall Rule.
		/// </summary>
		public Pulumi.IO<string> ServerName { get; set; }

		/// <summary>
		/// The starting IP address to allow through the firewall for this rule.
		/// </summary>
		public Pulumi.IO<string> StartIpAddress { get; set; }

	} // FirewallRuleArgs

	/// <summary>
	/// Allows you to manage an Azure SQL Firewall Rule
	/// </summary>
	public class FirewallRule : Pulumi.CustomResource {
		/// <summary>
		/// The ending IP address to allow through the firewall for this rule.
		/// </summary>
		public Pulumi.IO<string> EndIpAddress { get; set; }

		/// <summary>
		/// The name of the firewall rule.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The name of the resource group in which to
		/// create the sql server.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// The name of the SQL Server on which to create the Firewall Rule.
		/// </summary>
		public Pulumi.IO<string> ServerName { get; set; }

		/// <summary>
		/// The starting IP address to allow through the firewall for this rule.
		/// </summary>
		public Pulumi.IO<string> StartIpAddress { get; set; }

		public FirewallRule(string name, FirewallRuleArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:sql/firewallRule:FirewallRule", name, SerialiseArgs(args), opts) {
			EndIpAddress = base.Outputs["endIpAddress"].Select(item => Protobuf.ToString(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			ServerName = base.Outputs["serverName"].Select(item => Protobuf.ToString(item));
			StartIpAddress = base.Outputs["startIpAddress"].Select(item => Protobuf.ToString(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(FirewallRuleArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["endIpAddress"] = Protobuf.ToProtobuf(args.EndIpAddress);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["serverName"] = Protobuf.ToProtobuf(args.ServerName);
			props["startIpAddress"] = Protobuf.ToProtobuf(args.StartIpAddress);
			return props;
		} // SerialiseArgs

	} // FirewallRule
} // Pulumi.Azure.Sql
