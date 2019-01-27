# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import pulumi
import pulumi.runtime
from .. import utilities, tables

class Subscription(pulumi.CustomResource):
    auto_delete_on_idle: pulumi.Output[str]
    """
    The idle interval after which the
    Subscription is automatically deleted, minimum of 5 minutes. Provided in the
    TimeSpan format.
    """
    dead_lettering_on_filter_evaluation_exceptions: pulumi.Output[bool]
    dead_lettering_on_message_expiration: pulumi.Output[bool]
    """
    Boolean flag which controls
    whether the Subscription has dead letter support when a message expires. Defaults
    to false.
    """
    default_message_ttl: pulumi.Output[str]
    """
    The TTL of messages sent to this Subscription
    if no TTL value is set on the message itself. Provided in the TimeSpan
    format.
    """
    enable_batched_operations: pulumi.Output[bool]
    """
    Boolean flag which controls whether the
    Subscription supports batched operations. Defaults to false.
    """
    forward_to: pulumi.Output[str]
    """
    The name of a Queue or Topic to automatically forward 
    messages to.
    """
    location: pulumi.Output[str]
    """
    Specifies the supported Azure location where the resource exists.
    Changing this forces a new resource to be created.
    """
    lock_duration: pulumi.Output[str]
    """
    The lock duration for the subscription, maximum
    supported value is 5 minutes. Defaults to 1 minute.
    """
    max_delivery_count: pulumi.Output[int]
    """
    The maximum number of deliveries.
    """
    name: pulumi.Output[str]
    """
    Specifies the name of the ServiceBus Subscription resource.
    Changing this forces a new resource to be created.
    """
    namespace_name: pulumi.Output[str]
    """
    The name of the ServiceBus Namespace to create
    this Subscription in. Changing this forces a new resource to be created.
    """
    requires_session: pulumi.Output[bool]
    """
    Boolean flag which controls whether this Subscription
    supports the concept of a session. Defaults to false. Changing this forces a
    new resource to be created.
    """
    resource_group_name: pulumi.Output[str]
    """
    The name of the resource group in which to
    create the namespace. Changing this forces a new resource to be created.
    """
    topic_name: pulumi.Output[str]
    """
    The name of the ServiceBus Topic to create
    this Subscription in. Changing this forces a new resource to be created.
    """
    def __init__(__self__, __name__, __opts__=None, auto_delete_on_idle=None, dead_lettering_on_filter_evaluation_exceptions=None, dead_lettering_on_message_expiration=None, default_message_ttl=None, enable_batched_operations=None, forward_to=None, location=None, lock_duration=None, max_delivery_count=None, name=None, namespace_name=None, requires_session=None, resource_group_name=None, topic_name=None):
        """
        Manage a ServiceBus Subscription.
        
        
        :param str __name__: The name of the resource.
        :param pulumi.ResourceOptions __opts__: Options for the resource.
        :param pulumi.Input[str] auto_delete_on_idle: The idle interval after which the
               Subscription is automatically deleted, minimum of 5 minutes. Provided in the
               TimeSpan format.
        :param pulumi.Input[bool] dead_lettering_on_filter_evaluation_exceptions
        :param pulumi.Input[bool] dead_lettering_on_message_expiration: Boolean flag which controls
               whether the Subscription has dead letter support when a message expires. Defaults
               to false.
        :param pulumi.Input[str] default_message_ttl: The TTL of messages sent to this Subscription
               if no TTL value is set on the message itself. Provided in the TimeSpan
               format.
        :param pulumi.Input[bool] enable_batched_operations: Boolean flag which controls whether the
               Subscription supports batched operations. Defaults to false.
        :param pulumi.Input[str] forward_to: The name of a Queue or Topic to automatically forward 
               messages to.
        :param pulumi.Input[str] location: Specifies the supported Azure location where the resource exists.
               Changing this forces a new resource to be created.
        :param pulumi.Input[str] lock_duration: The lock duration for the subscription, maximum
               supported value is 5 minutes. Defaults to 1 minute.
        :param pulumi.Input[int] max_delivery_count: The maximum number of deliveries.
        :param pulumi.Input[str] name: Specifies the name of the ServiceBus Subscription resource.
               Changing this forces a new resource to be created.
        :param pulumi.Input[str] namespace_name: The name of the ServiceBus Namespace to create
               this Subscription in. Changing this forces a new resource to be created.
        :param pulumi.Input[bool] requires_session: Boolean flag which controls whether this Subscription
               supports the concept of a session. Defaults to false. Changing this forces a
               new resource to be created.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to
               create the namespace. Changing this forces a new resource to be created.
        :param pulumi.Input[str] topic_name: The name of the ServiceBus Topic to create
               this Subscription in. Changing this forces a new resource to be created.
        """
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, str):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        __props__['auto_delete_on_idle'] = auto_delete_on_idle

        __props__['dead_lettering_on_filter_evaluation_exceptions'] = dead_lettering_on_filter_evaluation_exceptions

        __props__['dead_lettering_on_message_expiration'] = dead_lettering_on_message_expiration

        __props__['default_message_ttl'] = default_message_ttl

        __props__['enable_batched_operations'] = enable_batched_operations

        __props__['forward_to'] = forward_to

        __props__['location'] = location

        __props__['lock_duration'] = lock_duration

        if not max_delivery_count:
            raise TypeError('Missing required property max_delivery_count')
        __props__['max_delivery_count'] = max_delivery_count

        __props__['name'] = name

        if not namespace_name:
            raise TypeError('Missing required property namespace_name')
        __props__['namespace_name'] = namespace_name

        __props__['requires_session'] = requires_session

        if not resource_group_name:
            raise TypeError('Missing required property resource_group_name')
        __props__['resource_group_name'] = resource_group_name

        if not topic_name:
            raise TypeError('Missing required property topic_name')
        __props__['topic_name'] = topic_name

        super(Subscription, __self__).__init__(
            'azure:eventhub/subscription:Subscription',
            __name__,
            __props__,
            __opts__)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

