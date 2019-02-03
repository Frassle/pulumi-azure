// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Network {

	/// <summary>
	/// A collection of arguments for invoking getApplicationSecurityGroup.
	/// </summary>
	public struct GetApplicationSecurityGroupArgs {
		/// <summary>
		/// The name of the Application Security Group.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The name of the resource group in which the Application Security Group exists.
		/// </summary>
		public string ResourceGroupName { get; set; }

	} // GetApplicationSecurityGroupArgs

	/// <summary>
	/// A collection of values returned by getApplicationSecurityGroup.
	/// </summary>
	public struct GetApplicationSecurityGroupResult {
		/// <summary>
		/// The supported Azure location where the Application Security Group exists.
		/// </summary>
		public string Location { get; set; }

		/// <summary>
		/// A mapping of tags assigned to the resource.
		/// </summary>
		public System.Collections.Generic.Dictionary<string, string> Tags { get; set; }

		/// <summary>
		/// id is the provider-assigned unique ID for this managed resource.
		/// </summary>
		public string Id { get; set; }

	} // GetApplicationSecurityGroupResult

	public static partial class NetworkModule {
		/// <summary>
		/// Use this data source to access information about an existing Application Security Group.
		/// </summary>
		public static System.Threading.Tasks.Task<GetApplicationSecurityGroupResult> GetApplicationSecurityGroup(GetApplicationSecurityGroupArgs args, Pulumi.InvokeOptions opts = default(Pulumi.InvokeOptions)) {
			var invokeArgs = new Google.Protobuf.WellKnownTypes.Struct();
			invokeArgs.Fields["name"] = Protobuf.ToProtobuf(args.Name);
			invokeArgs.Fields["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);

			var task = Pulumi.Runtime.InvokeAsync("azure:network/getApplicationSecurityGroup:getApplicationSecurityGroup", invokeArgs, opts);

			return task.ContinueWith(response => {
				var protobuf = response.Result;
				var result = new GetApplicationSecurityGroupResult();
				if (protobuf.Fields.ContainsKey("location")) {
					result.Location = Protobuf.ToString(protobuf.Fields["location"]);
				}
				if (protobuf.Fields.ContainsKey("tags")) {
					result.Tags = Protobuf.ToMap(protobuf.Fields["tags"]);
				}
				if (protobuf.Fields.ContainsKey("id")) {
					result.Id = Protobuf.ToString(protobuf.Fields["id"]);
				}
				return result;
			});
		} // GetApplicationSecurityGroup

	} // NetworkModule
} // Pulumi.Azure.Network
