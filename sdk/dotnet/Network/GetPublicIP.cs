// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Network {

	/// <summary>
	/// A collection of arguments for invoking getPublicIP.
	/// </summary>
	public struct GetPublicIPArgs {
		/// <summary>
		/// Specifies the name of the public IP address.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Specifies the name of the resource group.
		/// </summary>
		public string ResourceGroupName { get; set; }

		public System.Collections.Generic.Dictionary<string, string> Tags { get; set; }

		public string[] Zones { get; set; }

	} // GetPublicIPArgs

	/// <summary>
	/// A collection of values returned by getPublicIP.
	/// </summary>
	public struct GetPublicIPResult {
		public string AllocationMethod { get; set; }

		/// <summary>
		/// The label for the Domain Name.
		/// </summary>
		public string DomainNameLabel { get; set; }

		/// <summary>
		/// Fully qualified domain name of the A DNS record associated with the public IP. This is the concatenation of the domainNameLabel and the regionalized DNS zone.
		/// </summary>
		public string Fqdn { get; set; }

		/// <summary>
		/// Specifies the timeout for the TCP idle connection.
		/// </summary>
		public int IdleTimeoutInMinutes { get; set; }

		/// <summary>
		/// The IP address value that was allocated.
		/// </summary>
		public string IpAddress { get; set; }

		/// <summary>
		/// The IP version being used, for example `IPv4` or `IPv6`.
		/// </summary>
		public string IpVersion { get; set; }

		public string Location { get; set; }

		public string ReverseFqdn { get; set; }

		public string Sku { get; set; }

		/// <summary>
		/// A mapping of tags to assigned to the resource.
		/// </summary>
		public System.Collections.Generic.Dictionary<string, string> Tags { get; set; }

		public string[] Zones { get; set; }

		/// <summary>
		/// id is the provider-assigned unique ID for this managed resource.
		/// </summary>
		public string Id { get; set; }

	} // GetPublicIPResult

	public static partial class NetworkModule {
		/// <summary>
		/// Use this data source to access information about an existing Public IP Address.
		/// </summary>
		public static System.Threading.Tasks.Task<GetPublicIPResult> GetPublicIP(GetPublicIPArgs args, Pulumi.InvokeOptions opts = default(Pulumi.InvokeOptions)) {
			var invokeArgs = new Google.Protobuf.WellKnownTypes.Struct();
			invokeArgs.Fields["name"] = Protobuf.ToProtobuf(args.Name);
			invokeArgs.Fields["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			invokeArgs.Fields["tags"] = Protobuf.ToProtobuf(args.Tags);
			invokeArgs.Fields["zones"] = Protobuf.ToProtobuf(args.Zones, item => Protobuf.ToProtobuf(item));

			var task = Pulumi.Runtime.InvokeAsync("azure:network/getPublicIP:getPublicIP", invokeArgs, opts);

			return task.ContinueWith(response => {
				var protobuf = response.Result;
				var result = new GetPublicIPResult();
				if (protobuf.Fields.ContainsKey("allocationMethod")) {
					result.AllocationMethod = Protobuf.ToString(protobuf.Fields["allocationMethod"]);
				}
				if (protobuf.Fields.ContainsKey("domainNameLabel")) {
					result.DomainNameLabel = Protobuf.ToString(protobuf.Fields["domainNameLabel"]);
				}
				if (protobuf.Fields.ContainsKey("fqdn")) {
					result.Fqdn = Protobuf.ToString(protobuf.Fields["fqdn"]);
				}
				if (protobuf.Fields.ContainsKey("idleTimeoutInMinutes")) {
					result.IdleTimeoutInMinutes = Protobuf.ToInt(protobuf.Fields["idleTimeoutInMinutes"]);
				}
				if (protobuf.Fields.ContainsKey("ipAddress")) {
					result.IpAddress = Protobuf.ToString(protobuf.Fields["ipAddress"]);
				}
				if (protobuf.Fields.ContainsKey("ipVersion")) {
					result.IpVersion = Protobuf.ToString(protobuf.Fields["ipVersion"]);
				}
				if (protobuf.Fields.ContainsKey("location")) {
					result.Location = Protobuf.ToString(protobuf.Fields["location"]);
				}
				if (protobuf.Fields.ContainsKey("reverseFqdn")) {
					result.ReverseFqdn = Protobuf.ToString(protobuf.Fields["reverseFqdn"]);
				}
				if (protobuf.Fields.ContainsKey("sku")) {
					result.Sku = Protobuf.ToString(protobuf.Fields["sku"]);
				}
				if (protobuf.Fields.ContainsKey("tags")) {
					result.Tags = Protobuf.ToMap(protobuf.Fields["tags"]);
				}
				if (protobuf.Fields.ContainsKey("zones")) {
					result.Zones = Protobuf.ToList(protobuf.Fields["zones"], item => Protobuf.ToString(item));
				}
				if (protobuf.Fields.ContainsKey("id")) {
					result.Id = Protobuf.ToString(protobuf.Fields["id"]);
				}
				return result;
			});
		} // GetPublicIP

	} // NetworkModule
} // Pulumi.Azure.Network
