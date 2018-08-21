// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package role

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages a custom Role Definition, used to assign Roles to Users/Principals. See ['Understand role definitions'](https://docs.microsoft.com/en-us/azure/role-based-access-control/role-definitions) in the Azure documentation for more details.
type Definition struct {
	s *pulumi.ResourceState
}

// NewDefinition registers a new resource with the given unique name, arguments, and options.
func NewDefinition(ctx *pulumi.Context,
	name string, args *DefinitionArgs, opts ...pulumi.ResourceOpt) (*Definition, error) {
	if args == nil || args.AssignableScopes == nil {
		return nil, errors.New("missing required argument 'AssignableScopes'")
	}
	if args == nil || args.Permissions == nil {
		return nil, errors.New("missing required argument 'Permissions'")
	}
	if args == nil || args.Scope == nil {
		return nil, errors.New("missing required argument 'Scope'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["assignableScopes"] = nil
		inputs["description"] = nil
		inputs["name"] = nil
		inputs["permissions"] = nil
		inputs["roleDefinitionId"] = nil
		inputs["scope"] = nil
	} else {
		inputs["assignableScopes"] = args.AssignableScopes
		inputs["description"] = args.Description
		inputs["name"] = args.Name
		inputs["permissions"] = args.Permissions
		inputs["roleDefinitionId"] = args.RoleDefinitionId
		inputs["scope"] = args.Scope
	}
	s, err := ctx.RegisterResource("azure:role/definition:Definition", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Definition{s: s}, nil
}

// GetDefinition gets an existing Definition resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDefinition(ctx *pulumi.Context,
	name string, id pulumi.ID, state *DefinitionState, opts ...pulumi.ResourceOpt) (*Definition, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["assignableScopes"] = state.AssignableScopes
		inputs["description"] = state.Description
		inputs["name"] = state.Name
		inputs["permissions"] = state.Permissions
		inputs["roleDefinitionId"] = state.RoleDefinitionId
		inputs["scope"] = state.Scope
	}
	s, err := ctx.ReadResource("azure:role/definition:Definition", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Definition{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Definition) URN() *pulumi.URNOutput {
	return r.s.URN
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Definition) ID() *pulumi.IDOutput {
	return r.s.ID
}

// One or more assignable scopes for this Role Definition, such as `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333`, `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup`, or `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM`.
func (r *Definition) AssignableScopes() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["assignableScopes"])
}

// A description of the Role Definition.
func (r *Definition) Description() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["description"])
}

// The name of the Role Definition. Changing this forces a new resource to be created.
func (r *Definition) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// A `permissions` block as defined below.
func (r *Definition) Permissions() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["permissions"])
}

// A unique UUID/GUID which identifies this role - one will be generated if not specified. Changing this forces a new resource to be created.
func (r *Definition) RoleDefinitionId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["roleDefinitionId"])
}

// The scope at which the Role Definition applies too, such as `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333`, `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup`, or `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM`. Changing this forces a new resource to be created.
func (r *Definition) Scope() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["scope"])
}

// Input properties used for looking up and filtering Definition resources.
type DefinitionState struct {
	// One or more assignable scopes for this Role Definition, such as `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333`, `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup`, or `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM`.
	AssignableScopes interface{}
	// A description of the Role Definition.
	Description interface{}
	// The name of the Role Definition. Changing this forces a new resource to be created.
	Name interface{}
	// A `permissions` block as defined below.
	Permissions interface{}
	// A unique UUID/GUID which identifies this role - one will be generated if not specified. Changing this forces a new resource to be created.
	RoleDefinitionId interface{}
	// The scope at which the Role Definition applies too, such as `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333`, `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup`, or `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM`. Changing this forces a new resource to be created.
	Scope interface{}
}

// The set of arguments for constructing a Definition resource.
type DefinitionArgs struct {
	// One or more assignable scopes for this Role Definition, such as `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333`, `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup`, or `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM`.
	AssignableScopes interface{}
	// A description of the Role Definition.
	Description interface{}
	// The name of the Role Definition. Changing this forces a new resource to be created.
	Name interface{}
	// A `permissions` block as defined below.
	Permissions interface{}
	// A unique UUID/GUID which identifies this role - one will be generated if not specified. Changing this forces a new resource to be created.
	RoleDefinitionId interface{}
	// The scope at which the Role Definition applies too, such as `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333`, `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup`, or `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM`. Changing this forces a new resource to be created.
	Scope interface{}
}
