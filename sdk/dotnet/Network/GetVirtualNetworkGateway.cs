// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Network {

	public sealed class GetVirtualNetworkGatewayBgpSetting : Pulumi.IProtobuf {
		public int Asn { get; set; }
		public int PeerWeight { get; set; }
		public string PeeringAddress { get; set; }

		public Google.Protobuf.WellKnownTypes.Value ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("asn", Protobuf.ToProtobuf(Asn)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("peer_weight", Protobuf.ToProtobuf(PeerWeight)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("peering_address", Protobuf.ToProtobuf(PeeringAddress)));
		} // ToProtobuf

		public static GetVirtualNetworkGatewayBgpSetting FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new GetVirtualNetworkGatewayBgpSetting();
				if (obj.Fields.ContainsKey("asn")) {
					result.Asn = Protobuf.ToInt(obj.Fields["asn"]);
				}
				if (obj.Fields.ContainsKey("peer_weight")) {
					result.PeerWeight = Protobuf.ToInt(obj.Fields["peer_weight"]);
				}
				if (obj.Fields.ContainsKey("peering_address")) {
					result.PeeringAddress = Protobuf.ToString(obj.Fields["peering_address"]);
				}
			return result;
		} // FromProtobuf

	} // GetVirtualNetworkGatewayBgpSetting

	public sealed class GetVirtualNetworkGatewayIpConfiguration : Pulumi.IProtobuf {
		public string Name { get; set; }
		public string PrivateIpAddressAllocation { get; set; }
		public string PublicIpAddressId { get; set; }
		public string SubnetId { get; set; }

		public Google.Protobuf.WellKnownTypes.Value ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("name", Protobuf.ToProtobuf(Name)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("private_ip_address_allocation", Protobuf.ToProtobuf(PrivateIpAddressAllocation)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("public_ip_address_id", Protobuf.ToProtobuf(PublicIpAddressId)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("subnet_id", Protobuf.ToProtobuf(SubnetId)));
		} // ToProtobuf

		public static GetVirtualNetworkGatewayIpConfiguration FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new GetVirtualNetworkGatewayIpConfiguration();
				if (obj.Fields.ContainsKey("name")) {
					result.Name = Protobuf.ToString(obj.Fields["name"]);
				}
				if (obj.Fields.ContainsKey("private_ip_address_allocation")) {
					result.PrivateIpAddressAllocation = Protobuf.ToString(obj.Fields["private_ip_address_allocation"]);
				}
				if (obj.Fields.ContainsKey("public_ip_address_id")) {
					result.PublicIpAddressId = Protobuf.ToString(obj.Fields["public_ip_address_id"]);
				}
				if (obj.Fields.ContainsKey("subnet_id")) {
					result.SubnetId = Protobuf.ToString(obj.Fields["subnet_id"]);
				}
			return result;
		} // FromProtobuf

	} // GetVirtualNetworkGatewayIpConfiguration

	public sealed class GetVirtualNetworkGatewayVpnClientConfigurationRevokedCertificate : Pulumi.IProtobuf {
		public string Name { get; set; }
		public string Thumbprint { get; set; }

		public Google.Protobuf.WellKnownTypes.Value ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("name", Protobuf.ToProtobuf(Name)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("thumbprint", Protobuf.ToProtobuf(Thumbprint)));
		} // ToProtobuf

		public static GetVirtualNetworkGatewayVpnClientConfigurationRevokedCertificate FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new GetVirtualNetworkGatewayVpnClientConfigurationRevokedCertificate();
				if (obj.Fields.ContainsKey("name")) {
					result.Name = Protobuf.ToString(obj.Fields["name"]);
				}
				if (obj.Fields.ContainsKey("thumbprint")) {
					result.Thumbprint = Protobuf.ToString(obj.Fields["thumbprint"]);
				}
			return result;
		} // FromProtobuf

	} // GetVirtualNetworkGatewayVpnClientConfigurationRevokedCertificate

	public sealed class GetVirtualNetworkGatewayVpnClientConfigurationRootCertificate : Pulumi.IProtobuf {
		public string Name { get; set; }
		public string PublicCertData { get; set; }

		public Google.Protobuf.WellKnownTypes.Value ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("name", Protobuf.ToProtobuf(Name)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("public_cert_data", Protobuf.ToProtobuf(PublicCertData)));
		} // ToProtobuf

		public static GetVirtualNetworkGatewayVpnClientConfigurationRootCertificate FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new GetVirtualNetworkGatewayVpnClientConfigurationRootCertificate();
				if (obj.Fields.ContainsKey("name")) {
					result.Name = Protobuf.ToString(obj.Fields["name"]);
				}
				if (obj.Fields.ContainsKey("public_cert_data")) {
					result.PublicCertData = Protobuf.ToString(obj.Fields["public_cert_data"]);
				}
			return result;
		} // FromProtobuf

	} // GetVirtualNetworkGatewayVpnClientConfigurationRootCertificate

	public sealed class GetVirtualNetworkGatewayVpnClientConfiguration : Pulumi.IProtobuf {
		public string[] AddressSpace { get; set; }
		public string RadiusServerAddress { get; set; }
		public string RadiusServerSecret { get; set; }
		public GetVirtualNetworkGatewayVpnClientConfigurationRevokedCertificate[] RevokedCertificate { get; set; }
		public GetVirtualNetworkGatewayVpnClientConfigurationRootCertificate[] RootCertificate { get; set; }
		public string[] VpnClientProtocols { get; set; }

		public Google.Protobuf.WellKnownTypes.Value ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("address_space", Protobuf.ToProtobuf(AddressSpace, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("radius_server_address", Protobuf.ToProtobuf(RadiusServerAddress)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("radius_server_secret", Protobuf.ToProtobuf(RadiusServerSecret)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("revoked_certificate", Protobuf.ToProtobuf(RevokedCertificate, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("root_certificate", Protobuf.ToProtobuf(RootCertificate, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("vpn_client_protocols", Protobuf.ToProtobuf(VpnClientProtocols, item => Protobuf.ToProtobuf(item))));
		} // ToProtobuf

		public static GetVirtualNetworkGatewayVpnClientConfiguration FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new GetVirtualNetworkGatewayVpnClientConfiguration();
				if (obj.Fields.ContainsKey("address_space")) {
					result.AddressSpace = Protobuf.ToList(obj.Fields["address_space"], item => Protobuf.ToString(item));
				}
				if (obj.Fields.ContainsKey("radius_server_address")) {
					result.RadiusServerAddress = Protobuf.ToString(obj.Fields["radius_server_address"]);
				}
				if (obj.Fields.ContainsKey("radius_server_secret")) {
					result.RadiusServerSecret = Protobuf.ToString(obj.Fields["radius_server_secret"]);
				}
				if (obj.Fields.ContainsKey("revoked_certificate")) {
					result.RevokedCertificate = Protobuf.ToList(obj.Fields["revoked_certificate"], item => GetVirtualNetworkGatewayVpnClientConfigurationRevokedCertificate.FromProtobuf(item));
				}
				if (obj.Fields.ContainsKey("root_certificate")) {
					result.RootCertificate = Protobuf.ToList(obj.Fields["root_certificate"], item => GetVirtualNetworkGatewayVpnClientConfigurationRootCertificate.FromProtobuf(item));
				}
				if (obj.Fields.ContainsKey("vpn_client_protocols")) {
					result.VpnClientProtocols = Protobuf.ToList(obj.Fields["vpn_client_protocols"], item => Protobuf.ToString(item));
				}
			return result;
		} // FromProtobuf

	} // GetVirtualNetworkGatewayVpnClientConfiguration

	/// <summary>
	/// A collection of arguments for invoking getVirtualNetworkGateway.
	/// </summary>
	public struct GetVirtualNetworkGatewayArgs {
		/// <summary>
		/// Specifies the name of the Virtual Network Gateway.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Specifies the name of the resource group the Virtual Network Gateway is located in.
		/// </summary>
		public string ResourceGroupName { get; set; }

	} // GetVirtualNetworkGatewayArgs

	/// <summary>
	/// A collection of values returned by getVirtualNetworkGateway.
	/// </summary>
	public struct GetVirtualNetworkGatewayResult {
		/// <summary>
		/// (Optional) Is this an Active-Active Gateway?
		/// </summary>
		public bool ActiveActive { get; set; }

		public GetVirtualNetworkGatewayBgpSetting[] BgpSettings { get; set; }

		/// <summary>
		/// The ID of the local network gateway
		/// through which outbound Internet traffic from the virtual network in which the
		/// gateway is created will be routed (*forced tunneling*). Refer to the
		/// [Azure documentation on forced tunneling](https://docs.microsoft.com/en-us/azure/vpn-gateway/vpn-gateway-forced-tunneling-rm).
		/// </summary>
		public string DefaultLocalNetworkGatewayId { get; set; }

		/// <summary>
		/// Will BGP (Border Gateway Protocol) will be enabled
		/// for this Virtual Network Gateway.
		/// </summary>
		public bool EnableBgp { get; set; }

		/// <summary>
		/// One or two `ip_configuration` blocks documented below.
		/// </summary>
		public GetVirtualNetworkGatewayIpConfiguration[] IpConfigurations { get; set; }

		/// <summary>
		/// The location/region where the Virtual Network Gateway is located.
		/// </summary>
		public string Location { get; set; }

		/// <summary>
		/// Configuration of the size and capacity of the Virtual Network Gateway.
		/// </summary>
		public string Sku { get; set; }

		/// <summary>
		/// A mapping of tags assigned to the resource.
		/// </summary>
		public System.Collections.Generic.Dictionary<string, string> Tags { get; set; }

		/// <summary>
		/// The type of the Virtual Network Gateway.
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// A `vpn_client_configuration` block which is documented below.
		/// </summary>
		public GetVirtualNetworkGatewayVpnClientConfiguration[] VpnClientConfigurations { get; set; }

		/// <summary>
		/// The routing type of the Virtual Network Gateway.
		/// </summary>
		public string VpnType { get; set; }

		/// <summary>
		/// id is the provider-assigned unique ID for this managed resource.
		/// </summary>
		public string Id { get; set; }

	} // GetVirtualNetworkGatewayResult

	public static partial class NetworkModule {
		/// <summary>
		/// Use this data source to access information about an existing Virtual Network Gateway.
		/// </summary>
		public static System.Threading.Tasks.Task<GetVirtualNetworkGatewayResult> GetVirtualNetworkGateway(GetVirtualNetworkGatewayArgs args, Pulumi.InvokeOptions opts = default(Pulumi.InvokeOptions)) {
			var invokeArgs = new Google.Protobuf.WellKnownTypes.Struct();
			invokeArgs.Fields["name"] = Protobuf.ToProtobuf(args.Name);
			invokeArgs.Fields["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);

			var task = Pulumi.Runtime.InvokeAsync("azure:network/getVirtualNetworkGateway:getVirtualNetworkGateway", invokeArgs, opts);

			return task.ContinueWith(response => {
				var protobuf = response.Result;
				var result = new GetVirtualNetworkGatewayResult();
				if (protobuf.Fields.ContainsKey("activeActive")) {
					result.ActiveActive = Protobuf.ToBool(protobuf.Fields["activeActive"]);
				}
				if (protobuf.Fields.ContainsKey("bgpSettings")) {
					result.BgpSettings = Protobuf.ToList(protobuf.Fields["bgpSettings"], item => GetVirtualNetworkGatewayBgpSetting.FromProtobuf(item));
				}
				if (protobuf.Fields.ContainsKey("defaultLocalNetworkGatewayId")) {
					result.DefaultLocalNetworkGatewayId = Protobuf.ToString(protobuf.Fields["defaultLocalNetworkGatewayId"]);
				}
				if (protobuf.Fields.ContainsKey("enableBgp")) {
					result.EnableBgp = Protobuf.ToBool(protobuf.Fields["enableBgp"]);
				}
				if (protobuf.Fields.ContainsKey("ipConfigurations")) {
					result.IpConfigurations = Protobuf.ToList(protobuf.Fields["ipConfigurations"], item => GetVirtualNetworkGatewayIpConfiguration.FromProtobuf(item));
				}
				if (protobuf.Fields.ContainsKey("location")) {
					result.Location = Protobuf.ToString(protobuf.Fields["location"]);
				}
				if (protobuf.Fields.ContainsKey("sku")) {
					result.Sku = Protobuf.ToString(protobuf.Fields["sku"]);
				}
				if (protobuf.Fields.ContainsKey("tags")) {
					result.Tags = Protobuf.ToMap(protobuf.Fields["tags"]);
				}
				if (protobuf.Fields.ContainsKey("type")) {
					result.Type = Protobuf.ToString(protobuf.Fields["type"]);
				}
				if (protobuf.Fields.ContainsKey("vpnClientConfigurations")) {
					result.VpnClientConfigurations = Protobuf.ToList(protobuf.Fields["vpnClientConfigurations"], item => GetVirtualNetworkGatewayVpnClientConfiguration.FromProtobuf(item));
				}
				if (protobuf.Fields.ContainsKey("vpnType")) {
					result.VpnType = Protobuf.ToString(protobuf.Fields["vpnType"]);
				}
				if (protobuf.Fields.ContainsKey("id")) {
					result.Id = Protobuf.ToString(protobuf.Fields["id"]);
				}
				return result;
			});
		} // GetVirtualNetworkGateway

	} // NetworkModule
} // Pulumi.Azure.Network
