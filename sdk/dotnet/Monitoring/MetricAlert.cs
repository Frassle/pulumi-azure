// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Monitoring {

	public sealed class MetricAlertArgsAction : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> ActionGroupId { get; set; }
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> WebhookProperties { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("action_group_id", Protobuf.ToProtobuf(ActionGroupId)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("webhook_properties", Protobuf.ToProtobuf(WebhookProperties)));
		} // ToProtobuf

	} // MetricAlertArgsAction

	public sealed class MetricAlertArgsCriteriaArgsDimension : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Name { get; set; }
		public Pulumi.IO<string> Operator { get; set; }
		public Pulumi.IO<Pulumi.IO<string>[]> Values { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("name", Protobuf.ToProtobuf(Name)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("operator", Protobuf.ToProtobuf(Operator)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("values", Protobuf.ToProtobuf(Values, item => Protobuf.ToProtobuf(item))));
		} // ToProtobuf

	} // MetricAlertArgsCriteriaArgsDimension

	public sealed class MetricAlertArgsCriteria : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Aggregation { get; set; }
		public Pulumi.IO<Pulumi.IO<MetricAlertArgsCriteriaArgsDimension>[]> Dimension { get; set; }
		public Pulumi.IO<string> MetricName { get; set; }
		public Pulumi.IO<string> MetricNamespace { get; set; }
		public Pulumi.IO<string> Operator { get; set; }
		public Pulumi.IO<double> Threshold { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("aggregation", Protobuf.ToProtobuf(Aggregation)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("dimension", Protobuf.ToProtobuf(Dimension, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("metric_name", Protobuf.ToProtobuf(MetricName)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("metric_namespace", Protobuf.ToProtobuf(MetricNamespace)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("operator", Protobuf.ToProtobuf(Operator)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("threshold", Protobuf.ToProtobuf(Threshold)));
		} // ToProtobuf

	} // MetricAlertArgsCriteria

	public sealed class MetricAlertAction : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> ActionGroupId { get; set; }
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> WebhookProperties { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("action_group_id", Protobuf.ToProtobuf(ActionGroupId)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("webhook_properties", Protobuf.ToProtobuf(WebhookProperties)));
		} // ToProtobuf

		public static MetricAlertAction FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new MetricAlertAction();
				if (obj.Fields.ContainsKey("action_group_id")) {
					result.ActionGroupId = Protobuf.ToString(obj.Fields["action_group_id"]);
				}
				if (obj.Fields.ContainsKey("webhook_properties")) {
					result.WebhookProperties = Protobuf.ToMap(obj.Fields["webhook_properties"]);
				}
			return result;
		} // FromProtobuf

	} // MetricAlertAction

	public sealed class MetricAlertCriteriaDimension : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Name { get; set; }
		public Pulumi.IO<string> Operator { get; set; }
		public Pulumi.IO<string[]> Values { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("name", Protobuf.ToProtobuf(Name)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("operator", Protobuf.ToProtobuf(Operator)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("values", Protobuf.ToProtobuf(Values, item => Protobuf.ToProtobuf(item))));
		} // ToProtobuf

		public static MetricAlertCriteriaDimension FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new MetricAlertCriteriaDimension();
				if (obj.Fields.ContainsKey("name")) {
					result.Name = Protobuf.ToString(obj.Fields["name"]);
				}
				if (obj.Fields.ContainsKey("operator")) {
					result.Operator = Protobuf.ToString(obj.Fields["operator"]);
				}
				if (obj.Fields.ContainsKey("values")) {
					result.Values = Protobuf.ToList(obj.Fields["values"], item => Protobuf.ToString(item));
				}
			return result;
		} // FromProtobuf

	} // MetricAlertCriteriaDimension

	public sealed class MetricAlertCriteria : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Aggregation { get; set; }
		public Pulumi.IO<MetricAlertCriteriaDimension[]> Dimension { get; set; }
		public Pulumi.IO<string> MetricName { get; set; }
		public Pulumi.IO<string> MetricNamespace { get; set; }
		public Pulumi.IO<string> Operator { get; set; }
		public Pulumi.IO<double> Threshold { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("aggregation", Protobuf.ToProtobuf(Aggregation)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("dimension", Protobuf.ToProtobuf(Dimension, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("metric_name", Protobuf.ToProtobuf(MetricName)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("metric_namespace", Protobuf.ToProtobuf(MetricNamespace)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("operator", Protobuf.ToProtobuf(Operator)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("threshold", Protobuf.ToProtobuf(Threshold)));
		} // ToProtobuf

		public static MetricAlertCriteria FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new MetricAlertCriteria();
				if (obj.Fields.ContainsKey("aggregation")) {
					result.Aggregation = Protobuf.ToString(obj.Fields["aggregation"]);
				}
				if (obj.Fields.ContainsKey("dimension")) {
					result.Dimension = Protobuf.ToList(obj.Fields["dimension"], item => MetricAlertCriteriaDimension.FromProtobuf(item));
				}
				if (obj.Fields.ContainsKey("metric_name")) {
					result.MetricName = Protobuf.ToString(obj.Fields["metric_name"]);
				}
				if (obj.Fields.ContainsKey("metric_namespace")) {
					result.MetricNamespace = Protobuf.ToString(obj.Fields["metric_namespace"]);
				}
				if (obj.Fields.ContainsKey("operator")) {
					result.Operator = Protobuf.ToString(obj.Fields["operator"]);
				}
				if (obj.Fields.ContainsKey("threshold")) {
					result.Threshold = Protobuf.ToDouble(obj.Fields["threshold"]);
				}
			return result;
		} // FromProtobuf

	} // MetricAlertCriteria

	/// <summary>
	/// The set of arguments for constructing a MetricAlert resource.
	/// </summary>
	public struct MetricAlertArgs {
		public Pulumi.IO<Pulumi.IO<MetricAlertArgsAction>[]> Actions { get; set; }

		public Pulumi.IO<bool> AutoMitigate { get; set; }

		public Pulumi.IO<Pulumi.IO<MetricAlertArgsCriteria>[]> Criterias { get; set; }

		public Pulumi.IO<string> Description { get; set; }

		public Pulumi.IO<bool> Enabled { get; set; }

		public Pulumi.IO<string> Frequency { get; set; }

		public Pulumi.IO<string> Name { get; set; }

		public Pulumi.IO<string> ResourceGroupName { get; set; }

		public Pulumi.IO<string> Scopes { get; set; }

		public Pulumi.IO<int> Severity { get; set; }

		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

		public Pulumi.IO<string> WindowSize { get; set; }

	} // MetricAlertArgs

	public class MetricAlert : Pulumi.CustomResource {
		public Pulumi.IO<MetricAlertAction[]> Actions { get; set; }

		public Pulumi.IO<bool> AutoMitigate { get; set; }

		public Pulumi.IO<MetricAlertCriteria[]> Criterias { get; set; }

		public Pulumi.IO<string> Description { get; set; }

		public Pulumi.IO<bool> Enabled { get; set; }

		public Pulumi.IO<string> Frequency { get; set; }

		public Pulumi.IO<string> Name { get; set; }

		public Pulumi.IO<string> ResourceGroupName { get; set; }

		public Pulumi.IO<string> Scopes { get; set; }

		public Pulumi.IO<int> Severity { get; set; }

		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

		public Pulumi.IO<string> WindowSize { get; set; }

		public MetricAlert(string name, MetricAlertArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:monitoring/metricAlert:MetricAlert", name, SerialiseArgs(args), opts) {
			Actions = base.Outputs["actions"].Select(item => Protobuf.ToList(item, item1 => MetricAlertAction.FromProtobuf(item1)));
			AutoMitigate = base.Outputs["autoMitigate"].Select(item => Protobuf.ToBool(item));
			Criterias = base.Outputs["criterias"].Select(item => Protobuf.ToList(item, item1 => MetricAlertCriteria.FromProtobuf(item1)));
			Description = base.Outputs["description"].Select(item => Protobuf.ToString(item));
			Enabled = base.Outputs["enabled"].Select(item => Protobuf.ToBool(item));
			Frequency = base.Outputs["frequency"].Select(item => Protobuf.ToString(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			Scopes = base.Outputs["scopes"].Select(item => Protobuf.ToString(item));
			Severity = base.Outputs["severity"].Select(item => Protobuf.ToInt(item));
			Tags = base.Outputs["tags"].Select(item => Protobuf.ToMap(item));
			WindowSize = base.Outputs["windowSize"].Select(item => Protobuf.ToString(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(MetricAlertArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["actions"] = Protobuf.ToProtobuf(args.Actions, item => Protobuf.ToProtobuf(item));
			props["autoMitigate"] = Protobuf.ToProtobuf(args.AutoMitigate);
			props["criterias"] = Protobuf.ToProtobuf(args.Criterias, item => Protobuf.ToProtobuf(item));
			props["description"] = Protobuf.ToProtobuf(args.Description);
			props["enabled"] = Protobuf.ToProtobuf(args.Enabled);
			props["frequency"] = Protobuf.ToProtobuf(args.Frequency);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["scopes"] = Protobuf.ToProtobuf(args.Scopes);
			props["severity"] = Protobuf.ToProtobuf(args.Severity);
			props["tags"] = Protobuf.ToProtobuf(args.Tags);
			props["windowSize"] = Protobuf.ToProtobuf(args.WindowSize);
			return props;
		} // SerialiseArgs

	} // MetricAlert
} // Pulumi.Azure.Monitoring
