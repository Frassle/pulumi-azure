// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Monitoring {

	/// <summary>
	/// A collection of arguments for invoking getDiagnosticCategories.
	/// </summary>
	public struct GetDiagnosticCategoriesArgs {
		/// <summary>
		/// The ID of an existing Resource which Monitor Diagnostics Categories should be retrieved for.
		/// </summary>
		public string ResourceId { get; set; }

	} // GetDiagnosticCategoriesArgs

	/// <summary>
	/// A collection of values returned by getDiagnosticCategories.
	/// </summary>
	public struct GetDiagnosticCategoriesResult {
		/// <summary>
		/// A list of the Log Categories supported for this Resource.
		/// </summary>
		public string[] Logs { get; set; }

		/// <summary>
		/// A list of the Metric Categories supported for this Resource.
		/// </summary>
		public string[] Metrics { get; set; }

		/// <summary>
		/// id is the provider-assigned unique ID for this managed resource.
		/// </summary>
		public string Id { get; set; }

	} // GetDiagnosticCategoriesResult

	public static partial class MonitoringModule {
		/// <summary>
		/// Use this data source to access information about the Monitor Diagnostics Categories supported by an existing Resource.
		/// </summary>
		public static System.Threading.Tasks.Task<GetDiagnosticCategoriesResult> GetDiagnosticCategories(GetDiagnosticCategoriesArgs args, Pulumi.InvokeOptions opts = default(Pulumi.InvokeOptions)) {
			var invokeArgs = new Google.Protobuf.WellKnownTypes.Struct();
			invokeArgs.Fields["resourceId"] = Protobuf.ToProtobuf(args.ResourceId);

			var task = Pulumi.Runtime.InvokeAsync("azure:monitoring/getDiagnosticCategories:getDiagnosticCategories", invokeArgs, opts);

			return task.ContinueWith(response => {
				var protobuf = response.Result;
				var result = new GetDiagnosticCategoriesResult();
				if (protobuf.Fields.ContainsKey("logs")) {
					result.Logs = Protobuf.ToList(protobuf.Fields["logs"], item => Protobuf.ToString(item));
				}
				if (protobuf.Fields.ContainsKey("metrics")) {
					result.Metrics = Protobuf.ToList(protobuf.Fields["metrics"], item => Protobuf.ToString(item));
				}
				if (protobuf.Fields.ContainsKey("id")) {
					result.Id = Protobuf.ToString(protobuf.Fields["id"]);
				}
				return result;
			});
		} // GetDiagnosticCategories

	} // MonitoringModule
} // Pulumi.Azure.Monitoring