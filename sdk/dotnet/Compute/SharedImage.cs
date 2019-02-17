// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Compute {

	public sealed class SharedImageArgsIdentifier : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Offer { get; set; }
		public Pulumi.IO<string> Publisher { get; set; }
		public Pulumi.IO<string> Sku { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("offer", Protobuf.ToProtobuf(Offer)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("publisher", Protobuf.ToProtobuf(Publisher)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("sku", Protobuf.ToProtobuf(Sku)));
		} // ToProtobuf

	} // SharedImageArgsIdentifier

	public sealed class SharedImageIdentifier : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Offer { get; set; }
		public Pulumi.IO<string> Publisher { get; set; }
		public Pulumi.IO<string> Sku { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("offer", Protobuf.ToProtobuf(Offer)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("publisher", Protobuf.ToProtobuf(Publisher)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("sku", Protobuf.ToProtobuf(Sku)));
		} // ToProtobuf

		public static SharedImageIdentifier FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new SharedImageIdentifier();
				if (obj.Fields.ContainsKey("offer")) {
					result.Offer = Protobuf.ToString(obj.Fields["offer"]);
				}
				if (obj.Fields.ContainsKey("publisher")) {
					result.Publisher = Protobuf.ToString(obj.Fields["publisher"]);
				}
				if (obj.Fields.ContainsKey("sku")) {
					result.Sku = Protobuf.ToString(obj.Fields["sku"]);
				}
			return result;
		} // FromProtobuf

	} // SharedImageIdentifier

	/// <summary>
	/// The set of arguments for constructing a SharedImage resource.
	/// </summary>
	public struct SharedImageArgs {
		/// <summary>
		/// A description of this Shared Image.
		/// </summary>
		public Pulumi.IO<string> Description { get; set; }

		/// <summary>
		/// The End User Licence Agreement for the Shared Image.
		/// </summary>
		public Pulumi.IO<string> Eula { get; set; }

		/// <summary>
		/// Specifies the name of the Shared Image Gallery in which this Shared Image should exist. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> GalleryName { get; set; }

		public Pulumi.IO<SharedImageArgsIdentifier> Identifier { get; set; }

		/// <summary>
		/// Specifies the supported Azure location where the Shared Image Gallery exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// Specifies the name of the Shared Image. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The type of Operating System present in this Shared Image. Possible values are `Linux` and `Windows`.
		/// </summary>
		public Pulumi.IO<string> OsType { get; set; }

		/// <summary>
		/// The URI containing the Privacy Statement associated with this Shared Image.
		/// </summary>
		public Pulumi.IO<string> PrivacyStatementUri { get; set; }

		/// <summary>
		/// The URI containing the Release Notes associated with this Shared Image.
		/// </summary>
		public Pulumi.IO<string> ReleaseNoteUri { get; set; }

		/// <summary>
		/// The name of the resource group in which the Shared Image Gallery exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the Shared Image.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

	} // SharedImageArgs

	/// <summary>
	/// Manages a Shared Image within a Shared Image Gallery.
	/// 
	/// -> **NOTE** Shared Image Galleries are currently in Public Preview. You can find more information, including [how to register for the Public Preview here](https://azure.microsoft.com/en-gb/blog/announcing-the-public-preview-of-shared-image-gallery/).
	/// </summary>
	public class SharedImage : Pulumi.CustomResource {
		/// <summary>
		/// A description of this Shared Image.
		/// </summary>
		public Pulumi.IO<string> Description { get; set; }

		/// <summary>
		/// The End User Licence Agreement for the Shared Image.
		/// </summary>
		public Pulumi.IO<string> Eula { get; set; }

		/// <summary>
		/// Specifies the name of the Shared Image Gallery in which this Shared Image should exist. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> GalleryName { get; set; }

		public Pulumi.IO<SharedImageIdentifier> Identifier { get; set; }

		/// <summary>
		/// Specifies the supported Azure location where the Shared Image Gallery exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// Specifies the name of the Shared Image. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The type of Operating System present in this Shared Image. Possible values are `Linux` and `Windows`.
		/// </summary>
		public Pulumi.IO<string> OsType { get; set; }

		/// <summary>
		/// The URI containing the Privacy Statement associated with this Shared Image.
		/// </summary>
		public Pulumi.IO<string> PrivacyStatementUri { get; set; }

		/// <summary>
		/// The URI containing the Release Notes associated with this Shared Image.
		/// </summary>
		public Pulumi.IO<string> ReleaseNoteUri { get; set; }

		/// <summary>
		/// The name of the resource group in which the Shared Image Gallery exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the Shared Image.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

		public SharedImage(string name, SharedImageArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:compute/sharedImage:SharedImage", name, SerialiseArgs(args), opts) {
			Description = base.Outputs["description"].Select(item => Protobuf.ToString(item));
			Eula = base.Outputs["eula"].Select(item => Protobuf.ToString(item));
			GalleryName = base.Outputs["galleryName"].Select(item => Protobuf.ToString(item));
			Identifier = base.Outputs["identifier"].Select(item => SharedImageIdentifier.FromProtobuf(item));
			Location = base.Outputs["location"].Select(item => Protobuf.ToString(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			OsType = base.Outputs["osType"].Select(item => Protobuf.ToString(item));
			PrivacyStatementUri = base.Outputs["privacyStatementUri"].Select(item => Protobuf.ToString(item));
			ReleaseNoteUri = base.Outputs["releaseNoteUri"].Select(item => Protobuf.ToString(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			Tags = base.Outputs["tags"].Select(item => Protobuf.ToMap(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(SharedImageArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["description"] = Protobuf.ToProtobuf(args.Description);
			props["eula"] = Protobuf.ToProtobuf(args.Eula);
			props["galleryName"] = Protobuf.ToProtobuf(args.GalleryName);
			props["identifier"] = Protobuf.ToProtobuf(args.Identifier);
			props["location"] = Protobuf.ToProtobuf(args.Location);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["osType"] = Protobuf.ToProtobuf(args.OsType);
			props["privacyStatementUri"] = Protobuf.ToProtobuf(args.PrivacyStatementUri);
			props["releaseNoteUri"] = Protobuf.ToProtobuf(args.ReleaseNoteUri);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["tags"] = Protobuf.ToProtobuf(args.Tags);
			return props;
		} // SerialiseArgs

	} // SharedImage
} // Pulumi.Azure.Compute