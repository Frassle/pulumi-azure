// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Containerservice {

	/// <summary>
	/// A collection of arguments for invoking getRegistry.
	/// </summary>
	public struct GetRegistryArgs {
		/// <summary>
		/// The name of the Container Registry.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The Name of the Resource Group where this Container Registry exists.
		/// </summary>
		public string ResourceGroupName { get; set; }

	} // GetRegistryArgs

	/// <summary>
	/// A collection of values returned by getRegistry.
	/// </summary>
	public struct GetRegistryResult {
		/// <summary>
		/// Is the Administrator account enabled for this Container Registry.
		/// </summary>
		public bool AdminEnabled { get; set; }

		/// <summary>
		/// The Password associated with the Container Registry Admin account - if the admin account is enabled.
		/// </summary>
		public string AdminPassword { get; set; }

		/// <summary>
		/// The Username associated with the Container Registry Admin account - if the admin account is enabled.
		/// </summary>
		public string AdminUsername { get; set; }

		/// <summary>
		/// The Azure Region in which this Container Registry exists.
		/// </summary>
		public string Location { get; set; }

		/// <summary>
		/// The URL that can be used to log into the container registry.
		/// </summary>
		public string LoginServer { get; set; }

		/// <summary>
		/// The SKU of this Container Registry, such as `Basic`.
		/// </summary>
		public string Sku { get; set; }

		/// <summary>
		/// The ID of the Storage Account used for this Container Registry. This is only returned for `Classic` SKU's.
		/// </summary>
		public string StorageAccountId { get; set; }

		/// <summary>
		/// A map of tags assigned to the Container Registry.
		/// </summary>
		public System.Collections.Generic.Dictionary<string, string> Tags { get; set; }

		/// <summary>
		/// id is the provider-assigned unique ID for this managed resource.
		/// </summary>
		public string Id { get; set; }

	} // GetRegistryResult

	public static partial class ContainerserviceModule {
		/// <summary>
		/// Use this data source to access information about an existing Container Registry.
		/// </summary>
		public static System.Threading.Tasks.Task<GetRegistryResult> GetRegistry(GetRegistryArgs args, Pulumi.InvokeOptions opts = default(Pulumi.InvokeOptions)) {
			var invokeArgs = new Google.Protobuf.WellKnownTypes.Struct();
			invokeArgs.Fields["name"] = Protobuf.ToProtobuf(args.Name);
			invokeArgs.Fields["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);

			var task = Pulumi.Runtime.InvokeAsync("azure:containerservice/getRegistry:getRegistry", invokeArgs, opts);

			return task.ContinueWith(response => {
				var protobuf = response.Result;
				var result = new GetRegistryResult();
				if (protobuf.Fields.ContainsKey("adminEnabled")) {
					result.AdminEnabled = Protobuf.ToBool(protobuf.Fields["adminEnabled"]);
				}
				if (protobuf.Fields.ContainsKey("adminPassword")) {
					result.AdminPassword = Protobuf.ToString(protobuf.Fields["adminPassword"]);
				}
				if (protobuf.Fields.ContainsKey("adminUsername")) {
					result.AdminUsername = Protobuf.ToString(protobuf.Fields["adminUsername"]);
				}
				if (protobuf.Fields.ContainsKey("location")) {
					result.Location = Protobuf.ToString(protobuf.Fields["location"]);
				}
				if (protobuf.Fields.ContainsKey("loginServer")) {
					result.LoginServer = Protobuf.ToString(protobuf.Fields["loginServer"]);
				}
				if (protobuf.Fields.ContainsKey("sku")) {
					result.Sku = Protobuf.ToString(protobuf.Fields["sku"]);
				}
				if (protobuf.Fields.ContainsKey("storageAccountId")) {
					result.StorageAccountId = Protobuf.ToString(protobuf.Fields["storageAccountId"]);
				}
				if (protobuf.Fields.ContainsKey("tags")) {
					result.Tags = Protobuf.ToMap(protobuf.Fields["tags"]);
				}
				if (protobuf.Fields.ContainsKey("id")) {
					result.Id = Protobuf.ToString(protobuf.Fields["id"]);
				}
				return result;
			});
		} // GetRegistry

	} // ContainerserviceModule
} // Pulumi.Azure.Containerservice