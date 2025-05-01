using AutoMapper;
using FIAP.Contacts.Delete.Application.Dto;
using FIAP.Contacts.Delete.Domain.ContactAggregate;

namespace FIAP.Contacts.Delete.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Contact, ContactDto>().ReverseMap();
            CreateMap<Contact, ContactWithIdDto>().ReverseMap();
            CreateMap<Phone, PhoneDto>().ReverseMap();
            CreateMap<Address, AddressDto>().ReverseMap();

        }
    }
}
