// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * Configured the specified Policy Definition at the specified Scope.
 */
export class Assignment extends pulumi.CustomResource {
    /**
     * Get an existing Assignment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AssignmentState): Assignment {
        return new Assignment(name, <any>state, { id });
    }

    /**
     * A description to use for this Policy Assignment. Changing this forces a new resource to be created.
     */
    public readonly description: pulumi.Output<string | undefined>;
    /**
     * A friendly display name to use for this Policy Assignment. Changing this forces a new resource to be created.
     */
    public readonly displayName: pulumi.Output<string | undefined>;
    /**
     * The name of the Policy Assignment. Changing this forces a new resource to be created.
     */
    public readonly name: pulumi.Output<string>;
    /**
     * Parameters for the policy definition. This field is a JSON object that maps to the Parameters field from the Policy Definition. Changing this forces a new resource to be created.
     */
    public readonly parameters: pulumi.Output<string | undefined>;
    /**
     * The ID of the Policy Definition to be applied at the specified Scope.
     */
    public readonly policyDefinitionId: pulumi.Output<string>;
    public readonly scope: pulumi.Output<string>;

    /**
     * Create a Assignment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AssignmentArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AssignmentArgs | AssignmentState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: AssignmentState = argsOrState as AssignmentState | undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["displayName"] = state ? state.displayName : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["parameters"] = state ? state.parameters : undefined;
            inputs["policyDefinitionId"] = state ? state.policyDefinitionId : undefined;
            inputs["scope"] = state ? state.scope : undefined;
        } else {
            const args = argsOrState as AssignmentArgs | undefined;
            if (!args || args.policyDefinitionId === undefined) {
                throw new Error("Missing required property 'policyDefinitionId'");
            }
            if (!args || args.scope === undefined) {
                throw new Error("Missing required property 'scope'");
            }
            inputs["description"] = args ? args.description : undefined;
            inputs["displayName"] = args ? args.displayName : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["parameters"] = args ? args.parameters : undefined;
            inputs["policyDefinitionId"] = args ? args.policyDefinitionId : undefined;
            inputs["scope"] = args ? args.scope : undefined;
        }
        super("azure:policy/assignment:Assignment", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Assignment resources.
 */
export interface AssignmentState {
    /**
     * A description to use for this Policy Assignment. Changing this forces a new resource to be created.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * A friendly display name to use for this Policy Assignment. Changing this forces a new resource to be created.
     */
    readonly displayName?: pulumi.Input<string>;
    /**
     * The name of the Policy Assignment. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Parameters for the policy definition. This field is a JSON object that maps to the Parameters field from the Policy Definition. Changing this forces a new resource to be created.
     */
    readonly parameters?: pulumi.Input<string>;
    /**
     * The ID of the Policy Definition to be applied at the specified Scope.
     */
    readonly policyDefinitionId?: pulumi.Input<string>;
    readonly scope?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Assignment resource.
 */
export interface AssignmentArgs {
    /**
     * A description to use for this Policy Assignment. Changing this forces a new resource to be created.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * A friendly display name to use for this Policy Assignment. Changing this forces a new resource to be created.
     */
    readonly displayName?: pulumi.Input<string>;
    /**
     * The name of the Policy Assignment. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Parameters for the policy definition. This field is a JSON object that maps to the Parameters field from the Policy Definition. Changing this forces a new resource to be created.
     */
    readonly parameters?: pulumi.Input<string>;
    /**
     * The ID of the Policy Definition to be applied at the specified Scope.
     */
    readonly policyDefinitionId: pulumi.Input<string>;
    readonly scope: pulumi.Input<string>;
}
