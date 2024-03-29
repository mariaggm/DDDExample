﻿using Domain.Command;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly IVeiculoService _veiculoService;
        public VeiculoController(IVeiculoService veiculoService)
        { 
            _veiculoService = veiculoService; 
        }
        
        [HttpPost]
        [Route("CadastrarVeiculos")]
        public async Task<IActionResult> PostAsync([FromBody] VeiculoCommand command) 
        {
             
            return Ok(await _veiculoService.PostAsync(command));

        }
        [HttpGet]
        [Route("SimularAluguel")]

        public IActionResult GetAsync() 
        {
            
            return Ok();

        }
        [HttpPost]
        [Route("Alugar")]
        public IActionResult PostAsync()
        {
            return Ok(); 

        }
    }
}
