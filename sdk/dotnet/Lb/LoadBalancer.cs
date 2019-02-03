// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Lb {

	public sealed class LoadBalancerArgsFrontendIpConfiguration : Pulumi.IIOProtobuf {
		public Pulumi.IO<Pulumi.IO<string>[]> InboundNatRules { get; set; }
		public Pulumi.IO<Pulumi.IO<string>[]> LoadBalancerRules { get; set; }
		public Pulumi.IO<string> Name { get; set; }
		public Pulumi.IO<string> PrivateIpAddress { get; set; }
		public Pulumi.IO<string> PrivateIpAddressAllocation { get; set; }
		public Pulumi.IO<string> PublicIpAddressId { get; set; }
		public Pulumi.IO<string> SubnetId { get; set; }
		public Pulumi.IO<string> Zones { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("inbound_nat_rules", Protobuf.ToProtobuf(InboundNatRules, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("load_balancer_rules", Protobuf.ToProtobuf(LoadBalancerRules, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("name", Protobuf.ToProtobuf(Name)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("private_ip_address", Protobuf.ToProtobuf(PrivateIpAddress)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("private_ip_address_allocation", Protobuf.ToProtobuf(PrivateIpAddressAllocation)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("public_ip_address_id", Protobuf.ToProtobuf(PublicIpAddressId)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("subnet_id", Protobuf.ToProtobuf(SubnetId)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("zones", Protobuf.ToProtobuf(Zones)));
		} // ToProtobuf

	} // LoadBalancerArgsFrontendIpConfiguration

	public sealed class LoadBalancerFrontendIpConfiguration : Pulumi.IIOProtobuf {
		public Pulumi.IO<string[]> InboundNatRules { get; set; }
		public Pulumi.IO<string[]> LoadBalancerRules { get; set; }
		public Pulumi.IO<string> Name { get; set; }
		public Pulumi.IO<string> PrivateIpAddress { get; set; }
		public Pulumi.IO<string> PrivateIpAddressAllocation { get; set; }
		public Pulumi.IO<string> PublicIpAddressId { get; set; }
		public Pulumi.IO<string> SubnetId { get; set; }
		public Pulumi.IO<string> Zones { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("inbound_nat_rules", Protobuf.ToProtobuf(InboundNatRules, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("load_balancer_rules", Protobuf.ToProtobuf(LoadBalancerRules, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("name", Protobuf.ToProtobuf(Name)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("private_ip_address", Protobuf.ToProtobuf(PrivateIpAddress)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("private_ip_address_allocation", Protobuf.ToProtobuf(PrivateIpAddressAllocation)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("public_ip_address_id", Protobuf.ToProtobuf(PublicIpAddressId)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("subnet_id", Protobuf.ToProtobuf(SubnetId)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("zones", Protobuf.ToProtobuf(Zones)));
		} // ToProtobuf

		public static LoadBalancerFrontendIpConfiguration FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new LoadBalancerFrontendIpConfiguration();
				if (obj.Fields.ContainsKey("inbound_nat_rules")) {
					result.InboundNatRules = Protobuf.ToList(obj.Fields["inbound_nat_rules"], item => Protobuf.ToString(item));
				}
				if (obj.Fields.ContainsKey("load_balancer_rules")) {
					result.LoadBalancerRules = Protobuf.ToList(obj.Fields["load_balancer_rules"], item => Protobuf.ToString(item));
				}
				if (obj.Fields.ContainsKey("name")) {
					result.Name = Protobuf.ToString(obj.Fields["name"]);
				}
				if (obj.Fields.ContainsKey("private_ip_address")) {
					result.PrivateIpAddress = Protobuf.ToString(obj.Fields["private_ip_address"]);
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
				if (obj.Fields.ContainsKey("zones")) {
					result.Zones = Protobuf.ToString(obj.Fields["zones"]);
				}
			return result;
		} // FromProtobuf

	} // LoadBalancerFrontendIpConfiguration

	/// <summary>
	/// The set of arguments for constructing a LoadBalancer resource.
	/// </summary>
	public struct LoadBalancerArgs {
		/// <summary>
		/// A `frontend_ip_configuration` block as documented below.
		/// </summary>
		public Pulumi.IO<Pulumi.IO<LoadBalancerArgsFrontendIpConfiguration>[]> FrontendIpConfigurations { get; set; }

		/// <summary>
		/// Specifies the supported Azure Region where the Load Balancer should be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// Specifies the name of the frontend ip configuration.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The name of the Resource Group in which to create the Load Balancer.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// The SKU of the Azure Load Balancer. Accepted values are `Basic` and `Standard`. Defaults to `Basic`.
		/// </summary>
		public Pulumi.IO<string> Sku { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

	} // LoadBalancerArgs

	/// <summary>
	/// Manage a Load Balancer Resource.
	/// </summary>
	public class LoadBalancer : Pulumi.CustomResource {
		/// <summary>
		/// A `frontend_ip_configuration` block as documented below.
		/// </summary>
		public Pulumi.IO<LoadBalancerFrontendIpConfiguration[]> FrontendIpConfigurations { get; set; }

		/// <summary>
		/// Specifies the supported Azure Region where the Load Balancer should be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// Specifies the name of the frontend ip configuration.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// Private IP Address to assign to the Load Balancer. The last one and first four IPs in any range are reserved and cannot be manually assigned.
		/// </summary>
		public Pulumi.IO<string> PrivateIpAddress { get; set; }

		/// <summary>
		/// The list of private IP address assigned to the load balancer in `frontend_ip_configuration` blocks, if any.
		/// </summary>
		public Pulumi.IO<string[]> PrivateIpAddresses { get; set; }

		/// <summary>
		/// The name of the Resource Group in which to create the Load Balancer.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// The SKU of the Azure Load Balancer. Accepted values are `Basic` and `Standard`. Defaults to `Basic`.
		/// </summary>
		public Pulumi.IO<string> Sku { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

		public LoadBalancer(string name, LoadBalancerArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:lb/loadBalancer:LoadBalancer", name, SerialiseArgs(args), opts) {
			FrontendIpConfigurations = base.Outputs["frontendIpConfigurations"].Select(item => Protobuf.ToList(item, item1 => LoadBalancerFrontendIpConfiguration.FromProtobuf(item1)));
			Location = base.Outputs["location"].Select(item => Protobuf.ToString(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			PrivateIpAddress = base.Outputs["privateIpAddress"].Select(item => Protobuf.ToString(item));
			PrivateIpAddresses = base.Outputs["privateIpAddresses"].Select(item => Protobuf.ToList(item, item1 => Protobuf.ToString(item1)));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			Sku = base.Outputs["sku"].Select(item => Protobuf.ToString(item));
			Tags = base.Outputs["tags"].Select(item => Protobuf.ToMap(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(LoadBalancerArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["frontendIpConfigurations"] = Protobuf.ToProtobuf(args.FrontendIpConfigurations, item => Protobuf.ToProtobuf(item));
			props["location"] = Protobuf.ToProtobuf(args.Location);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["sku"] = Protobuf.ToProtobuf(args.Sku);
			props["tags"] = Protobuf.ToProtobuf(args.Tags);
			props["privateIpAddress"] = null; //out
			props["privateIpAddresses"] = null; //out
			return props;
		} // SerialiseArgs

	} // LoadBalancer
} // Pulumi.Azure.Lb
