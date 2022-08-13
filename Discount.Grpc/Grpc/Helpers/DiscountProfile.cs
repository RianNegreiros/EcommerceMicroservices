using AutoMapper;
using Discount.Grpc.Core.Entities;
using Discount.Grpc.Protos;

namespace Discount.Grpc.Grpc.Helpers;

public class DiscountProfile : Profile
{
    public DiscountProfile()
    {
        CreateMap<Coupon, CouponModel>().ReverseMap();
    }
}