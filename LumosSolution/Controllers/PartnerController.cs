﻿using BussinessObject;
using DataTransferObject.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.InterfaceService;
using Service.Service;
using Utils;

namespace LumosSolution.Controllers
{
    [Route("api/partner")]
    [ApiController]
    public class PartnerController : ControllerBase
    {
        private readonly IPartnerService _partnerService;
        public PartnerController(IPartnerService partnerService)
        {
            _partnerService = partnerService;
        }

        [HttpGet("service/{id}")]
        [Authorize(Roles = "Admin,Customer,Partner")]
        public async Task<ActionResult<PartnerServiceDTO?>> GetaPartnerServiceDetailById(int id){
            ApiResponse<PartnerServiceDTO?> res = await _partnerService.GetPartnerServiceDetailAsync(id);
            return Ok(res);
        }

        [HttpGet, Route("{keyword?}")]
        [Authorize(Roles = "Admin,Customer,Partner")]
        public async Task<ActionResult<IEnumerable<Partner>>> GetPartnerByPartnerOrServiceName(string? keyword = null)
        {
            ApiResponse<IEnumerable<Partner>> res = await _partnerService.SearchPartnerByPartnerOrServiceName(keyword);

            if(res.StatusCode == 200)
            {
                return Ok(res);
            }
            return BadRequest();
        }

    }
}
