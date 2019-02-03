// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Sql {

	/// <summary>
	/// The set of arguments for constructing a ActiveDirectoryAdministrator resource.
	/// </summary>
	public struct ActiveDirectoryAdministratorArgs {
		/// <summary>
		/// The login name of the principal to set as the server administrator
		/// </summary>
		public Pulumi.IO<string> Login { get; set; }

		/// <summary>
		/// The ID of the principal to set as the server administrator
		/// </summary>
		public Pulumi.IO<string> ObjectId { get; set; }

		/// <summary>
		/// The name of the resource group for the SQL server. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// The name of the SQL Server on which to set the administrator. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ServerName { get; set; }

		/// <summary>
		/// The Azure Tenant ID
		/// </summary>
		public Pulumi.IO<string> TenantId { get; set; }

	} // ActiveDirectoryAdministratorArgs

	/// <summary>
	/// Allows you to set a user or group as the AD administrator for an Azure SQL server
	/// </summary>
	public class ActiveDirectoryAdministrator : Pulumi.CustomResource {
		/// <summary>
		/// The login name of the principal to set as the server administrator
		/// </summary>
		public Pulumi.IO<string> Login { get; set; }

		/// <summary>
		/// The ID of the principal to set as the server administrator
		/// </summary>
		public Pulumi.IO<string> ObjectId { get; set; }

		/// <summary>
		/// The name of the resource group for the SQL server. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// The name of the SQL Server on which to set the administrator. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ServerName { get; set; }

		/// <summary>
		/// The Azure Tenant ID
		/// </summary>
		public Pulumi.IO<string> TenantId { get; set; }

		public ActiveDirectoryAdministrator(string name, ActiveDirectoryAdministratorArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:sql/activeDirectoryAdministrator:ActiveDirectoryAdministrator", name, SerialiseArgs(args), opts) {
			Login = base.Outputs["login"].Select(item => Protobuf.ToString(item));
			ObjectId = base.Outputs["objectId"].Select(item => Protobuf.ToString(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			ServerName = base.Outputs["serverName"].Select(item => Protobuf.ToString(item));
			TenantId = base.Outputs["tenantId"].Select(item => Protobuf.ToString(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(ActiveDirectoryAdministratorArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["login"] = Protobuf.ToProtobuf(args.Login);
			props["objectId"] = Protobuf.ToProtobuf(args.ObjectId);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["serverName"] = Protobuf.ToProtobuf(args.ServerName);
			props["tenantId"] = Protobuf.ToProtobuf(args.TenantId);
			return props;
		} // SerialiseArgs

	} // ActiveDirectoryAdministrator
} // Pulumi.Azure.Sql
