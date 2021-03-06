// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export class MetricAlert extends pulumi.CustomResource {
    /**
     * Get an existing MetricAlert resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: MetricAlertState, opts?: pulumi.CustomResourceOptions): MetricAlert {
        return new MetricAlert(name, <any>state, { ...opts, id: id });
    }

    public readonly actions: pulumi.Output<{ actionGroupId: string, webhookProperties?: {[key: string]: string} }[] | undefined>;
    public readonly autoMitigate: pulumi.Output<boolean | undefined>;
    public readonly criterias: pulumi.Output<{ aggregation: string, dimensions?: { name: string, operator: string, values: string[] }[], metricName: string, metricNamespace: string, operator: string, threshold: number }[]>;
    public readonly description: pulumi.Output<string | undefined>;
    public readonly enabled: pulumi.Output<boolean | undefined>;
    public readonly frequency: pulumi.Output<string | undefined>;
    public readonly name: pulumi.Output<string>;
    public readonly resourceGroupName: pulumi.Output<string>;
    public readonly scopes: pulumi.Output<string>;
    public readonly severity: pulumi.Output<number | undefined>;
    public readonly tags: pulumi.Output<{[key: string]: any}>;
    public readonly windowSize: pulumi.Output<string | undefined>;

    /**
     * Create a MetricAlert resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: MetricAlertArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: MetricAlertArgs | MetricAlertState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: MetricAlertState = argsOrState as MetricAlertState | undefined;
            inputs["actions"] = state ? state.actions : undefined;
            inputs["autoMitigate"] = state ? state.autoMitigate : undefined;
            inputs["criterias"] = state ? state.criterias : undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["enabled"] = state ? state.enabled : undefined;
            inputs["frequency"] = state ? state.frequency : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["scopes"] = state ? state.scopes : undefined;
            inputs["severity"] = state ? state.severity : undefined;
            inputs["tags"] = state ? state.tags : undefined;
            inputs["windowSize"] = state ? state.windowSize : undefined;
        } else {
            const args = argsOrState as MetricAlertArgs | undefined;
            if (!args || args.criterias === undefined) {
                throw new Error("Missing required property 'criterias'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.scopes === undefined) {
                throw new Error("Missing required property 'scopes'");
            }
            inputs["actions"] = args ? args.actions : undefined;
            inputs["autoMitigate"] = args ? args.autoMitigate : undefined;
            inputs["criterias"] = args ? args.criterias : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["enabled"] = args ? args.enabled : undefined;
            inputs["frequency"] = args ? args.frequency : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["scopes"] = args ? args.scopes : undefined;
            inputs["severity"] = args ? args.severity : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["windowSize"] = args ? args.windowSize : undefined;
        }
        super("azure:monitoring/metricAlert:MetricAlert", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering MetricAlert resources.
 */
export interface MetricAlertState {
    readonly actions?: pulumi.Input<pulumi.Input<{ actionGroupId: pulumi.Input<string>, webhookProperties?: pulumi.Input<{[key: string]: pulumi.Input<string>}> }>[]>;
    readonly autoMitigate?: pulumi.Input<boolean>;
    readonly criterias?: pulumi.Input<pulumi.Input<{ aggregation: pulumi.Input<string>, dimensions?: pulumi.Input<pulumi.Input<{ name: pulumi.Input<string>, operator: pulumi.Input<string>, values: pulumi.Input<pulumi.Input<string>[]> }>[]>, metricName: pulumi.Input<string>, metricNamespace: pulumi.Input<string>, operator: pulumi.Input<string>, threshold: pulumi.Input<number> }>[]>;
    readonly description?: pulumi.Input<string>;
    readonly enabled?: pulumi.Input<boolean>;
    readonly frequency?: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    readonly resourceGroupName?: pulumi.Input<string>;
    readonly scopes?: pulumi.Input<string>;
    readonly severity?: pulumi.Input<number>;
    readonly tags?: pulumi.Input<{[key: string]: any}>;
    readonly windowSize?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a MetricAlert resource.
 */
export interface MetricAlertArgs {
    readonly actions?: pulumi.Input<pulumi.Input<{ actionGroupId: pulumi.Input<string>, webhookProperties?: pulumi.Input<{[key: string]: pulumi.Input<string>}> }>[]>;
    readonly autoMitigate?: pulumi.Input<boolean>;
    readonly criterias: pulumi.Input<pulumi.Input<{ aggregation: pulumi.Input<string>, dimensions?: pulumi.Input<pulumi.Input<{ name: pulumi.Input<string>, operator: pulumi.Input<string>, values: pulumi.Input<pulumi.Input<string>[]> }>[]>, metricName: pulumi.Input<string>, metricNamespace: pulumi.Input<string>, operator: pulumi.Input<string>, threshold: pulumi.Input<number> }>[]>;
    readonly description?: pulumi.Input<string>;
    readonly enabled?: pulumi.Input<boolean>;
    readonly frequency?: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    readonly resourceGroupName: pulumi.Input<string>;
    readonly scopes: pulumi.Input<string>;
    readonly severity?: pulumi.Input<number>;
    readonly tags?: pulumi.Input<{[key: string]: any}>;
    readonly windowSize?: pulumi.Input<string>;
}
