// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Compute {

	public sealed class GetSharedImageVersionTargetRegion : Pulumi.IProtobuf {
		public string Name { get; set; }
		public int RegionalReplicaCount { get; set; }

		public Google.Protobuf.WellKnownTypes.Value ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("name", Protobuf.ToProtobuf(Name)),
				new KeyValuePair<string, Google.Protobuf.WellKnownTypes.Value>("regional_replica_count", Protobuf.ToProtobuf(RegionalReplicaCount)));
		} // ToProtobuf

		public static GetSharedImageVersionTargetRegion FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new GetSharedImageVersionTargetRegion();
				if (obj.Fields.ContainsKey("name")) {
					result.Name = Protobuf.ToString(obj.Fields["name"]);
				}
				if (obj.Fields.ContainsKey("regional_replica_count")) {
					result.RegionalReplicaCount = Protobuf.ToInt(obj.Fields["regional_replica_count"]);
				}
			return result;
		} // FromProtobuf

	} // GetSharedImageVersionTargetRegion

	/// <summary>
	/// A collection of arguments for invoking getSharedImageVersion.
	/// </summary>
	public struct GetSharedImageVersionArgs {
		/// <summary>
		/// The name of the Shared Image in which the Shared Image exists.
		/// </summary>
		public string GalleryName { get; set; }

		/// <summary>
		/// The name of the Shared Image in which this Version exists.
		/// </summary>
		public string ImageName { get; set; }

		/// <summary>
		/// The name of the Image Version.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The name of the Resource Group in which the Shared Image Gallery exists.
		/// </summary>
		public string ResourceGroupName { get; set; }

	} // GetSharedImageVersionArgs

	/// <summary>
	/// A collection of values returned by getSharedImageVersion.
	/// </summary>
	public struct GetSharedImageVersionResult {
		/// <summary>
		/// Is this Image Version excluded from the `latest` filter?
		/// </summary>
		public bool ExcludeFromLatest { get; set; }

		/// <summary>
		/// The supported Azure location where the Shared Image Gallery exists.
		/// </summary>
		public string Location { get; set; }

		/// <summary>
		/// The ID of the Managed Image which was the source of this Shared Image Version.
		/// </summary>
		public string ManagedImageId { get; set; }

		/// <summary>
		/// A mapping of tags assigned to the Shared Image.
		/// </summary>
		public System.Collections.Generic.Dictionary<string, string> Tags { get; set; }

		/// <summary>
		/// One or more `target_region` blocks as documented below.
		/// </summary>
		public GetSharedImageVersionTargetRegion[] TargetRegions { get; set; }

		/// <summary>
		/// id is the provider-assigned unique ID for this managed resource.
		/// </summary>
		public string Id { get; set; }

	} // GetSharedImageVersionResult

	public static partial class ComputeModule {
		/// <summary>
		/// Use this data source to access information about an existing Version of a Shared Image within a Shared Image Gallery.
		/// 
		/// -> **NOTE** Shared Image Galleries are currently in Public Preview. You can find more information, including [how to register for the Public Preview here](https://azure.microsoft.com/en-gb/blog/announcing-the-public-preview-of-shared-image-gallery/).
		/// </summary>
		public static System.Threading.Tasks.Task<GetSharedImageVersionResult> GetSharedImageVersion(GetSharedImageVersionArgs args, Pulumi.InvokeOptions opts = default(Pulumi.InvokeOptions)) {
			var invokeArgs = new Google.Protobuf.WellKnownTypes.Struct();
			invokeArgs.Fields["galleryName"] = Protobuf.ToProtobuf(args.GalleryName);
			invokeArgs.Fields["imageName"] = Protobuf.ToProtobuf(args.ImageName);
			invokeArgs.Fields["name"] = Protobuf.ToProtobuf(args.Name);
			invokeArgs.Fields["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);

			var task = Pulumi.Runtime.InvokeAsync("azure:compute/getSharedImageVersion:getSharedImageVersion", invokeArgs, opts);

			return task.ContinueWith(response => {
				var protobuf = response.Result;
				var result = new GetSharedImageVersionResult();
				if (protobuf.Fields.ContainsKey("excludeFromLatest")) {
					result.ExcludeFromLatest = Protobuf.ToBool(protobuf.Fields["excludeFromLatest"]);
				}
				if (protobuf.Fields.ContainsKey("location")) {
					result.Location = Protobuf.ToString(protobuf.Fields["location"]);
				}
				if (protobuf.Fields.ContainsKey("managedImageId")) {
					result.ManagedImageId = Protobuf.ToString(protobuf.Fields["managedImageId"]);
				}
				if (protobuf.Fields.ContainsKey("tags")) {
					result.Tags = Protobuf.ToMap(protobuf.Fields["tags"]);
				}
				if (protobuf.Fields.ContainsKey("targetRegions")) {
					result.TargetRegions = Protobuf.ToList(protobuf.Fields["targetRegions"], item => GetSharedImageVersionTargetRegion.FromProtobuf(item));
				}
				if (protobuf.Fields.ContainsKey("id")) {
					result.Id = Protobuf.ToString(protobuf.Fields["id"]);
				}
				return result;
			});
		} // GetSharedImageVersion

	} // ComputeModule
} // Pulumi.Azure.Compute