// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package msi

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

type UserAssignedIdentity struct {
	s *pulumi.ResourceState
}

// NewUserAssignedIdentity registers a new resource with the given unique name, arguments, and options.
func NewUserAssignedIdentity(ctx *pulumi.Context,
	name string, args *UserAssignedIdentityArgs, opts ...pulumi.ResourceOpt) (*UserAssignedIdentity, error) {
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["location"] = nil
		inputs["name"] = nil
		inputs["resourceGroupName"] = nil
		inputs["tags"] = nil
	} else {
		inputs["location"] = args.Location
		inputs["name"] = args.Name
		inputs["resourceGroupName"] = args.ResourceGroupName
		inputs["tags"] = args.Tags
	}
	inputs["clientId"] = nil
	inputs["principalId"] = nil
	s, err := ctx.RegisterResource("azure:msi/userAssignedIdentity:UserAssignedIdentity", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &UserAssignedIdentity{s: s}, nil
}

// GetUserAssignedIdentity gets an existing UserAssignedIdentity resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetUserAssignedIdentity(ctx *pulumi.Context,
	name string, id pulumi.ID, state *UserAssignedIdentityState, opts ...pulumi.ResourceOpt) (*UserAssignedIdentity, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["clientId"] = state.ClientId
		inputs["location"] = state.Location
		inputs["name"] = state.Name
		inputs["principalId"] = state.PrincipalId
		inputs["resourceGroupName"] = state.ResourceGroupName
		inputs["tags"] = state.Tags
	}
	s, err := ctx.ReadResource("azure:msi/userAssignedIdentity:UserAssignedIdentity", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &UserAssignedIdentity{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *UserAssignedIdentity) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *UserAssignedIdentity) ID() *pulumi.IDOutput {
	return r.s.ID()
}

func (r *UserAssignedIdentity) ClientId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["clientId"])
}

func (r *UserAssignedIdentity) Location() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["location"])
}

func (r *UserAssignedIdentity) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

func (r *UserAssignedIdentity) PrincipalId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["principalId"])
}

func (r *UserAssignedIdentity) ResourceGroupName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["resourceGroupName"])
}

func (r *UserAssignedIdentity) Tags() *pulumi.MapOutput {
	return (*pulumi.MapOutput)(r.s.State["tags"])
}

// Input properties used for looking up and filtering UserAssignedIdentity resources.
type UserAssignedIdentityState struct {
	ClientId interface{}
	Location interface{}
	Name interface{}
	PrincipalId interface{}
	ResourceGroupName interface{}
	Tags interface{}
}

// The set of arguments for constructing a UserAssignedIdentity resource.
type UserAssignedIdentityArgs struct {
	Location interface{}
	Name interface{}
	ResourceGroupName interface{}
	Tags interface{}
}
