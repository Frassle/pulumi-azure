// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Ad {

	/// <summary>
	/// The set of arguments for constructing a Application resource.
	/// </summary>
	public struct ApplicationArgs {
		/// <summary>
		/// Is this Azure AD Application available to other tenants? Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> AvailableToOtherTenants { get; set; }

		/// <summary>
		/// The URL to the application's home page. If no homepage is specified this defaults to `https://{name}`.
		/// </summary>
		public Pulumi.IO<string> Homepage { get; set; }

		/// <summary>
		/// A list of user-defined URI(s) that uniquely identify a Web application within it's Azure AD tenant, or within a verified custom domain if the application is multi-tenant.
		/// </summary>
		public Pulumi.IO<Pulumi.IO<string>[]> IdentifierUris { get; set; }

		/// <summary>
		/// The display name for the application.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// Does this Azure AD Application allow OAuth2.0 implicit flow tokens? Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> Oauth2AllowImplicitFlow { get; set; }

		/// <summary>
		/// A list of URLs that user tokens are sent to for sign in, or the redirect URIs that OAuth 2.0 authorization codes and access tokens are sent to.
		/// </summary>
		public Pulumi.IO<Pulumi.IO<string>[]> ReplyUrls { get; set; }

	} // ApplicationArgs

	/// <summary>
	/// Manages an Application within Azure Active Directory.
	/// 
	/// > **NOTE:** The Azure Active Directory resources have been split out into [a new AzureAD Provider](http://terraform.io/docs/providers/azuread/index.html) - as such the AzureAD resources within the AzureRM Provider are deprecated and will be removed in the next major version (2.0). Information on how to migrate from the existing resources to the new AzureAD Provider can be found here.
	/// 
	/// -> **NOTE:** If you're authenticating using a Service Principal then it must have permissions to both `Read and write all applications` and `Sign in and read user profile` within the `Windows Azure Active Directory` API.
	/// </summary>
	public class Application : Pulumi.CustomResource {
		/// <summary>
		/// The Application ID.
		/// </summary>
		public Pulumi.IO<string> ApplicationId { get; set; }

		/// <summary>
		/// Is this Azure AD Application available to other tenants? Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> AvailableToOtherTenants { get; set; }

		/// <summary>
		/// The URL to the application's home page. If no homepage is specified this defaults to `https://{name}`.
		/// </summary>
		public Pulumi.IO<string> Homepage { get; set; }

		/// <summary>
		/// A list of user-defined URI(s) that uniquely identify a Web application within it's Azure AD tenant, or within a verified custom domain if the application is multi-tenant.
		/// </summary>
		public Pulumi.IO<string[]> IdentifierUris { get; set; }

		/// <summary>
		/// The display name for the application.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// Does this Azure AD Application allow OAuth2.0 implicit flow tokens? Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> Oauth2AllowImplicitFlow { get; set; }

		/// <summary>
		/// A list of URLs that user tokens are sent to for sign in, or the redirect URIs that OAuth 2.0 authorization codes and access tokens are sent to.
		/// </summary>
		public Pulumi.IO<string[]> ReplyUrls { get; set; }

		public Application(string name, ApplicationArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:ad/application:Application", name, SerialiseArgs(args), opts) {
			ApplicationId = base.Outputs["applicationId"].Select(item => Protobuf.ToString(item));
			AvailableToOtherTenants = base.Outputs["availableToOtherTenants"].Select(item => Protobuf.ToBool(item));
			Homepage = base.Outputs["homepage"].Select(item => Protobuf.ToString(item));
			IdentifierUris = base.Outputs["identifierUris"].Select(item => Protobuf.ToList(item, item1 => Protobuf.ToString(item1)));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			Oauth2AllowImplicitFlow = base.Outputs["oauth2AllowImplicitFlow"].Select(item => Protobuf.ToBool(item));
			ReplyUrls = base.Outputs["replyUrls"].Select(item => Protobuf.ToList(item, item1 => Protobuf.ToString(item1)));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(ApplicationArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["availableToOtherTenants"] = Protobuf.ToProtobuf(args.AvailableToOtherTenants);
			props["homepage"] = Protobuf.ToProtobuf(args.Homepage);
			props["identifierUris"] = Protobuf.ToProtobuf(args.IdentifierUris, item => Protobuf.ToProtobuf(item));
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["oauth2AllowImplicitFlow"] = Protobuf.ToProtobuf(args.Oauth2AllowImplicitFlow);
			props["replyUrls"] = Protobuf.ToProtobuf(args.ReplyUrls, item => Protobuf.ToProtobuf(item));
			props["applicationId"] = null; //out
			return props;
		} // SerialiseArgs

	} // Application
} // Pulumi.Azure.Ad
