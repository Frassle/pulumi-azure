// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export function getPlatformImage(args: GetPlatformImageArgs, opts?: pulumi.InvokeOptions): Promise<GetPlatformImageResult> {
    return pulumi.runtime.invoke("azure:compute/getPlatformImage:getPlatformImage", {
        "location": args.location,
        "offer": args.offer,
        "publisher": args.publisher,
        "sku": args.sku,
    }, opts);
}

/**
 * A collection of arguments for invoking getPlatformImage.
 */
export interface GetPlatformImageArgs {
    readonly location: string;
    readonly offer: string;
    readonly publisher: string;
    readonly sku: string;
}

/**
 * A collection of values returned by getPlatformImage.
 */
export interface GetPlatformImageResult {
    readonly version: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
