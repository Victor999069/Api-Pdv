namespace API_PDV.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set;}
        public string Cnpj { get; set;}
        public string? InscricaoEstadual { get; set;}
        public string ?InscricaoMunicipal { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string TelFixo { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string? Observacoes { get; set; }

    }
}
