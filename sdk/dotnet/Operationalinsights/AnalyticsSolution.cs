// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Operationalinsights {

	public sealed class AnalyticsSolutionArgsPlan : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Name { get; set; }
		public Pulumi.IO<string> Product { get; set; }
		public Pulumi.IO<string> PromotionCode { get; set; }
		public Pulumi.IO<string> Publisher { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("name", Protobuf.ToProtobuf(Name)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("product", Protobuf.ToProtobuf(Product)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("promotion_code", Protobuf.ToProtobuf(PromotionCode)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("publisher", Protobuf.ToProtobuf(Publisher)));
		} // ToProtobuf

	} // AnalyticsSolutionArgsPlan

	public sealed class AnalyticsSolutionPlan : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Name { get; set; }
		public Pulumi.IO<string> Product { get; set; }
		public Pulumi.IO<string> PromotionCode { get; set; }
		public Pulumi.IO<string> Publisher { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("name", Protobuf.ToProtobuf(Name)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("product", Protobuf.ToProtobuf(Product)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("promotion_code", Protobuf.ToProtobuf(PromotionCode)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("publisher", Protobuf.ToProtobuf(Publisher)));
		} // ToProtobuf

		public static AnalyticsSolutionPlan FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new AnalyticsSolutionPlan();
				if (obj.Fields.ContainsKey("name")) {
					result.Name = Protobuf.ToString(obj.Fields["name"]);
				}
				if (obj.Fields.ContainsKey("product")) {
					result.Product = Protobuf.ToString(obj.Fields["product"]);
				}
				if (obj.Fields.ContainsKey("promotion_code")) {
					result.PromotionCode = Protobuf.ToString(obj.Fields["promotion_code"]);
				}
				if (obj.Fields.ContainsKey("publisher")) {
					result.Publisher = Protobuf.ToString(obj.Fields["publisher"]);
				}
			return result;
		} // FromProtobuf

	} // AnalyticsSolutionPlan

	/// <summary>
	/// The set of arguments for constructing a AnalyticsSolution resource.
	/// </summary>
	public struct AnalyticsSolutionArgs {
		/// <summary>
		/// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// A `plan` block as documented below.
		/// </summary>
		public Pulumi.IO<AnalyticsSolutionArgsPlan> Plan { get; set; }

		/// <summary>
		/// The name of the resource group in which the Log Analytics solution is created. Changing this forces a new resource to be created. Note: The solution and it's related workspace can only exist in the same resource group.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// Specifies the name of the solution to be deployed. See [here for options](https://docs.microsoft.com/en-us/azure/log-analytics/log-analytics-add-solutions).Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> SolutionName { get; set; }

		/// <summary>
		/// The full name of the Log Analytics workspace with which the solution will be linked. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> WorkspaceName { get; set; }

		/// <summary>
		/// The full resource ID of the Log Analytics workspace with which the solution will be linked. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> WorkspaceResourceId { get; set; }

	} // AnalyticsSolutionArgs

	/// <summary>
	/// Manages a Log Analytics (formally Operational Insights) Solution.
	/// </summary>
	public class AnalyticsSolution : Pulumi.CustomResource {
		/// <summary>
		/// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// A `plan` block as documented below.
		/// </summary>
		public Pulumi.IO<AnalyticsSolutionPlan> Plan { get; set; }

		/// <summary>
		/// The name of the resource group in which the Log Analytics solution is created. Changing this forces a new resource to be created. Note: The solution and it's related workspace can only exist in the same resource group.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// Specifies the name of the solution to be deployed. See [here for options](https://docs.microsoft.com/en-us/azure/log-analytics/log-analytics-add-solutions).Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> SolutionName { get; set; }

		/// <summary>
		/// The full name of the Log Analytics workspace with which the solution will be linked. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> WorkspaceName { get; set; }

		/// <summary>
		/// The full resource ID of the Log Analytics workspace with which the solution will be linked. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> WorkspaceResourceId { get; set; }

		public AnalyticsSolution(string name, AnalyticsSolutionArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:operationalinsights/analyticsSolution:AnalyticsSolution", name, SerialiseArgs(args), opts) {
			Location = base.Outputs["location"].Select(item => Protobuf.ToString(item));
			Plan = base.Outputs["plan"].Select(item => AnalyticsSolutionPlan.FromProtobuf(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			SolutionName = base.Outputs["solutionName"].Select(item => Protobuf.ToString(item));
			WorkspaceName = base.Outputs["workspaceName"].Select(item => Protobuf.ToString(item));
			WorkspaceResourceId = base.Outputs["workspaceResourceId"].Select(item => Protobuf.ToString(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(AnalyticsSolutionArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["location"] = Protobuf.ToProtobuf(args.Location);
			props["plan"] = Protobuf.ToProtobuf(args.Plan);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["solutionName"] = Protobuf.ToProtobuf(args.SolutionName);
			props["workspaceName"] = Protobuf.ToProtobuf(args.WorkspaceName);
			props["workspaceResourceId"] = Protobuf.ToProtobuf(args.WorkspaceResourceId);
			return props;
		} // SerialiseArgs

	} // AnalyticsSolution
} // Pulumi.Azure.Operationalinsights