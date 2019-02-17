// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Cosmosdb {

	public sealed class AccountArgsCapability : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Name { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("name", Protobuf.ToProtobuf(Name)));
		} // ToProtobuf

	} // AccountArgsCapability

	public sealed class AccountArgsConsistencyPolicy : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> ConsistencyLevel { get; set; }
		public Pulumi.IO<int> MaxIntervalInSeconds { get; set; }
		public Pulumi.IO<int> MaxStalenessPrefix { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("consistency_level", Protobuf.ToProtobuf(ConsistencyLevel)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("max_interval_in_seconds", Protobuf.ToProtobuf(MaxIntervalInSeconds)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("max_staleness_prefix", Protobuf.ToProtobuf(MaxStalenessPrefix)));
		} // ToProtobuf

	} // AccountArgsConsistencyPolicy

	public sealed class AccountArgsFailoverPolicy : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Id { get; set; }
		public Pulumi.IO<string> Location { get; set; }
		public Pulumi.IO<int> Priority { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("id", Protobuf.ToProtobuf(Id)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("location", Protobuf.ToProtobuf(Location)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("priority", Protobuf.ToProtobuf(Priority)));
		} // ToProtobuf

	} // AccountArgsFailoverPolicy

	public sealed class AccountArgsGeoLocation : Pulumi.IIOProtobuf {
		public Pulumi.IO<int> FailoverPriority { get; set; }
		public Pulumi.IO<string> Id { get; set; }
		public Pulumi.IO<string> Location { get; set; }
		public Pulumi.IO<string> Prefix { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("failover_priority", Protobuf.ToProtobuf(FailoverPriority)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("id", Protobuf.ToProtobuf(Id)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("location", Protobuf.ToProtobuf(Location)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("prefix", Protobuf.ToProtobuf(Prefix)));
		} // ToProtobuf

	} // AccountArgsGeoLocation

	public sealed class AccountArgsVirtualNetworkRule : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Id { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("id", Protobuf.ToProtobuf(Id)));
		} // ToProtobuf

	} // AccountArgsVirtualNetworkRule

	public sealed class AccountCapability : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Name { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("name", Protobuf.ToProtobuf(Name)));
		} // ToProtobuf

		public static AccountCapability FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new AccountCapability();
				if (obj.Fields.ContainsKey("name")) {
					result.Name = Protobuf.ToString(obj.Fields["name"]);
				}
			return result;
		} // FromProtobuf

	} // AccountCapability

	public sealed class AccountConsistencyPolicy : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> ConsistencyLevel { get; set; }
		public Pulumi.IO<int> MaxIntervalInSeconds { get; set; }
		public Pulumi.IO<int> MaxStalenessPrefix { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("consistency_level", Protobuf.ToProtobuf(ConsistencyLevel)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("max_interval_in_seconds", Protobuf.ToProtobuf(MaxIntervalInSeconds)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("max_staleness_prefix", Protobuf.ToProtobuf(MaxStalenessPrefix)));
		} // ToProtobuf

		public static AccountConsistencyPolicy FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new AccountConsistencyPolicy();
				if (obj.Fields.ContainsKey("consistency_level")) {
					result.ConsistencyLevel = Protobuf.ToString(obj.Fields["consistency_level"]);
				}
				if (obj.Fields.ContainsKey("max_interval_in_seconds")) {
					result.MaxIntervalInSeconds = Protobuf.ToInt(obj.Fields["max_interval_in_seconds"]);
				}
				if (obj.Fields.ContainsKey("max_staleness_prefix")) {
					result.MaxStalenessPrefix = Protobuf.ToInt(obj.Fields["max_staleness_prefix"]);
				}
			return result;
		} // FromProtobuf

	} // AccountConsistencyPolicy

	public sealed class AccountFailoverPolicy : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Id { get; set; }
		public Pulumi.IO<string> Location { get; set; }
		public Pulumi.IO<int> Priority { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("id", Protobuf.ToProtobuf(Id)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("location", Protobuf.ToProtobuf(Location)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("priority", Protobuf.ToProtobuf(Priority)));
		} // ToProtobuf

		public static AccountFailoverPolicy FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new AccountFailoverPolicy();
				if (obj.Fields.ContainsKey("id")) {
					result.Id = Protobuf.ToString(obj.Fields["id"]);
				}
				if (obj.Fields.ContainsKey("location")) {
					result.Location = Protobuf.ToString(obj.Fields["location"]);
				}
				if (obj.Fields.ContainsKey("priority")) {
					result.Priority = Protobuf.ToInt(obj.Fields["priority"]);
				}
			return result;
		} // FromProtobuf

	} // AccountFailoverPolicy

	public sealed class AccountGeoLocation : Pulumi.IIOProtobuf {
		public Pulumi.IO<int> FailoverPriority { get; set; }
		public Pulumi.IO<string> Id { get; set; }
		public Pulumi.IO<string> Location { get; set; }
		public Pulumi.IO<string> Prefix { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("failover_priority", Protobuf.ToProtobuf(FailoverPriority)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("id", Protobuf.ToProtobuf(Id)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("location", Protobuf.ToProtobuf(Location)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("prefix", Protobuf.ToProtobuf(Prefix)));
		} // ToProtobuf

		public static AccountGeoLocation FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new AccountGeoLocation();
				if (obj.Fields.ContainsKey("failover_priority")) {
					result.FailoverPriority = Protobuf.ToInt(obj.Fields["failover_priority"]);
				}
				if (obj.Fields.ContainsKey("id")) {
					result.Id = Protobuf.ToString(obj.Fields["id"]);
				}
				if (obj.Fields.ContainsKey("location")) {
					result.Location = Protobuf.ToString(obj.Fields["location"]);
				}
				if (obj.Fields.ContainsKey("prefix")) {
					result.Prefix = Protobuf.ToString(obj.Fields["prefix"]);
				}
			return result;
		} // FromProtobuf

	} // AccountGeoLocation

	public sealed class AccountVirtualNetworkRule : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Id { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("id", Protobuf.ToProtobuf(Id)));
		} // ToProtobuf

		public static AccountVirtualNetworkRule FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new AccountVirtualNetworkRule();
				if (obj.Fields.ContainsKey("id")) {
					result.Id = Protobuf.ToString(obj.Fields["id"]);
				}
			return result;
		} // FromProtobuf

	} // AccountVirtualNetworkRule

	/// <summary>
	/// The set of arguments for constructing a Account resource.
	/// </summary>
	public struct AccountArgs {
		/// <summary>
		/// Enable capabilities for this Cosmos DB account. Possible values are `EnableTable` and `EnableGremlin`.
		/// </summary>
		public Pulumi.IO<Pulumi.IO<AccountArgsCapability>[]> Capabilities { get; set; }

		/// <summary>
		/// Specifies a `consistency_policy` resource, used to define the consistency policy for this CosmosDB account.
		/// </summary>
		public Pulumi.IO<AccountArgsConsistencyPolicy> ConsistencyPolicy { get; set; }

		/// <summary>
		/// Enable automatic fail over for this Cosmos DB account.
		/// </summary>
		public Pulumi.IO<bool> EnableAutomaticFailover { get; set; }

		/// <summary>
		/// Enable multi-master support for this Cosmos DB account.
		/// </summary>
		public Pulumi.IO<bool> EnableMultipleWriteLocations { get; set; }

		public Pulumi.IO<Pulumi.IO<AccountArgsFailoverPolicy>[]> FailoverPolicies { get; set; }

		/// <summary>
		/// Specifies a `geo_location` resource, used to define where data should be replicated with the `failover_priority` 0 specifying the primary location.
		/// </summary>
		public Pulumi.IO<Pulumi.IO<AccountArgsGeoLocation>[]> GeoLocations { get; set; }

		/// <summary>
		/// CosmosDB Firewall Support: This value specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IP's for a given database account. IP addresses/ranges must be comma separated and must not contain any spaces.
		/// </summary>
		public Pulumi.IO<string> IpRangeFilter { get; set; }

		/// <summary>
		/// Enables virtual network filtering for this Cosmos DB account.
		/// </summary>
		public Pulumi.IO<bool> IsVirtualNetworkFilterEnabled { get; set; }

		/// <summary>
		/// Specifies the Kind of CosmosDB to create - possible values are `GlobalDocumentDB` and `MongoDB`. Defaults to `GlobalDocumentDB`. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Kind { get; set; }

		/// <summary>
		/// The name of the Azure region to host replicated data.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// Specifies the name of the CosmosDB Account. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// Specifies the Offer Type to use for this CosmosDB Account - currently this can only be set to `Standard`.
		/// </summary>
		public Pulumi.IO<string> OfferType { get; set; }

		/// <summary>
		/// The name of the resource group in which the CosmosDB Account is created. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

		/// <summary>
		/// Specifies a `virtual_network_rules` resource, used to define which subnets are allowed to access this CosmosDB account.
		/// </summary>
		public Pulumi.IO<Pulumi.IO<AccountArgsVirtualNetworkRule>[]> VirtualNetworkRules { get; set; }

	} // AccountArgs

	/// <summary>
	/// Manages a CosmosDB (formally DocumentDB) Account.
	/// </summary>
	public class Account : Pulumi.CustomResource {
		/// <summary>
		/// Enable capabilities for this Cosmos DB account. Possible values are `EnableTable` and `EnableGremlin`.
		/// </summary>
		public Pulumi.IO<AccountCapability[]> Capabilities { get; set; }

		/// <summary>
		/// A list of connection strings available for this CosmosDB account. If the kind is `GlobalDocumentDB`, this will be empty.
		/// </summary>
		public Pulumi.IO<string[]> ConnectionStrings { get; set; }

		/// <summary>
		/// Specifies a `consistency_policy` resource, used to define the consistency policy for this CosmosDB account.
		/// </summary>
		public Pulumi.IO<AccountConsistencyPolicy> ConsistencyPolicy { get; set; }

		/// <summary>
		/// Enable automatic fail over for this Cosmos DB account.
		/// </summary>
		public Pulumi.IO<bool> EnableAutomaticFailover { get; set; }

		/// <summary>
		/// Enable multi-master support for this Cosmos DB account.
		/// </summary>
		public Pulumi.IO<bool> EnableMultipleWriteLocations { get; set; }

		/// <summary>
		/// The endpoint used to connect to the CosmosDB account.
		/// </summary>
		public Pulumi.IO<string> Endpoint { get; set; }

		public Pulumi.IO<AccountFailoverPolicy[]> FailoverPolicies { get; set; }

		/// <summary>
		/// Specifies a `geo_location` resource, used to define where data should be replicated with the `failover_priority` 0 specifying the primary location.
		/// </summary>
		public Pulumi.IO<AccountGeoLocation[]> GeoLocations { get; set; }

		/// <summary>
		/// CosmosDB Firewall Support: This value specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IP's for a given database account. IP addresses/ranges must be comma separated and must not contain any spaces.
		/// </summary>
		public Pulumi.IO<string> IpRangeFilter { get; set; }

		/// <summary>
		/// Enables virtual network filtering for this Cosmos DB account.
		/// </summary>
		public Pulumi.IO<bool> IsVirtualNetworkFilterEnabled { get; set; }

		/// <summary>
		/// Specifies the Kind of CosmosDB to create - possible values are `GlobalDocumentDB` and `MongoDB`. Defaults to `GlobalDocumentDB`. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Kind { get; set; }

		/// <summary>
		/// The name of the Azure region to host replicated data.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// Specifies the name of the CosmosDB Account. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// Specifies the Offer Type to use for this CosmosDB Account - currently this can only be set to `Standard`.
		/// </summary>
		public Pulumi.IO<string> OfferType { get; set; }

		/// <summary>
		/// The Primary master key for the CosmosDB Account.
		/// </summary>
		public Pulumi.IO<string> PrimaryMasterKey { get; set; }

		/// <summary>
		/// The Primary read-only master Key for the CosmosDB Account.
		/// </summary>
		public Pulumi.IO<string> PrimaryReadonlyMasterKey { get; set; }

		/// <summary>
		/// A list of read endpoints available for this CosmosDB account.
		/// </summary>
		public Pulumi.IO<string[]> ReadEndpoints { get; set; }

		/// <summary>
		/// The name of the resource group in which the CosmosDB Account is created. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// The Secondary master key for the CosmosDB Account.
		/// </summary>
		public Pulumi.IO<string> SecondaryMasterKey { get; set; }

		/// <summary>
		/// The Secondary read-only master key for the CosmosDB Account.
		/// </summary>
		public Pulumi.IO<string> SecondaryReadonlyMasterKey { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

		/// <summary>
		/// Specifies a `virtual_network_rules` resource, used to define which subnets are allowed to access this CosmosDB account.
		/// </summary>
		public Pulumi.IO<AccountVirtualNetworkRule[]> VirtualNetworkRules { get; set; }

		/// <summary>
		/// A list of write endpoints available for this CosmosDB account.
		/// </summary>
		public Pulumi.IO<string[]> WriteEndpoints { get; set; }

		public Account(string name, AccountArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:cosmosdb/account:Account", name, SerialiseArgs(args), opts) {
			Capabilities = base.Outputs["capabilities"].Select(item => Protobuf.ToList(item, item1 => AccountCapability.FromProtobuf(item1)));
			ConnectionStrings = base.Outputs["connectionStrings"].Select(item => Protobuf.ToList(item, item1 => Protobuf.ToString(item1)));
			ConsistencyPolicy = base.Outputs["consistencyPolicy"].Select(item => AccountConsistencyPolicy.FromProtobuf(item));
			EnableAutomaticFailover = base.Outputs["enableAutomaticFailover"].Select(item => Protobuf.ToBool(item));
			EnableMultipleWriteLocations = base.Outputs["enableMultipleWriteLocations"].Select(item => Protobuf.ToBool(item));
			Endpoint = base.Outputs["endpoint"].Select(item => Protobuf.ToString(item));
			FailoverPolicies = base.Outputs["failoverPolicies"].Select(item => Protobuf.ToList(item, item1 => AccountFailoverPolicy.FromProtobuf(item1)));
			GeoLocations = base.Outputs["geoLocations"].Select(item => Protobuf.ToList(item, item1 => AccountGeoLocation.FromProtobuf(item1)));
			IpRangeFilter = base.Outputs["ipRangeFilter"].Select(item => Protobuf.ToString(item));
			IsVirtualNetworkFilterEnabled = base.Outputs["isVirtualNetworkFilterEnabled"].Select(item => Protobuf.ToBool(item));
			Kind = base.Outputs["kind"].Select(item => Protobuf.ToString(item));
			Location = base.Outputs["location"].Select(item => Protobuf.ToString(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			OfferType = base.Outputs["offerType"].Select(item => Protobuf.ToString(item));
			PrimaryMasterKey = base.Outputs["primaryMasterKey"].Select(item => Protobuf.ToString(item));
			PrimaryReadonlyMasterKey = base.Outputs["primaryReadonlyMasterKey"].Select(item => Protobuf.ToString(item));
			ReadEndpoints = base.Outputs["readEndpoints"].Select(item => Protobuf.ToList(item, item1 => Protobuf.ToString(item1)));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			SecondaryMasterKey = base.Outputs["secondaryMasterKey"].Select(item => Protobuf.ToString(item));
			SecondaryReadonlyMasterKey = base.Outputs["secondaryReadonlyMasterKey"].Select(item => Protobuf.ToString(item));
			Tags = base.Outputs["tags"].Select(item => Protobuf.ToMap(item));
			VirtualNetworkRules = base.Outputs["virtualNetworkRules"].Select(item => Protobuf.ToList(item, item1 => AccountVirtualNetworkRule.FromProtobuf(item1)));
			WriteEndpoints = base.Outputs["writeEndpoints"].Select(item => Protobuf.ToList(item, item1 => Protobuf.ToString(item1)));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(AccountArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["capabilities"] = Protobuf.ToProtobuf(args.Capabilities, item => Protobuf.ToProtobuf(item));
			props["consistencyPolicy"] = Protobuf.ToProtobuf(args.ConsistencyPolicy);
			props["enableAutomaticFailover"] = Protobuf.ToProtobuf(args.EnableAutomaticFailover);
			props["enableMultipleWriteLocations"] = Protobuf.ToProtobuf(args.EnableMultipleWriteLocations);
			props["failoverPolicies"] = Protobuf.ToProtobuf(args.FailoverPolicies, item => Protobuf.ToProtobuf(item));
			props["geoLocations"] = Protobuf.ToProtobuf(args.GeoLocations, item => Protobuf.ToProtobuf(item));
			props["ipRangeFilter"] = Protobuf.ToProtobuf(args.IpRangeFilter);
			props["isVirtualNetworkFilterEnabled"] = Protobuf.ToProtobuf(args.IsVirtualNetworkFilterEnabled);
			props["kind"] = Protobuf.ToProtobuf(args.Kind);
			props["location"] = Protobuf.ToProtobuf(args.Location);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["offerType"] = Protobuf.ToProtobuf(args.OfferType);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["tags"] = Protobuf.ToProtobuf(args.Tags);
			props["virtualNetworkRules"] = Protobuf.ToProtobuf(args.VirtualNetworkRules, item => Protobuf.ToProtobuf(item));
			props["connectionStrings"] = null; //out
			props["endpoint"] = null; //out
			props["primaryMasterKey"] = null; //out
			props["primaryReadonlyMasterKey"] = null; //out
			props["readEndpoints"] = null; //out
			props["secondaryMasterKey"] = null; //out
			props["secondaryReadonlyMasterKey"] = null; //out
			props["writeEndpoints"] = null; //out
			return props;
		} // SerialiseArgs

	} // Account
} // Pulumi.Azure.Cosmosdb