// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Manages a Scheduler Job.
 * 
 * ~> **NOTE:** Support for Scheduler Job has been deprecated by Microsoft in favour of Logic Apps ([more information can be found at this link](https://docs.microsoft.com/en-us/azure/scheduler/migrate-from-scheduler-to-logic-apps)) - as such we plan to remove support for this resource as a part of version 2.0 of the AzureRM Provider.
 */
export class Job extends pulumi.CustomResource {
    /**
     * Get an existing Job resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: JobState, opts?: pulumi.CustomResourceOptions): Job {
        return new Job(name, <any>state, { ...opts, id: id });
    }

    /**
     * A `action_storage_queue` block defining a storage queue job action as described below. Note this is identical to an `error_action_storage_queue` block.
     */
    public readonly actionStorageQueue: pulumi.Output<{ message: string, sasToken: string, storageAccountName: string, storageQueueName: string } | undefined>;
    /**
     * A `action_web` block defining the job action as described below. Note this is identical to an `error_action_web` block.
     */
    public readonly actionWeb: pulumi.Output<{ authenticationActiveDirectory?: { audience: string, clientId: string, secret: string, tenantId: string }, authenticationBasic?: { password: string, username: string }, authenticationCertificate?: { expiration: string, password: string, pfx: string, subjectName: string, thumbprint: string }, body?: string, headers?: {[key: string]: any}, method: string, url: string } | undefined>;
    /**
     * A `error_action_storage_queue` block defining the a web action to take on an error as described below. Note this is identical to an `action_storage_queue` block.
     */
    public readonly errorActionStorageQueue: pulumi.Output<{ message: string, sasToken: string, storageAccountName: string, storageQueueName: string } | undefined>;
    /**
     * A `error_action_web` block defining the action to take on an error as described below. Note this is identical to an `action_web` block.
     */
    public readonly errorActionWeb: pulumi.Output<{ authenticationActiveDirectory?: { audience: string, clientId: string, secret: string, tenantId: string }, authenticationBasic?: { password: string, username: string }, authenticationCertificate?: { expiration: string, password: string, pfx: string, subjectName: string, thumbprint: string }, body?: string, headers?: {[key: string]: any}, method: string, url: string } | undefined>;
    /**
     * Specifies the name of the Scheduler Job Collection in which the Job should exist. Changing this forces a new resource to be created.
     */
    public readonly jobCollectionName: pulumi.Output<string>;
    /**
     * The name of the Scheduler Job. Changing this forces a new resource to be created.
     */
    public readonly name: pulumi.Output<string>;
    /**
     * A `recurrence` block defining a job occurrence schedule.
     */
    public readonly recurrence: pulumi.Output<{ count?: number, endTime: string, frequency: string, hours?: number[], interval?: number, minutes?: number[], monthDays?: number[], monthlyOccurrences?: { day: string, occurrence: number }[], weekDays?: string[] } | undefined>;
    /**
     * The name of the resource group in which to create the Scheduler Job. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName: pulumi.Output<string>;
    /**
     * A `retry` block defining how to retry as described below.
     */
    public readonly retry: pulumi.Output<{ count?: number, interval?: string } | undefined>;
    /**
     * The time the first instance of the job is to start running at.
     */
    public readonly startTime: pulumi.Output<string>;
    /**
     * The sets or gets the current state of the job. Can be set to either `Enabled` or `Completed`
     */
    public readonly state: pulumi.Output<string>;

    /**
     * Create a Job resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: JobArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: JobArgs | JobState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: JobState = argsOrState as JobState | undefined;
            inputs["actionStorageQueue"] = state ? state.actionStorageQueue : undefined;
            inputs["actionWeb"] = state ? state.actionWeb : undefined;
            inputs["errorActionStorageQueue"] = state ? state.errorActionStorageQueue : undefined;
            inputs["errorActionWeb"] = state ? state.errorActionWeb : undefined;
            inputs["jobCollectionName"] = state ? state.jobCollectionName : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["recurrence"] = state ? state.recurrence : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["retry"] = state ? state.retry : undefined;
            inputs["startTime"] = state ? state.startTime : undefined;
            inputs["state"] = state ? state.state : undefined;
        } else {
            const args = argsOrState as JobArgs | undefined;
            if (!args || args.jobCollectionName === undefined) {
                throw new Error("Missing required property 'jobCollectionName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["actionStorageQueue"] = args ? args.actionStorageQueue : undefined;
            inputs["actionWeb"] = args ? args.actionWeb : undefined;
            inputs["errorActionStorageQueue"] = args ? args.errorActionStorageQueue : undefined;
            inputs["errorActionWeb"] = args ? args.errorActionWeb : undefined;
            inputs["jobCollectionName"] = args ? args.jobCollectionName : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["recurrence"] = args ? args.recurrence : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["retry"] = args ? args.retry : undefined;
            inputs["startTime"] = args ? args.startTime : undefined;
            inputs["state"] = args ? args.state : undefined;
        }
        super("azure:scheduler/job:Job", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Job resources.
 */
export interface JobState {
    /**
     * A `action_storage_queue` block defining a storage queue job action as described below. Note this is identical to an `error_action_storage_queue` block.
     */
    readonly actionStorageQueue?: pulumi.Input<{ message: pulumi.Input<string>, sasToken: pulumi.Input<string>, storageAccountName: pulumi.Input<string>, storageQueueName: pulumi.Input<string> }>;
    /**
     * A `action_web` block defining the job action as described below. Note this is identical to an `error_action_web` block.
     */
    readonly actionWeb?: pulumi.Input<{ authenticationActiveDirectory?: pulumi.Input<{ audience?: pulumi.Input<string>, clientId: pulumi.Input<string>, secret: pulumi.Input<string>, tenantId: pulumi.Input<string> }>, authenticationBasic?: pulumi.Input<{ password: pulumi.Input<string>, username: pulumi.Input<string> }>, authenticationCertificate?: pulumi.Input<{ expiration?: pulumi.Input<string>, password: pulumi.Input<string>, pfx: pulumi.Input<string>, subjectName?: pulumi.Input<string>, thumbprint?: pulumi.Input<string> }>, body?: pulumi.Input<string>, headers?: pulumi.Input<{[key: string]: any}>, method: pulumi.Input<string>, url: pulumi.Input<string> }>;
    /**
     * A `error_action_storage_queue` block defining the a web action to take on an error as described below. Note this is identical to an `action_storage_queue` block.
     */
    readonly errorActionStorageQueue?: pulumi.Input<{ message: pulumi.Input<string>, sasToken: pulumi.Input<string>, storageAccountName: pulumi.Input<string>, storageQueueName: pulumi.Input<string> }>;
    /**
     * A `error_action_web` block defining the action to take on an error as described below. Note this is identical to an `action_web` block.
     */
    readonly errorActionWeb?: pulumi.Input<{ authenticationActiveDirectory?: pulumi.Input<{ audience?: pulumi.Input<string>, clientId: pulumi.Input<string>, secret: pulumi.Input<string>, tenantId: pulumi.Input<string> }>, authenticationBasic?: pulumi.Input<{ password: pulumi.Input<string>, username: pulumi.Input<string> }>, authenticationCertificate?: pulumi.Input<{ expiration?: pulumi.Input<string>, password: pulumi.Input<string>, pfx: pulumi.Input<string>, subjectName?: pulumi.Input<string>, thumbprint?: pulumi.Input<string> }>, body?: pulumi.Input<string>, headers?: pulumi.Input<{[key: string]: any}>, method: pulumi.Input<string>, url: pulumi.Input<string> }>;
    /**
     * Specifies the name of the Scheduler Job Collection in which the Job should exist. Changing this forces a new resource to be created.
     */
    readonly jobCollectionName?: pulumi.Input<string>;
    /**
     * The name of the Scheduler Job. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A `recurrence` block defining a job occurrence schedule.
     */
    readonly recurrence?: pulumi.Input<{ count?: pulumi.Input<number>, endTime?: pulumi.Input<string>, frequency: pulumi.Input<string>, hours?: pulumi.Input<pulumi.Input<number>[]>, interval?: pulumi.Input<number>, minutes?: pulumi.Input<pulumi.Input<number>[]>, monthDays?: pulumi.Input<pulumi.Input<number>[]>, monthlyOccurrences?: pulumi.Input<pulumi.Input<{ day: pulumi.Input<string>, occurrence: pulumi.Input<number> }>[]>, weekDays?: pulumi.Input<pulumi.Input<string>[]> }>;
    /**
     * The name of the resource group in which to create the Scheduler Job. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * A `retry` block defining how to retry as described below.
     */
    readonly retry?: pulumi.Input<{ count?: pulumi.Input<number>, interval?: pulumi.Input<string> }>;
    /**
     * The time the first instance of the job is to start running at.
     */
    readonly startTime?: pulumi.Input<string>;
    /**
     * The sets or gets the current state of the job. Can be set to either `Enabled` or `Completed`
     */
    readonly state?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Job resource.
 */
export interface JobArgs {
    /**
     * A `action_storage_queue` block defining a storage queue job action as described below. Note this is identical to an `error_action_storage_queue` block.
     */
    readonly actionStorageQueue?: pulumi.Input<{ message: pulumi.Input<string>, sasToken: pulumi.Input<string>, storageAccountName: pulumi.Input<string>, storageQueueName: pulumi.Input<string> }>;
    /**
     * A `action_web` block defining the job action as described below. Note this is identical to an `error_action_web` block.
     */
    readonly actionWeb?: pulumi.Input<{ authenticationActiveDirectory?: pulumi.Input<{ audience?: pulumi.Input<string>, clientId: pulumi.Input<string>, secret: pulumi.Input<string>, tenantId: pulumi.Input<string> }>, authenticationBasic?: pulumi.Input<{ password: pulumi.Input<string>, username: pulumi.Input<string> }>, authenticationCertificate?: pulumi.Input<{ expiration?: pulumi.Input<string>, password: pulumi.Input<string>, pfx: pulumi.Input<string>, subjectName?: pulumi.Input<string>, thumbprint?: pulumi.Input<string> }>, body?: pulumi.Input<string>, headers?: pulumi.Input<{[key: string]: any}>, method: pulumi.Input<string>, url: pulumi.Input<string> }>;
    /**
     * A `error_action_storage_queue` block defining the a web action to take on an error as described below. Note this is identical to an `action_storage_queue` block.
     */
    readonly errorActionStorageQueue?: pulumi.Input<{ message: pulumi.Input<string>, sasToken: pulumi.Input<string>, storageAccountName: pulumi.Input<string>, storageQueueName: pulumi.Input<string> }>;
    /**
     * A `error_action_web` block defining the action to take on an error as described below. Note this is identical to an `action_web` block.
     */
    readonly errorActionWeb?: pulumi.Input<{ authenticationActiveDirectory?: pulumi.Input<{ audience?: pulumi.Input<string>, clientId: pulumi.Input<string>, secret: pulumi.Input<string>, tenantId: pulumi.Input<string> }>, authenticationBasic?: pulumi.Input<{ password: pulumi.Input<string>, username: pulumi.Input<string> }>, authenticationCertificate?: pulumi.Input<{ expiration?: pulumi.Input<string>, password: pulumi.Input<string>, pfx: pulumi.Input<string>, subjectName?: pulumi.Input<string>, thumbprint?: pulumi.Input<string> }>, body?: pulumi.Input<string>, headers?: pulumi.Input<{[key: string]: any}>, method: pulumi.Input<string>, url: pulumi.Input<string> }>;
    /**
     * Specifies the name of the Scheduler Job Collection in which the Job should exist. Changing this forces a new resource to be created.
     */
    readonly jobCollectionName: pulumi.Input<string>;
    /**
     * The name of the Scheduler Job. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A `recurrence` block defining a job occurrence schedule.
     */
    readonly recurrence?: pulumi.Input<{ count?: pulumi.Input<number>, endTime?: pulumi.Input<string>, frequency: pulumi.Input<string>, hours?: pulumi.Input<pulumi.Input<number>[]>, interval?: pulumi.Input<number>, minutes?: pulumi.Input<pulumi.Input<number>[]>, monthDays?: pulumi.Input<pulumi.Input<number>[]>, monthlyOccurrences?: pulumi.Input<pulumi.Input<{ day: pulumi.Input<string>, occurrence: pulumi.Input<number> }>[]>, weekDays?: pulumi.Input<pulumi.Input<string>[]> }>;
    /**
     * The name of the resource group in which to create the Scheduler Job. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * A `retry` block defining how to retry as described below.
     */
    readonly retry?: pulumi.Input<{ count?: pulumi.Input<number>, interval?: pulumi.Input<string> }>;
    /**
     * The time the first instance of the job is to start running at.
     */
    readonly startTime?: pulumi.Input<string>;
    /**
     * The sets or gets the current state of the job. Can be set to either `Enabled` or `Completed`
     */
    readonly state?: pulumi.Input<string>;
}
