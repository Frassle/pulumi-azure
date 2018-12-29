# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities, tables

class StoreFile(pulumi.CustomResource):
    """
    Manage a Azure Data Lake Store File.
    
    > **Note:** If you want to change the data in the remote file without changing the `local_file_path`, then 
    taint the resource so the `azurerm_data_lake_store_file` gets recreated with the new data.
    """
    def __init__(__self__, __name__, __opts__=None, account_name=None, local_file_path=None, remote_file_path=None):
        """Create a StoreFile resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, str):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if not account_name:
            raise TypeError('Missing required property account_name')
        __props__['account_name'] = account_name

        if not local_file_path:
            raise TypeError('Missing required property local_file_path')
        __props__['local_file_path'] = local_file_path

        if not remote_file_path:
            raise TypeError('Missing required property remote_file_path')
        __props__['remote_file_path'] = remote_file_path

        super(StoreFile, __self__).__init__(
            'azure:datalake/storeFile:StoreFile',
            __name__,
            __props__,
            __opts__)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

