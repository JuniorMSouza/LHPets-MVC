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
        // instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Arthur A.Ferreira", "857.032.950-41", "arthur.antunes@sp.senai.br", "madruguinha");
        Cliente cliente2 = new Cliente(02, "Robelvado b. leite", "039.618.250-09", "robel20231@sp.senai.br", "caramelo de esquina");
        Cliente cliente3 = new Cliente(03, "ziraldina l.matos", "800.777.920-50", "ziraldina2023@sp.senai.br", "robevaldo");
        Cliente cliente4 = new Cliente(04, "Girondino l.leite", "933.622.400-03", "giro2020dino@sp.senai.br", "zubumafu");
        Cliente cliente5 = new Cliente(05, "ben p.spider", "911.702.988-00", "bentenison1000@sp.senai.br", "porco aranha" );
        
        
        // lista de clientes e atribui os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;  


        // instancias do tipo fornecedor e atribui os fornecedores
        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl alt Dog", "15.836.698/0001-57", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "BootsPet INC", "40.810.224/0001-83", "boots.pet@gatomania.us");
        Fornecedor fornecedor4 = new Fornecedor(04, "Tik Tok Dogs", "87.945.350/0001-09", "noisnamidia!tiktokdogs.uk");
        Fornecedor fornecedor5 = new Fornecedor(05, "Bifinho Forever", "18.760.614/0001-37", "contato@bff.us"); 
        
        // lista de Fonecedor 
        List<Fornecedor> listaFornecedor = new List<Fornecedor>();
        listaFornecedor.Add(fornecedor1);
        listaFornecedor.Add(fornecedor2);
        listaFornecedor.Add(fornecedor3);
        listaFornecedor.Add(fornecedor4);
        listaFornecedor.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedor;

        
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
