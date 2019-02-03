// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export class AppService extends pulumi.CustomResource {
    /**
     * Get an existing AppService resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AppServiceState, opts?: pulumi.CustomResourceOptions): AppService {
        return new AppService(name, <any>state, { ...opts, id: id });
    }

    public readonly appServicePlanId: pulumi.Output<string>;
    public readonly appSettings: pulumi.Output<{[key: string]: any}>;
    public readonly clientAffinityEnabled: pulumi.Output<boolean>;
    public readonly connectionStrings: pulumi.Output<{ name: string, type: string, value: string }[]>;
    public /*out*/ readonly defaultSiteHostname: pulumi.Output<string>;
    public readonly enabled: pulumi.Output<boolean | undefined>;
    public readonly httpsOnly: pulumi.Output<boolean | undefined>;
    public readonly identity: pulumi.Output<{ principalId: string, tenantId: string, type: string }>;
    public readonly location: pulumi.Output<string>;
    public readonly name: pulumi.Output<string>;
    public /*out*/ readonly outboundIpAddresses: pulumi.Output<string>;
    public /*out*/ readonly possibleOutboundIpAddresses: pulumi.Output<string>;
    public readonly resourceGroupName: pulumi.Output<string>;
    public readonly siteConfig: pulumi.Output<{ alwaysOn?: boolean, appCommandLine?: string, defaultDocuments?: string[], dotnetFrameworkVersion?: string, ftpsState: string, http2Enabled?: boolean, ipRestrictions: { ipAddress: string, subnetMask?: string }[], javaContainer?: string, javaContainerVersion?: string, javaVersion?: string, linuxFxVersion: string, localMysqlEnabled: boolean, managedPipelineMode: string, minTlsVersion: string, phpVersion?: string, pythonVersion?: string, remoteDebuggingEnabled?: boolean, remoteDebuggingVersion: string, scmType?: string, use32BitWorkerProcess: boolean, virtualNetworkName?: string, websocketsEnabled: boolean }>;
    public /*out*/ readonly siteCredential: pulumi.Output<{ password: string, username: string }>;
    public /*out*/ readonly sourceControl: pulumi.Output<{ branch: string, repoUrl: string }>;
    public readonly tags: pulumi.Output<{[key: string]: any}>;

    /**
     * Create a AppService resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AppServiceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AppServiceArgs | AppServiceState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: AppServiceState = argsOrState as AppServiceState | undefined;
            inputs["appServicePlanId"] = state ? state.appServicePlanId : undefined;
            inputs["appSettings"] = state ? state.appSettings : undefined;
            inputs["clientAffinityEnabled"] = state ? state.clientAffinityEnabled : undefined;
            inputs["connectionStrings"] = state ? state.connectionStrings : undefined;
            inputs["defaultSiteHostname"] = state ? state.defaultSiteHostname : undefined;
            inputs["enabled"] = state ? state.enabled : undefined;
            inputs["httpsOnly"] = state ? state.httpsOnly : undefined;
            inputs["identity"] = state ? state.identity : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["outboundIpAddresses"] = state ? state.outboundIpAddresses : undefined;
            inputs["possibleOutboundIpAddresses"] = state ? state.possibleOutboundIpAddresses : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["siteConfig"] = state ? state.siteConfig : undefined;
            inputs["siteCredential"] = state ? state.siteCredential : undefined;
            inputs["sourceControl"] = state ? state.sourceControl : undefined;
            inputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as AppServiceArgs | undefined;
            if (!args || args.appServicePlanId === undefined) {
                throw new Error("Missing required property 'appServicePlanId'");
            }
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["appServicePlanId"] = args ? args.appServicePlanId : undefined;
            inputs["appSettings"] = args ? args.appSettings : undefined;
            inputs["clientAffinityEnabled"] = args ? args.clientAffinityEnabled : undefined;
            inputs["connectionStrings"] = args ? args.connectionStrings : undefined;
            inputs["enabled"] = args ? args.enabled : undefined;
            inputs["httpsOnly"] = args ? args.httpsOnly : undefined;
            inputs["identity"] = args ? args.identity : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["siteConfig"] = args ? args.siteConfig : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["defaultSiteHostname"] = undefined /*out*/;
            inputs["outboundIpAddresses"] = undefined /*out*/;
            inputs["possibleOutboundIpAddresses"] = undefined /*out*/;
            inputs["siteCredential"] = undefined /*out*/;
            inputs["sourceControl"] = undefined /*out*/;
        }
        super("azure:appservice/appService:AppService", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AppService resources.
 */
export interface AppServiceState {
    readonly appServicePlanId?: pulumi.Input<string>;
    readonly appSettings?: pulumi.Input<{[key: string]: any}>;
    readonly clientAffinityEnabled?: pulumi.Input<boolean>;
    readonly connectionStrings?: pulumi.Input<pulumi.Input<{ name: pulumi.Input<string>, type: pulumi.Input<string>, value: pulumi.Input<string> }>[]>;
    readonly defaultSiteHostname?: pulumi.Input<string>;
    readonly enabled?: pulumi.Input<boolean>;
    readonly httpsOnly?: pulumi.Input<boolean>;
    readonly identity?: pulumi.Input<{ principalId?: pulumi.Input<string>, tenantId?: pulumi.Input<string>, type: pulumi.Input<string> }>;
    readonly location?: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    readonly outboundIpAddresses?: pulumi.Input<string>;
    readonly possibleOutboundIpAddresses?: pulumi.Input<string>;
    readonly resourceGroupName?: pulumi.Input<string>;
    readonly siteConfig?: pulumi.Input<{ alwaysOn?: pulumi.Input<boolean>, appCommandLine?: pulumi.Input<string>, defaultDocuments?: pulumi.Input<pulumi.Input<string>[]>, dotnetFrameworkVersion?: pulumi.Input<string>, ftpsState?: pulumi.Input<string>, http2Enabled?: pulumi.Input<boolean>, ipRestrictions?: pulumi.Input<pulumi.Input<{ ipAddress: pulumi.Input<string>, subnetMask?: pulumi.Input<string> }>[]>, javaContainer?: pulumi.Input<string>, javaContainerVersion?: pulumi.Input<string>, javaVersion?: pulumi.Input<string>, linuxFxVersion?: pulumi.Input<string>, localMysqlEnabled?: pulumi.Input<boolean>, managedPipelineMode?: pulumi.Input<string>, minTlsVersion?: pulumi.Input<string>, phpVersion?: pulumi.Input<string>, pythonVersion?: pulumi.Input<string>, remoteDebuggingEnabled?: pulumi.Input<boolean>, remoteDebuggingVersion?: pulumi.Input<string>, scmType?: pulumi.Input<string>, use32BitWorkerProcess?: pulumi.Input<boolean>, virtualNetworkName?: pulumi.Input<string>, websocketsEnabled?: pulumi.Input<boolean> }>;
    readonly siteCredential?: pulumi.Input<{ password?: pulumi.Input<string>, username?: pulumi.Input<string> }>;
    readonly sourceControl?: pulumi.Input<{ branch?: pulumi.Input<string>, repoUrl?: pulumi.Input<string> }>;
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}

/**
 * The set of arguments for constructing a AppService resource.
 */
export interface AppServiceArgs {
    readonly appServicePlanId: pulumi.Input<string>;
    readonly appSettings?: pulumi.Input<{[key: string]: any}>;
    readonly clientAffinityEnabled?: pulumi.Input<boolean>;
    readonly connectionStrings?: pulumi.Input<pulumi.Input<{ name: pulumi.Input<string>, type: pulumi.Input<string>, value: pulumi.Input<string> }>[]>;
    readonly enabled?: pulumi.Input<boolean>;
    readonly httpsOnly?: pulumi.Input<boolean>;
    readonly identity?: pulumi.Input<{ principalId?: pulumi.Input<string>, tenantId?: pulumi.Input<string>, type: pulumi.Input<string> }>;
    readonly location: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    readonly resourceGroupName: pulumi.Input<string>;
    readonly siteConfig?: pulumi.Input<{ alwaysOn?: pulumi.Input<boolean>, appCommandLine?: pulumi.Input<string>, defaultDocuments?: pulumi.Input<pulumi.Input<string>[]>, dotnetFrameworkVersion?: pulumi.Input<string>, ftpsState?: pulumi.Input<string>, http2Enabled?: pulumi.Input<boolean>, ipRestrictions?: pulumi.Input<pulumi.Input<{ ipAddress: pulumi.Input<string>, subnetMask?: pulumi.Input<string> }>[]>, javaContainer?: pulumi.Input<string>, javaContainerVersion?: pulumi.Input<string>, javaVersion?: pulumi.Input<string>, linuxFxVersion?: pulumi.Input<string>, localMysqlEnabled?: pulumi.Input<boolean>, managedPipelineMode?: pulumi.Input<string>, minTlsVersion?: pulumi.Input<string>, phpVersion?: pulumi.Input<string>, pythonVersion?: pulumi.Input<string>, remoteDebuggingEnabled?: pulumi.Input<boolean>, remoteDebuggingVersion?: pulumi.Input<string>, scmType?: pulumi.Input<string>, use32BitWorkerProcess?: pulumi.Input<boolean>, virtualNetworkName?: pulumi.Input<string>, websocketsEnabled?: pulumi.Input<boolean> }>;
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}
