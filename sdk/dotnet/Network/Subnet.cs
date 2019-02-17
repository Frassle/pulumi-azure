// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Network {

	public sealed class SubnetArgsDelegationArgsServiceDelegation : Pulumi.IIOProtobuf {
		public Pulumi.IO<Pulumi.IO<string>[]> Actions { get; set; }
		public Pulumi.IO<string> Name { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("actions", Protobuf.ToProtobuf(Actions, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("name", Protobuf.ToProtobuf(Name)));
		} // ToProtobuf

	} // SubnetArgsDelegationArgsServiceDelegation

	public sealed class SubnetArgsDelegation : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Name { get; set; }
		public Pulumi.IO<SubnetArgsDelegationArgsServiceDelegation> ServiceDelegation { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("name", Protobuf.ToProtobuf(Name)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("service_delegation", Protobuf.ToProtobuf(ServiceDelegation)));
		} // ToProtobuf

	} // SubnetArgsDelegation

	public sealed class SubnetDelegationServiceDelegation : Pulumi.IIOProtobuf {
		public Pulumi.IO<string[]> Actions { get; set; }
		public Pulumi.IO<string> Name { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("actions", Protobuf.ToProtobuf(Actions, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("name", Protobuf.ToProtobuf(Name)));
		} // ToProtobuf

		public static SubnetDelegationServiceDelegation FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new SubnetDelegationServiceDelegation();
				if (obj.Fields.ContainsKey("actions")) {
					result.Actions = Protobuf.ToList(obj.Fields["actions"], item => Protobuf.ToString(item));
				}
				if (obj.Fields.ContainsKey("name")) {
					result.Name = Protobuf.ToString(obj.Fields["name"]);
				}
			return result;
		} // FromProtobuf

	} // SubnetDelegationServiceDelegation

	public sealed class SubnetDelegation : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Name { get; set; }
		public Pulumi.IO<SubnetDelegationServiceDelegation> ServiceDelegation { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("name", Protobuf.ToProtobuf(Name)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("service_delegation", Protobuf.ToProtobuf(ServiceDelegation)));
		} // ToProtobuf

		public static SubnetDelegation FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new SubnetDelegation();
				if (obj.Fields.ContainsKey("name")) {
					result.Name = Protobuf.ToString(obj.Fields["name"]);
				}
				if (obj.Fields.ContainsKey("service_delegation")) {
					result.ServiceDelegation = SubnetDelegationServiceDelegation.FromProtobuf(obj.Fields["service_delegation"]);
				}
			return result;
		} // FromProtobuf

	} // SubnetDelegation

	/// <summary>
	/// The set of arguments for constructing a Subnet resource.
	/// </summary>
	public struct SubnetArgs {
		/// <summary>
		/// The address prefix to use for the subnet.
		/// </summary>
		public Pulumi.IO<string> AddressPrefix { get; set; }

		/// <summary>
		/// One or more `delegation` blocks as defined below.
		/// </summary>
		public Pulumi.IO<Pulumi.IO<SubnetArgsDelegation>[]> Delegations { get; set; }

		/// <summary>
		/// The collection of IP Configurations with IPs within this subnet.
		/// </summary>
		public Pulumi.IO<Pulumi.IO<string>[]> IpConfigurations { get; set; }

		/// <summary>
		/// The name of the subnet. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The ID of the Network Security Group to associate with the subnet.
		/// </summary>
		public Pulumi.IO<string> NetworkSecurityGroupId { get; set; }

		/// <summary>
		/// The name of the resource group in which to create the subnet. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// The ID of the Route Table to associate with the subnet.
		/// </summary>
		public Pulumi.IO<string> RouteTableId { get; set; }

		/// <summary>
		/// The list of Service endpoints to associate with the subnet. Possible values include: `Microsoft.AzureActiveDirectory`, `Microsoft.AzureCosmosDB`, `Microsoft.EventHub`, `Microsoft.KeyVault`, `Microsoft.ServiceBus`, `Microsoft.Sql` and `Microsoft.Storage`.
		/// </summary>
		public Pulumi.IO<Pulumi.IO<string>[]> ServiceEndpoints { get; set; }

		/// <summary>
		/// The name of the virtual network to which to attach the subnet. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> VirtualNetworkName { get; set; }

	} // SubnetArgs

	/// <summary>
	/// Manages a subnet. Subnets represent network segments within the IP space defined by the virtual network.
	/// 
	/// > **NOTE on Virtual Networks and Subnet's:** Terraform currently
	/// provides both a standalone Subnet resource, and allows for Subnets to be defined in-line within the Virtual Network resource.
	/// At this time you cannot use a Virtual Network with in-line Subnets in conjunction with any Subnet resources. Doing so will cause a conflict of Subnet configurations and will overwrite Subnet's.
	/// </summary>
	public class Subnet : Pulumi.CustomResource {
		/// <summary>
		/// The address prefix to use for the subnet.
		/// </summary>
		public Pulumi.IO<string> AddressPrefix { get; set; }

		/// <summary>
		/// One or more `delegation` blocks as defined below.
		/// </summary>
		public Pulumi.IO<SubnetDelegation[]> Delegations { get; set; }

		/// <summary>
		/// The collection of IP Configurations with IPs within this subnet.
		/// </summary>
		public Pulumi.IO<string[]> IpConfigurations { get; set; }

		/// <summary>
		/// The name of the subnet. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The ID of the Network Security Group to associate with the subnet.
		/// </summary>
		public Pulumi.IO<string> NetworkSecurityGroupId { get; set; }

		/// <summary>
		/// The name of the resource group in which to create the subnet. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// The ID of the Route Table to associate with the subnet.
		/// </summary>
		public Pulumi.IO<string> RouteTableId { get; set; }

		/// <summary>
		/// The list of Service endpoints to associate with the subnet. Possible values include: `Microsoft.AzureActiveDirectory`, `Microsoft.AzureCosmosDB`, `Microsoft.EventHub`, `Microsoft.KeyVault`, `Microsoft.ServiceBus`, `Microsoft.Sql` and `Microsoft.Storage`.
		/// </summary>
		public Pulumi.IO<string[]> ServiceEndpoints { get; set; }

		/// <summary>
		/// The name of the virtual network to which to attach the subnet. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> VirtualNetworkName { get; set; }

		public Subnet(string name, SubnetArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:network/subnet:Subnet", name, SerialiseArgs(args), opts) {
			AddressPrefix = base.Outputs["addressPrefix"].Select(item => Protobuf.ToString(item));
			Delegations = base.Outputs["delegations"].Select(item => Protobuf.ToList(item, item1 => SubnetDelegation.FromProtobuf(item1)));
			IpConfigurations = base.Outputs["ipConfigurations"].Select(item => Protobuf.ToList(item, item1 => Protobuf.ToString(item1)));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			NetworkSecurityGroupId = base.Outputs["networkSecurityGroupId"].Select(item => Protobuf.ToString(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			RouteTableId = base.Outputs["routeTableId"].Select(item => Protobuf.ToString(item));
			ServiceEndpoints = base.Outputs["serviceEndpoints"].Select(item => Protobuf.ToList(item, item1 => Protobuf.ToString(item1)));
			VirtualNetworkName = base.Outputs["virtualNetworkName"].Select(item => Protobuf.ToString(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(SubnetArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["addressPrefix"] = Protobuf.ToProtobuf(args.AddressPrefix);
			props["delegations"] = Protobuf.ToProtobuf(args.Delegations, item => Protobuf.ToProtobuf(item));
			props["ipConfigurations"] = Protobuf.ToProtobuf(args.IpConfigurations, item => Protobuf.ToProtobuf(item));
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["networkSecurityGroupId"] = Protobuf.ToProtobuf(args.NetworkSecurityGroupId);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["routeTableId"] = Protobuf.ToProtobuf(args.RouteTableId);
			props["serviceEndpoints"] = Protobuf.ToProtobuf(args.ServiceEndpoints, item => Protobuf.ToProtobuf(item));
			props["virtualNetworkName"] = Protobuf.ToProtobuf(args.VirtualNetworkName);
			return props;
		} // SerialiseArgs

	} // Subnet
} // Pulumi.Azure.Network