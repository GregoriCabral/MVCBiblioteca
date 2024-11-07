using BibliotecaMVC.Data.Repositorio.Interfaces;
using BibliotecaMVC.Models;

namespace BibliotecaMVC.Data.Repositorio
{
    public class ReservaRepositorio : IReservaRepositorio
    {
        private readonly BancoContexto _bancoContexto;

        public ReservaRepositorio(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }

        public List<Reserva> BuscarReservas()
        {
            return _bancoContexto.Reserva.ToList();
        }

        public void InserirReserva(Reserva reserva)
        {
            _bancoContexto.Reserva.Add(reserva);
            _bancoContexto.SaveChanges();
        }

        //Lambda
        public Reserva BuscarId(int id)
        {
            return _bancoContexto.Reserva.FirstOrDefault(x => x.Id == id);
        }

        public void EditarReserva(Reserva reserva)
        {
            _bancoContexto.Reserva.Update(reserva);
            _bancoContexto.SaveChanges();
        }

        public void ExcluirReserva(Reserva reserva)
        {
            _bancoContexto.Reserva.Remove(reserva);
            _bancoContexto.SaveChanges();
        }
    }
}
