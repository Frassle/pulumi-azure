# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities, tables

class Registry(pulumi.CustomResource):
    """
    Manages an Azure Container Registry.
    
    ~> **Note:** All arguments including the access key will be stored in the raw state as plain-text.
    [Read more about sensitive data in state](https://www.terraform.io/docs/state/sensitive-data.html).
    """
    def __init__(__self__, __name__, __opts__=None, admin_enabled=None, georeplication_locations=None, location=None, name=None, resource_group_name=None, sku=None, storage_account=None, storage_account_id=None, tags=None):
        """Create a Registry resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, str):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        __props__['admin_enabled'] = admin_enabled

        __props__['georeplication_locations'] = georeplication_locations

        if not location:
            raise TypeError('Missing required property location')
        __props__['location'] = location

        __props__['name'] = name

        if not resource_group_name:
            raise TypeError('Missing required property resource_group_name')
        __props__['resource_group_name'] = resource_group_name

        __props__['sku'] = sku

        __props__['storage_account'] = storage_account

        __props__['storage_account_id'] = storage_account_id

        __props__['tags'] = tags

        __props__['admin_password'] = None
        __props__['admin_username'] = None
        __props__['login_server'] = None

        super(Registry, __self__).__init__(
            'azure:containerservice/registry:Registry',
            __name__,
            __props__,
            __opts__)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

