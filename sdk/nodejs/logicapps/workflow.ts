// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Manages a Logic App Workflow.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const azurerm_resource_group_test = new azure.core.ResourceGroup("test", {
 *     location: "East US",
 *     name: "workflow-resources",
 * });
 * const azurerm_logic_app_workflow_test = new azure.logicapps.Workflow("test", {
 *     location: azurerm_resource_group_test.location,
 *     name: "workflow1",
 *     resourceGroupName: azurerm_resource_group_test.name,
 * });
 * ```
 */
export class Workflow extends pulumi.CustomResource {
    /**
     * Get an existing Workflow resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: WorkflowState, opts?: pulumi.CustomResourceOptions): Workflow {
        return new Workflow(name, <any>state, { ...opts, id: id });
    }

    /**
     * The Access Endpoint for the Logic App Workflow
     */
    public /*out*/ readonly accessEndpoint: pulumi.Output<string>;
    /**
     * Specifies the supported Azure location where the Logic App Workflow exists. Changing this forces a new resource to be created.
     */
    public readonly location: pulumi.Output<string>;
    /**
     * Specifies the name of the Logic App Workflow. Changing this forces a new resource to be created.
     */
    public readonly name: pulumi.Output<string>;
    /**
     * A map of Key-Value pairs.
     */
    public readonly parameters: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * The name of the Resource Group in which the Logic App Workflow should be created. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName: pulumi.Output<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    public readonly tags: pulumi.Output<{[key: string]: any}>;
    /**
     * Specifies the Schema to use for this Logic App Workflow. Defaults to `https://schema.management.azure.com/providers/Microsoft.Logic/schemas/2016-06-01/workflowdefinition.json#`. Changing this forces a new resource to be created.
     */
    public readonly workflowSchema: pulumi.Output<string | undefined>;
    /**
     * Specifies the version of the Schema used for this Logic App Workflow. Defaults to `1.0.0.0`. Changing this forces a new resource to be create.d
     */
    public readonly workflowVersion: pulumi.Output<string | undefined>;

    /**
     * Create a Workflow resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WorkflowArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: WorkflowArgs | WorkflowState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: WorkflowState = argsOrState as WorkflowState | undefined;
            inputs["accessEndpoint"] = state ? state.accessEndpoint : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["parameters"] = state ? state.parameters : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["tags"] = state ? state.tags : undefined;
            inputs["workflowSchema"] = state ? state.workflowSchema : undefined;
            inputs["workflowVersion"] = state ? state.workflowVersion : undefined;
        } else {
            const args = argsOrState as WorkflowArgs | undefined;
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["parameters"] = args ? args.parameters : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["workflowSchema"] = args ? args.workflowSchema : undefined;
            inputs["workflowVersion"] = args ? args.workflowVersion : undefined;
            inputs["accessEndpoint"] = undefined /*out*/;
        }
        super("azure:logicapps/workflow:Workflow", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Workflow resources.
 */
export interface WorkflowState {
    /**
     * The Access Endpoint for the Logic App Workflow
     */
    readonly accessEndpoint?: pulumi.Input<string>;
    /**
     * Specifies the supported Azure location where the Logic App Workflow exists. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Specifies the name of the Logic App Workflow. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A map of Key-Value pairs.
     */
    readonly parameters?: pulumi.Input<{[key: string]: any}>;
    /**
     * The name of the Resource Group in which the Logic App Workflow should be created. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * Specifies the Schema to use for this Logic App Workflow. Defaults to `https://schema.management.azure.com/providers/Microsoft.Logic/schemas/2016-06-01/workflowdefinition.json#`. Changing this forces a new resource to be created.
     */
    readonly workflowSchema?: pulumi.Input<string>;
    /**
     * Specifies the version of the Schema used for this Logic App Workflow. Defaults to `1.0.0.0`. Changing this forces a new resource to be create.d
     */
    readonly workflowVersion?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Workflow resource.
 */
export interface WorkflowArgs {
    /**
     * Specifies the supported Azure location where the Logic App Workflow exists. Changing this forces a new resource to be created.
     */
    readonly location: pulumi.Input<string>;
    /**
     * Specifies the name of the Logic App Workflow. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A map of Key-Value pairs.
     */
    readonly parameters?: pulumi.Input<{[key: string]: any}>;
    /**
     * The name of the Resource Group in which the Logic App Workflow should be created. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * Specifies the Schema to use for this Logic App Workflow. Defaults to `https://schema.management.azure.com/providers/Microsoft.Logic/schemas/2016-06-01/workflowdefinition.json#`. Changing this forces a new resource to be created.
     */
    readonly workflowSchema?: pulumi.Input<string>;
    /**
     * Specifies the version of the Schema used for this Logic App Workflow. Defaults to `1.0.0.0`. Changing this forces a new resource to be create.d
     */
    readonly workflowVersion?: pulumi.Input<string>;
}
