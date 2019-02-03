// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Eventhub {

	/// <summary>
	/// The set of arguments for constructing a QueueAuthorizationRule resource.
	/// </summary>
	public struct QueueAuthorizationRuleArgs {
		/// <summary>
		/// Does this Authorization Rule have Listen permissions to the ServiceBus Queue? Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> Listen { get; set; }

		/// <summary>
		/// Does this Authorization Rule have Manage permissions to the ServiceBus Queue? When this property is `true` - both `listen` and `send` must be too. Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> Manage { get; set; }

		/// <summary>
		/// Specifies the name of the Authorization Rule. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// Specifies the name of the ServiceBus Namespace in which the Queue exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> NamespaceName { get; set; }

		/// <summary>
		/// Specifies the name of the ServiceBus Queue. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> QueueName { get; set; }

		/// <summary>
		/// The name of the Resource Group in which the ServiceBus Namespace exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// Does this Authorization Rule have Send permissions to the ServiceBus Queue? Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> Send { get; set; }

	} // QueueAuthorizationRuleArgs

	/// <summary>
	/// Manages an Authorization Rule for a ServiceBus Queue.
	/// </summary>
	public class QueueAuthorizationRule : Pulumi.CustomResource {
		/// <summary>
		/// Does this Authorization Rule have Listen permissions to the ServiceBus Queue? Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> Listen { get; set; }

		/// <summary>
		/// Does this Authorization Rule have Manage permissions to the ServiceBus Queue? When this property is `true` - both `listen` and `send` must be too. Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> Manage { get; set; }

		/// <summary>
		/// Specifies the name of the Authorization Rule. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// Specifies the name of the ServiceBus Namespace in which the Queue exists. Changing this forces a new resource to be created.
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
		/// Specifies the name of the ServiceBus Queue. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> QueueName { get; set; }

		/// <summary>
		/// The name of the Resource Group in which the ServiceBus Namespace exists. Changing this forces a new resource to be created.
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
		/// Does this Authorization Rule have Send permissions to the ServiceBus Queue? Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> Send { get; set; }

		public QueueAuthorizationRule(string name, QueueAuthorizationRuleArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:eventhub/queueAuthorizationRule:QueueAuthorizationRule", name, SerialiseArgs(args), opts) {
			Listen = base.Outputs["listen"].Select(item => Protobuf.ToBool(item));
			Manage = base.Outputs["manage"].Select(item => Protobuf.ToBool(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			NamespaceName = base.Outputs["namespaceName"].Select(item => Protobuf.ToString(item));
			PrimaryConnectionString = base.Outputs["primaryConnectionString"].Select(item => Protobuf.ToString(item));
			PrimaryKey = base.Outputs["primaryKey"].Select(item => Protobuf.ToString(item));
			QueueName = base.Outputs["queueName"].Select(item => Protobuf.ToString(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			SecondaryConnectionString = base.Outputs["secondaryConnectionString"].Select(item => Protobuf.ToString(item));
			SecondaryKey = base.Outputs["secondaryKey"].Select(item => Protobuf.ToString(item));
			Send = base.Outputs["send"].Select(item => Protobuf.ToBool(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(QueueAuthorizationRuleArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["listen"] = Protobuf.ToProtobuf(args.Listen);
			props["manage"] = Protobuf.ToProtobuf(args.Manage);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["namespaceName"] = Protobuf.ToProtobuf(args.NamespaceName);
			props["queueName"] = Protobuf.ToProtobuf(args.QueueName);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["send"] = Protobuf.ToProtobuf(args.Send);
			props["primaryConnectionString"] = null; //out
			props["primaryKey"] = null; //out
			props["secondaryConnectionString"] = null; //out
			props["secondaryKey"] = null; //out
			return props;
		} // SerialiseArgs

	} // QueueAuthorizationRule
} // Pulumi.Azure.Eventhub
