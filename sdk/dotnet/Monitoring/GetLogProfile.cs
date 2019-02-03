// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Monitoring {

	public sealed class GetLogProfileRetentionPolicy : Pulumi.IProtobuf {
		public int Days { get; set; }
		public bool Enabled { get; set; }

		public Google.Protobuf.WellKnownTypes.Value ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("days", Protobuf.ToProtobuf(Days)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("enabled", Protobuf.ToProtobuf(Enabled)));
		} // ToProtobuf

		public static GetLogProfileRetentionPolicy FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new GetLogProfileRetentionPolicy();
				if (obj.Fields.ContainsKey("days")) {
					result.Days = Protobuf.ToInt(obj.Fields["days"]);
				}
				if (obj.Fields.ContainsKey("enabled")) {
					result.Enabled = Protobuf.ToBool(obj.Fields["enabled"]);
				}
			return result;
		} // FromProtobuf

	} // GetLogProfileRetentionPolicy

	/// <summary>
	/// A collection of arguments for invoking getLogProfile.
	/// </summary>
	public struct GetLogProfileArgs {
		/// <summary>
		/// Specifies the Name of the Log Profile.
		/// </summary>
		public string Name { get; set; }

	} // GetLogProfileArgs

	/// <summary>
	/// A collection of values returned by getLogProfile.
	/// </summary>
	public struct GetLogProfileResult {
		/// <summary>
		/// List of categories of the logs.
		/// </summary>
		public string[] Categories { get; set; }

		/// <summary>
		/// List of regions for which Activity Log events are stored or streamed.
		/// </summary>
		public string[] Locations { get; set; }

		public GetLogProfileRetentionPolicy RetentionPolicy { get; set; }

		/// <summary>
		/// The service bus (or event hub) rule ID of the service bus (or event hub) namespace in which the Activity Log is streamed to.
		/// </summary>
		public string ServicebusRuleId { get; set; }

		/// <summary>
		/// The resource id of the storage account in which the Activity Log is stored.
		/// </summary>
		public string StorageAccountId { get; set; }

		/// <summary>
		/// id is the provider-assigned unique ID for this managed resource.
		/// </summary>
		public string Id { get; set; }

	} // GetLogProfileResult

	public static partial class MonitoringModule {
		/// <summary>
		/// Use this data source to access the properties of a Log Profile.
		/// </summary>
		public static System.Threading.Tasks.Task<GetLogProfileResult> GetLogProfile(GetLogProfileArgs args, Pulumi.InvokeOptions opts = default(Pulumi.InvokeOptions)) {
			var invokeArgs = new Google.Protobuf.WellKnownTypes.Struct();
			invokeArgs.Fields["name"] = Protobuf.ToProtobuf(args.Name);

			var task = Pulumi.Runtime.InvokeAsync("azure:monitoring/getLogProfile:getLogProfile", invokeArgs, opts);

			return task.ContinueWith(response => {
				var protobuf = response.Result;
				var result = new GetLogProfileResult();
				if (protobuf.Fields.ContainsKey("categories")) {
					result.Categories = Protobuf.ToList(protobuf.Fields["categories"], item => Protobuf.ToString(item));
				}
				if (protobuf.Fields.ContainsKey("locations")) {
					result.Locations = Protobuf.ToList(protobuf.Fields["locations"], item => Protobuf.ToString(item));
				}
				if (protobuf.Fields.ContainsKey("retentionPolicy")) {
					result.RetentionPolicy = GetLogProfileRetentionPolicy.FromProtobuf(protobuf.Fields["retentionPolicy"]);
				}
				if (protobuf.Fields.ContainsKey("servicebusRuleId")) {
					result.ServicebusRuleId = Protobuf.ToString(protobuf.Fields["servicebusRuleId"]);
				}
				if (protobuf.Fields.ContainsKey("storageAccountId")) {
					result.StorageAccountId = Protobuf.ToString(protobuf.Fields["storageAccountId"]);
				}
				if (protobuf.Fields.ContainsKey("id")) {
					result.Id = Protobuf.ToString(protobuf.Fields["id"]);
				}
				return result;
			});
		} // GetLogProfile

	} // MonitoringModule
} // Pulumi.Azure.Monitoring
