using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PadariaDoceAroma.DataBase;
using PadariaDoceAroma.Models;

namespace PadariaDoceAroma.Controllers
{
    public class PedidoController : Controller
    {

        private PadariaContext _context;

        private static IList<Item> _listaItens = new List<Item>();


        public PedidoController(PadariaContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            _listaItens = _context.Itens.ToList();
            ViewBag.Pedido = new Pedido();

            return View(_listaItens);
        }


        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Pedido pedido, int ItemId)
        {

            ItemController ItemValorPesquisa = new ItemController(_context);
            

            pedido.DataPedido = DateTime.Now;
            pedido.FkItemId =  ItemId;

            // Valor
            pedido.valorPedido = ItemValorPesquisa.PesquisaValor(ItemId);

            _context.Pedidos.Add(pedido);
            _context.SaveChanges();

            TempData["mensagem"] = "Pedido cadastrado com sucesso!";

            return RedirectToAction("Index");

        }
    }
}
