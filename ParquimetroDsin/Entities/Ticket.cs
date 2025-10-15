namespace ParquimetroDsin.Entities
{
    public class Ticket
    {
        public int Id { get; set; }              
        public DateTime DataEntrada { get; set; } = DateTime.Now;
        public DateTime? DataSaida { get; set; }
        public decimal Valor { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
