// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Compute {

	public sealed class SharedImageVersionArgsTargetRegion : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Name { get; set; }
		public Pulumi.IO<int> RegionalReplicaCount { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("name", Protobuf.ToProtobuf(Name)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("regional_replica_count", Protobuf.ToProtobuf(RegionalReplicaCount)));
		} // ToProtobuf

	} // SharedImageVersionArgsTargetRegion

	public sealed class SharedImageVersionTargetRegion : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Name { get; set; }
		public Pulumi.IO<int> RegionalReplicaCount { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("name", Protobuf.ToProtobuf(Name)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("regional_replica_count", Protobuf.ToProtobuf(RegionalReplicaCount)));
		} // ToProtobuf

		public static SharedImageVersionTargetRegion FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new SharedImageVersionTargetRegion();
				if (obj.Fields.ContainsKey("name")) {
					result.Name = Protobuf.ToString(obj.Fields["name"]);
				}
				if (obj.Fields.ContainsKey("regional_replica_count")) {
					result.RegionalReplicaCount = Protobuf.ToInt(obj.Fields["regional_replica_count"]);
				}
			return result;
		} // FromProtobuf

	} // SharedImageVersionTargetRegion

	/// <summary>
	/// The set of arguments for constructing a SharedImageVersion resource.
	/// </summary>
	public struct SharedImageVersionArgs {
		/// <summary>
		/// Should this Image Version be excluded from the `latest` filter? If set to `true` this Image Version won't be returned for the `latest` version. Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> ExcludeFromLatest { get; set; }

		/// <summary>
		/// The name of the Shared Image Gallery in which the Shared Image exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> GalleryName { get; set; }

		/// <summary>
		/// The name of the Shared Image within the Shared Image Gallery in which this Version should be created. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ImageName { get; set; }

		/// <summary>
		/// The Azure Region in which the Shared Image Gallery exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// The ID of the Managed Image which should be used for this Shared Image Version. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ManagedImageId { get; set; }

		/// <summary>
		/// The version number for this Image Version, such as `1.0.0`. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The name of the Resource Group in which the Shared Image Gallery exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// A collection of tags which should be applied to this resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

		/// <summary>
		/// One or more `target_region` blocks as documented below.
		/// </summary>
		public Pulumi.IO<Pulumi.IO<SharedImageVersionArgsTargetRegion>[]> TargetRegions { get; set; }

	} // SharedImageVersionArgs

	/// <summary>
	/// Manages a Version of a Shared Image within a Shared Image Gallery.
	/// 
	/// -> **NOTE** Shared Image Galleries are currently in Public Preview. You can find more information, including [how to register for the Public Preview here](https://azure.microsoft.com/en-gb/blog/announcing-the-public-preview-of-shared-image-gallery/).
	/// </summary>
	public class SharedImageVersion : Pulumi.CustomResource {
		/// <summary>
		/// Should this Image Version be excluded from the `latest` filter? If set to `true` this Image Version won't be returned for the `latest` version. Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> ExcludeFromLatest { get; set; }

		/// <summary>
		/// The name of the Shared Image Gallery in which the Shared Image exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> GalleryName { get; set; }

		/// <summary>
		/// The name of the Shared Image within the Shared Image Gallery in which this Version should be created. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ImageName { get; set; }

		/// <summary>
		/// The Azure Region in which the Shared Image Gallery exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// The ID of the Managed Image which should be used for this Shared Image Version. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ManagedImageId { get; set; }

		/// <summary>
		/// The version number for this Image Version, such as `1.0.0`. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The name of the Resource Group in which the Shared Image Gallery exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// A collection of tags which should be applied to this resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

		/// <summary>
		/// One or more `target_region` blocks as documented below.
		/// </summary>
		public Pulumi.IO<SharedImageVersionTargetRegion[]> TargetRegions { get; set; }

		public SharedImageVersion(string name, SharedImageVersionArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:compute/sharedImageVersion:SharedImageVersion", name, SerialiseArgs(args), opts) {
			ExcludeFromLatest = base.Outputs["excludeFromLatest"].Select(item => Protobuf.ToBool(item));
			GalleryName = base.Outputs["galleryName"].Select(item => Protobuf.ToString(item));
			ImageName = base.Outputs["imageName"].Select(item => Protobuf.ToString(item));
			Location = base.Outputs["location"].Select(item => Protobuf.ToString(item));
			ManagedImageId = base.Outputs["managedImageId"].Select(item => Protobuf.ToString(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			Tags = base.Outputs["tags"].Select(item => Protobuf.ToMap(item));
			TargetRegions = base.Outputs["targetRegions"].Select(item => Protobuf.ToList(item, item1 => SharedImageVersionTargetRegion.FromProtobuf(item1)));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(SharedImageVersionArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["excludeFromLatest"] = Protobuf.ToProtobuf(args.ExcludeFromLatest);
			props["galleryName"] = Protobuf.ToProtobuf(args.GalleryName);
			props["imageName"] = Protobuf.ToProtobuf(args.ImageName);
			props["location"] = Protobuf.ToProtobuf(args.Location);
			props["managedImageId"] = Protobuf.ToProtobuf(args.ManagedImageId);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["tags"] = Protobuf.ToProtobuf(args.Tags);
			props["targetRegions"] = Protobuf.ToProtobuf(args.TargetRegions, item => Protobuf.ToProtobuf(item));
			return props;
		} // SerialiseArgs

	} // SharedImageVersion
} // Pulumi.Azure.Compute
