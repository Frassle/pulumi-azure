// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Keyvault {

	/// <summary>
	/// A collection of arguments for invoking getKey.
	/// </summary>
	public struct GetKeyArgs {
		/// <summary>
		/// Specifies the name of the Key Vault Key.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Specifies the URI used to access the Key Vault instance, available on the `azurerm_key_vault` Data Source / Resource.
		/// </summary>
		public string VaultUri { get; set; }

	} // GetKeyArgs

	/// <summary>
	/// A collection of values returned by getKey.
	/// </summary>
	public struct GetKeyResult {
		/// <summary>
		/// The RSA public exponent of this Key Vault Key.
		/// </summary>
		public string E { get; set; }

		/// <summary>
		/// A list of JSON web key operations assigned to this Key Vault Key
		/// </summary>
		public string[] KeyOpts { get; set; }

		/// <summary>
		/// Specifies the Size of this Key Vault Key.
		/// </summary>
		public int KeySize { get; set; }

		/// <summary>
		/// Specifies the Key Type of this Key Vault Key
		/// </summary>
		public string KeyType { get; set; }

		/// <summary>
		/// The RSA modulus of this Key Vault Key.
		/// </summary>
		public string N { get; set; }

		/// <summary>
		/// A mapping of tags assigned to this Key Vault Key.
		/// </summary>
		public System.Collections.Generic.Dictionary<string, string> Tags { get; set; }

		/// <summary>
		/// The current version of the Key Vault Key.
		/// </summary>
		public string Version { get; set; }

		/// <summary>
		/// id is the provider-assigned unique ID for this managed resource.
		/// </summary>
		public string Id { get; set; }

	} // GetKeyResult

	public static partial class KeyvaultModule {
		/// <summary>
		/// Use this data source to access information about an existing Key Vault Key.
		/// 
		/// > **Note:** All arguments including the secret value will be stored in the raw state as plain-text.
		/// [Read more about sensitive data in state](https://www.terraform.io/docs/state/sensitive-data.html).
		/// </summary>
		public static System.Threading.Tasks.Task<GetKeyResult> GetKey(GetKeyArgs args, Pulumi.InvokeOptions opts = default(Pulumi.InvokeOptions)) {
			var invokeArgs = new Google.Protobuf.WellKnownTypes.Struct();
			invokeArgs.Fields["name"] = Protobuf.ToProtobuf(args.Name);
			invokeArgs.Fields["vaultUri"] = Protobuf.ToProtobuf(args.VaultUri);

			var task = Pulumi.Runtime.InvokeAsync("azure:keyvault/getKey:getKey", invokeArgs, opts);

			return task.ContinueWith(response => {
				var protobuf = response.Result;
				var result = new GetKeyResult();
				if (protobuf.Fields.ContainsKey("e")) {
					result.E = Protobuf.ToString(protobuf.Fields["e"]);
				}
				if (protobuf.Fields.ContainsKey("keyOpts")) {
					result.KeyOpts = Protobuf.ToList(protobuf.Fields["keyOpts"], item => Protobuf.ToString(item));
				}
				if (protobuf.Fields.ContainsKey("keySize")) {
					result.KeySize = Protobuf.ToInt(protobuf.Fields["keySize"]);
				}
				if (protobuf.Fields.ContainsKey("keyType")) {
					result.KeyType = Protobuf.ToString(protobuf.Fields["keyType"]);
				}
				if (protobuf.Fields.ContainsKey("n")) {
					result.N = Protobuf.ToString(protobuf.Fields["n"]);
				}
				if (protobuf.Fields.ContainsKey("tags")) {
					result.Tags = Protobuf.ToMap(protobuf.Fields["tags"]);
				}
				if (protobuf.Fields.ContainsKey("version")) {
					result.Version = Protobuf.ToString(protobuf.Fields["version"]);
				}
				if (protobuf.Fields.ContainsKey("id")) {
					result.Id = Protobuf.ToString(protobuf.Fields["id"]);
				}
				return result;
			});
		} // GetKey

	} // KeyvaultModule
} // Pulumi.Azure.Keyvault