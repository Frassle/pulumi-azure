// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export function getBackendAddressPool(args: GetBackendAddressPoolArgs, opts?: pulumi.InvokeOptions): Promise<GetBackendAddressPoolResult> {
    return pulumi.runtime.invoke("azure:lb/getBackendAddressPool:getBackendAddressPool", {
        "loadbalancerId": args.loadbalancerId,
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getBackendAddressPool.
 */
export interface GetBackendAddressPoolArgs {
    readonly loadbalancerId: string;
    readonly name: string;
}

/**
 * A collection of values returned by getBackendAddressPool.
 */
export interface GetBackendAddressPoolResult {
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
