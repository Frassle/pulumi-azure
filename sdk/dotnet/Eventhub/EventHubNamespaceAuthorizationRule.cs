// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Eventhub {

	/// <summary>
	/// The set of arguments for constructing a EventHubNamespaceAuthorizationRule resource.
	/// </summary>
	public struct EventHubNamespaceAuthorizationRuleArgs {
		/// <summary>
		/// Grants listen access to this this Authorization Rule. Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> Listen { get; set; }

		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// Grants manage access to this this Authorization Rule. When this property is `true` - both `listen` and `send` must be too. Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> Manage { get; set; }

		/// <summary>
		/// Specifies the name of the Authorization Rule. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// Specifies the name of the EventHub Namespace. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> NamespaceName { get; set; }

		/// <summary>
		/// The name of the resource group in which the EventHub Namespace exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// Grants send access to this this Authorization Rule. Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> Send { get; set; }

	} // EventHubNamespaceAuthorizationRuleArgs

	/// <summary>
	/// Manages an Authorization Rule for an Event Hub Namespace.
	/// </summary>
	public class EventHubNamespaceAuthorizationRule : Pulumi.CustomResource {
		/// <summary>
		/// Grants listen access to this this Authorization Rule. Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> Listen { get; set; }

		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// Grants manage access to this this Authorization Rule. When this property is `true` - both `listen` and `send` must be too. Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> Manage { get; set; }

		/// <summary>
		/// Specifies the name of the Authorization Rule. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// Specifies the name of the EventHub Namespace. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> NamespaceName { get; set; }

		/// <summary>
		/// The Primary Connection String for the Authorization Rule.
		/// </summary>
		public Pulumi.IO<string> PrimaryConnectionString { get; set; }

		/// <summary>
		/// The Primary Key for the Authorization Rule.
		/// </summary>
		public Pulumi.IO<string> PrimaryKey { get; set; }

		/// <summary>
		/// The name of the resource group in which the EventHub Namespace exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// The Secondary Connection String for the Authorization Rule.
		/// </summary>
		public Pulumi.IO<string> SecondaryConnectionString { get; set; }

		/// <summary>
		/// The Secondary Key for the Authorization Rule.
		/// </summary>
		public Pulumi.IO<string> SecondaryKey { get; set; }

		/// <summary>
		/// Grants send access to this this Authorization Rule. Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> Send { get; set; }

		public EventHubNamespaceAuthorizationRule(string name, EventHubNamespaceAuthorizationRuleArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:eventhub/eventHubNamespaceAuthorizationRule:EventHubNamespaceAuthorizationRule", name, SerialiseArgs(args), opts) {
			Listen = base.Outputs["listen"].Select(item => Protobuf.ToBool(item));
			Location = base.Outputs["location"].Select(item => Protobuf.ToString(item));
			Manage = base.Outputs["manage"].Select(item => Protobuf.ToBool(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			NamespaceName = base.Outputs["namespaceName"].Select(item => Protobuf.ToString(item));
			PrimaryConnectionString = base.Outputs["primaryConnectionString"].Select(item => Protobuf.ToString(item));
			PrimaryKey = base.Outputs["primaryKey"].Select(item => Protobuf.ToString(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			SecondaryConnectionString = base.Outputs["secondaryConnectionString"].Select(item => Protobuf.ToString(item));
			SecondaryKey = base.Outputs["secondaryKey"].Select(item => Protobuf.ToString(item));
			Send = base.Outputs["send"].Select(item => Protobuf.ToBool(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(EventHubNamespaceAuthorizationRuleArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["listen"] = Protobuf.ToProtobuf(args.Listen);
			props["location"] = Protobuf.ToProtobuf(args.Location);
			props["manage"] = Protobuf.ToProtobuf(args.Manage);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["namespaceName"] = Protobuf.ToProtobuf(args.NamespaceName);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["send"] = Protobuf.ToProtobuf(args.Send);
			props["primaryConnectionString"] = null; //out
			props["primaryKey"] = null; //out
			props["secondaryConnectionString"] = null; //out
			props["secondaryKey"] = null; //out
			return props;
		} // SerialiseArgs

	} // EventHubNamespaceAuthorizationRule
} // Pulumi.Azure.Eventhub