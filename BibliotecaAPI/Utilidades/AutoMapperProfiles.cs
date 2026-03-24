using AutoMapper;
using BibliotecaAPI.DTOs;
using BibliotecaAPI.Enitities;

namespace BibliotecaAPI.Utilidades
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Autor, AutorDTO>()
                .ForMember(dto => dto.NombreCompleto, config => config.MapFrom(autor => MapearNombreYApellidosAutor(autor)));

            CreateMap<Autor, AutorConLibrosDTO>()
               .ForMember(dto => dto.NombreCompleto, config => config.MapFrom(autor => MapearNombreYApellidosAutor(autor)));

           
            CreateMap<AutorCreateDTO, Autor>();
            CreateMap<Autor, AutorPatchDTO>().ReverseMap();  
            CreateMap<Libro, LibroDTO>();
            CreateMap<LibroCreateDTO, Libro>();

            CreateMap<Libro, LibrosConAutorDTO>()
                .ForMember(dto => dto.AutorNombre, config => config.MapFrom(ent => MapearNombreYApellidosAutor(ent.Autor!)));
        }

        private string MapearNombreYApellidosAutor(Autor autor) => $"{autor.Nombres} {autor.Apellidos}";
    }
}
