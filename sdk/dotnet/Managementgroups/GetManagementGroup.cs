// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Managementgroups {

	/// <summary>
	/// A collection of arguments for invoking getManagementGroup.
	/// </summary>
	public struct GetManagementGroupArgs {
		/// <summary>
		/// Specifies the UUID of this Management Group.
		/// </summary>
		public string GroupId { get; set; }

	} // GetManagementGroupArgs

	/// <summary>
	/// A collection of values returned by getManagementGroup.
	/// </summary>
	public struct GetManagementGroupResult {
		/// <summary>
		/// A friendly name for the Management Group.
		/// </summary>
		public string DisplayName { get; set; }

		/// <summary>
		/// The ID of any Parent Management Group.
		/// </summary>
		public string ParentManagementGroupId { get; set; }

		/// <summary>
		/// A list of Subscription ID's which are assigned to the Management Group.
		/// </summary>
		public string[] SubscriptionIds { get; set; }

		/// <summary>
		/// id is the provider-assigned unique ID for this managed resource.
		/// </summary>
		public string Id { get; set; }

	} // GetManagementGroupResult

	public static partial class ManagementgroupsModule {
		/// <summary>
		/// Use this data source to access information about an existing Management Group.
		/// </summary>
		public static System.Threading.Tasks.Task<GetManagementGroupResult> GetManagementGroup(GetManagementGroupArgs args, Pulumi.InvokeOptions opts = default(Pulumi.InvokeOptions)) {
			var invokeArgs = new Google.Protobuf.WellKnownTypes.Struct();
			invokeArgs.Fields["groupId"] = Protobuf.ToProtobuf(args.GroupId);

			var task = Pulumi.Runtime.InvokeAsync("azure:managementgroups/getManagementGroup:getManagementGroup", invokeArgs, opts);

			return task.ContinueWith(response => {
				var protobuf = response.Result;
				var result = new GetManagementGroupResult();
				if (protobuf.Fields.ContainsKey("displayName")) {
					result.DisplayName = Protobuf.ToString(protobuf.Fields["displayName"]);
				}
				if (protobuf.Fields.ContainsKey("parentManagementGroupId")) {
					result.ParentManagementGroupId = Protobuf.ToString(protobuf.Fields["parentManagementGroupId"]);
				}
				if (protobuf.Fields.ContainsKey("subscriptionIds")) {
					result.SubscriptionIds = Protobuf.ToList(protobuf.Fields["subscriptionIds"], item => Protobuf.ToString(item));
				}
				if (protobuf.Fields.ContainsKey("id")) {
					result.Id = Protobuf.ToString(protobuf.Fields["id"]);
				}
				return result;
			});
		} // GetManagementGroup

	} // ManagementgroupsModule
} // Pulumi.Azure.Managementgroups
