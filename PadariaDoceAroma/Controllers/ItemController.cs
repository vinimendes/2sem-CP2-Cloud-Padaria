﻿using Microsoft.AspNetCore.Mvc;
using PadariaDoceAroma.DataBase;
using PadariaDoceAroma.Models;

namespace PadariaDoceAroma.Controllers
{
    public class ItemController : Controller
    {
        // Para nao precisar mais usar as LISTAS
        private PadariaContext _context;

        // Para nao precisar mais usar as LISTAS
        public ItemController(PadariaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            var listaItens = _context.Itens.ToList();

            return View(listaItens);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Item item)
        {

            _context.Itens.Add(item);
            _context.SaveChanges();
            
            TempData["mensagem"] = "Item cadastrado com sucesso!";
            
            return RedirectToAction("Cadastrar");

        }


        [HttpGet]
        public IActionResult Editar(int id)
        {

            var item = _context.Itens.Find(id);

            return View(item);
        }

        [HttpPost]
        public IActionResult Editar(Item item)
        {

            _context.Itens.Update(item);
            _context.SaveChanges();

            TempData["mensagem"] = " Item atualizado com sucesso!!";

            return RedirectToAction("Editar");
        }


        [HttpPost]
        public IActionResult Apagar(Item item)

        {

            _context.Itens.Remove(item);
            _context.SaveChanges();

            TempData["mensagem"] = "O item selecionado foi removido com sucesso!";

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Pesquisar(string nomePesquisa)
        {

            var listaPesquisa = _context.Itens.Where(
                                    i => i.Nome.ToLower()
                                               .Contains(nomePesquisa.ToLower()))
                                               .ToList();

            return View(listaPesquisa);
        }

        public double PesquisaValor(int id)
        {
            var Item = _context.Itens.First(i => i.Id == id);


            return Item.Valor;
        }

        public IActionResult Resetar()
        {

            return RedirectToAction("Index");

        }

    }
}
