// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Manage a ServiceBus Subscription Rule.
 * 
 * ## Example Usage (SQL Filter)
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const azurerm_resource_group_example = new azure.core.ResourceGroup("example", {
 *     location: "West Europe",
 *     name: "tfex-servicebus-subscription-rule-sql",
 * });
 * const azurerm_servicebus_namespace_example = new azure.eventhub.Namespace("example", {
 *     location: azurerm_resource_group_example.location,
 *     name: "tfex_sevicebus_namespace",
 *     resourceGroupName: azurerm_resource_group_example.name,
 *     sku: "Standard",
 *     tags: {
 *         source: "terraform",
 *     },
 * });
 * const azurerm_servicebus_topic_example = new azure.eventhub.Topic("example", {
 *     enablePartitioning: true,
 *     name: "tfex_sevicebus_topic",
 *     namespaceName: azurerm_servicebus_namespace_example.name,
 *     resourceGroupName: azurerm_resource_group_example.name,
 * });
 * const azurerm_servicebus_subscription_example = new azure.eventhub.Subscription("example", {
 *     maxDeliveryCount: 1,
 *     name: "tfex_sevicebus_subscription",
 *     namespaceName: azurerm_servicebus_namespace_example.name,
 *     resourceGroupName: azurerm_resource_group_example.name,
 *     topicName: azurerm_servicebus_topic_example.name,
 * });
 * const azurerm_servicebus_subscription_rule_example = new azure.eventhub.SubscriptionRule("example", {
 *     filterType: "SqlFilter",
 *     name: "tfex_sevicebus_rule",
 *     namespaceName: azurerm_servicebus_namespace_example.name,
 *     resourceGroupName: azurerm_resource_group_example.name,
 *     sqlFilter: "color = 'red'",
 *     subscriptionName: azurerm_servicebus_subscription_example.name,
 *     topicName: azurerm_servicebus_topic_example.name,
 * });
 * ```
 * 
 * ## Example Usage (Correlation Filter)
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const azurerm_resource_group_example = new azure.core.ResourceGroup("example", {
 *     location: "West Europe",
 *     name: "tfex-servicebus-subscription-rule-cor",
 * });
 * const azurerm_servicebus_namespace_example = new azure.eventhub.Namespace("example", {
 *     location: azurerm_resource_group_example.location,
 *     name: "tfex_sevicebus_namespace",
 *     resourceGroupName: azurerm_resource_group_example.name,
 *     sku: "Standard",
 *     tags: {
 *         source: "terraform",
 *     },
 * });
 * const azurerm_servicebus_topic_example = new azure.eventhub.Topic("example", {
 *     enablePartitioning: true,
 *     name: "tfex_sevicebus_topic",
 *     namespaceName: azurerm_servicebus_namespace_example.name,
 *     resourceGroupName: azurerm_resource_group_example.name,
 * });
 * const azurerm_servicebus_subscription_example = new azure.eventhub.Subscription("example", {
 *     maxDeliveryCount: 1,
 *     name: "tfex_sevicebus_subscription",
 *     namespaceName: azurerm_servicebus_namespace_example.name,
 *     resourceGroupName: azurerm_resource_group_example.name,
 *     topicName: azurerm_servicebus_topic_example.name,
 * });
 * const azurerm_servicebus_subscription_rule_example = new azure.eventhub.SubscriptionRule("example", {
 *     correlationFilter: {
 *         correlationId: "high",
 *         label: "red",
 *     },
 *     filterType: "CorrelationFilter",
 *     name: "tfex_sevicebus_rule",
 *     namespaceName: azurerm_servicebus_namespace_example.name,
 *     resourceGroupName: azurerm_resource_group_example.name,
 *     subscriptionName: azurerm_servicebus_subscription_example.name,
 *     topicName: azurerm_servicebus_topic_example.name,
 * });
 * ```
 */
export class SubscriptionRule extends pulumi.CustomResource {
    /**
     * Get an existing SubscriptionRule resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SubscriptionRuleState, opts?: pulumi.CustomResourceOptions): SubscriptionRule {
        return new SubscriptionRule(name, <any>state, { ...opts, id: id });
    }

    /**
     * Represents set of actions written in SQL language-based syntax that is performed against a BrokeredMessage.
     */
    public readonly action: pulumi.Output<string | undefined>;
    /**
     * A `correlation_filter` block as documented below to be evaluated against a BrokeredMessage. Required when `filter_type` is set to `CorrelationFilter`.
     */
    public readonly correlationFilter: pulumi.Output<{ contentType?: string, correlationId?: string, label?: string, messageId?: string, replyTo?: string, replyToSessionId?: string, sessionId?: string, to?: string } | undefined>;
    /**
     * Type of filter to be applied to a BrokeredMessage. Possible values are `SqlFilter` and `CorrelationFilter`.
     */
    public readonly filterType: pulumi.Output<string>;
    /**
     * Specifies the name of the ServiceBus Subscription Rule. Changing this forces a new resource to be created.
     */
    public readonly name: pulumi.Output<string>;
    /**
     * The name of the ServiceBus Namespace in which the ServiceBus Topic exists. Changing this forces a new resource to be created.
     */
    public readonly namespaceName: pulumi.Output<string>;
    /**
     * The name of the resource group in the ServiceBus Namespace exists. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName: pulumi.Output<string>;
    /**
     * Represents a filter written in SQL language-based syntax that to be evaluated against a BrokeredMessage. Required when `filter_type` is set to `SqlFilter`.
     */
    public readonly sqlFilter: pulumi.Output<string | undefined>;
    /**
     * The name of the ServiceBus Subscription in which this Rule should be created. Changing this forces a new resource to be created.
     */
    public readonly subscriptionName: pulumi.Output<string>;
    /**
     * The name of the ServiceBus Topic in which the ServiceBus Subscription exists. Changing this forces a new resource to be created.
     */
    public readonly topicName: pulumi.Output<string>;

    /**
     * Create a SubscriptionRule resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SubscriptionRuleArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SubscriptionRuleArgs | SubscriptionRuleState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: SubscriptionRuleState = argsOrState as SubscriptionRuleState | undefined;
            inputs["action"] = state ? state.action : undefined;
            inputs["correlationFilter"] = state ? state.correlationFilter : undefined;
            inputs["filterType"] = state ? state.filterType : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["namespaceName"] = state ? state.namespaceName : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["sqlFilter"] = state ? state.sqlFilter : undefined;
            inputs["subscriptionName"] = state ? state.subscriptionName : undefined;
            inputs["topicName"] = state ? state.topicName : undefined;
        } else {
            const args = argsOrState as SubscriptionRuleArgs | undefined;
            if (!args || args.filterType === undefined) {
                throw new Error("Missing required property 'filterType'");
            }
            if (!args || args.namespaceName === undefined) {
                throw new Error("Missing required property 'namespaceName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.subscriptionName === undefined) {
                throw new Error("Missing required property 'subscriptionName'");
            }
            if (!args || args.topicName === undefined) {
                throw new Error("Missing required property 'topicName'");
            }
            inputs["action"] = args ? args.action : undefined;
            inputs["correlationFilter"] = args ? args.correlationFilter : undefined;
            inputs["filterType"] = args ? args.filterType : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["namespaceName"] = args ? args.namespaceName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sqlFilter"] = args ? args.sqlFilter : undefined;
            inputs["subscriptionName"] = args ? args.subscriptionName : undefined;
            inputs["topicName"] = args ? args.topicName : undefined;
        }
        super("azure:eventhub/subscriptionRule:SubscriptionRule", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering SubscriptionRule resources.
 */
export interface SubscriptionRuleState {
    /**
     * Represents set of actions written in SQL language-based syntax that is performed against a BrokeredMessage.
     */
    readonly action?: pulumi.Input<string>;
    /**
     * A `correlation_filter` block as documented below to be evaluated against a BrokeredMessage. Required when `filter_type` is set to `CorrelationFilter`.
     */
    readonly correlationFilter?: pulumi.Input<{ contentType?: pulumi.Input<string>, correlationId?: pulumi.Input<string>, label?: pulumi.Input<string>, messageId?: pulumi.Input<string>, replyTo?: pulumi.Input<string>, replyToSessionId?: pulumi.Input<string>, sessionId?: pulumi.Input<string>, to?: pulumi.Input<string> }>;
    /**
     * Type of filter to be applied to a BrokeredMessage. Possible values are `SqlFilter` and `CorrelationFilter`.
     */
    readonly filterType?: pulumi.Input<string>;
    /**
     * Specifies the name of the ServiceBus Subscription Rule. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the ServiceBus Namespace in which the ServiceBus Topic exists. Changing this forces a new resource to be created.
     */
    readonly namespaceName?: pulumi.Input<string>;
    /**
     * The name of the resource group in the ServiceBus Namespace exists. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * Represents a filter written in SQL language-based syntax that to be evaluated against a BrokeredMessage. Required when `filter_type` is set to `SqlFilter`.
     */
    readonly sqlFilter?: pulumi.Input<string>;
    /**
     * The name of the ServiceBus Subscription in which this Rule should be created. Changing this forces a new resource to be created.
     */
    readonly subscriptionName?: pulumi.Input<string>;
    /**
     * The name of the ServiceBus Topic in which the ServiceBus Subscription exists. Changing this forces a new resource to be created.
     */
    readonly topicName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a SubscriptionRule resource.
 */
export interface SubscriptionRuleArgs {
    /**
     * Represents set of actions written in SQL language-based syntax that is performed against a BrokeredMessage.
     */
    readonly action?: pulumi.Input<string>;
    /**
     * A `correlation_filter` block as documented below to be evaluated against a BrokeredMessage. Required when `filter_type` is set to `CorrelationFilter`.
     */
    readonly correlationFilter?: pulumi.Input<{ contentType?: pulumi.Input<string>, correlationId?: pulumi.Input<string>, label?: pulumi.Input<string>, messageId?: pulumi.Input<string>, replyTo?: pulumi.Input<string>, replyToSessionId?: pulumi.Input<string>, sessionId?: pulumi.Input<string>, to?: pulumi.Input<string> }>;
    /**
     * Type of filter to be applied to a BrokeredMessage. Possible values are `SqlFilter` and `CorrelationFilter`.
     */
    readonly filterType: pulumi.Input<string>;
    /**
     * Specifies the name of the ServiceBus Subscription Rule. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the ServiceBus Namespace in which the ServiceBus Topic exists. Changing this forces a new resource to be created.
     */
    readonly namespaceName: pulumi.Input<string>;
    /**
     * The name of the resource group in the ServiceBus Namespace exists. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Represents a filter written in SQL language-based syntax that to be evaluated against a BrokeredMessage. Required when `filter_type` is set to `SqlFilter`.
     */
    readonly sqlFilter?: pulumi.Input<string>;
    /**
     * The name of the ServiceBus Subscription in which this Rule should be created. Changing this forces a new resource to be created.
     */
    readonly subscriptionName: pulumi.Input<string>;
    /**
     * The name of the ServiceBus Topic in which the ServiceBus Subscription exists. Changing this forces a new resource to be created.
     */
    readonly topicName: pulumi.Input<string>;
}
