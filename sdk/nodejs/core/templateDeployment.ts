// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * Create a template deployment of resources
 * 
 * ~> **Note on ARM Template Deployments:** Due to the way the underlying Azure API is designed, Terraform can only manage the deployment of the ARM Template - and not any resources which are created by it.
 * This means that when deleting the `azurerm_template_deployment` resource, Terraform will only remove the reference to the deployment, whilst leaving any resources created by that ARM Template Deployment.
 * One workaround for this is to use a unique Resource Group for each ARM Template Deployment, which means deleting the Resource Group would contain any resources created within it - however this isn't ideal. [More information](https://docs.microsoft.com/en-us/rest/api/resources/deployments#Deployments_Delete).
 */
export class TemplateDeployment extends pulumi.CustomResource {
    /**
     * Get an existing TemplateDeployment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: TemplateDeploymentState): TemplateDeployment {
        return new TemplateDeployment(name, <any>state, { id });
    }

    /**
     * Specifies the mode that is used to deploy resources. This value could be either `Incremental` or `Complete`.
     * Note that you will almost *always* want this to be set to `Incremental` otherwise the deployment will destroy all infrastructure not
     * specified within the template, and Terraform will not be aware of this.
     */
    public readonly deploymentMode: pulumi.Output<string>;
    /**
     * Specifies the name of the template deployment. Changing this forces a
     * new resource to be created.
     */
    public readonly name: pulumi.Output<string>;
    /**
     * A map of supported scalar output types returned from the deployment (currently, Azure Template Deployment outputs of type String, Int and Bool are supported, and are converted to strings - others will be ignored) and can be accessed using `.outputs["name"]`.
     */
    public /*out*/ readonly outputs: pulumi.Output<{[key: string]: any}>;
    /**
     * Specifies the name and value pairs that define the deployment parameters for the template.
     */
    public readonly parameters: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * Specifies a valid Azure JSON parameters file that define the deployment parameters. It can contain KeyVault references
     */
    public readonly parametersBody: pulumi.Output<string | undefined>;
    /**
     * The name of the resource group in which to
     * create the template deployment.
     */
    public readonly resourceGroupName: pulumi.Output<string>;
    /**
     * Specifies the JSON definition for the template.
     */
    public readonly templateBody: pulumi.Output<string>;

    /**
     * Create a TemplateDeployment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: TemplateDeploymentArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: TemplateDeploymentArgs | TemplateDeploymentState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: TemplateDeploymentState = argsOrState as TemplateDeploymentState | undefined;
            inputs["deploymentMode"] = state ? state.deploymentMode : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["outputs"] = state ? state.outputs : undefined;
            inputs["parameters"] = state ? state.parameters : undefined;
            inputs["parametersBody"] = state ? state.parametersBody : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["templateBody"] = state ? state.templateBody : undefined;
        } else {
            const args = argsOrState as TemplateDeploymentArgs | undefined;
            if (!args || args.deploymentMode === undefined) {
                throw new Error("Missing required property 'deploymentMode'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["deploymentMode"] = args ? args.deploymentMode : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["parameters"] = args ? args.parameters : undefined;
            inputs["parametersBody"] = args ? args.parametersBody : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["templateBody"] = args ? args.templateBody : undefined;
            inputs["outputs"] = undefined /*out*/;
        }
        super("azure:core/templateDeployment:TemplateDeployment", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering TemplateDeployment resources.
 */
export interface TemplateDeploymentState {
    /**
     * Specifies the mode that is used to deploy resources. This value could be either `Incremental` or `Complete`.
     * Note that you will almost *always* want this to be set to `Incremental` otherwise the deployment will destroy all infrastructure not
     * specified within the template, and Terraform will not be aware of this.
     */
    readonly deploymentMode?: pulumi.Input<string>;
    /**
     * Specifies the name of the template deployment. Changing this forces a
     * new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A map of supported scalar output types returned from the deployment (currently, Azure Template Deployment outputs of type String, Int and Bool are supported, and are converted to strings - others will be ignored) and can be accessed using `.outputs["name"]`.
     */
    readonly outputs?: pulumi.Input<{[key: string]: any}>;
    /**
     * Specifies the name and value pairs that define the deployment parameters for the template.
     */
    readonly parameters?: pulumi.Input<{[key: string]: any}>;
    /**
     * Specifies a valid Azure JSON parameters file that define the deployment parameters. It can contain KeyVault references
     */
    readonly parametersBody?: pulumi.Input<string>;
    /**
     * The name of the resource group in which to
     * create the template deployment.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * Specifies the JSON definition for the template.
     */
    readonly templateBody?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a TemplateDeployment resource.
 */
export interface TemplateDeploymentArgs {
    /**
     * Specifies the mode that is used to deploy resources. This value could be either `Incremental` or `Complete`.
     * Note that you will almost *always* want this to be set to `Incremental` otherwise the deployment will destroy all infrastructure not
     * specified within the template, and Terraform will not be aware of this.
     */
    readonly deploymentMode: pulumi.Input<string>;
    /**
     * Specifies the name of the template deployment. Changing this forces a
     * new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Specifies the name and value pairs that define the deployment parameters for the template.
     */
    readonly parameters?: pulumi.Input<{[key: string]: any}>;
    /**
     * Specifies a valid Azure JSON parameters file that define the deployment parameters. It can contain KeyVault references
     */
    readonly parametersBody?: pulumi.Input<string>;
    /**
     * The name of the resource group in which to
     * create the template deployment.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Specifies the JSON definition for the template.
     */
    readonly templateBody?: pulumi.Input<string>;
}
