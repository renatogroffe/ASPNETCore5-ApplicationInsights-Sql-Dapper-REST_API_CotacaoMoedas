using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using APIMoedas.Data;
using APIMoedas.Models;

namespace APIMoedas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CotacoesController : ControllerBase
    {
        private readonly ILogger<CotacoesController> _logger;
        private readonly CotacoesRepository _repository;

        public CotacoesController(ILogger<CotacoesController> logger,
            CotacoesRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Cotacao> Get()
        {
            _logger.LogInformation($"Recebida requisição {DateTime.Now:HH:mm:ss}");
            return _repository.GetAll();
        }
    }
}