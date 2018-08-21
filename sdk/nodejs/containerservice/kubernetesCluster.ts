// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * Manages a managed Kubernetes Cluster (AKS)
 * 
 * ~> **Note:** All arguments including the client secret will be stored in the raw state as plain-text.
 * [Read more about sensitive data in state](/docs/state/sensitive-data.html).
 */
export class KubernetesCluster extends pulumi.CustomResource {
    /**
     * Get an existing KubernetesCluster resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: KubernetesClusterState): KubernetesCluster {
        return new KubernetesCluster(name, <any>state, { id });
    }

    /**
     * A `addon_profile` block.
     */
    public readonly addonProfile: pulumi.Output<{ httpApplicationRouting?: { enabled: boolean, httpApplicationRoutingZoneName: string }, omsAgent?: { enabled: boolean, logAnalyticsWorkspaceId: string } }>;
    /**
     * One or more Agent Pool Profile's block as documented below.
     */
    public readonly agentPoolProfile: pulumi.Output<{ count?: number, dnsPrefix: string, fqdn: string, maxPods: number, name: string, osDiskSizeGb?: number, osType?: string, vmSize: string, vnetSubnetId?: string }>;
    /**
     * DNS prefix specified when creating the managed cluster.
     */
    public readonly dnsPrefix: pulumi.Output<string>;
    /**
     * The FQDN of the Azure Kubernetes Managed Cluster.
     */
    public /*out*/ readonly fqdn: pulumi.Output<string>;
    /**
     * A `kube_config` block as defined below.
     */
    public /*out*/ readonly kubeConfig: pulumi.Output<{ clientCertificate: string, clientKey: string, clusterCaCertificate: string, host: string, password: string, username: string }>;
    /**
     * Raw Kubernetes config to be used by
     * [kubectl](https://kubernetes.io/docs/reference/kubectl/overview/) and
     * other compatible tools
     */
    public /*out*/ readonly kubeConfigRaw: pulumi.Output<string>;
    /**
     * Version of Kubernetes specified when creating the AKS managed cluster. If not specified, the latest recommended version will be used at provisioning time (but won't auto-upgrade).
     */
    public readonly kubernetesVersion: pulumi.Output<string>;
    /**
     * A Linux Profile block as documented below.
     */
    public readonly linuxProfile: pulumi.Output<{ adminUsername: string, sshKeys: { keyData: string }[] }>;
    /**
     * The location where the AKS Managed Cluster instance should be created. Changing this forces a new resource to be created.
     */
    public readonly location: pulumi.Output<string>;
    /**
     * Unique name of the Agent Pool Profile in the context of the Subscription and Resource Group. Changing this forces a new resource to be created.
     */
    public readonly name: pulumi.Output<string>;
    /**
     * A Network Profile block as documented below.
     */
    public readonly networkProfile: pulumi.Output<{ dnsServiceIp: string, dockerBridgeCidr: string, networkPlugin: string, podCidr: string, serviceCidr: string }>;
    /**
     * Auto-generated Resource Group containing AKS Cluster resources.
     */
    public /*out*/ readonly nodeResourceGroup: pulumi.Output<string>;
    /**
     * Specifies the resource group where the resource exists. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName: pulumi.Output<string>;
    /**
     * A Service Principal block as documented below.
     */
    public readonly servicePrincipal: pulumi.Output<{ clientId: string, clientSecret: string }>;
    /**
     * A mapping of tags to assign to the resource.
     */
    public readonly tags: pulumi.Output<{[key: string]: any}>;

    /**
     * Create a KubernetesCluster resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: KubernetesClusterArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: KubernetesClusterArgs | KubernetesClusterState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: KubernetesClusterState = argsOrState as KubernetesClusterState | undefined;
            inputs["addonProfile"] = state ? state.addonProfile : undefined;
            inputs["agentPoolProfile"] = state ? state.agentPoolProfile : undefined;
            inputs["dnsPrefix"] = state ? state.dnsPrefix : undefined;
            inputs["fqdn"] = state ? state.fqdn : undefined;
            inputs["kubeConfig"] = state ? state.kubeConfig : undefined;
            inputs["kubeConfigRaw"] = state ? state.kubeConfigRaw : undefined;
            inputs["kubernetesVersion"] = state ? state.kubernetesVersion : undefined;
            inputs["linuxProfile"] = state ? state.linuxProfile : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["networkProfile"] = state ? state.networkProfile : undefined;
            inputs["nodeResourceGroup"] = state ? state.nodeResourceGroup : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["servicePrincipal"] = state ? state.servicePrincipal : undefined;
            inputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as KubernetesClusterArgs | undefined;
            if (!args || args.agentPoolProfile === undefined) {
                throw new Error("Missing required property 'agentPoolProfile'");
            }
            if (!args || args.dnsPrefix === undefined) {
                throw new Error("Missing required property 'dnsPrefix'");
            }
            if (!args || args.linuxProfile === undefined) {
                throw new Error("Missing required property 'linuxProfile'");
            }
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.servicePrincipal === undefined) {
                throw new Error("Missing required property 'servicePrincipal'");
            }
            inputs["addonProfile"] = args ? args.addonProfile : undefined;
            inputs["agentPoolProfile"] = args ? args.agentPoolProfile : undefined;
            inputs["dnsPrefix"] = args ? args.dnsPrefix : undefined;
            inputs["kubernetesVersion"] = args ? args.kubernetesVersion : undefined;
            inputs["linuxProfile"] = args ? args.linuxProfile : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["networkProfile"] = args ? args.networkProfile : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["servicePrincipal"] = args ? args.servicePrincipal : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["fqdn"] = undefined /*out*/;
            inputs["kubeConfig"] = undefined /*out*/;
            inputs["kubeConfigRaw"] = undefined /*out*/;
            inputs["nodeResourceGroup"] = undefined /*out*/;
        }
        super("azure:containerservice/kubernetesCluster:KubernetesCluster", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering KubernetesCluster resources.
 */
export interface KubernetesClusterState {
    /**
     * A `addon_profile` block.
     */
    readonly addonProfile?: pulumi.Input<{ httpApplicationRouting?: pulumi.Input<{ enabled: pulumi.Input<boolean>, httpApplicationRoutingZoneName?: pulumi.Input<string> }>, omsAgent?: pulumi.Input<{ enabled: pulumi.Input<boolean>, logAnalyticsWorkspaceId: pulumi.Input<string> }> }>;
    /**
     * One or more Agent Pool Profile's block as documented below.
     */
    readonly agentPoolProfile?: pulumi.Input<{ count?: pulumi.Input<number>, dnsPrefix?: pulumi.Input<string>, fqdn?: pulumi.Input<string>, maxPods?: pulumi.Input<number>, name: pulumi.Input<string>, osDiskSizeGb?: pulumi.Input<number>, osType?: pulumi.Input<string>, vmSize: pulumi.Input<string>, vnetSubnetId?: pulumi.Input<string> }>;
    /**
     * DNS prefix specified when creating the managed cluster.
     */
    readonly dnsPrefix?: pulumi.Input<string>;
    /**
     * The FQDN of the Azure Kubernetes Managed Cluster.
     */
    readonly fqdn?: pulumi.Input<string>;
    /**
     * A `kube_config` block as defined below.
     */
    readonly kubeConfig?: pulumi.Input<{ clientCertificate?: pulumi.Input<string>, clientKey?: pulumi.Input<string>, clusterCaCertificate?: pulumi.Input<string>, host?: pulumi.Input<string>, password?: pulumi.Input<string>, username?: pulumi.Input<string> }>;
    /**
     * Raw Kubernetes config to be used by
     * [kubectl](https://kubernetes.io/docs/reference/kubectl/overview/) and
     * other compatible tools
     */
    readonly kubeConfigRaw?: pulumi.Input<string>;
    /**
     * Version of Kubernetes specified when creating the AKS managed cluster. If not specified, the latest recommended version will be used at provisioning time (but won't auto-upgrade).
     */
    readonly kubernetesVersion?: pulumi.Input<string>;
    /**
     * A Linux Profile block as documented below.
     */
    readonly linuxProfile?: pulumi.Input<{ adminUsername: pulumi.Input<string>, sshKeys: pulumi.Input<pulumi.Input<{ keyData: pulumi.Input<string> }>[]> }>;
    /**
     * The location where the AKS Managed Cluster instance should be created. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Unique name of the Agent Pool Profile in the context of the Subscription and Resource Group. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A Network Profile block as documented below.
     */
    readonly networkProfile?: pulumi.Input<{ dnsServiceIp?: pulumi.Input<string>, dockerBridgeCidr?: pulumi.Input<string>, networkPlugin: pulumi.Input<string>, podCidr?: pulumi.Input<string>, serviceCidr?: pulumi.Input<string> }>;
    /**
     * Auto-generated Resource Group containing AKS Cluster resources.
     */
    readonly nodeResourceGroup?: pulumi.Input<string>;
    /**
     * Specifies the resource group where the resource exists. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * A Service Principal block as documented below.
     */
    readonly servicePrincipal?: pulumi.Input<{ clientId: pulumi.Input<string>, clientSecret: pulumi.Input<string> }>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}

/**
 * The set of arguments for constructing a KubernetesCluster resource.
 */
export interface KubernetesClusterArgs {
    /**
     * A `addon_profile` block.
     */
    readonly addonProfile?: pulumi.Input<{ httpApplicationRouting?: pulumi.Input<{ enabled: pulumi.Input<boolean>, httpApplicationRoutingZoneName?: pulumi.Input<string> }>, omsAgent?: pulumi.Input<{ enabled: pulumi.Input<boolean>, logAnalyticsWorkspaceId: pulumi.Input<string> }> }>;
    /**
     * One or more Agent Pool Profile's block as documented below.
     */
    readonly agentPoolProfile: pulumi.Input<{ count?: pulumi.Input<number>, dnsPrefix?: pulumi.Input<string>, fqdn?: pulumi.Input<string>, maxPods?: pulumi.Input<number>, name: pulumi.Input<string>, osDiskSizeGb?: pulumi.Input<number>, osType?: pulumi.Input<string>, vmSize: pulumi.Input<string>, vnetSubnetId?: pulumi.Input<string> }>;
    /**
     * DNS prefix specified when creating the managed cluster.
     */
    readonly dnsPrefix: pulumi.Input<string>;
    /**
     * Version of Kubernetes specified when creating the AKS managed cluster. If not specified, the latest recommended version will be used at provisioning time (but won't auto-upgrade).
     */
    readonly kubernetesVersion?: pulumi.Input<string>;
    /**
     * A Linux Profile block as documented below.
     */
    readonly linuxProfile: pulumi.Input<{ adminUsername: pulumi.Input<string>, sshKeys: pulumi.Input<pulumi.Input<{ keyData: pulumi.Input<string> }>[]> }>;
    /**
     * The location where the AKS Managed Cluster instance should be created. Changing this forces a new resource to be created.
     */
    readonly location: pulumi.Input<string>;
    /**
     * Unique name of the Agent Pool Profile in the context of the Subscription and Resource Group. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A Network Profile block as documented below.
     */
    readonly networkProfile?: pulumi.Input<{ dnsServiceIp?: pulumi.Input<string>, dockerBridgeCidr?: pulumi.Input<string>, networkPlugin: pulumi.Input<string>, podCidr?: pulumi.Input<string>, serviceCidr?: pulumi.Input<string> }>;
    /**
     * Specifies the resource group where the resource exists. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * A Service Principal block as documented below.
     */
    readonly servicePrincipal: pulumi.Input<{ clientId: pulumi.Input<string>, clientSecret: pulumi.Input<string> }>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}
