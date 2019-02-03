// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Network {

	/// <summary>
	/// The set of arguments for constructing a SubnetRouteTableAssociation resource.
	/// </summary>
	public struct SubnetRouteTableAssociationArgs {
		/// <summary>
		/// The ID of the Route Table which should be associated with the Subnet. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> RouteTableId { get; set; }

		/// <summary>
		/// The ID of the Subnet. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> SubnetId { get; set; }

	} // SubnetRouteTableAssociationArgs

	/// <summary>
	/// Associates a Route Table with a Subnet within a Virtual Network.
	/// 
	/// -> **NOTE:** Subnet `<->` Route Table associations currently need to be configured on both this resource and using the `route_table_id` field on the `azurerm_subnet` resource. The next major version of the AzureRM Provider (2.0) will remove the `route_table_id` field from the `azurerm_subnet` resource such that this resource is used to link resources in future.
	/// </summary>
	public class SubnetRouteTableAssociation : Pulumi.CustomResource {
		/// <summary>
		/// The ID of the Route Table which should be associated with the Subnet. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> RouteTableId { get; set; }

		/// <summary>
		/// The ID of the Subnet. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> SubnetId { get; set; }

		public SubnetRouteTableAssociation(string name, SubnetRouteTableAssociationArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:network/subnetRouteTableAssociation:SubnetRouteTableAssociation", name, SerialiseArgs(args), opts) {
			RouteTableId = base.Outputs["routeTableId"].Select(item => Protobuf.ToString(item));
			SubnetId = base.Outputs["subnetId"].Select(item => Protobuf.ToString(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(SubnetRouteTableAssociationArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["routeTableId"] = Protobuf.ToProtobuf(args.RouteTableId);
			props["subnetId"] = Protobuf.ToProtobuf(args.SubnetId);
			return props;
		} // SerialiseArgs

	} // SubnetRouteTableAssociation
} // Pulumi.Azure.Network
