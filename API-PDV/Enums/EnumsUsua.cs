using System.ComponentModel;

namespace API_PDV.Enums
{
    public enum EnumsUsua
    {
        [Description("Cliente")]
        Cliente = 1,
        [Description("Fornecedor")]
        Fornecedor = 2,
        [Description("Transportadora")]
        Transportadora = 3,
        [Description("Funcionário(a)")]
        Funcionario = 4
    }
}
