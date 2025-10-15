namespace ParquimetroDsin.Entities
{
    public class Veiculo
    {
        public int Id { get; set; }              
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }

        public int UsuarioId { get; set; }       
        public Usuario Usuario { get; set; }     
    }
}

