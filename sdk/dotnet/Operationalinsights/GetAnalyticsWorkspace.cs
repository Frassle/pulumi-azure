// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Operationalinsights {

	/// <summary>
	/// A collection of arguments for invoking getAnalyticsWorkspace.
	/// </summary>
	public struct GetAnalyticsWorkspaceArgs {
		/// <summary>
		/// Specifies the name of the Log Analytics Workspace.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The name of the resource group in which the Log Analytics workspace is located in.
		/// </summary>
		public string ResourceGroupName { get; set; }

	} // GetAnalyticsWorkspaceArgs

	/// <summary>
	/// A collection of values returned by getAnalyticsWorkspace.
	/// </summary>
	public struct GetAnalyticsWorkspaceResult {
		public string Location { get; set; }

		/// <summary>
		/// The Portal URL for the Log Analytics Workspace.
		/// </summary>
		public string PortalUrl { get; set; }

		/// <summary>
		/// The Primary shared key for the Log Analytics Workspace.
		/// </summary>
		public string PrimarySharedKey { get; set; }

		/// <summary>
		/// The workspace data retention in days.
		/// </summary>
		public int RetentionInDays { get; set; }

		/// <summary>
		/// The Secondary shared key for the Log Analytics Workspace.
		/// </summary>
		public string SecondarySharedKey { get; set; }

		/// <summary>
		/// The Sku of the Log Analytics Workspace.
		/// </summary>
		public string Sku { get; set; }

		/// <summary>
		/// A mapping of tags assigned to the resource.
		/// </summary>
		public System.Collections.Generic.Dictionary<string, string> Tags { get; set; }

		/// <summary>
		/// The Workspace (or Customer) ID for the Log Analytics Workspace.
		/// </summary>
		public string WorkspaceId { get; set; }

		/// <summary>
		/// id is the provider-assigned unique ID for this managed resource.
		/// </summary>
		public string Id { get; set; }

	} // GetAnalyticsWorkspaceResult

	public static partial class OperationalinsightsModule {
		/// <summary>
		/// Use this data source to access information about an existing Log Analytics (formally Operational Insights) Workspace.
		/// </summary>
		public static System.Threading.Tasks.Task<GetAnalyticsWorkspaceResult> GetAnalyticsWorkspace(GetAnalyticsWorkspaceArgs args, Pulumi.InvokeOptions opts = default(Pulumi.InvokeOptions)) {
			var invokeArgs = new Google.Protobuf.WellKnownTypes.Struct();
			invokeArgs.Fields["name"] = Protobuf.ToProtobuf(args.Name);
			invokeArgs.Fields["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);

			var task = Pulumi.Runtime.InvokeAsync("azure:operationalinsights/getAnalyticsWorkspace:getAnalyticsWorkspace", invokeArgs, opts);

			return task.ContinueWith(response => {
				var protobuf = response.Result;
				var result = new GetAnalyticsWorkspaceResult();
				if (protobuf.Fields.ContainsKey("location")) {
					result.Location = Protobuf.ToString(protobuf.Fields["location"]);
				}
				if (protobuf.Fields.ContainsKey("portalUrl")) {
					result.PortalUrl = Protobuf.ToString(protobuf.Fields["portalUrl"]);
				}
				if (protobuf.Fields.ContainsKey("primarySharedKey")) {
					result.PrimarySharedKey = Protobuf.ToString(protobuf.Fields["primarySharedKey"]);
				}
				if (protobuf.Fields.ContainsKey("retentionInDays")) {
					result.RetentionInDays = Protobuf.ToInt(protobuf.Fields["retentionInDays"]);
				}
				if (protobuf.Fields.ContainsKey("secondarySharedKey")) {
					result.SecondarySharedKey = Protobuf.ToString(protobuf.Fields["secondarySharedKey"]);
				}
				if (protobuf.Fields.ContainsKey("sku")) {
					result.Sku = Protobuf.ToString(protobuf.Fields["sku"]);
				}
				if (protobuf.Fields.ContainsKey("tags")) {
					result.Tags = Protobuf.ToMap(protobuf.Fields["tags"]);
				}
				if (protobuf.Fields.ContainsKey("workspaceId")) {
					result.WorkspaceId = Protobuf.ToString(protobuf.Fields["workspaceId"]);
				}
				if (protobuf.Fields.ContainsKey("id")) {
					result.Id = Protobuf.ToString(protobuf.Fields["id"]);
				}
				return result;
			});
		} // GetAnalyticsWorkspace

	} // OperationalinsightsModule
} // Pulumi.Azure.Operationalinsights