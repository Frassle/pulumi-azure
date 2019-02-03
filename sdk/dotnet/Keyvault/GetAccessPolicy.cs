// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Keyvault {

	/// <summary>
	/// A collection of arguments for invoking getAccessPolicy.
	/// </summary>
	public struct GetAccessPolicyArgs {
		/// <summary>
		/// Specifies the name of the Management Template. Possible values are: `Key Management`,
		/// `Secret Management`, `Certificate Management`, `Key & Secret Management`, `Key & Certificate Management`,
		/// `Secret & Certificate Management`,  `Key, Secret, & Certificate Management`
		/// </summary>
		public string Name { get; set; }

	} // GetAccessPolicyArgs

	/// <summary>
	/// A collection of values returned by getAccessPolicy.
	/// </summary>
	public struct GetAccessPolicyResult {
		/// <summary>
		/// the certificate permissions for the access policy
		/// </summary>
		public string[] CertificatePermissions { get; set; }

		/// <summary>
		/// the key permissions for the access policy
		/// </summary>
		public string[] KeyPermissions { get; set; }

		/// <summary>
		/// the secret permissions for the access policy
		/// </summary>
		public string[] SecretPermissions { get; set; }

		/// <summary>
		/// id is the provider-assigned unique ID for this managed resource.
		/// </summary>
		public string Id { get; set; }

	} // GetAccessPolicyResult

	public static partial class KeyvaultModule {
		/// <summary>
		/// Use this data source to access information about the permissions from the Management Key Vault Templates.
		/// </summary>
		public static System.Threading.Tasks.Task<GetAccessPolicyResult> GetAccessPolicy(GetAccessPolicyArgs args, Pulumi.InvokeOptions opts = default(Pulumi.InvokeOptions)) {
			var invokeArgs = new Google.Protobuf.WellKnownTypes.Struct();
			invokeArgs.Fields["name"] = Protobuf.ToProtobuf(args.Name);

			var task = Pulumi.Runtime.InvokeAsync("azure:keyvault/getAccessPolicy:getAccessPolicy", invokeArgs, opts);

			return task.ContinueWith(response => {
				var protobuf = response.Result;
				var result = new GetAccessPolicyResult();
				if (protobuf.Fields.ContainsKey("certificatePermissions")) {
					result.CertificatePermissions = Protobuf.ToList(protobuf.Fields["certificatePermissions"], item => Protobuf.ToString(item));
				}
				if (protobuf.Fields.ContainsKey("keyPermissions")) {
					result.KeyPermissions = Protobuf.ToList(protobuf.Fields["keyPermissions"], item => Protobuf.ToString(item));
				}
				if (protobuf.Fields.ContainsKey("secretPermissions")) {
					result.SecretPermissions = Protobuf.ToList(protobuf.Fields["secretPermissions"], item => Protobuf.ToString(item));
				}
				if (protobuf.Fields.ContainsKey("id")) {
					result.Id = Protobuf.ToString(protobuf.Fields["id"]);
				}
				return result;
			});
		} // GetAccessPolicy

	} // KeyvaultModule
} // Pulumi.Azure.Keyvault
