// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Network {

	public sealed class RouteTableArgsRoute : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> AddressPrefix { get; set; }
		public Pulumi.IO<string> Name { get; set; }
		public Pulumi.IO<string> NextHopInIpAddress { get; set; }
		public Pulumi.IO<string> NextHopType { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("address_prefix", Protobuf.ToProtobuf(AddressPrefix)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("name", Protobuf.ToProtobuf(Name)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("next_hop_in_ip_address", Protobuf.ToProtobuf(NextHopInIpAddress)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("next_hop_type", Protobuf.ToProtobuf(NextHopType)));
		} // ToProtobuf

	} // RouteTableArgsRoute

	public sealed class RouteTableRoute : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> AddressPrefix { get; set; }
		public Pulumi.IO<string> Name { get; set; }
		public Pulumi.IO<string> NextHopInIpAddress { get; set; }
		public Pulumi.IO<string> NextHopType { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("address_prefix", Protobuf.ToProtobuf(AddressPrefix)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("name", Protobuf.ToProtobuf(Name)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("next_hop_in_ip_address", Protobuf.ToProtobuf(NextHopInIpAddress)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("next_hop_type", Protobuf.ToProtobuf(NextHopType)));
		} // ToProtobuf

		public static RouteTableRoute FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new RouteTableRoute();
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

	} // RouteTableRoute

	/// <summary>
	/// The set of arguments for constructing a RouteTable resource.
	/// </summary>
	public struct RouteTableArgs {
		/// <summary>
		/// Boolean flag which controls propagation of routes learned by BGP on that route table. True means disable.
		/// </summary>
		public Pulumi.IO<bool> DisableBgpRoutePropagation { get; set; }

		/// <summary>
		/// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// The name of the route table. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The name of the resource group in which to create the route table. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// Can be specified multiple times to define multiple routes. Each `route` block supports fields documented below.
		/// </summary>
		public Pulumi.IO<Pulumi.IO<RouteTableArgsRoute>[]> Routes { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

	} // RouteTableArgs

	/// <summary>
	/// Manages a Route Table
	/// </summary>
	public class RouteTable : Pulumi.CustomResource {
		/// <summary>
		/// Boolean flag which controls propagation of routes learned by BGP on that route table. True means disable.
		/// </summary>
		public Pulumi.IO<bool> DisableBgpRoutePropagation { get; set; }

		/// <summary>
		/// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// The name of the route table. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The name of the resource group in which to create the route table. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// Can be specified multiple times to define multiple routes. Each `route` block supports fields documented below.
		/// </summary>
		public Pulumi.IO<RouteTableRoute[]> Routes { get; set; }

		/// <summary>
		/// The collection of Subnets associated with this route table.
		/// </summary>
		public Pulumi.IO<string[]> Subnets { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

		public RouteTable(string name, RouteTableArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:network/routeTable:RouteTable", name, SerialiseArgs(args), opts) {
			DisableBgpRoutePropagation = base.Outputs["disableBgpRoutePropagation"].Select(item => Protobuf.ToBool(item));
			Location = base.Outputs["location"].Select(item => Protobuf.ToString(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			Routes = base.Outputs["routes"].Select(item => Protobuf.ToList(item, item1 => RouteTableRoute.FromProtobuf(item1)));
			Subnets = base.Outputs["subnets"].Select(item => Protobuf.ToList(item, item1 => Protobuf.ToString(item1)));
			Tags = base.Outputs["tags"].Select(item => Protobuf.ToMap(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(RouteTableArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["disableBgpRoutePropagation"] = Protobuf.ToProtobuf(args.DisableBgpRoutePropagation);
			props["location"] = Protobuf.ToProtobuf(args.Location);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["routes"] = Protobuf.ToProtobuf(args.Routes, item => Protobuf.ToProtobuf(item));
			props["tags"] = Protobuf.ToProtobuf(args.Tags);
			props["subnets"] = null; //out
			return props;
		} // SerialiseArgs

	} // RouteTable
} // Pulumi.Azure.Network