// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Appinsights {

	/// <summary>
	/// A collection of arguments for invoking getInsights.
	/// </summary>
	public struct GetInsightsArgs {
		/// <summary>
		/// Specifies the name of the Application Insights component.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Specifies the name of the resource group the Application Insights component is located in.
		/// </summary>
		public string ResourceGroupName { get; set; }

	} // GetInsightsArgs

	/// <summary>
	/// A collection of values returned by getInsights.
	/// </summary>
	public struct GetInsightsResult {
		/// <summary>
		/// The App ID associated with this Application Insights component.
		/// </summary>
		public string AppId { get; set; }

		/// <summary>
		/// The type of the component.
		/// </summary>
		public string ApplicationType { get; set; }

		/// <summary>
		/// The instrumentation key of the Application Insights component.
		/// </summary>
		public string InstrumentationKey { get; set; }

		/// <summary>
		/// The Azure location where the component exists.
		/// </summary>
		public string Location { get; set; }

		/// <summary>
		/// Tags applied to the component.
		/// </summary>
		public System.Collections.Generic.Dictionary<string, string> Tags { get; set; }

		/// <summary>
		/// id is the provider-assigned unique ID for this managed resource.
		/// </summary>
		public string Id { get; set; }

	} // GetInsightsResult

	public static partial class AppinsightsModule {
		/// <summary>
		/// Use this data source to access information about an existing Application Insights component.
		/// </summary>
		public static System.Threading.Tasks.Task<GetInsightsResult> GetInsights(GetInsightsArgs args, Pulumi.InvokeOptions opts = default(Pulumi.InvokeOptions)) {
			var invokeArgs = new Google.Protobuf.WellKnownTypes.Struct();
			invokeArgs.Fields["name"] = Protobuf.ToProtobuf(args.Name);
			invokeArgs.Fields["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);

			var task = Pulumi.Runtime.InvokeAsync("azure:appinsights/getInsights:getInsights", invokeArgs, opts);

			return task.ContinueWith(response => {
				var protobuf = response.Result;
				var result = new GetInsightsResult();
				if (protobuf.Fields.ContainsKey("appId")) {
					result.AppId = Protobuf.ToString(protobuf.Fields["appId"]);
				}
				if (protobuf.Fields.ContainsKey("applicationType")) {
					result.ApplicationType = Protobuf.ToString(protobuf.Fields["applicationType"]);
				}
				if (protobuf.Fields.ContainsKey("instrumentationKey")) {
					result.InstrumentationKey = Protobuf.ToString(protobuf.Fields["instrumentationKey"]);
				}
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
		} // GetInsights

	} // AppinsightsModule
} // Pulumi.Azure.Appinsights