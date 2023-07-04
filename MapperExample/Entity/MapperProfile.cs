using AutoMapper;

namespace MapperExample.Entity
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Student, StudentDto>();
            CreateMap<StudentDto, Student>();
        }
    }
}
