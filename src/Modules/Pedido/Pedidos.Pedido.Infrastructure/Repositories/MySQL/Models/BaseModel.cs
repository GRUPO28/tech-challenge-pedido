using System.ComponentModel.DataAnnotations;

namespace Pedidos.Pedido.Infrastructure.Repositories.MySQL.Models;

public class BaseModel
{
    [Key]
    public string Id { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime? DataAtualizacao { get; set; }
}