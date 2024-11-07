using BibliotecaMVC.Data.Repositorio.Interfaces;
using BibliotecaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaMVC.Controllers
{
    public class ReservaController : Controller
    {
        private readonly IReservaRepositorio _reservaRepositorio;

        public ReservaController(IReservaRepositorio reservaRepositorio)
        {
            _reservaRepositorio = reservaRepositorio;
        }

        public IActionResult Index()
        {
            var reserva = _reservaRepositorio.BuscarReservas();
            return View(reserva);
        }

        public IActionResult AdicionarReserva()
        {
            return View();
        }

        public IActionResult InserirReserva(Reserva reserva)
        {
            try
            {
                _reservaRepositorio.InserirReserva(reserva);
            }
            catch (Exception)
            {

                throw;
            }

            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var reserva = _reservaRepositorio.BuscarId(id);
            return View(reserva);
        }

        public IActionResult EditarReserva(Reserva reserva)
        {
            _reservaRepositorio.EditarReserva(reserva);
            return RedirectToAction("Index");
        }

        public IActionResult ExcluirReserva(Reserva reserva)
        {
            _reservaRepositorio.ExcluirReserva(reserva);
            return RedirectToAction("Index");
        }
    }
}
