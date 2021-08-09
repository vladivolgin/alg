﻿using AutoMapper;
using MetricsAgent.Responses;
using MetricsAgent.Models;




namespace Lesson_5
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<CpuMetric, CpuMetricDto>();
            CreateMap<AgentInfo, AgentInfoDto>();
            CreateMap<RamMetric, RamMetricDto>();
            CreateMap<HddMetric, HddMetricDto>();
        }
    }
}