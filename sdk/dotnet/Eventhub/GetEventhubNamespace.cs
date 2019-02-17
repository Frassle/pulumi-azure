// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Eventhub {

	/// <summary>
	/// A collection of arguments for invoking getEventhubNamespace.
	/// </summary>
	public struct GetEventhubNamespaceArgs {
		/// <summary>
		/// The name of the EventHub Namespace.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The Name of the Resource Group where the EventHub Namespace exists.
		/// </summary>
		public string ResourceGroupName { get; set; }

	} // GetEventhubNamespaceArgs

	/// <summary>
	/// A collection of values returned by getEventhubNamespace.
	/// </summary>
	public struct GetEventhubNamespaceResult {
		/// <summary>
		/// Is Auto Inflate enabled for the EventHub Namespace?
		/// </summary>
		public bool AutoInflateEnabled { get; set; }

		/// <summary>
		/// The Capacity / Throughput Units for a `Standard` SKU namespace.
		/// </summary>
		public int Capacity { get; set; }

		/// <summary>
		/// The primary connection string for the authorization
		/// rule `RootManageSharedAccessKey`.
		/// </summary>
		public string DefaultPrimaryConnectionString { get; set; }

		/// <summary>
		/// The primary access key for the authorization rule `RootManageSharedAccessKey`.
		/// </summary>
		public string DefaultPrimaryKey { get; set; }

		/// <summary>
		/// The secondary connection string for the
		/// authorization rule `RootManageSharedAccessKey`.
		/// </summary>
		public string DefaultSecondaryConnectionString { get; set; }

		/// <summary>
		/// The secondary access key for the authorization rule `RootManageSharedAccessKey`.
		/// </summary>
		public string DefaultSecondaryKey { get; set; }

		public bool KafkaEnabled { get; set; }

		/// <summary>
		/// The Azure location where the EventHub Namespace exists
		/// </summary>
		public string Location { get; set; }

		/// <summary>
		/// Specifies the maximum number of throughput units when Auto Inflate is Enabled.
		/// </summary>
		public int MaximumThroughputUnits { get; set; }

		/// <summary>
		/// Defines which tier to use.
		/// </summary>
		public string Sku { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the EventHub Namespace.
		/// </summary>
		public System.Collections.Generic.Dictionary<string, string> Tags { get; set; }

		/// <summary>
		/// id is the provider-assigned unique ID for this managed resource.
		/// </summary>
		public string Id { get; set; }

	} // GetEventhubNamespaceResult

	public static partial class EventhubModule {
		/// <summary>
		/// Use this data source to access information about an existing EventHub Namespace.
		/// </summary>
		public static System.Threading.Tasks.Task<GetEventhubNamespaceResult> GetEventhubNamespace(GetEventhubNamespaceArgs args, Pulumi.InvokeOptions opts = default(Pulumi.InvokeOptions)) {
			var invokeArgs = new Google.Protobuf.WellKnownTypes.Struct();
			invokeArgs.Fields["name"] = Protobuf.ToProtobuf(args.Name);
			invokeArgs.Fields["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);

			var task = Pulumi.Runtime.InvokeAsync("azure:eventhub/getEventhubNamespace:getEventhubNamespace", invokeArgs, opts);

			return task.ContinueWith(response => {
				var protobuf = response.Result;
				var result = new GetEventhubNamespaceResult();
				if (protobuf.Fields.ContainsKey("autoInflateEnabled")) {
					result.AutoInflateEnabled = Protobuf.ToBool(protobuf.Fields["autoInflateEnabled"]);
				}
				if (protobuf.Fields.ContainsKey("capacity")) {
					result.Capacity = Protobuf.ToInt(protobuf.Fields["capacity"]);
				}
				if (protobuf.Fields.ContainsKey("defaultPrimaryConnectionString")) {
					result.DefaultPrimaryConnectionString = Protobuf.ToString(protobuf.Fields["defaultPrimaryConnectionString"]);
				}
				if (protobuf.Fields.ContainsKey("defaultPrimaryKey")) {
					result.DefaultPrimaryKey = Protobuf.ToString(protobuf.Fields["defaultPrimaryKey"]);
				}
				if (protobuf.Fields.ContainsKey("defaultSecondaryConnectionString")) {
					result.DefaultSecondaryConnectionString = Protobuf.ToString(protobuf.Fields["defaultSecondaryConnectionString"]);
				}
				if (protobuf.Fields.ContainsKey("defaultSecondaryKey")) {
					result.DefaultSecondaryKey = Protobuf.ToString(protobuf.Fields["defaultSecondaryKey"]);
				}
				if (protobuf.Fields.ContainsKey("kafkaEnabled")) {
					result.KafkaEnabled = Protobuf.ToBool(protobuf.Fields["kafkaEnabled"]);
				}
				if (protobuf.Fields.ContainsKey("location")) {
					result.Location = Protobuf.ToString(protobuf.Fields["location"]);
				}
				if (protobuf.Fields.ContainsKey("maximumThroughputUnits")) {
					result.MaximumThroughputUnits = Protobuf.ToInt(protobuf.Fields["maximumThroughputUnits"]);
				}
				if (protobuf.Fields.ContainsKey("sku")) {
					result.Sku = Protobuf.ToString(protobuf.Fields["sku"]);
				}
				if (protobuf.Fields.ContainsKey("tags")) {
					result.Tags = Protobuf.ToMap(protobuf.Fields["tags"]);
				}
				if (protobuf.Fields.ContainsKey("id")) {
					result.Id = Protobuf.ToString(protobuf.Fields["id"]);
				}
				return result;
			});
		} // GetEventhubNamespace

	} // EventhubModule
} // Pulumi.Azure.Eventhub