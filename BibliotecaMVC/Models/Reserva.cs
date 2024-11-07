namespace BibliotecaMVC.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public DateTime Quando {  get; set; }
        public DateTime Devolucao { get; set; }
        public String Pessoa {  get; set; }
        public String Livro { get; set; }
    }
}
