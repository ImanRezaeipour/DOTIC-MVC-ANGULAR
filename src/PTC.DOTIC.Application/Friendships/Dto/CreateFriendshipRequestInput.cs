using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace PTC.DOTIC.Friendships.Dto
{
    public class CreateFriendshipRequestInput
    {
        [Range(1, long.MaxValue)]
        public long UserId { get; set; }

        public int? TenantId { get; set; }
    }
}