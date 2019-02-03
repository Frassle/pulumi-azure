// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Monitoring {

	public sealed class AlertRuleArgsEmailAction : Pulumi.IIOProtobuf {
		public Pulumi.IO<Pulumi.IO<string>[]> CustomEmails { get; set; }
		public Pulumi.IO<bool> SendToServiceOwners { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("custom_emails", Protobuf.ToProtobuf(CustomEmails, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("send_to_service_owners", Protobuf.ToProtobuf(SendToServiceOwners)));
		} // ToProtobuf

	} // AlertRuleArgsEmailAction

	public sealed class AlertRuleArgsWebhookAction : Pulumi.IIOProtobuf {
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Properties { get; set; }
		public Pulumi.IO<string> ServiceUri { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("properties", Protobuf.ToProtobuf(Properties)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("service_uri", Protobuf.ToProtobuf(ServiceUri)));
		} // ToProtobuf

	} // AlertRuleArgsWebhookAction

	public sealed class AlertRuleEmailAction : Pulumi.IIOProtobuf {
		public Pulumi.IO<string[]> CustomEmails { get; set; }
		public Pulumi.IO<bool> SendToServiceOwners { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("custom_emails", Protobuf.ToProtobuf(CustomEmails, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("send_to_service_owners", Protobuf.ToProtobuf(SendToServiceOwners)));
		} // ToProtobuf

		public static AlertRuleEmailAction FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new AlertRuleEmailAction();
				if (obj.Fields.ContainsKey("custom_emails")) {
					result.CustomEmails = Protobuf.ToList(obj.Fields["custom_emails"], item => Protobuf.ToString(item));
				}
				if (obj.Fields.ContainsKey("send_to_service_owners")) {
					result.SendToServiceOwners = Protobuf.ToBool(obj.Fields["send_to_service_owners"]);
				}
			return result;
		} // FromProtobuf

	} // AlertRuleEmailAction

	public sealed class AlertRuleWebhookAction : Pulumi.IIOProtobuf {
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Properties { get; set; }
		public Pulumi.IO<string> ServiceUri { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("properties", Protobuf.ToProtobuf(Properties)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("service_uri", Protobuf.ToProtobuf(ServiceUri)));
		} // ToProtobuf

		public static AlertRuleWebhookAction FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new AlertRuleWebhookAction();
				if (obj.Fields.ContainsKey("properties")) {
					result.Properties = Protobuf.ToMap(obj.Fields["properties"]);
				}
				if (obj.Fields.ContainsKey("service_uri")) {
					result.ServiceUri = Protobuf.ToString(obj.Fields["service_uri"]);
				}
			return result;
		} // FromProtobuf

	} // AlertRuleWebhookAction

	/// <summary>
	/// The set of arguments for constructing a AlertRule resource.
	/// </summary>
	public struct AlertRuleArgs {
		/// <summary>
		/// Defines how the metric data is combined over time. Possible values are `Average`, `Minimum`, `Maximum`, `Total`, and `Last`.
		/// </summary>
		public Pulumi.IO<string> Aggregation { get; set; }

		/// <summary>
		/// A verbose description of the alert rule that will be included in the alert email.
		/// </summary>
		public Pulumi.IO<string> Description { get; set; }

		/// <summary>
		/// A `email_action` block as defined below.
		/// </summary>
		public Pulumi.IO<AlertRuleArgsEmailAction> EmailAction { get; set; }

		/// <summary>
		/// If `true`, the alert rule is enabled. Defaults to `true`.
		/// </summary>
		public Pulumi.IO<bool> Enabled { get; set; }

		/// <summary>
		/// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// The metric that defines what the rule monitors.
		/// </summary>
		public Pulumi.IO<string> MetricName { get; set; }

		/// <summary>
		/// Specifies the name of the alert rule. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The operator used to compare the metric data and the threshold. Possible values are `GreaterThan`, `GreaterThanOrEqual`, `LessThan`, and `LessThanOrEqual`.
		/// </summary>
		public Pulumi.IO<string> Operator { get; set; }

		/// <summary>
		/// The period of time formatted in [ISO 8601 duration format](https://en.wikipedia.org/wiki/ISO_8601#Durations) that is used to monitor the alert activity based on the threshold. The period must be between 5 minutes and 1 day.
		/// </summary>
		public Pulumi.IO<string> Period { get; set; }

		/// <summary>
		/// The name of the resource group in which to create the alert rule. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// The ID of the resource monitored by the alert rule.
		/// </summary>
		public Pulumi.IO<string> ResourceId { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

		/// <summary>
		/// The threshold value that activates the alert.
		/// </summary>
		public Pulumi.IO<double> Threshold { get; set; }

		/// <summary>
		/// A `webhook_action` block as defined below.
		/// </summary>
		public Pulumi.IO<AlertRuleArgsWebhookAction> WebhookAction { get; set; }

	} // AlertRuleArgs

	/// <summary>
	/// Manages a [metric-based alert rule](https://docs.microsoft.com/en-us/azure/monitoring-and-diagnostics/monitor-quick-resource-metric-alert-portal) in Azure Monitor.
	/// </summary>
	public class AlertRule : Pulumi.CustomResource {
		/// <summary>
		/// Defines how the metric data is combined over time. Possible values are `Average`, `Minimum`, `Maximum`, `Total`, and `Last`.
		/// </summary>
		public Pulumi.IO<string> Aggregation { get; set; }

		/// <summary>
		/// A verbose description of the alert rule that will be included in the alert email.
		/// </summary>
		public Pulumi.IO<string> Description { get; set; }

		/// <summary>
		/// A `email_action` block as defined below.
		/// </summary>
		public Pulumi.IO<AlertRuleEmailAction> EmailAction { get; set; }

		/// <summary>
		/// If `true`, the alert rule is enabled. Defaults to `true`.
		/// </summary>
		public Pulumi.IO<bool> Enabled { get; set; }

		/// <summary>
		/// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// The metric that defines what the rule monitors.
		/// </summary>
		public Pulumi.IO<string> MetricName { get; set; }

		/// <summary>
		/// Specifies the name of the alert rule. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The operator used to compare the metric data and the threshold. Possible values are `GreaterThan`, `GreaterThanOrEqual`, `LessThan`, and `LessThanOrEqual`.
		/// </summary>
		public Pulumi.IO<string> Operator { get; set; }

		/// <summary>
		/// The period of time formatted in [ISO 8601 duration format](https://en.wikipedia.org/wiki/ISO_8601#Durations) that is used to monitor the alert activity based on the threshold. The period must be between 5 minutes and 1 day.
		/// </summary>
		public Pulumi.IO<string> Period { get; set; }

		/// <summary>
		/// The name of the resource group in which to create the alert rule. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// The ID of the resource monitored by the alert rule.
		/// </summary>
		public Pulumi.IO<string> ResourceId { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

		/// <summary>
		/// The threshold value that activates the alert.
		/// </summary>
		public Pulumi.IO<double> Threshold { get; set; }

		/// <summary>
		/// A `webhook_action` block as defined below.
		/// </summary>
		public Pulumi.IO<AlertRuleWebhookAction> WebhookAction { get; set; }

		public AlertRule(string name, AlertRuleArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:monitoring/alertRule:AlertRule", name, SerialiseArgs(args), opts) {
			Aggregation = base.Outputs["aggregation"].Select(item => Protobuf.ToString(item));
			Description = base.Outputs["description"].Select(item => Protobuf.ToString(item));
			EmailAction = base.Outputs["emailAction"].Select(item => AlertRuleEmailAction.FromProtobuf(item));
			Enabled = base.Outputs["enabled"].Select(item => Protobuf.ToBool(item));
			Location = base.Outputs["location"].Select(item => Protobuf.ToString(item));
			MetricName = base.Outputs["metricName"].Select(item => Protobuf.ToString(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			Operator = base.Outputs["operator"].Select(item => Protobuf.ToString(item));
			Period = base.Outputs["period"].Select(item => Protobuf.ToString(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			ResourceId = base.Outputs["resourceId"].Select(item => Protobuf.ToString(item));
			Tags = base.Outputs["tags"].Select(item => Protobuf.ToMap(item));
			Threshold = base.Outputs["threshold"].Select(item => Protobuf.ToDouble(item));
			WebhookAction = base.Outputs["webhookAction"].Select(item => AlertRuleWebhookAction.FromProtobuf(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(AlertRuleArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["aggregation"] = Protobuf.ToProtobuf(args.Aggregation);
			props["description"] = Protobuf.ToProtobuf(args.Description);
			props["emailAction"] = Protobuf.ToProtobuf(args.EmailAction);
			props["enabled"] = Protobuf.ToProtobuf(args.Enabled);
			props["location"] = Protobuf.ToProtobuf(args.Location);
			props["metricName"] = Protobuf.ToProtobuf(args.MetricName);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["operator"] = Protobuf.ToProtobuf(args.Operator);
			props["period"] = Protobuf.ToProtobuf(args.Period);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["resourceId"] = Protobuf.ToProtobuf(args.ResourceId);
			props["tags"] = Protobuf.ToProtobuf(args.Tags);
			props["threshold"] = Protobuf.ToProtobuf(args.Threshold);
			props["webhookAction"] = Protobuf.ToProtobuf(args.WebhookAction);
			return props;
		} // SerialiseArgs

	} // AlertRule
} // Pulumi.Azure.Monitoring
