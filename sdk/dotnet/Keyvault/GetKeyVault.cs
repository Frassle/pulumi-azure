// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Keyvault {

	public sealed class GetKeyVaultAccessPolicy : Pulumi.IProtobuf {
		public string ApplicationId { get; set; }
		public string[] CertificatePermissions { get; set; }
		public string[] KeyPermissions { get; set; }
		public string ObjectId { get; set; }
		public string[] SecretPermissions { get; set; }
		public string TenantId { get; set; }

		public Google.Protobuf.WellKnownTypes.Value ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("application_id", Protobuf.ToProtobuf(ApplicationId)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("certificate_permissions", Protobuf.ToProtobuf(CertificatePermissions, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("key_permissions", Protobuf.ToProtobuf(KeyPermissions, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("object_id", Protobuf.ToProtobuf(ObjectId)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("secret_permissions", Protobuf.ToProtobuf(SecretPermissions, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("tenant_id", Protobuf.ToProtobuf(TenantId)));
		} // ToProtobuf

		public static GetKeyVaultAccessPolicy FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new GetKeyVaultAccessPolicy();
				if (obj.Fields.ContainsKey("application_id")) {
					result.ApplicationId = Protobuf.ToString(obj.Fields["application_id"]);
				}
				if (obj.Fields.ContainsKey("certificate_permissions")) {
					result.CertificatePermissions = Protobuf.ToList(obj.Fields["certificate_permissions"], item => Protobuf.ToString(item));
				}
				if (obj.Fields.ContainsKey("key_permissions")) {
					result.KeyPermissions = Protobuf.ToList(obj.Fields["key_permissions"], item => Protobuf.ToString(item));
				}
				if (obj.Fields.ContainsKey("object_id")) {
					result.ObjectId = Protobuf.ToString(obj.Fields["object_id"]);
				}
				if (obj.Fields.ContainsKey("secret_permissions")) {
					result.SecretPermissions = Protobuf.ToList(obj.Fields["secret_permissions"], item => Protobuf.ToString(item));
				}
				if (obj.Fields.ContainsKey("tenant_id")) {
					result.TenantId = Protobuf.ToString(obj.Fields["tenant_id"]);
				}
			return result;
		} // FromProtobuf

	} // GetKeyVaultAccessPolicy

	public sealed class GetKeyVaultNetworkAcl : Pulumi.IProtobuf {
		public string Bypass { get; set; }
		public string DefaultAction { get; set; }
		public string[] IpRules { get; set; }
		public string[] VirtualNetworkSubnetIds { get; set; }

		public Google.Protobuf.WellKnownTypes.Value ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("bypass", Protobuf.ToProtobuf(Bypass)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("default_action", Protobuf.ToProtobuf(DefaultAction)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("ip_rules", Protobuf.ToProtobuf(IpRules, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("virtual_network_subnet_ids", Protobuf.ToProtobuf(VirtualNetworkSubnetIds, item => Protobuf.ToProtobuf(item))));
		} // ToProtobuf

		public static GetKeyVaultNetworkAcl FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new GetKeyVaultNetworkAcl();
				if (obj.Fields.ContainsKey("bypass")) {
					result.Bypass = Protobuf.ToString(obj.Fields["bypass"]);
				}
				if (obj.Fields.ContainsKey("default_action")) {
					result.DefaultAction = Protobuf.ToString(obj.Fields["default_action"]);
				}
				if (obj.Fields.ContainsKey("ip_rules")) {
					result.IpRules = Protobuf.ToList(obj.Fields["ip_rules"], item => Protobuf.ToString(item));
				}
				if (obj.Fields.ContainsKey("virtual_network_subnet_ids")) {
					result.VirtualNetworkSubnetIds = Protobuf.ToList(obj.Fields["virtual_network_subnet_ids"], item => Protobuf.ToString(item));
				}
			return result;
		} // FromProtobuf

	} // GetKeyVaultNetworkAcl

	public sealed class GetKeyVaultSku : Pulumi.IProtobuf {
		public string Name { get; set; }

		public Google.Protobuf.WellKnownTypes.Value ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("name", Protobuf.ToProtobuf(Name)));
		} // ToProtobuf

		public static GetKeyVaultSku FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new GetKeyVaultSku();
				if (obj.Fields.ContainsKey("name")) {
					result.Name = Protobuf.ToString(obj.Fields["name"]);
				}
			return result;
		} // FromProtobuf

	} // GetKeyVaultSku

	/// <summary>
	/// A collection of arguments for invoking getKeyVault.
	/// </summary>
	public struct GetKeyVaultArgs {
		/// <summary>
		/// Specifies the name of the Key Vault.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The name of the Resource Group in which the Key Vault exists.
		/// </summary>
		public string ResourceGroupName { get; set; }

	} // GetKeyVaultArgs

	/// <summary>
	/// A collection of values returned by getKeyVault.
	/// </summary>
	public struct GetKeyVaultResult {
		/// <summary>
		/// One or more `access_policy` blocks as defined below.
		/// </summary>
		public GetKeyVaultAccessPolicy[] AccessPolicies { get; set; }

		/// <summary>
		/// Can Azure Virtual Machines retrieve certificates stored as secrets from the Key Vault?
		/// </summary>
		public bool EnabledForDeployment { get; set; }

		/// <summary>
		/// Can Azure Disk Encryption retrieve secrets from the Key Vault?
		/// </summary>
		public bool EnabledForDiskEncryption { get; set; }

		/// <summary>
		/// Can Azure Resource Manager retrieve secrets from the Key Vault?
		/// </summary>
		public bool EnabledForTemplateDeployment { get; set; }

		/// <summary>
		/// The Azure Region in which the Key Vault exists.
		/// </summary>
		public string Location { get; set; }

		public GetKeyVaultNetworkAcl[] NetworkAcls { get; set; }

		/// <summary>
		/// A `sku` block as described below.
		/// </summary>
		public GetKeyVaultSku[] Sku { get; set; }

		/// <summary>
		/// A mapping of tags assigned to the Key Vault.
		/// </summary>
		public System.Collections.Generic.Dictionary<string, string> Tags { get; set; }

		/// <summary>
		/// The Azure Active Directory Tenant ID used to authenticate requests for this Key Vault.
		/// </summary>
		public string TenantId { get; set; }

		/// <summary>
		/// The URI of the vault for performing operations on keys and secrets.
		/// </summary>
		public string VaultUri { get; set; }

		/// <summary>
		/// id is the provider-assigned unique ID for this managed resource.
		/// </summary>
		public string Id { get; set; }

	} // GetKeyVaultResult

	public static partial class KeyvaultModule {
		/// <summary>
		/// Use this data source to access information about an existing Key Vault.
		/// </summary>
		public static System.Threading.Tasks.Task<GetKeyVaultResult> GetKeyVault(GetKeyVaultArgs args, Pulumi.InvokeOptions opts = default(Pulumi.InvokeOptions)) {
			var invokeArgs = new Google.Protobuf.WellKnownTypes.Struct();
			invokeArgs.Fields["name"] = Protobuf.ToProtobuf(args.Name);
			invokeArgs.Fields["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);

			var task = Pulumi.Runtime.InvokeAsync("azure:keyvault/getKeyVault:getKeyVault", invokeArgs, opts);

			return task.ContinueWith(response => {
				var protobuf = response.Result;
				var result = new GetKeyVaultResult();
				if (protobuf.Fields.ContainsKey("accessPolicies")) {
					result.AccessPolicies = Protobuf.ToList(protobuf.Fields["accessPolicies"], item => GetKeyVaultAccessPolicy.FromProtobuf(item));
				}
				if (protobuf.Fields.ContainsKey("enabledForDeployment")) {
					result.EnabledForDeployment = Protobuf.ToBool(protobuf.Fields["enabledForDeployment"]);
				}
				if (protobuf.Fields.ContainsKey("enabledForDiskEncryption")) {
					result.EnabledForDiskEncryption = Protobuf.ToBool(protobuf.Fields["enabledForDiskEncryption"]);
				}
				if (protobuf.Fields.ContainsKey("enabledForTemplateDeployment")) {
					result.EnabledForTemplateDeployment = Protobuf.ToBool(protobuf.Fields["enabledForTemplateDeployment"]);
				}
				if (protobuf.Fields.ContainsKey("location")) {
					result.Location = Protobuf.ToString(protobuf.Fields["location"]);
				}
				if (protobuf.Fields.ContainsKey("networkAcls")) {
					result.NetworkAcls = Protobuf.ToList(protobuf.Fields["networkAcls"], item => GetKeyVaultNetworkAcl.FromProtobuf(item));
				}
				if (protobuf.Fields.ContainsKey("sku")) {
					result.Sku = Protobuf.ToList(protobuf.Fields["sku"], item => GetKeyVaultSku.FromProtobuf(item));
				}
				if (protobuf.Fields.ContainsKey("tags")) {
					result.Tags = Protobuf.ToMap(protobuf.Fields["tags"]);
				}
				if (protobuf.Fields.ContainsKey("tenantId")) {
					result.TenantId = Protobuf.ToString(protobuf.Fields["tenantId"]);
				}
				if (protobuf.Fields.ContainsKey("vaultUri")) {
					result.VaultUri = Protobuf.ToString(protobuf.Fields["vaultUri"]);
				}
				if (protobuf.Fields.ContainsKey("id")) {
					result.Id = Protobuf.ToString(protobuf.Fields["id"]);
				}
				return result;
			});
		} // GetKeyVault

	} // KeyvaultModule
} // Pulumi.Azure.Keyvault
