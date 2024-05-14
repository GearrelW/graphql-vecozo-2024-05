using VecozoApi.Entities;

namespace VecozoApi.Types
{
    public class ShowUnionType : UnionType
    {
        protected override void Configure(IUnionTypeDescriptor descriptor)
        {
            descriptor.Type<TvShowType>();
            descriptor.Type<StreamingShowType>();
            descriptor.Type<NotOldEnoughType>();
        }
    }
}
