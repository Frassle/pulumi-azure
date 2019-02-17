// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Trafficmanager {

	/// <summary>
	/// The set of arguments for constructing a Endpoint resource.
	/// </summary>
	public struct EndpointArgs {
		/// <summary>
		/// Specifies the Azure location of the Endpoint,
		/// this must be specified for Profiles using the `Performance` routing method
		/// if the Endpoint is of either type `nestedEndpoints` or `externalEndpoints`.
		/// For Endpoints of type `azureEndpoints` the value will be taken from the
		/// location of the Azure target resource.
		/// </summary>
		public Pulumi.IO<string> EndpointLocation { get; set; }

		/// <summary>
		/// The status of the Endpoint, can be set to
		/// either `Enabled` or `Disabled`. Defaults to `Enabled`.
		/// </summary>
		public Pulumi.IO<string> EndpointStatus { get; set; }

		/// <summary>
		/// A list of Geographic Regions used to distribute traffic, such as `WORLD`, `UK` or `DE`. The same location can't be specified in two endpoints. [See the Geographic Hierarchies documentation for more information](https://docs.microsoft.com/en-us/rest/api/trafficmanager/geographichierarchies/getdefault).
		/// </summary>
		public Pulumi.IO<Pulumi.IO<string>[]> GeoMappings { get; set; }

		/// <summary>
		/// This argument specifies the minimum number
		/// of endpoints that must be ‘online’ in the child profile in order for the
		/// parent profile to direct traffic to any of the endpoints in that child
		/// profile. This argument only applies to Endpoints of type `nestedEndpoints`
		/// and defaults to `1`.
		/// </summary>
		public Pulumi.IO<int> MinChildEndpoints { get; set; }

		/// <summary>
		/// The name of the Traffic Manager endpoint. Changing this forces a
		/// new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// Specifies the priority of this Endpoint, this must be
		/// specified for Profiles using the `Priority` traffic routing method. Supports
		/// values between 1 and 1000, with no Endpoints sharing the same value. If
		/// omitted the value will be computed in order of creation.
		/// </summary>
		public Pulumi.IO<int> Priority { get; set; }

		/// <summary>
		/// The name of the Traffic Manager Profile to attach
		/// create the Traffic Manager endpoint.
		/// </summary>
		public Pulumi.IO<string> ProfileName { get; set; }

		/// <summary>
		/// The name of the resource group in which to
		/// create the Traffic Manager endpoint.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// The FQDN DNS name of the target. This argument must be
		/// provided for an endpoint of type `externalEndpoints`, for other types it
		/// will be computed.
		/// </summary>
		public Pulumi.IO<string> Target { get; set; }

		/// <summary>
		/// The resource id of an Azure resource to
		/// target. This argument must be provided for an endpoint of type
		/// `azureEndpoints` or `nestedEndpoints`.
		/// </summary>
		public Pulumi.IO<string> TargetResourceId { get; set; }

		/// <summary>
		/// The Endpoint type, must be one of:
		/// - `azureEndpoints`
		/// - `externalEndpoints`
		/// - `nestedEndpoints`
		/// </summary>
		public Pulumi.IO<string> Type { get; set; }

		/// <summary>
		/// Specifies how much traffic should be distributed to this
		/// endpoint, this must be specified for Profiles using the  `Weighted` traffic
		/// routing method. Supports values between 1 and 1000.
		/// </summary>
		public Pulumi.IO<int> Weight { get; set; }

	} // EndpointArgs

	/// <summary>
	/// Manages a Traffic Manager Endpoint.
	/// </summary>
	public class Endpoint : Pulumi.CustomResource {
		/// <summary>
		/// Specifies the Azure location of the Endpoint,
		/// this must be specified for Profiles using the `Performance` routing method
		/// if the Endpoint is of either type `nestedEndpoints` or `externalEndpoints`.
		/// For Endpoints of type `azureEndpoints` the value will be taken from the
		/// location of the Azure target resource.
		/// </summary>
		public Pulumi.IO<string> EndpointLocation { get; set; }

		public Pulumi.IO<string> EndpointMonitorStatus { get; set; }

		/// <summary>
		/// The status of the Endpoint, can be set to
		/// either `Enabled` or `Disabled`. Defaults to `Enabled`.
		/// </summary>
		public Pulumi.IO<string> EndpointStatus { get; set; }

		/// <summary>
		/// A list of Geographic Regions used to distribute traffic, such as `WORLD`, `UK` or `DE`. The same location can't be specified in two endpoints. [See the Geographic Hierarchies documentation for more information](https://docs.microsoft.com/en-us/rest/api/trafficmanager/geographichierarchies/getdefault).
		/// </summary>
		public Pulumi.IO<string[]> GeoMappings { get; set; }

		/// <summary>
		/// This argument specifies the minimum number
		/// of endpoints that must be ‘online’ in the child profile in order for the
		/// parent profile to direct traffic to any of the endpoints in that child
		/// profile. This argument only applies to Endpoints of type `nestedEndpoints`
		/// and defaults to `1`.
		/// </summary>
		public Pulumi.IO<int> MinChildEndpoints { get; set; }

		/// <summary>
		/// The name of the Traffic Manager endpoint. Changing this forces a
		/// new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// Specifies the priority of this Endpoint, this must be
		/// specified for Profiles using the `Priority` traffic routing method. Supports
		/// values between 1 and 1000, with no Endpoints sharing the same value. If
		/// omitted the value will be computed in order of creation.
		/// </summary>
		public Pulumi.IO<int> Priority { get; set; }

		/// <summary>
		/// The name of the Traffic Manager Profile to attach
		/// create the Traffic Manager endpoint.
		/// </summary>
		public Pulumi.IO<string> ProfileName { get; set; }

		/// <summary>
		/// The name of the resource group in which to
		/// create the Traffic Manager endpoint.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// The FQDN DNS name of the target. This argument must be
		/// provided for an endpoint of type `externalEndpoints`, for other types it
		/// will be computed.
		/// </summary>
		public Pulumi.IO<string> Target { get; set; }

		/// <summary>
		/// The resource id of an Azure resource to
		/// target. This argument must be provided for an endpoint of type
		/// `azureEndpoints` or `nestedEndpoints`.
		/// </summary>
		public Pulumi.IO<string> TargetResourceId { get; set; }

		/// <summary>
		/// The Endpoint type, must be one of:
		/// - `azureEndpoints`
		/// - `externalEndpoints`
		/// - `nestedEndpoints`
		/// </summary>
		public Pulumi.IO<string> Type { get; set; }

		/// <summary>
		/// Specifies how much traffic should be distributed to this
		/// endpoint, this must be specified for Profiles using the  `Weighted` traffic
		/// routing method. Supports values between 1 and 1000.
		/// </summary>
		public Pulumi.IO<int> Weight { get; set; }

		public Endpoint(string name, EndpointArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:trafficmanager/endpoint:Endpoint", name, SerialiseArgs(args), opts) {
			EndpointLocation = base.Outputs["endpointLocation"].Select(item => Protobuf.ToString(item));
			EndpointMonitorStatus = base.Outputs["endpointMonitorStatus"].Select(item => Protobuf.ToString(item));
			EndpointStatus = base.Outputs["endpointStatus"].Select(item => Protobuf.ToString(item));
			GeoMappings = base.Outputs["geoMappings"].Select(item => Protobuf.ToList(item, item1 => Protobuf.ToString(item1)));
			MinChildEndpoints = base.Outputs["minChildEndpoints"].Select(item => Protobuf.ToInt(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			Priority = base.Outputs["priority"].Select(item => Protobuf.ToInt(item));
			ProfileName = base.Outputs["profileName"].Select(item => Protobuf.ToString(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			Target = base.Outputs["target"].Select(item => Protobuf.ToString(item));
			TargetResourceId = base.Outputs["targetResourceId"].Select(item => Protobuf.ToString(item));
			Type = base.Outputs["type"].Select(item => Protobuf.ToString(item));
			Weight = base.Outputs["weight"].Select(item => Protobuf.ToInt(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(EndpointArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["endpointLocation"] = Protobuf.ToProtobuf(args.EndpointLocation);
			props["endpointStatus"] = Protobuf.ToProtobuf(args.EndpointStatus);
			props["geoMappings"] = Protobuf.ToProtobuf(args.GeoMappings, item => Protobuf.ToProtobuf(item));
			props["minChildEndpoints"] = Protobuf.ToProtobuf(args.MinChildEndpoints);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["priority"] = Protobuf.ToProtobuf(args.Priority);
			props["profileName"] = Protobuf.ToProtobuf(args.ProfileName);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["target"] = Protobuf.ToProtobuf(args.Target);
			props["targetResourceId"] = Protobuf.ToProtobuf(args.TargetResourceId);
			props["type"] = Protobuf.ToProtobuf(args.Type);
			props["weight"] = Protobuf.ToProtobuf(args.Weight);
			props["endpointMonitorStatus"] = null; //out
			return props;
		} // SerialiseArgs

	} // Endpoint
} // Pulumi.Azure.Trafficmanager