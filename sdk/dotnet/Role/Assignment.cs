// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Role {

	/// <summary>
	/// The set of arguments for constructing a Assignment resource.
	/// </summary>
	public struct AssignmentArgs {
		/// <summary>
		/// A unique UUID/GUID for this Role Assignment - one will be generated if not specified. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The ID of the Principal (User or Application) to assign the Role Definition to. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> PrincipalId { get; set; }

		/// <summary>
		/// The Scoped-ID of the Role Definition. Changing this forces a new resource to be created. Conflicts with `role_definition_name`.
		/// </summary>
		public Pulumi.IO<string> RoleDefinitionId { get; set; }

		/// <summary>
		/// The name of a built-in Role. Changing this forces a new resource to be created. Conflicts with `role_definition_id`.
		/// </summary>
		public Pulumi.IO<string> RoleDefinitionName { get; set; }

		/// <summary>
		/// The scope at which the Role Assignment applies too, such as `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333`, `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup`, or `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM`. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Scope { get; set; }

	} // AssignmentArgs

	/// <summary>
	/// Assigns a given Principal (User or Application) to a given Role.
	/// </summary>
	public class Assignment : Pulumi.CustomResource {
		/// <summary>
		/// A unique UUID/GUID for this Role Assignment - one will be generated if not specified. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The ID of the Principal (User or Application) to assign the Role Definition to. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> PrincipalId { get; set; }

		/// <summary>
		/// The Scoped-ID of the Role Definition. Changing this forces a new resource to be created. Conflicts with `role_definition_name`.
		/// </summary>
		public Pulumi.IO<string> RoleDefinitionId { get; set; }

		/// <summary>
		/// The name of a built-in Role. Changing this forces a new resource to be created. Conflicts with `role_definition_id`.
		/// </summary>
		public Pulumi.IO<string> RoleDefinitionName { get; set; }

		/// <summary>
		/// The scope at which the Role Assignment applies too, such as `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333`, `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup`, or `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM`. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Scope { get; set; }

		public Assignment(string name, AssignmentArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:role/assignment:Assignment", name, SerialiseArgs(args), opts) {
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			PrincipalId = base.Outputs["principalId"].Select(item => Protobuf.ToString(item));
			RoleDefinitionId = base.Outputs["roleDefinitionId"].Select(item => Protobuf.ToString(item));
			RoleDefinitionName = base.Outputs["roleDefinitionName"].Select(item => Protobuf.ToString(item));
			Scope = base.Outputs["scope"].Select(item => Protobuf.ToString(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(AssignmentArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["principalId"] = Protobuf.ToProtobuf(args.PrincipalId);
			props["roleDefinitionId"] = Protobuf.ToProtobuf(args.RoleDefinitionId);
			props["roleDefinitionName"] = Protobuf.ToProtobuf(args.RoleDefinitionName);
			props["scope"] = Protobuf.ToProtobuf(args.Scope);
			return props;
		} // SerialiseArgs

	} // Assignment
} // Pulumi.Azure.Role
