using ParquimetroDsin.Entities;

namespace ParquimetroDsin.Interface
{
    public interface ITicketService
    {
        public Ticket CriarTicket(CriarTicketDTO dto);
        public Ticket EditarETicket(CriarTicketDTO dto);
    }
}
