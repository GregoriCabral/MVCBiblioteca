using BibliotecaMVC.Models;

namespace BibliotecaMVC.Data.Repositorio.Interfaces
{
    public interface IReservaRepositorio
    {
        List<Reserva> BuscarReservas();
        void InserirReserva(Reserva reserva);
        Reserva BuscarId(int id);
        void EditarReserva(Reserva reserva);
        void ExcluirReserva(Reserva reserva);
    }
}
