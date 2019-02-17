// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Logicapps {

	/// <summary>
	/// The set of arguments for constructing a Workflow resource.
	/// </summary>
	public struct WorkflowArgs {
		/// <summary>
		/// Specifies the supported Azure location where the Logic App Workflow exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// Specifies the name of the Logic App Workflow. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// A map of Key-Value pairs.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Parameters { get; set; }

		/// <summary>
		/// The name of the Resource Group in which the Logic App Workflow should be created. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

		/// <summary>
		/// Specifies the Schema to use for this Logic App Workflow. Defaults to `https://schema.management.azure.com/providers/Microsoft.Logic/schemas/2016-06-01/workflowdefinition.json#`. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> WorkflowSchema { get; set; }

		/// <summary>
		/// Specifies the version of the Schema used for this Logic App Workflow. Defaults to `1.0.0.0`. Changing this forces a new resource to be create.d
		/// </summary>
		public Pulumi.IO<string> WorkflowVersion { get; set; }

	} // WorkflowArgs

	/// <summary>
	/// Manages a Logic App Workflow.
	/// </summary>
	public class Workflow : Pulumi.CustomResource {
		/// <summary>
		/// The Access Endpoint for the Logic App Workflow
		/// </summary>
		public Pulumi.IO<string> AccessEndpoint { get; set; }

		/// <summary>
		/// Specifies the supported Azure location where the Logic App Workflow exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// Specifies the name of the Logic App Workflow. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// A map of Key-Value pairs.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Parameters { get; set; }

		/// <summary>
		/// The name of the Resource Group in which the Logic App Workflow should be created. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

		/// <summary>
		/// Specifies the Schema to use for this Logic App Workflow. Defaults to `https://schema.management.azure.com/providers/Microsoft.Logic/schemas/2016-06-01/workflowdefinition.json#`. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> WorkflowSchema { get; set; }

		/// <summary>
		/// Specifies the version of the Schema used for this Logic App Workflow. Defaults to `1.0.0.0`. Changing this forces a new resource to be create.d
		/// </summary>
		public Pulumi.IO<string> WorkflowVersion { get; set; }

		public Workflow(string name, WorkflowArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:logicapps/workflow:Workflow", name, SerialiseArgs(args), opts) {
			AccessEndpoint = base.Outputs["accessEndpoint"].Select(item => Protobuf.ToString(item));
			Location = base.Outputs["location"].Select(item => Protobuf.ToString(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			Parameters = base.Outputs["parameters"].Select(item => Protobuf.ToMap(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			Tags = base.Outputs["tags"].Select(item => Protobuf.ToMap(item));
			WorkflowSchema = base.Outputs["workflowSchema"].Select(item => Protobuf.ToString(item));
			WorkflowVersion = base.Outputs["workflowVersion"].Select(item => Protobuf.ToString(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(WorkflowArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["location"] = Protobuf.ToProtobuf(args.Location);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["parameters"] = Protobuf.ToProtobuf(args.Parameters);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["tags"] = Protobuf.ToProtobuf(args.Tags);
			props["workflowSchema"] = Protobuf.ToProtobuf(args.WorkflowSchema);
			props["workflowVersion"] = Protobuf.ToProtobuf(args.WorkflowVersion);
			props["accessEndpoint"] = null; //out
			return props;
		} // SerialiseArgs

	} // Workflow
} // Pulumi.Azure.Logicapps