// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export function getDiagnosticCategories(args: GetDiagnosticCategoriesArgs, opts?: pulumi.InvokeOptions): Promise<GetDiagnosticCategoriesResult> {
    return pulumi.runtime.invoke("azure:monitoring/getDiagnosticCategories:getDiagnosticCategories", {
        "resourceId": args.resourceId,
    }, opts);
}

/**
 * A collection of arguments for invoking getDiagnosticCategories.
 */
export interface GetDiagnosticCategoriesArgs {
    readonly resourceId: string;
}

/**
 * A collection of values returned by getDiagnosticCategories.
 */
export interface GetDiagnosticCategoriesResult {
    readonly logs: string[];
    readonly metrics: string[];
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
