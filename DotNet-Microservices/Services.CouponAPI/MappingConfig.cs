﻿using AutoMapper;
using Services.CouponAPI.Models;

namespace Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });

            return mappingConfig;
        }
    }
}
