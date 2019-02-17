// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Storage {

	/// <summary>
	/// The set of arguments for constructing a Queue resource.
	/// </summary>
	public struct QueueArgs {
		/// <summary>
		/// The name of the storage queue. Must be unique within the storage account the queue is located.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The name of the resource group in which to
		/// create the storage queue. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// Specifies the storage account in which to create the storage queue.
		/// Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> StorageAccountName { get; set; }

	} // QueueArgs

	/// <summary>
	/// Manage an Azure Storage Queue.
	/// </summary>
	public class Queue : Pulumi.CustomResource {
		/// <summary>
		/// The name of the storage queue. Must be unique within the storage account the queue is located.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The name of the resource group in which to
		/// create the storage queue. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// Specifies the storage account in which to create the storage queue.
		/// Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> StorageAccountName { get; set; }

		public Queue(string name, QueueArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:storage/queue:Queue", name, SerialiseArgs(args), opts) {
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			StorageAccountName = base.Outputs["storageAccountName"].Select(item => Protobuf.ToString(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(QueueArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["storageAccountName"] = Protobuf.ToProtobuf(args.StorageAccountName);
			return props;
		} // SerialiseArgs

	} // Queue
} // Pulumi.Azure.Storage