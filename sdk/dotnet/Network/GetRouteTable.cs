// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Network {

	public sealed class GetRouteTableRoute : Pulumi.IProtobuf {
		public string AddressPrefix { get; set; }
		public string Name { get; set; }
		public string NextHopInIpAddress { get; set; }
		public string NextHopType { get; set; }

		public Google.Protobuf.WellKnownTypes.Value ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("address_prefix", Protobuf.ToProtobuf(AddressPrefix)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("name", Protobuf.ToProtobuf(Name)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("next_hop_in_ip_address", Protobuf.ToProtobuf(NextHopInIpAddress)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("next_hop_type", Protobuf.ToProtobuf(NextHopType)));
		} // ToProtobuf

		public static GetRouteTableRoute FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new GetRouteTableRoute();
				if (obj.Fields.ContainsKey("address_prefix")) {
					result.AddressPrefix = Protobuf.ToString(obj.Fields["address_prefix"]);
				}
				if (obj.Fields.ContainsKey("name")) {
					result.Name = Protobuf.ToString(obj.Fields["name"]);
				}
				if (obj.Fields.ContainsKey("next_hop_in_ip_address")) {
					result.NextHopInIpAddress = Protobuf.ToString(obj.Fields["next_hop_in_ip_address"]);
				}
				if (obj.Fields.ContainsKey("next_hop_type")) {
					result.NextHopType = Protobuf.ToString(obj.Fields["next_hop_type"]);
				}
			return result;
		} // FromProtobuf

	} // GetRouteTableRoute

	/// <summary>
	/// A collection of arguments for invoking getRouteTable.
	/// </summary>
	public struct GetRouteTableArgs {
		/// <summary>
		/// The name of the Route Table.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The name of the Resource Group in which the Route Table exists.
		/// </summary>
		public string ResourceGroupName { get; set; }

	} // GetRouteTableArgs

	/// <summary>
	/// A collection of values returned by getRouteTable.
	/// </summary>
	public struct GetRouteTableResult {
		/// <summary>
		/// The Azure Region in which the Route Table exists.
		/// </summary>
		public string Location { get; set; }

		/// <summary>
		/// One or more `route` blocks as documented below.
		/// </summary>
		public GetRouteTableRoute[] Routes { get; set; }

		/// <summary>
		/// The collection of Subnets associated with this route table.
		/// </summary>
		public string[] Subnets { get; set; }

		/// <summary>
		/// A mapping of tags assigned to the Route Table.
		/// </summary>
		public System.Collections.Generic.Dictionary<string, string> Tags { get; set; }

		/// <summary>
		/// id is the provider-assigned unique ID for this managed resource.
		/// </summary>
		public string Id { get; set; }

	} // GetRouteTableResult

	public static partial class NetworkModule {
		/// <summary>
		/// Use this data source to access information about an existing Route Table.
		/// </summary>
		public static System.Threading.Tasks.Task<GetRouteTableResult> GetRouteTable(GetRouteTableArgs args, Pulumi.InvokeOptions opts = default(Pulumi.InvokeOptions)) {
			var invokeArgs = new Google.Protobuf.WellKnownTypes.Struct();
			invokeArgs.Fields["name"] = Protobuf.ToProtobuf(args.Name);
			invokeArgs.Fields["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);

			var task = Pulumi.Runtime.InvokeAsync("azure:network/getRouteTable:getRouteTable", invokeArgs, opts);

			return task.ContinueWith(response => {
				var protobuf = response.Result;
				var result = new GetRouteTableResult();
				if (protobuf.Fields.ContainsKey("location")) {
					result.Location = Protobuf.ToString(protobuf.Fields["location"]);
				}
				if (protobuf.Fields.ContainsKey("routes")) {
					result.Routes = Protobuf.ToList(protobuf.Fields["routes"], item => GetRouteTableRoute.FromProtobuf(item));
				}
				if (protobuf.Fields.ContainsKey("subnets")) {
					result.Subnets = Protobuf.ToList(protobuf.Fields["subnets"], item => Protobuf.ToString(item));
				}
				if (protobuf.Fields.ContainsKey("tags")) {
					result.Tags = Protobuf.ToMap(protobuf.Fields["tags"]);
				}
				if (protobuf.Fields.ContainsKey("id")) {
					result.Id = Protobuf.ToString(protobuf.Fields["id"]);
				}
				return result;
			});
		} // GetRouteTable

	} // NetworkModule
} // Pulumi.Azure.Network