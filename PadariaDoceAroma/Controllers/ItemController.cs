using Microsoft.AspNetCore.Mvc;
using PadariaDoceAroma.Models;

namespace PadariaDoceAroma.Controllers
{
    public class ItemController : Controller
    {

        private static IList<Item> _listaItens = new List<Item>();
        private static int _idItem = 0;
        
        public IActionResult Index()
        {
            return View(_listaItens);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Item item)
        {
            item.Id = ++_idItem;
            _listaItens.Add(item);
            Console.WriteLine(item.Id);
            Console.WriteLine(item.Descricao);
            Console.WriteLine(item.Nome);
            return RedirectToAction("Cadastrar");
        }


        [HttpGet]
        public IActionResult Editar(int id)
        {
            //Pesquisar o veiculo pelo ID
            var veiculo = _listaItens.First(v => v.Id == id);
            //Enviar o objeto Veiculo para a View
            return View(veiculo);
        }

        [HttpPost]
        public IActionResult Editar(Item veiculo)
        {
            //Atualizar o veiculo na lista
            //Pesquisar a posição do veiculo na lista
            var index = _listaItens.ToList().FindIndex(v => v.Id == veiculo.Id);
            //Atualiza o veiculo na lista, adicionando o novo veiculo na posição do veiculo antigo
            _listaItens[index] = veiculo;
            //Enviar uma mensagem para view
            TempData["msg"] = "Veículo Atualizado!";
            //Redirect para a listagem (index)
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Apagar(int id)

        {
            _listaItens.Remove(_listaItens.First(i => i.Id == id));
            TempData["msg"] = "Veiculo removido!";
            //Redirect para a Index
            return RedirectToAction("Index");
        }

    }
}
