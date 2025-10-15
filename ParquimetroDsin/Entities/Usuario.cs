namespace ParquimetroDsin.Entities
{
        public class Usuario
        {
            public int Id { get; set; }              
            public string Nome { get; set; }
            public string Fun_Usuario { get; set; }
            public string SenhaHash { get; set; }    
            public DateTime DataCadastro { get; set; } = DateTime.Now;

            public virtual List<Veiculo> Veiculos { get; set; } 
            public virtual List<Ticket> Tickets { get; set; }
        }
  }