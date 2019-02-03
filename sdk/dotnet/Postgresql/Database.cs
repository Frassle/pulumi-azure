// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Postgresql {

	/// <summary>
	/// The set of arguments for constructing a Database resource.
	/// </summary>
	public struct DatabaseArgs {
		/// <summary>
		/// Specifies the Charset for the PostgreSQL Database, which needs [to be a valid PostgreSQL Charset](https://www.postgresql.org/docs/current/static/multibyte.html). Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Charset { get; set; }

		/// <summary>
		/// Specifies the Collation for the PostgreSQL Database, which needs [to be a valid PostgreSQL Collation](https://www.postgresql.org/docs/current/static/collation.html). Note that Microsoft uses different [notation](https://msdn.microsoft.com/library/windows/desktop/dd373814.aspx) - en-US instead of en_US. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Collation { get; set; }

		/// <summary>
		/// Specifies the name of the PostgreSQL Database, which needs [to be a valid PostgreSQL identifier](https://www.postgresql.org/docs/current/static/sql-syntax-lexical.html#SQL-SYNTAX-IDENTIFIERS). Changing this forces a
		/// new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The name of the resource group in which the PostgreSQL Server exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// Specifies the name of the PostgreSQL Server. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ServerName { get; set; }

	} // DatabaseArgs

	/// <summary>
	/// Manages a PostgreSQL Database within a PostgreSQL Server
	/// </summary>
	public class Database : Pulumi.CustomResource {
		/// <summary>
		/// Specifies the Charset for the PostgreSQL Database, which needs [to be a valid PostgreSQL Charset](https://www.postgresql.org/docs/current/static/multibyte.html). Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Charset { get; set; }

		/// <summary>
		/// Specifies the Collation for the PostgreSQL Database, which needs [to be a valid PostgreSQL Collation](https://www.postgresql.org/docs/current/static/collation.html). Note that Microsoft uses different [notation](https://msdn.microsoft.com/library/windows/desktop/dd373814.aspx) - en-US instead of en_US. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Collation { get; set; }

		/// <summary>
		/// Specifies the name of the PostgreSQL Database, which needs [to be a valid PostgreSQL identifier](https://www.postgresql.org/docs/current/static/sql-syntax-lexical.html#SQL-SYNTAX-IDENTIFIERS). Changing this forces a
		/// new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The name of the resource group in which the PostgreSQL Server exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// Specifies the name of the PostgreSQL Server. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ServerName { get; set; }

		public Database(string name, DatabaseArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:postgresql/database:Database", name, SerialiseArgs(args), opts) {
			Charset = base.Outputs["charset"].Select(item => Protobuf.ToString(item));
			Collation = base.Outputs["collation"].Select(item => Protobuf.ToString(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			ServerName = base.Outputs["serverName"].Select(item => Protobuf.ToString(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(DatabaseArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["charset"] = Protobuf.ToProtobuf(args.Charset);
			props["collation"] = Protobuf.ToProtobuf(args.Collation);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["serverName"] = Protobuf.ToProtobuf(args.ServerName);
			return props;
		} // SerialiseArgs

	} // Database
} // Pulumi.Azure.Postgresql
