namespace ParquimetroDsin.Entities
{
    public class Vaga
    {
        public int Id { get; set; }              
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool Ocupada { get; set; } = false;
        public string Descricao { get; set; }   
    }
}
