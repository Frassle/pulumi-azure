// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Notificationhub {

	public sealed class GetHubApnsCredential : Pulumi.IProtobuf {
		public string ApplicationMode { get; set; }
		public string BundleId { get; set; }
		public string KeyId { get; set; }
		public string TeamId { get; set; }
		public string Token { get; set; }

		public Google.Protobuf.WellKnownTypes.Value ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("application_mode", Protobuf.ToProtobuf(ApplicationMode)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("bundle_id", Protobuf.ToProtobuf(BundleId)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("key_id", Protobuf.ToProtobuf(KeyId)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("team_id", Protobuf.ToProtobuf(TeamId)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("token", Protobuf.ToProtobuf(Token)));
		} // ToProtobuf

		public static GetHubApnsCredential FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new GetHubApnsCredential();
				if (obj.Fields.ContainsKey("application_mode")) {
					result.ApplicationMode = Protobuf.ToString(obj.Fields["application_mode"]);
				}
				if (obj.Fields.ContainsKey("bundle_id")) {
					result.BundleId = Protobuf.ToString(obj.Fields["bundle_id"]);
				}
				if (obj.Fields.ContainsKey("key_id")) {
					result.KeyId = Protobuf.ToString(obj.Fields["key_id"]);
				}
				if (obj.Fields.ContainsKey("team_id")) {
					result.TeamId = Protobuf.ToString(obj.Fields["team_id"]);
				}
				if (obj.Fields.ContainsKey("token")) {
					result.Token = Protobuf.ToString(obj.Fields["token"]);
				}
			return result;
		} // FromProtobuf

	} // GetHubApnsCredential

	public sealed class GetHubGcmCredential : Pulumi.IProtobuf {
		public string ApiKey { get; set; }

		public Google.Protobuf.WellKnownTypes.Value ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("api_key", Protobuf.ToProtobuf(ApiKey)));
		} // ToProtobuf

		public static GetHubGcmCredential FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new GetHubGcmCredential();
				if (obj.Fields.ContainsKey("api_key")) {
					result.ApiKey = Protobuf.ToString(obj.Fields["api_key"]);
				}
			return result;
		} // FromProtobuf

	} // GetHubGcmCredential

	/// <summary>
	/// A collection of arguments for invoking getHub.
	/// </summary>
	public struct GetHubArgs {
		/// <summary>
		/// Specifies the Name of the Notification Hub.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Specifies the Name of the Notification Hub Namespace which contains the Notification Hub.
		/// </summary>
		public string NamespaceName { get; set; }

		/// <summary>
		/// Specifies the Name of the Resource Group within which the Notification Hub exists.
		/// </summary>
		public string ResourceGroupName { get; set; }

	} // GetHubArgs

	/// <summary>
	/// A collection of values returned by getHub.
	/// </summary>
	public struct GetHubResult {
		/// <summary>
		/// A `apns_credential` block as defined below.
		/// </summary>
		public GetHubApnsCredential[] ApnsCredentials { get; set; }

		/// <summary>
		/// A `gcm_credential` block as defined below.
		/// </summary>
		public GetHubGcmCredential[] GcmCredentials { get; set; }

		/// <summary>
		/// The Azure Region in which this Notification Hub exists.
		/// </summary>
		public string Location { get; set; }

		/// <summary>
		/// id is the provider-assigned unique ID for this managed resource.
		/// </summary>
		public string Id { get; set; }

	} // GetHubResult

	public static partial class NotificationhubModule {
		/// <summary>
		/// Use this data source to access information about an existing Notification Hub within a Notification Hub Namespace.
		/// </summary>
		public static System.Threading.Tasks.Task<GetHubResult> GetHub(GetHubArgs args, Pulumi.InvokeOptions opts = default(Pulumi.InvokeOptions)) {
			var invokeArgs = new Google.Protobuf.WellKnownTypes.Struct();
			invokeArgs.Fields["name"] = Protobuf.ToProtobuf(args.Name);
			invokeArgs.Fields["namespaceName"] = Protobuf.ToProtobuf(args.NamespaceName);
			invokeArgs.Fields["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);

			var task = Pulumi.Runtime.InvokeAsync("azure:notificationhub/getHub:getHub", invokeArgs, opts);

			return task.ContinueWith(response => {
				var protobuf = response.Result;
				var result = new GetHubResult();
				if (protobuf.Fields.ContainsKey("apnsCredentials")) {
					result.ApnsCredentials = Protobuf.ToList(protobuf.Fields["apnsCredentials"], item => GetHubApnsCredential.FromProtobuf(item));
				}
				if (protobuf.Fields.ContainsKey("gcmCredentials")) {
					result.GcmCredentials = Protobuf.ToList(protobuf.Fields["gcmCredentials"], item => GetHubGcmCredential.FromProtobuf(item));
				}
				if (protobuf.Fields.ContainsKey("location")) {
					result.Location = Protobuf.ToString(protobuf.Fields["location"]);
				}
				if (protobuf.Fields.ContainsKey("id")) {
					result.Id = Protobuf.ToString(protobuf.Fields["id"]);
				}
				return result;
			});
		} // GetHub

	} // NotificationhubModule
} // Pulumi.Azure.Notificationhub