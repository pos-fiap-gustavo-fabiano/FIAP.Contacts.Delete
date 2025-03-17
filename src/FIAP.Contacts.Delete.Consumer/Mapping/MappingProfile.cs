using AutoMapper;
using FIAP.Contacts.Delete.Application.Dto;
using FIAP.Contacts.Delete.Application.Handlers.Commands.UpdateContact;
using FIAP.Contacts.Delete.Application.Handlers.Commands.UpdateContact.Dto;
using FIAP.Contacts.Delete.Consumer.Dtos;
using FIAP.Contacts.Delete.Domain.ContactAggregate;

namespace FIAP.Contacts.Delete.Consumer.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UpdateContactRequest, DeleteContactDto>().ReverseMap();
            CreateMap<Contact, ContactForUpdateDto>().ReverseMap();
            CreateMap<ContactForUpdateDto, Application.Dto.ContactDto>().ReverseMap();
            CreateMap<Contact, Application.Dto.ContactDto>().ReverseMap();
            CreateMap<Contact, ContactWithIdDto>().ReverseMap();
            CreateMap<Phone, Application.Dto.PhoneDto>().ReverseMap();
            CreateMap<Address, Application.Dto.AddressDto>().ReverseMap();

        }
    }
}
