// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Apimanagement {

	public sealed class GetAPIAdditionalLocation : Pulumi.IProtobuf {
		public string GatewayRegionalUrl { get; set; }
		public string Location { get; set; }
		public string[] PublicIpAddresses { get; set; }

		public Google.Protobuf.WellKnownTypes.Value ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("gateway_regional_url", Protobuf.ToProtobuf(GatewayRegionalUrl)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("location", Protobuf.ToProtobuf(Location)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("public_ip_addresses", Protobuf.ToProtobuf(PublicIpAddresses, item => Protobuf.ToProtobuf(item))));
		} // ToProtobuf

		public static GetAPIAdditionalLocation FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new GetAPIAdditionalLocation();
				if (obj.Fields.ContainsKey("gateway_regional_url")) {
					result.GatewayRegionalUrl = Protobuf.ToString(obj.Fields["gateway_regional_url"]);
				}
				if (obj.Fields.ContainsKey("location")) {
					result.Location = Protobuf.ToString(obj.Fields["location"]);
				}
				if (obj.Fields.ContainsKey("public_ip_addresses")) {
					result.PublicIpAddresses = Protobuf.ToList(obj.Fields["public_ip_addresses"], item => Protobuf.ToString(item));
				}
			return result;
		} // FromProtobuf

	} // GetAPIAdditionalLocation

	public sealed class GetAPIHostnameConfigurationManagement : Pulumi.IProtobuf {
		public string HostName { get; set; }
		public string KeyVaultId { get; set; }
		public bool NegotiateClientCertificate { get; set; }

		public Google.Protobuf.WellKnownTypes.Value ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("host_name", Protobuf.ToProtobuf(HostName)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("key_vault_id", Protobuf.ToProtobuf(KeyVaultId)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("negotiate_client_certificate", Protobuf.ToProtobuf(NegotiateClientCertificate)));
		} // ToProtobuf

		public static GetAPIHostnameConfigurationManagement FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new GetAPIHostnameConfigurationManagement();
				if (obj.Fields.ContainsKey("host_name")) {
					result.HostName = Protobuf.ToString(obj.Fields["host_name"]);
				}
				if (obj.Fields.ContainsKey("key_vault_id")) {
					result.KeyVaultId = Protobuf.ToString(obj.Fields["key_vault_id"]);
				}
				if (obj.Fields.ContainsKey("negotiate_client_certificate")) {
					result.NegotiateClientCertificate = Protobuf.ToBool(obj.Fields["negotiate_client_certificate"]);
				}
			return result;
		} // FromProtobuf

	} // GetAPIHostnameConfigurationManagement

	public sealed class GetAPIHostnameConfigurationPortal : Pulumi.IProtobuf {
		public string HostName { get; set; }
		public string KeyVaultId { get; set; }
		public bool NegotiateClientCertificate { get; set; }

		public Google.Protobuf.WellKnownTypes.Value ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("host_name", Protobuf.ToProtobuf(HostName)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("key_vault_id", Protobuf.ToProtobuf(KeyVaultId)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("negotiate_client_certificate", Protobuf.ToProtobuf(NegotiateClientCertificate)));
		} // ToProtobuf

		public static GetAPIHostnameConfigurationPortal FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new GetAPIHostnameConfigurationPortal();
				if (obj.Fields.ContainsKey("host_name")) {
					result.HostName = Protobuf.ToString(obj.Fields["host_name"]);
				}
				if (obj.Fields.ContainsKey("key_vault_id")) {
					result.KeyVaultId = Protobuf.ToString(obj.Fields["key_vault_id"]);
				}
				if (obj.Fields.ContainsKey("negotiate_client_certificate")) {
					result.NegotiateClientCertificate = Protobuf.ToBool(obj.Fields["negotiate_client_certificate"]);
				}
			return result;
		} // FromProtobuf

	} // GetAPIHostnameConfigurationPortal

	public sealed class GetAPIHostnameConfigurationProxy : Pulumi.IProtobuf {
		public bool DefaultSslBinding { get; set; }
		public string HostName { get; set; }
		public string KeyVaultId { get; set; }
		public bool NegotiateClientCertificate { get; set; }

		public Google.Protobuf.WellKnownTypes.Value ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("default_ssl_binding", Protobuf.ToProtobuf(DefaultSslBinding)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("host_name", Protobuf.ToProtobuf(HostName)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("key_vault_id", Protobuf.ToProtobuf(KeyVaultId)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("negotiate_client_certificate", Protobuf.ToProtobuf(NegotiateClientCertificate)));
		} // ToProtobuf

		public static GetAPIHostnameConfigurationProxy FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new GetAPIHostnameConfigurationProxy();
				if (obj.Fields.ContainsKey("default_ssl_binding")) {
					result.DefaultSslBinding = Protobuf.ToBool(obj.Fields["default_ssl_binding"]);
				}
				if (obj.Fields.ContainsKey("host_name")) {
					result.HostName = Protobuf.ToString(obj.Fields["host_name"]);
				}
				if (obj.Fields.ContainsKey("key_vault_id")) {
					result.KeyVaultId = Protobuf.ToString(obj.Fields["key_vault_id"]);
				}
				if (obj.Fields.ContainsKey("negotiate_client_certificate")) {
					result.NegotiateClientCertificate = Protobuf.ToBool(obj.Fields["negotiate_client_certificate"]);
				}
			return result;
		} // FromProtobuf

	} // GetAPIHostnameConfigurationProxy

	public sealed class GetAPIHostnameConfigurationScm : Pulumi.IProtobuf {
		public string HostName { get; set; }
		public string KeyVaultId { get; set; }
		public bool NegotiateClientCertificate { get; set; }

		public Google.Protobuf.WellKnownTypes.Value ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("host_name", Protobuf.ToProtobuf(HostName)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("key_vault_id", Protobuf.ToProtobuf(KeyVaultId)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("negotiate_client_certificate", Protobuf.ToProtobuf(NegotiateClientCertificate)));
		} // ToProtobuf

		public static GetAPIHostnameConfigurationScm FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new GetAPIHostnameConfigurationScm();
				if (obj.Fields.ContainsKey("host_name")) {
					result.HostName = Protobuf.ToString(obj.Fields["host_name"]);
				}
				if (obj.Fields.ContainsKey("key_vault_id")) {
					result.KeyVaultId = Protobuf.ToString(obj.Fields["key_vault_id"]);
				}
				if (obj.Fields.ContainsKey("negotiate_client_certificate")) {
					result.NegotiateClientCertificate = Protobuf.ToBool(obj.Fields["negotiate_client_certificate"]);
				}
			return result;
		} // FromProtobuf

	} // GetAPIHostnameConfigurationScm

	public sealed class GetAPIHostnameConfiguration : Pulumi.IProtobuf {
		public GetAPIHostnameConfigurationManagement[] Management { get; set; }
		public GetAPIHostnameConfigurationPortal[] Portal { get; set; }
		public GetAPIHostnameConfigurationProxy[] Proxy { get; set; }
		public GetAPIHostnameConfigurationScm[] Scm { get; set; }

		public Google.Protobuf.WellKnownTypes.Value ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("management", Protobuf.ToProtobuf(Management, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("portal", Protobuf.ToProtobuf(Portal, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("proxy", Protobuf.ToProtobuf(Proxy, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("scm", Protobuf.ToProtobuf(Scm, item => Protobuf.ToProtobuf(item))));
		} // ToProtobuf

		public static GetAPIHostnameConfiguration FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new GetAPIHostnameConfiguration();
				if (obj.Fields.ContainsKey("management")) {
					result.Management = Protobuf.ToList(obj.Fields["management"], item => GetAPIHostnameConfigurationManagement.FromProtobuf(item));
				}
				if (obj.Fields.ContainsKey("portal")) {
					result.Portal = Protobuf.ToList(obj.Fields["portal"], item => GetAPIHostnameConfigurationPortal.FromProtobuf(item));
				}
				if (obj.Fields.ContainsKey("proxy")) {
					result.Proxy = Protobuf.ToList(obj.Fields["proxy"], item => GetAPIHostnameConfigurationProxy.FromProtobuf(item));
				}
				if (obj.Fields.ContainsKey("scm")) {
					result.Scm = Protobuf.ToList(obj.Fields["scm"], item => GetAPIHostnameConfigurationScm.FromProtobuf(item));
				}
			return result;
		} // FromProtobuf

	} // GetAPIHostnameConfiguration

	public sealed class GetAPISku : Pulumi.IProtobuf {
		public int Capacity { get; set; }
		public string Name { get; set; }

		public Google.Protobuf.WellKnownTypes.Value ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("capacity", Protobuf.ToProtobuf(Capacity)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("name", Protobuf.ToProtobuf(Name)));
		} // ToProtobuf

		public static GetAPISku FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new GetAPISku();
				if (obj.Fields.ContainsKey("capacity")) {
					result.Capacity = Protobuf.ToInt(obj.Fields["capacity"]);
				}
				if (obj.Fields.ContainsKey("name")) {
					result.Name = Protobuf.ToString(obj.Fields["name"]);
				}
			return result;
		} // FromProtobuf

	} // GetAPISku

	/// <summary>
	/// A collection of arguments for invoking getAPI.
	/// </summary>
	public struct GetAPIArgs {
		/// <summary>
		/// The name of the API Management service.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The Name of the Resource Group in which the API Management Service exists.
		/// </summary>
		public string ResourceGroupName { get; set; }

	} // GetAPIArgs

	/// <summary>
	/// A collection of values returned by getAPI.
	/// </summary>
	public struct GetAPIResult {
		/// <summary>
		/// One or more `additional_location` blocks as defined below
		/// </summary>
		public GetAPIAdditionalLocation[] AdditionalLocations { get; set; }

		/// <summary>
		/// Gateway URL of the API Management service in the Region.
		/// </summary>
		public string GatewayRegionalUrl { get; set; }

		/// <summary>
		/// The URL for the API Management Service's Gateway.
		/// </summary>
		public string GatewayUrl { get; set; }

		/// <summary>
		/// A `hostname_configuration` block as defined below.
		/// </summary>
		public GetAPIHostnameConfiguration[] HostnameConfigurations { get; set; }

		/// <summary>
		/// The location name of the additional region among Azure Data center regions.
		/// </summary>
		public string Location { get; set; }

		/// <summary>
		/// The URL for the Management API.
		/// </summary>
		public string ManagementApiUrl { get; set; }

		/// <summary>
		/// The email address from which the notification will be sent.
		/// </summary>
		public string NotificationSenderEmail { get; set; }

		/// <summary>
		/// The URL of the Publisher Portal.
		/// </summary>
		public string PortalUrl { get; set; }

		/// <summary>
		/// Public Static Load Balanced IP addresses of the API Management service in the additional location. Available only for Basic, Standard and Premium SKU.
		/// </summary>
		public string[] PublicIpAddresses { get; set; }

		/// <summary>
		/// The email of Publisher/Company of the API Management Service.
		/// </summary>
		public string PublisherEmail { get; set; }

		/// <summary>
		/// The name of the Publisher/Company of the API Management Service.
		/// </summary>
		public string PublisherName { get; set; }

		/// <summary>
		/// The SCM (Source Code Management) endpoint.
		/// </summary>
		public string ScmUrl { get; set; }

		/// <summary>
		/// A `sku` block as documented below.
		/// </summary>
		public GetAPISku[] Sku { get; set; }

		/// <summary>
		/// A mapping of tags assigned to the resource.
		/// </summary>
		public System.Collections.Generic.Dictionary<string, string> Tags { get; set; }

		/// <summary>
		/// id is the provider-assigned unique ID for this managed resource.
		/// </summary>
		public string Id { get; set; }

	} // GetAPIResult

	public static partial class ApimanagementModule {
		/// <summary>
		/// Use this data source to access information about an existing API Management Service.
		/// </summary>
		public static System.Threading.Tasks.Task<GetAPIResult> GetAPI(GetAPIArgs args, Pulumi.InvokeOptions opts = default(Pulumi.InvokeOptions)) {
			var invokeArgs = new Google.Protobuf.WellKnownTypes.Struct();
			invokeArgs.Fields["name"] = Protobuf.ToProtobuf(args.Name);
			invokeArgs.Fields["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);

			var task = Pulumi.Runtime.InvokeAsync("azure:apimanagement/getAPI:getAPI", invokeArgs, opts);

			return task.ContinueWith(response => {
				var protobuf = response.Result;
				var result = new GetAPIResult();
				if (protobuf.Fields.ContainsKey("additionalLocations")) {
					result.AdditionalLocations = Protobuf.ToList(protobuf.Fields["additionalLocations"], item => GetAPIAdditionalLocation.FromProtobuf(item));
				}
				if (protobuf.Fields.ContainsKey("gatewayRegionalUrl")) {
					result.GatewayRegionalUrl = Protobuf.ToString(protobuf.Fields["gatewayRegionalUrl"]);
				}
				if (protobuf.Fields.ContainsKey("gatewayUrl")) {
					result.GatewayUrl = Protobuf.ToString(protobuf.Fields["gatewayUrl"]);
				}
				if (protobuf.Fields.ContainsKey("hostnameConfigurations")) {
					result.HostnameConfigurations = Protobuf.ToList(protobuf.Fields["hostnameConfigurations"], item => GetAPIHostnameConfiguration.FromProtobuf(item));
				}
				if (protobuf.Fields.ContainsKey("location")) {
					result.Location = Protobuf.ToString(protobuf.Fields["location"]);
				}
				if (protobuf.Fields.ContainsKey("managementApiUrl")) {
					result.ManagementApiUrl = Protobuf.ToString(protobuf.Fields["managementApiUrl"]);
				}
				if (protobuf.Fields.ContainsKey("notificationSenderEmail")) {
					result.NotificationSenderEmail = Protobuf.ToString(protobuf.Fields["notificationSenderEmail"]);
				}
				if (protobuf.Fields.ContainsKey("portalUrl")) {
					result.PortalUrl = Protobuf.ToString(protobuf.Fields["portalUrl"]);
				}
				if (protobuf.Fields.ContainsKey("publicIpAddresses")) {
					result.PublicIpAddresses = Protobuf.ToList(protobuf.Fields["publicIpAddresses"], item => Protobuf.ToString(item));
				}
				if (protobuf.Fields.ContainsKey("publisherEmail")) {
					result.PublisherEmail = Protobuf.ToString(protobuf.Fields["publisherEmail"]);
				}
				if (protobuf.Fields.ContainsKey("publisherName")) {
					result.PublisherName = Protobuf.ToString(protobuf.Fields["publisherName"]);
				}
				if (protobuf.Fields.ContainsKey("scmUrl")) {
					result.ScmUrl = Protobuf.ToString(protobuf.Fields["scmUrl"]);
				}
				if (protobuf.Fields.ContainsKey("sku")) {
					result.Sku = Protobuf.ToList(protobuf.Fields["sku"], item => GetAPISku.FromProtobuf(item));
				}
				if (protobuf.Fields.ContainsKey("tags")) {
					result.Tags = Protobuf.ToMap(protobuf.Fields["tags"]);
				}
				if (protobuf.Fields.ContainsKey("id")) {
					result.Id = Protobuf.ToString(protobuf.Fields["id"]);
				}
				return result;
			});
		} // GetAPI

	} // ApimanagementModule
} // Pulumi.Azure.Apimanagement