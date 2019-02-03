// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export function getJobCollection(args: GetJobCollectionArgs, opts?: pulumi.InvokeOptions): Promise<GetJobCollectionResult> {
    return pulumi.runtime.invoke("azure:scheduler/getJobCollection:getJobCollection", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

/**
 * A collection of arguments for invoking getJobCollection.
 */
export interface GetJobCollectionArgs {
    readonly name: string;
    readonly resourceGroupName: string;
}

/**
 * A collection of values returned by getJobCollection.
 */
export interface GetJobCollectionResult {
    readonly location: string;
    readonly quotas: { maxJobCount: number, maxRecurrenceFrequency: string, maxRecurrenceInterval: number, maxRetryInterval: number }[];
    readonly sku: string;
    readonly state: string;
    readonly tags: {[key: string]: any};
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
