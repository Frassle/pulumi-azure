// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Devtest {

	public sealed class WindowsVirtualMachineArgsGalleryImageReference : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Offer { get; set; }
		public Pulumi.IO<string> Publisher { get; set; }
		public Pulumi.IO<string> Sku { get; set; }
		public Pulumi.IO<string> Version { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("offer", Protobuf.ToProtobuf(Offer)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("publisher", Protobuf.ToProtobuf(Publisher)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("sku", Protobuf.ToProtobuf(Sku)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("version", Protobuf.ToProtobuf(Version)));
		} // ToProtobuf

	} // WindowsVirtualMachineArgsGalleryImageReference

	public sealed class WindowsVirtualMachineArgsInboundNatRule : Pulumi.IIOProtobuf {
		public Pulumi.IO<int> BackendPort { get; set; }
		public Pulumi.IO<int> FrontendPort { get; set; }
		public Pulumi.IO<string> Protocol { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("backend_port", Protobuf.ToProtobuf(BackendPort)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("frontend_port", Protobuf.ToProtobuf(FrontendPort)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("protocol", Protobuf.ToProtobuf(Protocol)));
		} // ToProtobuf

	} // WindowsVirtualMachineArgsInboundNatRule

	public sealed class WindowsVirtualMachineGalleryImageReference : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Offer { get; set; }
		public Pulumi.IO<string> Publisher { get; set; }
		public Pulumi.IO<string> Sku { get; set; }
		public Pulumi.IO<string> Version { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("offer", Protobuf.ToProtobuf(Offer)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("publisher", Protobuf.ToProtobuf(Publisher)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("sku", Protobuf.ToProtobuf(Sku)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("version", Protobuf.ToProtobuf(Version)));
		} // ToProtobuf

		public static WindowsVirtualMachineGalleryImageReference FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new WindowsVirtualMachineGalleryImageReference();
				if (obj.Fields.ContainsKey("offer")) {
					result.Offer = Protobuf.ToString(obj.Fields["offer"]);
				}
				if (obj.Fields.ContainsKey("publisher")) {
					result.Publisher = Protobuf.ToString(obj.Fields["publisher"]);
				}
				if (obj.Fields.ContainsKey("sku")) {
					result.Sku = Protobuf.ToString(obj.Fields["sku"]);
				}
				if (obj.Fields.ContainsKey("version")) {
					result.Version = Protobuf.ToString(obj.Fields["version"]);
				}
			return result;
		} // FromProtobuf

	} // WindowsVirtualMachineGalleryImageReference

	public sealed class WindowsVirtualMachineInboundNatRule : Pulumi.IIOProtobuf {
		public Pulumi.IO<int> BackendPort { get; set; }
		public Pulumi.IO<int> FrontendPort { get; set; }
		public Pulumi.IO<string> Protocol { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("backend_port", Protobuf.ToProtobuf(BackendPort)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("frontend_port", Protobuf.ToProtobuf(FrontendPort)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("protocol", Protobuf.ToProtobuf(Protocol)));
		} // ToProtobuf

		public static WindowsVirtualMachineInboundNatRule FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new WindowsVirtualMachineInboundNatRule();
				if (obj.Fields.ContainsKey("backend_port")) {
					result.BackendPort = Protobuf.ToInt(obj.Fields["backend_port"]);
				}
				if (obj.Fields.ContainsKey("frontend_port")) {
					result.FrontendPort = Protobuf.ToInt(obj.Fields["frontend_port"]);
				}
				if (obj.Fields.ContainsKey("protocol")) {
					result.Protocol = Protobuf.ToString(obj.Fields["protocol"]);
				}
			return result;
		} // FromProtobuf

	} // WindowsVirtualMachineInboundNatRule

	/// <summary>
	/// The set of arguments for constructing a WindowsVirtualMachine resource.
	/// </summary>
	public struct WindowsVirtualMachineArgs {
		/// <summary>
		/// Can this Virtual Machine be claimed by users? Defaults to `true`.
		/// </summary>
		public Pulumi.IO<bool> AllowClaim { get; set; }

		/// <summary>
		/// Should the Virtual Machine be created without a Public IP Address? Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<bool> DisallowPublicIpAddress { get; set; }

		/// <summary>
		/// A `gallery_image_reference` block as defined below.
		/// </summary>
		public Pulumi.IO<WindowsVirtualMachineArgsGalleryImageReference> GalleryImageReference { get; set; }

		/// <summary>
		/// One or more `inbound_nat_rule` blocks as defined below. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<Pulumi.IO<WindowsVirtualMachineArgsInboundNatRule>[]> InboundNatRules { get; set; }

		/// <summary>
		/// Specifies the name of the Dev Test Lab in which the Virtual Machine should be created. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> LabName { get; set; }

		/// <summary>
		/// The name of a Subnet within the Dev Test Virtual Network where this machine should exist. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> LabSubnetName { get; set; }

		/// <summary>
		/// The ID of the Dev Test Virtual Network where this Virtual Machine should be created. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> LabVirtualNetworkId { get; set; }

		/// <summary>
		/// Specifies the supported Azure location where the Dev Test Lab exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// Specifies the name of the Dev Test Machine. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// Any notes about the Virtual Machine.
		/// </summary>
		public Pulumi.IO<string> Notes { get; set; }

		/// <summary>
		/// The Password associated with the `username` used to login to this Virtual Machine. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Password { get; set; }

		/// <summary>
		/// The name of the resource group in which the Dev Test Lab resource exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// The Machine Size to use for this Virtual Machine, such as `Standard_F2`. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Size { get; set; }

		/// <summary>
		/// The type of Storage to use on this Virtual Machine. Possible values are `Standard` and `Premium`.
		/// </summary>
		public Pulumi.IO<string> StorageType { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

		/// <summary>
		/// The Username associated with the local administrator on this Virtual Machine. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Username { get; set; }

	} // WindowsVirtualMachineArgs

	/// <summary>
	/// Manages a Windows Virtual Machine within a Dev Test Lab.
	/// </summary>
	public class WindowsVirtualMachine : Pulumi.CustomResource {
		/// <summary>
		/// Can this Virtual Machine be claimed by users? Defaults to `true`.
		/// </summary>
		public Pulumi.IO<bool> AllowClaim { get; set; }

		/// <summary>
		/// Should the Virtual Machine be created without a Public IP Address? Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<bool> DisallowPublicIpAddress { get; set; }

		/// <summary>
		/// The FQDN of the Virtual Machine.
		/// </summary>
		public Pulumi.IO<string> Fqdn { get; set; }

		/// <summary>
		/// A `gallery_image_reference` block as defined below.
		/// </summary>
		public Pulumi.IO<WindowsVirtualMachineGalleryImageReference> GalleryImageReference { get; set; }

		/// <summary>
		/// One or more `inbound_nat_rule` blocks as defined below. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<WindowsVirtualMachineInboundNatRule[]> InboundNatRules { get; set; }

		/// <summary>
		/// Specifies the name of the Dev Test Lab in which the Virtual Machine should be created. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> LabName { get; set; }

		/// <summary>
		/// The name of a Subnet within the Dev Test Virtual Network where this machine should exist. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> LabSubnetName { get; set; }

		/// <summary>
		/// The ID of the Dev Test Virtual Network where this Virtual Machine should be created. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> LabVirtualNetworkId { get; set; }

		/// <summary>
		/// Specifies the supported Azure location where the Dev Test Lab exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// Specifies the name of the Dev Test Machine. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// Any notes about the Virtual Machine.
		/// </summary>
		public Pulumi.IO<string> Notes { get; set; }

		/// <summary>
		/// The Password associated with the `username` used to login to this Virtual Machine. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Password { get; set; }

		/// <summary>
		/// The name of the resource group in which the Dev Test Lab resource exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// The Machine Size to use for this Virtual Machine, such as `Standard_F2`. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Size { get; set; }

		/// <summary>
		/// The type of Storage to use on this Virtual Machine. Possible values are `Standard` and `Premium`.
		/// </summary>
		public Pulumi.IO<string> StorageType { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

		/// <summary>
		/// The unique immutable identifier of the Virtual Machine.
		/// </summary>
		public Pulumi.IO<string> UniqueIdentifier { get; set; }

		/// <summary>
		/// The Username associated with the local administrator on this Virtual Machine. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Username { get; set; }

		public WindowsVirtualMachine(string name, WindowsVirtualMachineArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:devtest/windowsVirtualMachine:WindowsVirtualMachine", name, SerialiseArgs(args), opts) {
			AllowClaim = base.Outputs["allowClaim"].Select(item => Protobuf.ToBool(item));
			DisallowPublicIpAddress = base.Outputs["disallowPublicIpAddress"].Select(item => Protobuf.ToBool(item));
			Fqdn = base.Outputs["fqdn"].Select(item => Protobuf.ToString(item));
			GalleryImageReference = base.Outputs["galleryImageReference"].Select(item => WindowsVirtualMachineGalleryImageReference.FromProtobuf(item));
			InboundNatRules = base.Outputs["inboundNatRules"].Select(item => Protobuf.ToList(item, item1 => WindowsVirtualMachineInboundNatRule.FromProtobuf(item1)));
			LabName = base.Outputs["labName"].Select(item => Protobuf.ToString(item));
			LabSubnetName = base.Outputs["labSubnetName"].Select(item => Protobuf.ToString(item));
			LabVirtualNetworkId = base.Outputs["labVirtualNetworkId"].Select(item => Protobuf.ToString(item));
			Location = base.Outputs["location"].Select(item => Protobuf.ToString(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			Notes = base.Outputs["notes"].Select(item => Protobuf.ToString(item));
			Password = base.Outputs["password"].Select(item => Protobuf.ToString(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			Size = base.Outputs["size"].Select(item => Protobuf.ToString(item));
			StorageType = base.Outputs["storageType"].Select(item => Protobuf.ToString(item));
			Tags = base.Outputs["tags"].Select(item => Protobuf.ToMap(item));
			UniqueIdentifier = base.Outputs["uniqueIdentifier"].Select(item => Protobuf.ToString(item));
			Username = base.Outputs["username"].Select(item => Protobuf.ToString(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(WindowsVirtualMachineArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["allowClaim"] = Protobuf.ToProtobuf(args.AllowClaim);
			props["disallowPublicIpAddress"] = Protobuf.ToProtobuf(args.DisallowPublicIpAddress);
			props["galleryImageReference"] = Protobuf.ToProtobuf(args.GalleryImageReference);
			props["inboundNatRules"] = Protobuf.ToProtobuf(args.InboundNatRules, item => Protobuf.ToProtobuf(item));
			props["labName"] = Protobuf.ToProtobuf(args.LabName);
			props["labSubnetName"] = Protobuf.ToProtobuf(args.LabSubnetName);
			props["labVirtualNetworkId"] = Protobuf.ToProtobuf(args.LabVirtualNetworkId);
			props["location"] = Protobuf.ToProtobuf(args.Location);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["notes"] = Protobuf.ToProtobuf(args.Notes);
			props["password"] = Protobuf.ToProtobuf(args.Password);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["size"] = Protobuf.ToProtobuf(args.Size);
			props["storageType"] = Protobuf.ToProtobuf(args.StorageType);
			props["tags"] = Protobuf.ToProtobuf(args.Tags);
			props["username"] = Protobuf.ToProtobuf(args.Username);
			props["fqdn"] = null; //out
			props["uniqueIdentifier"] = null; //out
			return props;
		} // SerialiseArgs

	} // WindowsVirtualMachine
} // Pulumi.Azure.Devtest
