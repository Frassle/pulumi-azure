// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Recoveryservices {

	/// <summary>
	/// The set of arguments for constructing a Vault resource.
	/// </summary>
	public struct VaultArgs {
		/// <summary>
		/// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// Specifies the name of the Recovery Services Vault. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The name of the resource group in which to create the Recovery Services Vault. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// Sets the vault's SKU. Possible values include: `Standard`, `RS0`.
		/// </summary>
		public Pulumi.IO<string> Sku { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

	} // VaultArgs

	/// <summary>
	/// Manage an Recovery Services Vault.
	/// </summary>
	public class Vault : Pulumi.CustomResource {
		/// <summary>
		/// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// Specifies the name of the Recovery Services Vault. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The name of the resource group in which to create the Recovery Services Vault. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// Sets the vault's SKU. Possible values include: `Standard`, `RS0`.
		/// </summary>
		public Pulumi.IO<string> Sku { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

		public Vault(string name, VaultArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:recoveryservices/vault:Vault", name, SerialiseArgs(args), opts) {
			Location = base.Outputs["location"].Select(item => Protobuf.ToString(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			Sku = base.Outputs["sku"].Select(item => Protobuf.ToString(item));
			Tags = base.Outputs["tags"].Select(item => Protobuf.ToMap(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(VaultArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["location"] = Protobuf.ToProtobuf(args.Location);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["sku"] = Protobuf.ToProtobuf(args.Sku);
			props["tags"] = Protobuf.ToProtobuf(args.Tags);
			return props;
		} // SerialiseArgs

	} // Vault
} // Pulumi.Azure.Recoveryservices