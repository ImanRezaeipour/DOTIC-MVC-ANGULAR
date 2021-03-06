﻿using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using PTC.DOTIC.Authorization.Users;

namespace PTC.DOTIC.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}