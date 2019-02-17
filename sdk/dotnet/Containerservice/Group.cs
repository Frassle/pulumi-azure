// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Containerservice {

	public sealed class GroupArgsContainerArgsPort : Pulumi.IIOProtobuf {
		public Pulumi.IO<int> Port { get; set; }
		public Pulumi.IO<string> Protocol { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("port", Protobuf.ToProtobuf(Port)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("protocol", Protobuf.ToProtobuf(Protocol)));
		} // ToProtobuf

	} // GroupArgsContainerArgsPort

	public sealed class GroupArgsContainerArgsVolume : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> MountPath { get; set; }
		public Pulumi.IO<string> Name { get; set; }
		public Pulumi.IO<bool> ReadOnly { get; set; }
		public Pulumi.IO<string> ShareName { get; set; }
		public Pulumi.IO<string> StorageAccountKey { get; set; }
		public Pulumi.IO<string> StorageAccountName { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("mount_path", Protobuf.ToProtobuf(MountPath)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("name", Protobuf.ToProtobuf(Name)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("read_only", Protobuf.ToProtobuf(ReadOnly)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("share_name", Protobuf.ToProtobuf(ShareName)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("storage_account_key", Protobuf.ToProtobuf(StorageAccountKey)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("storage_account_name", Protobuf.ToProtobuf(StorageAccountName)));
		} // ToProtobuf

	} // GroupArgsContainerArgsVolume

	public sealed class GroupArgsContainer : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Command { get; set; }
		public Pulumi.IO<Pulumi.IO<string>[]> Commands { get; set; }
		public Pulumi.IO<double> Cpu { get; set; }
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> EnvironmentVariables { get; set; }
		public Pulumi.IO<string> Image { get; set; }
		public Pulumi.IO<double> Memory { get; set; }
		public Pulumi.IO<string> Name { get; set; }
		public Pulumi.IO<int> Port { get; set; }
		public Pulumi.IO<Pulumi.IO<GroupArgsContainerArgsPort>[]> Ports { get; set; }
		public Pulumi.IO<string> Protocol { get; set; }
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> SecureEnvironmentVariables { get; set; }
		public Pulumi.IO<Pulumi.IO<GroupArgsContainerArgsVolume>[]> Volume { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("command", Protobuf.ToProtobuf(Command)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("commands", Protobuf.ToProtobuf(Commands, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("cpu", Protobuf.ToProtobuf(Cpu)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("environment_variables", Protobuf.ToProtobuf(EnvironmentVariables)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("image", Protobuf.ToProtobuf(Image)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("memory", Protobuf.ToProtobuf(Memory)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("name", Protobuf.ToProtobuf(Name)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("port", Protobuf.ToProtobuf(Port)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("ports", Protobuf.ToProtobuf(Ports, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("protocol", Protobuf.ToProtobuf(Protocol)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("secure_environment_variables", Protobuf.ToProtobuf(SecureEnvironmentVariables)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("volume", Protobuf.ToProtobuf(Volume, item => Protobuf.ToProtobuf(item))));
		} // ToProtobuf

	} // GroupArgsContainer

	public sealed class GroupArgsImageRegistryCredential : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Password { get; set; }
		public Pulumi.IO<string> Server { get; set; }
		public Pulumi.IO<string> Username { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("password", Protobuf.ToProtobuf(Password)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("server", Protobuf.ToProtobuf(Server)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("username", Protobuf.ToProtobuf(Username)));
		} // ToProtobuf

	} // GroupArgsImageRegistryCredential

	public sealed class GroupContainerPort : Pulumi.IIOProtobuf {
		public Pulumi.IO<int> Port { get; set; }
		public Pulumi.IO<string> Protocol { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("port", Protobuf.ToProtobuf(Port)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("protocol", Protobuf.ToProtobuf(Protocol)));
		} // ToProtobuf

		public static GroupContainerPort FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new GroupContainerPort();
				if (obj.Fields.ContainsKey("port")) {
					result.Port = Protobuf.ToInt(obj.Fields["port"]);
				}
				if (obj.Fields.ContainsKey("protocol")) {
					result.Protocol = Protobuf.ToString(obj.Fields["protocol"]);
				}
			return result;
		} // FromProtobuf

	} // GroupContainerPort

	public sealed class GroupContainerVolume : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> MountPath { get; set; }
		public Pulumi.IO<string> Name { get; set; }
		public Pulumi.IO<bool> ReadOnly { get; set; }
		public Pulumi.IO<string> ShareName { get; set; }
		public Pulumi.IO<string> StorageAccountKey { get; set; }
		public Pulumi.IO<string> StorageAccountName { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("mount_path", Protobuf.ToProtobuf(MountPath)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("name", Protobuf.ToProtobuf(Name)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("read_only", Protobuf.ToProtobuf(ReadOnly)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("share_name", Protobuf.ToProtobuf(ShareName)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("storage_account_key", Protobuf.ToProtobuf(StorageAccountKey)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("storage_account_name", Protobuf.ToProtobuf(StorageAccountName)));
		} // ToProtobuf

		public static GroupContainerVolume FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new GroupContainerVolume();
				if (obj.Fields.ContainsKey("mount_path")) {
					result.MountPath = Protobuf.ToString(obj.Fields["mount_path"]);
				}
				if (obj.Fields.ContainsKey("name")) {
					result.Name = Protobuf.ToString(obj.Fields["name"]);
				}
				if (obj.Fields.ContainsKey("read_only")) {
					result.ReadOnly = Protobuf.ToBool(obj.Fields["read_only"]);
				}
				if (obj.Fields.ContainsKey("share_name")) {
					result.ShareName = Protobuf.ToString(obj.Fields["share_name"]);
				}
				if (obj.Fields.ContainsKey("storage_account_key")) {
					result.StorageAccountKey = Protobuf.ToString(obj.Fields["storage_account_key"]);
				}
				if (obj.Fields.ContainsKey("storage_account_name")) {
					result.StorageAccountName = Protobuf.ToString(obj.Fields["storage_account_name"]);
				}
			return result;
		} // FromProtobuf

	} // GroupContainerVolume

	public sealed class GroupContainer : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Command { get; set; }
		public Pulumi.IO<string[]> Commands { get; set; }
		public Pulumi.IO<double> Cpu { get; set; }
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> EnvironmentVariables { get; set; }
		public Pulumi.IO<string> Image { get; set; }
		public Pulumi.IO<double> Memory { get; set; }
		public Pulumi.IO<string> Name { get; set; }
		public Pulumi.IO<int> Port { get; set; }
		public Pulumi.IO<GroupContainerPort[]> Ports { get; set; }
		public Pulumi.IO<string> Protocol { get; set; }
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> SecureEnvironmentVariables { get; set; }
		public Pulumi.IO<GroupContainerVolume[]> Volume { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("command", Protobuf.ToProtobuf(Command)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("commands", Protobuf.ToProtobuf(Commands, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("cpu", Protobuf.ToProtobuf(Cpu)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("environment_variables", Protobuf.ToProtobuf(EnvironmentVariables)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("image", Protobuf.ToProtobuf(Image)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("memory", Protobuf.ToProtobuf(Memory)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("name", Protobuf.ToProtobuf(Name)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("port", Protobuf.ToProtobuf(Port)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("ports", Protobuf.ToProtobuf(Ports, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("protocol", Protobuf.ToProtobuf(Protocol)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("secure_environment_variables", Protobuf.ToProtobuf(SecureEnvironmentVariables)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("volume", Protobuf.ToProtobuf(Volume, item => Protobuf.ToProtobuf(item))));
		} // ToProtobuf

		public static GroupContainer FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new GroupContainer();
				if (obj.Fields.ContainsKey("command")) {
					result.Command = Protobuf.ToString(obj.Fields["command"]);
				}
				if (obj.Fields.ContainsKey("commands")) {
					result.Commands = Protobuf.ToList(obj.Fields["commands"], item => Protobuf.ToString(item));
				}
				if (obj.Fields.ContainsKey("cpu")) {
					result.Cpu = Protobuf.ToDouble(obj.Fields["cpu"]);
				}
				if (obj.Fields.ContainsKey("environment_variables")) {
					result.EnvironmentVariables = Protobuf.ToMap(obj.Fields["environment_variables"]);
				}
				if (obj.Fields.ContainsKey("image")) {
					result.Image = Protobuf.ToString(obj.Fields["image"]);
				}
				if (obj.Fields.ContainsKey("memory")) {
					result.Memory = Protobuf.ToDouble(obj.Fields["memory"]);
				}
				if (obj.Fields.ContainsKey("name")) {
					result.Name = Protobuf.ToString(obj.Fields["name"]);
				}
				if (obj.Fields.ContainsKey("port")) {
					result.Port = Protobuf.ToInt(obj.Fields["port"]);
				}
				if (obj.Fields.ContainsKey("ports")) {
					result.Ports = Protobuf.ToList(obj.Fields["ports"], item => GroupContainerPort.FromProtobuf(item));
				}
				if (obj.Fields.ContainsKey("protocol")) {
					result.Protocol = Protobuf.ToString(obj.Fields["protocol"]);
				}
				if (obj.Fields.ContainsKey("secure_environment_variables")) {
					result.SecureEnvironmentVariables = Protobuf.ToMap(obj.Fields["secure_environment_variables"]);
				}
				if (obj.Fields.ContainsKey("volume")) {
					result.Volume = Protobuf.ToList(obj.Fields["volume"], item => GroupContainerVolume.FromProtobuf(item));
				}
			return result;
		} // FromProtobuf

	} // GroupContainer

	public sealed class GroupImageRegistryCredential : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Password { get; set; }
		public Pulumi.IO<string> Server { get; set; }
		public Pulumi.IO<string> Username { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("password", Protobuf.ToProtobuf(Password)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("server", Protobuf.ToProtobuf(Server)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("username", Protobuf.ToProtobuf(Username)));
		} // ToProtobuf

		public static GroupImageRegistryCredential FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new GroupImageRegistryCredential();
				if (obj.Fields.ContainsKey("password")) {
					result.Password = Protobuf.ToString(obj.Fields["password"]);
				}
				if (obj.Fields.ContainsKey("server")) {
					result.Server = Protobuf.ToString(obj.Fields["server"]);
				}
				if (obj.Fields.ContainsKey("username")) {
					result.Username = Protobuf.ToString(obj.Fields["username"]);
				}
			return result;
		} // FromProtobuf

	} // GroupImageRegistryCredential

	/// <summary>
	/// The set of arguments for constructing a Group resource.
	/// </summary>
	public struct GroupArgs {
		/// <summary>
		/// The definition of a container that is part of the group as documented in the `container` block below. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<Pulumi.IO<GroupArgsContainer>[]> Containers { get; set; }

		/// <summary>
		/// The DNS label/name for the container groups IP.
		/// </summary>
		public Pulumi.IO<string> DnsNameLabel { get; set; }

		/// <summary>
		/// Set image registry credentials for the group as documented in the `image_registry_credential` block below
		/// </summary>
		public Pulumi.IO<Pulumi.IO<GroupArgsImageRegistryCredential>[]> ImageRegistryCredentials { get; set; }

		/// <summary>
		/// Specifies the ip address type of the container. `Public` is the only acceptable value at this time. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> IpAddressType { get; set; }

		/// <summary>
		/// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// Specifies the name of the Container Group. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The OS for the container group. Allowed values are `Linux` and `Windows`. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> OsType { get; set; }

		/// <summary>
		/// The name of the resource group in which to create the Container Group. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// Restart policy for the container group. Allowed values are `Always`, `Never`, `OnFailure`. Defaults to `Always`.
		/// </summary>
		public Pulumi.IO<string> RestartPolicy { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

	} // GroupArgs

	/// <summary>
	/// Manage as an Azure Container Group instance.
	/// </summary>
	public class Group : Pulumi.CustomResource {
		/// <summary>
		/// The definition of a container that is part of the group as documented in the `container` block below. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<GroupContainer[]> Containers { get; set; }

		/// <summary>
		/// The DNS label/name for the container groups IP.
		/// </summary>
		public Pulumi.IO<string> DnsNameLabel { get; set; }

		/// <summary>
		/// The FQDN of the container group derived from `dns_name_label`.
		/// </summary>
		public Pulumi.IO<string> Fqdn { get; set; }

		/// <summary>
		/// Set image registry credentials for the group as documented in the `image_registry_credential` block below
		/// </summary>
		public Pulumi.IO<GroupImageRegistryCredential[]> ImageRegistryCredentials { get; set; }

		/// <summary>
		/// The IP address allocated to the container group.
		/// </summary>
		public Pulumi.IO<string> IpAddress { get; set; }

		/// <summary>
		/// Specifies the ip address type of the container. `Public` is the only acceptable value at this time. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> IpAddressType { get; set; }

		/// <summary>
		/// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// Specifies the name of the Container Group. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The OS for the container group. Allowed values are `Linux` and `Windows`. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> OsType { get; set; }

		/// <summary>
		/// The name of the resource group in which to create the Container Group. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// Restart policy for the container group. Allowed values are `Always`, `Never`, `OnFailure`. Defaults to `Always`.
		/// </summary>
		public Pulumi.IO<string> RestartPolicy { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

		public Group(string name, GroupArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:containerservice/group:Group", name, SerialiseArgs(args), opts) {
			Containers = base.Outputs["containers"].Select(item => Protobuf.ToList(item, item1 => GroupContainer.FromProtobuf(item1)));
			DnsNameLabel = base.Outputs["dnsNameLabel"].Select(item => Protobuf.ToString(item));
			Fqdn = base.Outputs["fqdn"].Select(item => Protobuf.ToString(item));
			ImageRegistryCredentials = base.Outputs["imageRegistryCredentials"].Select(item => Protobuf.ToList(item, item1 => GroupImageRegistryCredential.FromProtobuf(item1)));
			IpAddress = base.Outputs["ipAddress"].Select(item => Protobuf.ToString(item));
			IpAddressType = base.Outputs["ipAddressType"].Select(item => Protobuf.ToString(item));
			Location = base.Outputs["location"].Select(item => Protobuf.ToString(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			OsType = base.Outputs["osType"].Select(item => Protobuf.ToString(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			RestartPolicy = base.Outputs["restartPolicy"].Select(item => Protobuf.ToString(item));
			Tags = base.Outputs["tags"].Select(item => Protobuf.ToMap(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(GroupArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["containers"] = Protobuf.ToProtobuf(args.Containers, item => Protobuf.ToProtobuf(item));
			props["dnsNameLabel"] = Protobuf.ToProtobuf(args.DnsNameLabel);
			props["imageRegistryCredentials"] = Protobuf.ToProtobuf(args.ImageRegistryCredentials, item => Protobuf.ToProtobuf(item));
			props["ipAddressType"] = Protobuf.ToProtobuf(args.IpAddressType);
			props["location"] = Protobuf.ToProtobuf(args.Location);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["osType"] = Protobuf.ToProtobuf(args.OsType);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["restartPolicy"] = Protobuf.ToProtobuf(args.RestartPolicy);
			props["tags"] = Protobuf.ToProtobuf(args.Tags);
			props["fqdn"] = null; //out
			props["ipAddress"] = null; //out
			return props;
		} // SerialiseArgs

	} // Group
} // Pulumi.Azure.Containerservice