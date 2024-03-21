namespace ConsultaAPI.Model
{
    public class Paciente : EntidadeBase
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }        
    }
}
