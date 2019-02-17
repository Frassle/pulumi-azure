// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Network {

	/// <summary>
	/// The set of arguments for constructing a ExpressRouteCircuitAuthorization resource.
	/// </summary>
	public struct ExpressRouteCircuitAuthorizationArgs {
		/// <summary>
		/// The name of the Express Route Circuit in which to create the Authorization.
		/// </summary>
		public Pulumi.IO<string> ExpressRouteCircuitName { get; set; }

		/// <summary>
		/// The name of the ExpressRoute circuit. Changing this forces a
		/// new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The name of the resource group in which to
		/// create the ExpressRoute circuit. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

	} // ExpressRouteCircuitAuthorizationArgs

	/// <summary>
	/// Manages an ExpressRoute Circuit Authorization.
	/// </summary>
	public class ExpressRouteCircuitAuthorization : Pulumi.CustomResource {
		/// <summary>
		/// The Authorization Key.
		/// </summary>
		public Pulumi.IO<string> AuthorizationKey { get; set; }

		/// <summary>
		/// The authorization use status.
		/// </summary>
		public Pulumi.IO<string> AuthorizationUseStatus { get; set; }

		/// <summary>
		/// The name of the Express Route Circuit in which to create the Authorization.
		/// </summary>
		public Pulumi.IO<string> ExpressRouteCircuitName { get; set; }

		/// <summary>
		/// The name of the ExpressRoute circuit. Changing this forces a
		/// new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The name of the resource group in which to
		/// create the ExpressRoute circuit. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		public ExpressRouteCircuitAuthorization(string name, ExpressRouteCircuitAuthorizationArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:network/expressRouteCircuitAuthorization:ExpressRouteCircuitAuthorization", name, SerialiseArgs(args), opts) {
			AuthorizationKey = base.Outputs["authorizationKey"].Select(item => Protobuf.ToString(item));
			AuthorizationUseStatus = base.Outputs["authorizationUseStatus"].Select(item => Protobuf.ToString(item));
			ExpressRouteCircuitName = base.Outputs["expressRouteCircuitName"].Select(item => Protobuf.ToString(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(ExpressRouteCircuitAuthorizationArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["expressRouteCircuitName"] = Protobuf.ToProtobuf(args.ExpressRouteCircuitName);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["authorizationKey"] = null; //out
			props["authorizationUseStatus"] = null; //out
			return props;
		} // SerialiseArgs

	} // ExpressRouteCircuitAuthorization
} // Pulumi.Azure.Network