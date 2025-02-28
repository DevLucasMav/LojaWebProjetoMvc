using LojaWeb.Controllers.Base;
using LojaWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AutoMapper;

namespace LojaWeb.Controllers
{
    public class ClienteController : BaseController
    {

        private readonly IMapper _mapper;

        public ClienteController(IMapper mapper) 
        {
            _mapper = mapper; 
        }

        public IActionResult Index()
        {
            List<ClienteViewModel> lstCliente = new List<ClienteViewModel>()
            {
                new ClienteViewModel()
                {
                    Nome = "Lucas",
                    Endereço = "",
                    Telefone = "123"
                },

                 new ClienteViewModel()
                {
                    Nome = "Ranielle",
                    Endereço = "",
                    Telefone = "456"
                }
            };
            return View(lstCliente);
        }

        public IActionResult Create()
        {
            var cliente = new ClienteViewModel() { CPF = "1", Endereço = "a", Id = 1, Nome = "Lucas", NumeroCartaoCredito = "1", Telefone = "1" };


            var clienteVM = _mapper.Map<ClienteViewModel>(cliente);

            return View(clienteVM);
        }

        [HttpPost]
        public IActionResult Create(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                List<ClienteViewModel> lstCliente = new List<ClienteViewModel>();
                lstCliente.Add(cliente);
                Mensagem("Cliente salvo com sucesso", "Success");
                return View("index", lstCliente);

            }
            return View(cliente);
        }

        public IActionResult Details(string nome) 
        {
            return View();
        }
    }
}
