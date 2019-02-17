// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Network {

	/// <summary>
	/// The set of arguments for constructing a ApplicationSecurityGroup resource.
	/// </summary>
	public struct ApplicationSecurityGroupArgs {
		/// <summary>
		/// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// Specifies the name of the Application Security Group. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The name of the resource group in which to create the Application Security Group.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

	} // ApplicationSecurityGroupArgs

	/// <summary>
	/// Manage an Application Security Group.
	/// </summary>
	public class ApplicationSecurityGroup : Pulumi.CustomResource {
		/// <summary>
		/// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// Specifies the name of the Application Security Group. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The name of the resource group in which to create the Application Security Group.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

		public ApplicationSecurityGroup(string name, ApplicationSecurityGroupArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:network/applicationSecurityGroup:ApplicationSecurityGroup", name, SerialiseArgs(args), opts) {
			Location = base.Outputs["location"].Select(item => Protobuf.ToString(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			Tags = base.Outputs["tags"].Select(item => Protobuf.ToMap(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(ApplicationSecurityGroupArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["location"] = Protobuf.ToProtobuf(args.Location);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["tags"] = Protobuf.ToProtobuf(args.Tags);
			return props;
		} // SerialiseArgs

	} // ApplicationSecurityGroup
} // Pulumi.Azure.Network