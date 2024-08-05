namespace Negocios.Models;

public class Usuario
{
    public string? login { get; set; }
    public int id { get; set; }
    public string? name { get; set; }
    public DateTime? created_at { get; set; }
    public DateTime? updated_at { get; set; }
}
