# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class ExpressRouteCircuitAuthorization(pulumi.CustomResource):
    authorization_key: pulumi.Output[str]
    """
    The Authorization Key.
    """
    authorization_use_status: pulumi.Output[str]
    """
    The authorization use status.
    """
    express_route_circuit_name: pulumi.Output[str]
    """
    The name of the Express Route Circuit in which to create the Authorization.
    """
    name: pulumi.Output[str]
    """
    The name of the ExpressRoute circuit. Changing this forces a
    new resource to be created.
    """
    resource_group_name: pulumi.Output[str]
    """
    The name of the resource group in which to
    create the ExpressRoute circuit. Changing this forces a new resource to be created.
    """
    def __init__(__self__, resource_name, opts=None, express_route_circuit_name=None, name=None, resource_group_name=None, __name__=None, __opts__=None):
        """
        Manages an ExpressRoute Circuit Authorization.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] express_route_circuit_name: The name of the Express Route Circuit in which to create the Authorization.
        :param pulumi.Input[str] name: The name of the ExpressRoute circuit. Changing this forces a
               new resource to be created.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to
               create the ExpressRoute circuit. Changing this forces a new resource to be created.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if not resource_name:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(resource_name, str):
            raise TypeError('Expected resource name to be a string')
        if opts and not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if express_route_circuit_name is None:
            raise TypeError('Missing required property express_route_circuit_name')
        __props__['express_route_circuit_name'] = express_route_circuit_name

        __props__['name'] = name

        if resource_group_name is None:
            raise TypeError('Missing required property resource_group_name')
        __props__['resource_group_name'] = resource_group_name

        __props__['authorization_key'] = None
        __props__['authorization_use_status'] = None

        super(ExpressRouteCircuitAuthorization, __self__).__init__(
            'azure:network/expressRouteCircuitAuthorization:ExpressRouteCircuitAuthorization',
            resource_name,
            __props__,
            opts)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

