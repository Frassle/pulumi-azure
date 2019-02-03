// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Network {

	/// <summary>
	/// The set of arguments for constructing a NetworkInterfaceApplicationGatewayBackendAddressPoolAssociation resource.
	/// </summary>
	public struct NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationArgs {
		/// <summary>
		/// The ID of the Application Gateway's Backend Address Pool which this Network Interface which should be connected to. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> BackendAddressPoolId { get; set; }

		/// <summary>
		/// The Name of the IP Configuration within the Network Interface which should be connected to the Backend Address Pool. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> IpConfigurationName { get; set; }

		/// <summary>
		/// The ID of the Network Interface. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> NetworkInterfaceId { get; set; }

	} // NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationArgs

	/// <summary>
	/// Manages the association between a Network Interface and a Application Gateway's Backend Address Pool.
	/// </summary>
	public class NetworkInterfaceApplicationGatewayBackendAddressPoolAssociation : Pulumi.CustomResource {
		/// <summary>
		/// The ID of the Application Gateway's Backend Address Pool which this Network Interface which should be connected to. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> BackendAddressPoolId { get; set; }

		/// <summary>
		/// The Name of the IP Configuration within the Network Interface which should be connected to the Backend Address Pool. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> IpConfigurationName { get; set; }

		/// <summary>
		/// The ID of the Network Interface. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> NetworkInterfaceId { get; set; }

		public NetworkInterfaceApplicationGatewayBackendAddressPoolAssociation(string name, NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:network/networkInterfaceApplicationGatewayBackendAddressPoolAssociation:NetworkInterfaceApplicationGatewayBackendAddressPoolAssociation", name, SerialiseArgs(args), opts) {
			BackendAddressPoolId = base.Outputs["backendAddressPoolId"].Select(item => Protobuf.ToString(item));
			IpConfigurationName = base.Outputs["ipConfigurationName"].Select(item => Protobuf.ToString(item));
			NetworkInterfaceId = base.Outputs["networkInterfaceId"].Select(item => Protobuf.ToString(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(NetworkInterfaceApplicationGatewayBackendAddressPoolAssociationArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["backendAddressPoolId"] = Protobuf.ToProtobuf(args.BackendAddressPoolId);
			props["ipConfigurationName"] = Protobuf.ToProtobuf(args.IpConfigurationName);
			props["networkInterfaceId"] = Protobuf.ToProtobuf(args.NetworkInterfaceId);
			return props;
		} // SerialiseArgs

	} // NetworkInterfaceApplicationGatewayBackendAddressPoolAssociation
} // Pulumi.Azure.Network
