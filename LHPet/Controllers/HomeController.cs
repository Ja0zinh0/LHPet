using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var clientes = new List<Cliente>
        {
            new Cliente
            {
                Id = 1,
                Nome = "Ana Silva",
                Cpf = "123.456.789-00",
                Email = "ana.silva@example.com",
                Paciente = "Luna"
            },
            new Cliente
            {
                Id = 2,
                Nome = "Bruno Souza",
                Cpf = "987.654.321-00",
                Email = "bruno.souza@example.com",
                Paciente = "Thor"
            },
            new Cliente
            {
                Id = 3,
                Nome = "Carla Santos",
                Cpf = "456.789.123-00",
                Email = "carla.santos@example.com",
                Paciente = "Mel"
            }
        };

        var fornecedores = new List<Fornecedor>
        {
            new Fornecedor
            {
                Id = 1,
                Nome = "Pet Foods Ltda.",
                Cnpj = "12.345.678/0001-00",
                Email = "contato@petfoods.example.com"
            },
            new Fornecedor
            {
                Id = 2,
                Nome = "Vet Saúde Distribuidora",
                Cnpj = "98.765.432/0001-00",
                Email = "vendas@vetsaude.example.com"
            },
            new Fornecedor
            {
                Id = 3,
                Nome = "Mundo Animal Produtos",
                Cnpj = "45.678.912/0001-00",
                Email = "comercial@mundoanimal.example.com"
            }
        };

        ViewBag.Clientes = clientes;
        ViewBag.Fornecedores = fornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
