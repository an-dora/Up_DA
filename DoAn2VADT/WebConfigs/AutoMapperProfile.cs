using AutoMapper;
using DoAn2VADT.Database.Entities;
using DoAn2VADT.ViewModels.Book;

namespace DoAn2VADT.WebConfigs
{
    public class AutoMapperProfile :Profile
    {
        public static MapperConfiguration bookAMC = new(opt =>
        {
            opt.CreateMap<Book, AoU_BookVM>();
            opt.CreateMap<Book, ListItemBook>();

        });
    }

}
