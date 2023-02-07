using AutoMapper;
using GolfSweep.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfSweep.Data
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EventDto, Event>().ReverseMap();

            });

            //return;



        }


    }

}
