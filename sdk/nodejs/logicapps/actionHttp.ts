// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export class ActionHttp extends pulumi.CustomResource {
    /**
     * Get an existing ActionHttp resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ActionHttpState, opts?: pulumi.CustomResourceOptions): ActionHttp {
        return new ActionHttp(name, <any>state, { ...opts, id: id });
    }

    public readonly body: pulumi.Output<string | undefined>;
    public readonly headers: pulumi.Output<{[key: string]: any} | undefined>;
    public readonly logicAppId: pulumi.Output<string>;
    public readonly method: pulumi.Output<string>;
    public readonly name: pulumi.Output<string>;
    public readonly uri: pulumi.Output<string>;

    /**
     * Create a ActionHttp resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ActionHttpArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ActionHttpArgs | ActionHttpState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: ActionHttpState = argsOrState as ActionHttpState | undefined;
            inputs["body"] = state ? state.body : undefined;
            inputs["headers"] = state ? state.headers : undefined;
            inputs["logicAppId"] = state ? state.logicAppId : undefined;
            inputs["method"] = state ? state.method : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["uri"] = state ? state.uri : undefined;
        } else {
            const args = argsOrState as ActionHttpArgs | undefined;
            if (!args || args.logicAppId === undefined) {
                throw new Error("Missing required property 'logicAppId'");
            }
            if (!args || args.method === undefined) {
                throw new Error("Missing required property 'method'");
            }
            if (!args || args.uri === undefined) {
                throw new Error("Missing required property 'uri'");
            }
            inputs["body"] = args ? args.body : undefined;
            inputs["headers"] = args ? args.headers : undefined;
            inputs["logicAppId"] = args ? args.logicAppId : undefined;
            inputs["method"] = args ? args.method : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["uri"] = args ? args.uri : undefined;
        }
        super("azure:logicapps/actionHttp:ActionHttp", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ActionHttp resources.
 */
export interface ActionHttpState {
    readonly body?: pulumi.Input<string>;
    readonly headers?: pulumi.Input<{[key: string]: any}>;
    readonly logicAppId?: pulumi.Input<string>;
    readonly method?: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    readonly uri?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ActionHttp resource.
 */
export interface ActionHttpArgs {
    readonly body?: pulumi.Input<string>;
    readonly headers?: pulumi.Input<{[key: string]: any}>;
    readonly logicAppId: pulumi.Input<string>;
    readonly method: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    readonly uri: pulumi.Input<string>;
}
