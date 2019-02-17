// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Compute {

	/// <summary>
	/// A collection of arguments for invoking getSharedImageGallery.
	/// </summary>
	public struct GetSharedImageGalleryArgs {
		/// <summary>
		/// The name of the Shared Image Gallery.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The name of the Resource Group in which the Shared Image Gallery exists.
		/// </summary>
		public string ResourceGroupName { get; set; }

	} // GetSharedImageGalleryArgs

	/// <summary>
	/// A collection of values returned by getSharedImageGallery.
	/// </summary>
	public struct GetSharedImageGalleryResult {
		/// <summary>
		/// A description for the Shared Image Gallery.
		/// </summary>
		public string Description { get; set; }

		public string Location { get; set; }

		/// <summary>
		/// A mapping of tags which are assigned to the Shared Image Gallery.
		/// </summary>
		public System.Collections.Generic.Dictionary<string, string> Tags { get; set; }

		/// <summary>
		/// The unique name assigned to the Shared Image Gallery.
		/// </summary>
		public string UniqueName { get; set; }

		/// <summary>
		/// id is the provider-assigned unique ID for this managed resource.
		/// </summary>
		public string Id { get; set; }

	} // GetSharedImageGalleryResult

	public static partial class ComputeModule {
		/// <summary>
		/// Use this data source to access information about an existing Shared Image Gallery.
		/// 
		/// -> **NOTE** Shared Image Galleries are currently in Public Preview. You can find more information, including [how to register for the Public Preview here](https://azure.microsoft.com/en-gb/blog/announcing-the-public-preview-of-shared-image-gallery/).
		/// </summary>
		public static System.Threading.Tasks.Task<GetSharedImageGalleryResult> GetSharedImageGallery(GetSharedImageGalleryArgs args, Pulumi.InvokeOptions opts = default(Pulumi.InvokeOptions)) {
			var invokeArgs = new Google.Protobuf.WellKnownTypes.Struct();
			invokeArgs.Fields["name"] = Protobuf.ToProtobuf(args.Name);
			invokeArgs.Fields["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);

			var task = Pulumi.Runtime.InvokeAsync("azure:compute/getSharedImageGallery:getSharedImageGallery", invokeArgs, opts);

			return task.ContinueWith(response => {
				var protobuf = response.Result;
				var result = new GetSharedImageGalleryResult();
				if (protobuf.Fields.ContainsKey("description")) {
					result.Description = Protobuf.ToString(protobuf.Fields["description"]);
				}
				if (protobuf.Fields.ContainsKey("location")) {
					result.Location = Protobuf.ToString(protobuf.Fields["location"]);
				}
				if (protobuf.Fields.ContainsKey("tags")) {
					result.Tags = Protobuf.ToMap(protobuf.Fields["tags"]);
				}
				if (protobuf.Fields.ContainsKey("uniqueName")) {
					result.UniqueName = Protobuf.ToString(protobuf.Fields["uniqueName"]);
				}
				if (protobuf.Fields.ContainsKey("id")) {
					result.Id = Protobuf.ToString(protobuf.Fields["id"]);
				}
				return result;
			});
		} // GetSharedImageGallery

	} // ComputeModule
} // Pulumi.Azure.Compute