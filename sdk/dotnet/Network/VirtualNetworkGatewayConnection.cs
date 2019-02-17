// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Network {

	public sealed class VirtualNetworkGatewayConnectionArgsIpsecPolicy : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> DhGroup { get; set; }
		public Pulumi.IO<string> IkeEncryption { get; set; }
		public Pulumi.IO<string> IkeIntegrity { get; set; }
		public Pulumi.IO<string> IpsecEncryption { get; set; }
		public Pulumi.IO<string> IpsecIntegrity { get; set; }
		public Pulumi.IO<string> PfsGroup { get; set; }
		public Pulumi.IO<int> SaDatasize { get; set; }
		public Pulumi.IO<int> SaLifetime { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("dh_group", Protobuf.ToProtobuf(DhGroup)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("ike_encryption", Protobuf.ToProtobuf(IkeEncryption)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("ike_integrity", Protobuf.ToProtobuf(IkeIntegrity)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("ipsec_encryption", Protobuf.ToProtobuf(IpsecEncryption)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("ipsec_integrity", Protobuf.ToProtobuf(IpsecIntegrity)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("pfs_group", Protobuf.ToProtobuf(PfsGroup)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("sa_datasize", Protobuf.ToProtobuf(SaDatasize)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("sa_lifetime", Protobuf.ToProtobuf(SaLifetime)));
		} // ToProtobuf

	} // VirtualNetworkGatewayConnectionArgsIpsecPolicy

	public sealed class VirtualNetworkGatewayConnectionIpsecPolicy : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> DhGroup { get; set; }
		public Pulumi.IO<string> IkeEncryption { get; set; }
		public Pulumi.IO<string> IkeIntegrity { get; set; }
		public Pulumi.IO<string> IpsecEncryption { get; set; }
		public Pulumi.IO<string> IpsecIntegrity { get; set; }
		public Pulumi.IO<string> PfsGroup { get; set; }
		public Pulumi.IO<int> SaDatasize { get; set; }
		public Pulumi.IO<int> SaLifetime { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("dh_group", Protobuf.ToProtobuf(DhGroup)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("ike_encryption", Protobuf.ToProtobuf(IkeEncryption)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("ike_integrity", Protobuf.ToProtobuf(IkeIntegrity)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("ipsec_encryption", Protobuf.ToProtobuf(IpsecEncryption)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("ipsec_integrity", Protobuf.ToProtobuf(IpsecIntegrity)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("pfs_group", Protobuf.ToProtobuf(PfsGroup)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("sa_datasize", Protobuf.ToProtobuf(SaDatasize)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("sa_lifetime", Protobuf.ToProtobuf(SaLifetime)));
		} // ToProtobuf

		public static VirtualNetworkGatewayConnectionIpsecPolicy FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new VirtualNetworkGatewayConnectionIpsecPolicy();
				if (obj.Fields.ContainsKey("dh_group")) {
					result.DhGroup = Protobuf.ToString(obj.Fields["dh_group"]);
				}
				if (obj.Fields.ContainsKey("ike_encryption")) {
					result.IkeEncryption = Protobuf.ToString(obj.Fields["ike_encryption"]);
				}
				if (obj.Fields.ContainsKey("ike_integrity")) {
					result.IkeIntegrity = Protobuf.ToString(obj.Fields["ike_integrity"]);
				}
				if (obj.Fields.ContainsKey("ipsec_encryption")) {
					result.IpsecEncryption = Protobuf.ToString(obj.Fields["ipsec_encryption"]);
				}
				if (obj.Fields.ContainsKey("ipsec_integrity")) {
					result.IpsecIntegrity = Protobuf.ToString(obj.Fields["ipsec_integrity"]);
				}
				if (obj.Fields.ContainsKey("pfs_group")) {
					result.PfsGroup = Protobuf.ToString(obj.Fields["pfs_group"]);
				}
				if (obj.Fields.ContainsKey("sa_datasize")) {
					result.SaDatasize = Protobuf.ToInt(obj.Fields["sa_datasize"]);
				}
				if (obj.Fields.ContainsKey("sa_lifetime")) {
					result.SaLifetime = Protobuf.ToInt(obj.Fields["sa_lifetime"]);
				}
			return result;
		} // FromProtobuf

	} // VirtualNetworkGatewayConnectionIpsecPolicy

	/// <summary>
	/// The set of arguments for constructing a VirtualNetworkGatewayConnection resource.
	/// </summary>
	public struct VirtualNetworkGatewayConnectionArgs {
		/// <summary>
		/// The authorization key associated with the
		/// Express Route Circuit. This field is required only if the type is an
		/// ExpressRoute connection.
		/// </summary>
		public Pulumi.IO<string> AuthorizationKey { get; set; }

		/// <summary>
		/// If `true`, BGP (Border Gateway Protocol) is enabled
		/// for this connection. Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> EnableBgp { get; set; }

		/// <summary>
		/// The ID of the Express Route Circuit
		/// when creating an ExpressRoute connection (i.e. when `type` is `ExpressRoute`).
		/// The Express Route Circuit can be in the same or in a different subscription.
		/// </summary>
		public Pulumi.IO<string> ExpressRouteCircuitId { get; set; }

		/// <summary>
		/// A `ipsec_policy` block which is documented below.
		/// Only a single policy can be defined for a connection. For details on
		/// custom policies refer to [the relevant section in the Azure documentation](https://docs.microsoft.com/en-us/azure/vpn-gateway/vpn-gateway-ipsecikepolicy-rm-powershell).
		/// </summary>
		public Pulumi.IO<VirtualNetworkGatewayConnectionArgsIpsecPolicy> IpsecPolicy { get; set; }

		/// <summary>
		/// The ID of the local network gateway
		/// when creating Site-to-Site connection (i.e. when `type` is `IPsec`).
		/// </summary>
		public Pulumi.IO<string> LocalNetworkGatewayId { get; set; }

		/// <summary>
		/// The location/region where the connection is
		/// located. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// The name of the connection. Changing the name forces a
		/// new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The ID of the peer virtual
		/// network gateway when creating a VNet-to-VNet connection (i.e. when `type`
		/// is `Vnet2Vnet`). The peer Virtual Network Gateway can be in the same or
		/// in a different subscription.
		/// </summary>
		public Pulumi.IO<string> PeerVirtualNetworkGatewayId { get; set; }

		/// <summary>
		/// The name of the resource group in which to
		/// create the connection Changing the name forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// The routing weight. Defaults to `10`.
		/// </summary>
		public Pulumi.IO<int> RoutingWeight { get; set; }

		/// <summary>
		/// The shared IPSec key. A key must be provided if a
		/// Site-to-Site or VNet-to-VNet connection is created whereas ExpressRoute
		/// connections do not need a shared key.
		/// </summary>
		public Pulumi.IO<string> SharedKey { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

		/// <summary>
		/// The type of connection. Valid options are `IPsec`
		/// (Site-to-Site), `ExpressRoute` (ExpressRoute), and `Vnet2Vnet` (VNet-to-VNet).
		/// Each connection type requires different mandatory arguments (refer to the
		/// examples above). Changing the connection type will force a new connection
		/// to be created.
		/// </summary>
		public Pulumi.IO<string> Type { get; set; }

		/// <summary>
		/// If `true`, policy-based traffic
		/// selectors are enabled for this connection. Enabling policy-based traffic
		/// selectors requires an `ipsec_policy` block. Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> UsePolicyBasedTrafficSelectors { get; set; }

		/// <summary>
		/// The ID of the Virtual Network Gateway
		/// in which the connection will be created. Changing the gateway forces a new
		/// resource to be created.
		/// </summary>
		public Pulumi.IO<string> VirtualNetworkGatewayId { get; set; }

	} // VirtualNetworkGatewayConnectionArgs

	/// <summary>
	/// Manages a connection in an existing Virtual Network Gateway.
	/// </summary>
	public class VirtualNetworkGatewayConnection : Pulumi.CustomResource {
		/// <summary>
		/// The authorization key associated with the
		/// Express Route Circuit. This field is required only if the type is an
		/// ExpressRoute connection.
		/// </summary>
		public Pulumi.IO<string> AuthorizationKey { get; set; }

		/// <summary>
		/// If `true`, BGP (Border Gateway Protocol) is enabled
		/// for this connection. Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> EnableBgp { get; set; }

		/// <summary>
		/// The ID of the Express Route Circuit
		/// when creating an ExpressRoute connection (i.e. when `type` is `ExpressRoute`).
		/// The Express Route Circuit can be in the same or in a different subscription.
		/// </summary>
		public Pulumi.IO<string> ExpressRouteCircuitId { get; set; }

		/// <summary>
		/// A `ipsec_policy` block which is documented below.
		/// Only a single policy can be defined for a connection. For details on
		/// custom policies refer to [the relevant section in the Azure documentation](https://docs.microsoft.com/en-us/azure/vpn-gateway/vpn-gateway-ipsecikepolicy-rm-powershell).
		/// </summary>
		public Pulumi.IO<VirtualNetworkGatewayConnectionIpsecPolicy> IpsecPolicy { get; set; }

		/// <summary>
		/// The ID of the local network gateway
		/// when creating Site-to-Site connection (i.e. when `type` is `IPsec`).
		/// </summary>
		public Pulumi.IO<string> LocalNetworkGatewayId { get; set; }

		/// <summary>
		/// The location/region where the connection is
		/// located. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// The name of the connection. Changing the name forces a
		/// new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The ID of the peer virtual
		/// network gateway when creating a VNet-to-VNet connection (i.e. when `type`
		/// is `Vnet2Vnet`). The peer Virtual Network Gateway can be in the same or
		/// in a different subscription.
		/// </summary>
		public Pulumi.IO<string> PeerVirtualNetworkGatewayId { get; set; }

		/// <summary>
		/// The name of the resource group in which to
		/// create the connection Changing the name forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// The routing weight. Defaults to `10`.
		/// </summary>
		public Pulumi.IO<int> RoutingWeight { get; set; }

		/// <summary>
		/// The shared IPSec key. A key must be provided if a
		/// Site-to-Site or VNet-to-VNet connection is created whereas ExpressRoute
		/// connections do not need a shared key.
		/// </summary>
		public Pulumi.IO<string> SharedKey { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

		/// <summary>
		/// The type of connection. Valid options are `IPsec`
		/// (Site-to-Site), `ExpressRoute` (ExpressRoute), and `Vnet2Vnet` (VNet-to-VNet).
		/// Each connection type requires different mandatory arguments (refer to the
		/// examples above). Changing the connection type will force a new connection
		/// to be created.
		/// </summary>
		public Pulumi.IO<string> Type { get; set; }

		/// <summary>
		/// If `true`, policy-based traffic
		/// selectors are enabled for this connection. Enabling policy-based traffic
		/// selectors requires an `ipsec_policy` block. Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> UsePolicyBasedTrafficSelectors { get; set; }

		/// <summary>
		/// The ID of the Virtual Network Gateway
		/// in which the connection will be created. Changing the gateway forces a new
		/// resource to be created.
		/// </summary>
		public Pulumi.IO<string> VirtualNetworkGatewayId { get; set; }

		public VirtualNetworkGatewayConnection(string name, VirtualNetworkGatewayConnectionArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:network/virtualNetworkGatewayConnection:VirtualNetworkGatewayConnection", name, SerialiseArgs(args), opts) {
			AuthorizationKey = base.Outputs["authorizationKey"].Select(item => Protobuf.ToString(item));
			EnableBgp = base.Outputs["enableBgp"].Select(item => Protobuf.ToBool(item));
			ExpressRouteCircuitId = base.Outputs["expressRouteCircuitId"].Select(item => Protobuf.ToString(item));
			IpsecPolicy = base.Outputs["ipsecPolicy"].Select(item => VirtualNetworkGatewayConnectionIpsecPolicy.FromProtobuf(item));
			LocalNetworkGatewayId = base.Outputs["localNetworkGatewayId"].Select(item => Protobuf.ToString(item));
			Location = base.Outputs["location"].Select(item => Protobuf.ToString(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			PeerVirtualNetworkGatewayId = base.Outputs["peerVirtualNetworkGatewayId"].Select(item => Protobuf.ToString(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			RoutingWeight = base.Outputs["routingWeight"].Select(item => Protobuf.ToInt(item));
			SharedKey = base.Outputs["sharedKey"].Select(item => Protobuf.ToString(item));
			Tags = base.Outputs["tags"].Select(item => Protobuf.ToMap(item));
			Type = base.Outputs["type"].Select(item => Protobuf.ToString(item));
			UsePolicyBasedTrafficSelectors = base.Outputs["usePolicyBasedTrafficSelectors"].Select(item => Protobuf.ToBool(item));
			VirtualNetworkGatewayId = base.Outputs["virtualNetworkGatewayId"].Select(item => Protobuf.ToString(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(VirtualNetworkGatewayConnectionArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["authorizationKey"] = Protobuf.ToProtobuf(args.AuthorizationKey);
			props["enableBgp"] = Protobuf.ToProtobuf(args.EnableBgp);
			props["expressRouteCircuitId"] = Protobuf.ToProtobuf(args.ExpressRouteCircuitId);
			props["ipsecPolicy"] = Protobuf.ToProtobuf(args.IpsecPolicy);
			props["localNetworkGatewayId"] = Protobuf.ToProtobuf(args.LocalNetworkGatewayId);
			props["location"] = Protobuf.ToProtobuf(args.Location);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["peerVirtualNetworkGatewayId"] = Protobuf.ToProtobuf(args.PeerVirtualNetworkGatewayId);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["routingWeight"] = Protobuf.ToProtobuf(args.RoutingWeight);
			props["sharedKey"] = Protobuf.ToProtobuf(args.SharedKey);
			props["tags"] = Protobuf.ToProtobuf(args.Tags);
			props["type"] = Protobuf.ToProtobuf(args.Type);
			props["usePolicyBasedTrafficSelectors"] = Protobuf.ToProtobuf(args.UsePolicyBasedTrafficSelectors);
			props["virtualNetworkGatewayId"] = Protobuf.ToProtobuf(args.VirtualNetworkGatewayId);
			return props;
		} // SerialiseArgs

	} // VirtualNetworkGatewayConnection
} // Pulumi.Azure.Network