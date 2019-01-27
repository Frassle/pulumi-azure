# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import pulumi
import pulumi.runtime
from .. import utilities, tables

class Application(pulumi.CustomResource):
    application_id: pulumi.Output[str]
    """
    The Application ID.
    """
    available_to_other_tenants: pulumi.Output[bool]
    """
    Is this Azure AD Application available to other tenants? Defaults to `false`.
    """
    homepage: pulumi.Output[str]
    """
    The URL to the application's home page. If no homepage is specified this defaults to `https://{name}`.
    """
    identifier_uris: pulumi.Output[list]
    """
    A list of user-defined URI(s) that uniquely identify a Web application within it's Azure AD tenant, or within a verified custom domain if the application is multi-tenant.
    """
    name: pulumi.Output[str]
    """
    The display name for the application.
    """
    oauth2_allow_implicit_flow: pulumi.Output[bool]
    """
    Does this Azure AD Application allow OAuth2.0 implicit flow tokens? Defaults to `false`.
    """
    reply_urls: pulumi.Output[list]
    """
    A list of URLs that user tokens are sent to for sign in, or the redirect URIs that OAuth 2.0 authorization codes and access tokens are sent to.
    """
    def __init__(__self__, __name__, __opts__=None, available_to_other_tenants=None, homepage=None, identifier_uris=None, name=None, oauth2_allow_implicit_flow=None, reply_urls=None):
        """
        Manages an Application within Azure Active Directory.
        
        > **NOTE:** The Azure Active Directory resources have been split out into [a new AzureAD Provider](http://terraform.io/docs/providers/azuread/index.html) - as such the AzureAD resources within the AzureRM Provider are deprecated and will be removed in the next major version (2.0). Information on how to migrate from the existing resources to the new AzureAD Provider can be found here.
        
        -> **NOTE:** If you're authenticating using a Service Principal then it must have permissions to both `Read and write all applications` and `Sign in and read user profile` within the `Windows Azure Active Directory` API.
        
        
        :param str __name__: The name of the resource.
        :param pulumi.ResourceOptions __opts__: Options for the resource.
        :param pulumi.Input[bool] available_to_other_tenants: Is this Azure AD Application available to other tenants? Defaults to `false`.
        :param pulumi.Input[str] homepage: The URL to the application's home page. If no homepage is specified this defaults to `https://{name}`.
        :param pulumi.Input[list] identifier_uris: A list of user-defined URI(s) that uniquely identify a Web application within it's Azure AD tenant, or within a verified custom domain if the application is multi-tenant.
        :param pulumi.Input[str] name: The display name for the application.
        :param pulumi.Input[bool] oauth2_allow_implicit_flow: Does this Azure AD Application allow OAuth2.0 implicit flow tokens? Defaults to `false`.
        :param pulumi.Input[list] reply_urls: A list of URLs that user tokens are sent to for sign in, or the redirect URIs that OAuth 2.0 authorization codes and access tokens are sent to.
        """
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, str):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        __props__['available_to_other_tenants'] = available_to_other_tenants

        __props__['homepage'] = homepage

        __props__['identifier_uris'] = identifier_uris

        __props__['name'] = name

        __props__['oauth2_allow_implicit_flow'] = oauth2_allow_implicit_flow

        __props__['reply_urls'] = reply_urls

        __props__['application_id'] = None

        super(Application, __self__).__init__(
            'azure:ad/application:Application',
            __name__,
            __props__,
            __opts__)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

