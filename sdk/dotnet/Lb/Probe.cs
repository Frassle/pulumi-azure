// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Lb {

	/// <summary>
	/// The set of arguments for constructing a Probe resource.
	/// </summary>
	public struct ProbeArgs {
		/// <summary>
		/// The interval, in seconds between probes to the backend endpoint for health status. The default value is 15, the minimum value is 5.
		/// </summary>
		public Pulumi.IO<int> IntervalInSeconds { get; set; }

		/// <summary>
		/// The ID of the LoadBalancer in which to create the NAT Rule.
		/// </summary>
		public Pulumi.IO<string> LoadbalancerId { get; set; }

		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// Specifies the name of the Probe.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The number of failed probe attempts after which the backend endpoint is removed from rotation. The default value is 2. NumberOfProbes multiplied by intervalInSeconds value must be greater or equal to 10.Endpoints are returned to rotation when at least one probe is successful.
		/// </summary>
		public Pulumi.IO<int> NumberOfProbes { get; set; }

		/// <summary>
		/// Port on which the Probe queries the backend endpoint. Possible values range from 1 to 65535, inclusive.
		/// </summary>
		public Pulumi.IO<int> Port { get; set; }

		/// <summary>
		/// Specifies the protocol of the end point. Possible values are `Http`, `Https` or `Tcp`. If Tcp is specified, a received ACK is required for the probe to be successful. If Http is specified, a 200 OK response from the specified URI is required for the probe to be successful.
		/// </summary>
		public Pulumi.IO<string> Protocol { get; set; }

		/// <summary>
		/// The URI used for requesting health status from the backend endpoint. Required if protocol is set to Http. Otherwise, it is not allowed.
		/// </summary>
		public Pulumi.IO<string> RequestPath { get; set; }

		/// <summary>
		/// The name of the resource group in which to create the resource.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

	} // ProbeArgs

	/// <summary>
	/// Manages a LoadBalancer Probe Resource.
	/// 
	/// > **NOTE** When using this resource, the Load Balancer needs to have a FrontEnd IP Configuration Attached
	/// </summary>
	public class Probe : Pulumi.CustomResource {
		/// <summary>
		/// The interval, in seconds between probes to the backend endpoint for health status. The default value is 15, the minimum value is 5.
		/// </summary>
		public Pulumi.IO<int> IntervalInSeconds { get; set; }

		public Pulumi.IO<string[]> LoadBalancerRules { get; set; }

		/// <summary>
		/// The ID of the LoadBalancer in which to create the NAT Rule.
		/// </summary>
		public Pulumi.IO<string> LoadbalancerId { get; set; }

		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// Specifies the name of the Probe.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The number of failed probe attempts after which the backend endpoint is removed from rotation. The default value is 2. NumberOfProbes multiplied by intervalInSeconds value must be greater or equal to 10.Endpoints are returned to rotation when at least one probe is successful.
		/// </summary>
		public Pulumi.IO<int> NumberOfProbes { get; set; }

		/// <summary>
		/// Port on which the Probe queries the backend endpoint. Possible values range from 1 to 65535, inclusive.
		/// </summary>
		public Pulumi.IO<int> Port { get; set; }

		/// <summary>
		/// Specifies the protocol of the end point. Possible values are `Http`, `Https` or `Tcp`. If Tcp is specified, a received ACK is required for the probe to be successful. If Http is specified, a 200 OK response from the specified URI is required for the probe to be successful.
		/// </summary>
		public Pulumi.IO<string> Protocol { get; set; }

		/// <summary>
		/// The URI used for requesting health status from the backend endpoint. Required if protocol is set to Http. Otherwise, it is not allowed.
		/// </summary>
		public Pulumi.IO<string> RequestPath { get; set; }

		/// <summary>
		/// The name of the resource group in which to create the resource.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		public Probe(string name, ProbeArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:lb/probe:Probe", name, SerialiseArgs(args), opts) {
			IntervalInSeconds = base.Outputs["intervalInSeconds"].Select(item => Protobuf.ToInt(item));
			LoadBalancerRules = base.Outputs["loadBalancerRules"].Select(item => Protobuf.ToList(item, item1 => Protobuf.ToString(item1)));
			LoadbalancerId = base.Outputs["loadbalancerId"].Select(item => Protobuf.ToString(item));
			Location = base.Outputs["location"].Select(item => Protobuf.ToString(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			NumberOfProbes = base.Outputs["numberOfProbes"].Select(item => Protobuf.ToInt(item));
			Port = base.Outputs["port"].Select(item => Protobuf.ToInt(item));
			Protocol = base.Outputs["protocol"].Select(item => Protobuf.ToString(item));
			RequestPath = base.Outputs["requestPath"].Select(item => Protobuf.ToString(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(ProbeArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["intervalInSeconds"] = Protobuf.ToProtobuf(args.IntervalInSeconds);
			props["loadbalancerId"] = Protobuf.ToProtobuf(args.LoadbalancerId);
			props["location"] = Protobuf.ToProtobuf(args.Location);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["numberOfProbes"] = Protobuf.ToProtobuf(args.NumberOfProbes);
			props["port"] = Protobuf.ToProtobuf(args.Port);
			props["protocol"] = Protobuf.ToProtobuf(args.Protocol);
			props["requestPath"] = Protobuf.ToProtobuf(args.RequestPath);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["loadBalancerRules"] = null; //out
			return props;
		} // SerialiseArgs

	} // Probe
} // Pulumi.Azure.Lb
