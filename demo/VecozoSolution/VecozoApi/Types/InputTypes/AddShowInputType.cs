using VecozoApi.Entities.Inputs;

namespace VecozoApi.Types.InputTypes;

public class AddShowInputType : InputObjectType<AddShowInput>
{
    protected override void Configure(IInputObjectTypeDescriptor<AddShowInput> descriptor)
    {
        //descriptor.Field(f => f.Title).Type<StringType>();
    }
}
