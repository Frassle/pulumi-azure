// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Compute {

	/// <summary>
	/// The set of arguments for constructing a AvailabilitySet resource.
	/// </summary>
	public struct AvailabilitySetArgs {
		/// <summary>
		/// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// Specifies whether the availability set is managed or not. Possible values are `true` (to specify aligned) or `false` (to specify classic). Default is `false`.
		/// </summary>
		public Pulumi.IO<bool> Managed { get; set; }

		/// <summary>
		/// Specifies the name of the availability set. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// Specifies the number of fault domains that are used. Defaults to 3.
		/// </summary>
		public Pulumi.IO<int> PlatformFaultDomainCount { get; set; }

		/// <summary>
		/// Specifies the number of update domains that are used. Defaults to 5.
		/// </summary>
		public Pulumi.IO<int> PlatformUpdateDomainCount { get; set; }

		/// <summary>
		/// The name of the resource group in which to create the availability set. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

	} // AvailabilitySetArgs

	/// <summary>
	/// Manages an availability set for virtual machines.
	/// </summary>
	public class AvailabilitySet : Pulumi.CustomResource {
		/// <summary>
		/// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// Specifies whether the availability set is managed or not. Possible values are `true` (to specify aligned) or `false` (to specify classic). Default is `false`.
		/// </summary>
		public Pulumi.IO<bool> Managed { get; set; }

		/// <summary>
		/// Specifies the name of the availability set. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// Specifies the number of fault domains that are used. Defaults to 3.
		/// </summary>
		public Pulumi.IO<int> PlatformFaultDomainCount { get; set; }

		/// <summary>
		/// Specifies the number of update domains that are used. Defaults to 5.
		/// </summary>
		public Pulumi.IO<int> PlatformUpdateDomainCount { get; set; }

		/// <summary>
		/// The name of the resource group in which to create the availability set. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

		public AvailabilitySet(string name, AvailabilitySetArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:compute/availabilitySet:AvailabilitySet", name, SerialiseArgs(args), opts) {
			Location = base.Outputs["location"].Select(item => Protobuf.ToString(item));
			Managed = base.Outputs["managed"].Select(item => Protobuf.ToBool(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			PlatformFaultDomainCount = base.Outputs["platformFaultDomainCount"].Select(item => Protobuf.ToInt(item));
			PlatformUpdateDomainCount = base.Outputs["platformUpdateDomainCount"].Select(item => Protobuf.ToInt(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			Tags = base.Outputs["tags"].Select(item => Protobuf.ToMap(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(AvailabilitySetArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["location"] = Protobuf.ToProtobuf(args.Location);
			props["managed"] = Protobuf.ToProtobuf(args.Managed);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["platformFaultDomainCount"] = Protobuf.ToProtobuf(args.PlatformFaultDomainCount);
			props["platformUpdateDomainCount"] = Protobuf.ToProtobuf(args.PlatformUpdateDomainCount);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["tags"] = Protobuf.ToProtobuf(args.Tags);
			return props;
		} // SerialiseArgs

	} // AvailabilitySet
} // Pulumi.Azure.Compute