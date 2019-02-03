// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export function getEventhubNamespace(args: GetEventhubNamespaceArgs, opts?: pulumi.InvokeOptions): Promise<GetEventhubNamespaceResult> {
    return pulumi.runtime.invoke("azure:eventhub/getEventhubNamespace:getEventhubNamespace", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

/**
 * A collection of arguments for invoking getEventhubNamespace.
 */
export interface GetEventhubNamespaceArgs {
    readonly name: string;
    readonly resourceGroupName: string;
}

/**
 * A collection of values returned by getEventhubNamespace.
 */
export interface GetEventhubNamespaceResult {
    readonly autoInflateEnabled: boolean;
    readonly capacity: number;
    readonly defaultPrimaryConnectionString: string;
    readonly defaultPrimaryKey: string;
    readonly defaultSecondaryConnectionString: string;
    readonly defaultSecondaryKey: string;
    readonly kafkaEnabled: boolean;
    readonly location: string;
    readonly maximumThroughputUnits: number;
    readonly sku: string;
    readonly tags: {[key: string]: any};
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
