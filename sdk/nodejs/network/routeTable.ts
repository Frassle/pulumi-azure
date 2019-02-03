// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export class RouteTable extends pulumi.CustomResource {
    /**
     * Get an existing RouteTable resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: RouteTableState, opts?: pulumi.CustomResourceOptions): RouteTable {
        return new RouteTable(name, <any>state, { ...opts, id: id });
    }

    public readonly disableBgpRoutePropagation: pulumi.Output<boolean | undefined>;
    public readonly location: pulumi.Output<string>;
    public readonly name: pulumi.Output<string>;
    public readonly resourceGroupName: pulumi.Output<string>;
    public readonly routes: pulumi.Output<{ addressPrefix: string, name: string, nextHopInIpAddress?: string, nextHopType: string }[]>;
    public /*out*/ readonly subnets: pulumi.Output<string[]>;
    public readonly tags: pulumi.Output<{[key: string]: any}>;

    /**
     * Create a RouteTable resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RouteTableArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: RouteTableArgs | RouteTableState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: RouteTableState = argsOrState as RouteTableState | undefined;
            inputs["disableBgpRoutePropagation"] = state ? state.disableBgpRoutePropagation : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["routes"] = state ? state.routes : undefined;
            inputs["subnets"] = state ? state.subnets : undefined;
            inputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as RouteTableArgs | undefined;
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["disableBgpRoutePropagation"] = args ? args.disableBgpRoutePropagation : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["routes"] = args ? args.routes : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["subnets"] = undefined /*out*/;
        }
        super("azure:network/routeTable:RouteTable", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering RouteTable resources.
 */
export interface RouteTableState {
    readonly disableBgpRoutePropagation?: pulumi.Input<boolean>;
    readonly location?: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    readonly resourceGroupName?: pulumi.Input<string>;
    readonly routes?: pulumi.Input<pulumi.Input<{ addressPrefix: pulumi.Input<string>, name: pulumi.Input<string>, nextHopInIpAddress?: pulumi.Input<string>, nextHopType: pulumi.Input<string> }>[]>;
    readonly subnets?: pulumi.Input<pulumi.Input<string>[]>;
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}

/**
 * The set of arguments for constructing a RouteTable resource.
 */
export interface RouteTableArgs {
    readonly disableBgpRoutePropagation?: pulumi.Input<boolean>;
    readonly location: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    readonly resourceGroupName: pulumi.Input<string>;
    readonly routes?: pulumi.Input<pulumi.Input<{ addressPrefix: pulumi.Input<string>, name: pulumi.Input<string>, nextHopInIpAddress?: pulumi.Input<string>, nextHopType: pulumi.Input<string> }>[]>;
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}
