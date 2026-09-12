using GJG.Entidades;
namespace GJG.Entidades;

public class Escuderia
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Pais { get; set; }
    public string ImagenUrl { get; set; }
    public int Fundacion { get; set; }
    public string Motor { get; set; }
    public List<Piloto> Pilotos { get; set; } = new List<Piloto>();
    public int Puntos {get; set;}

}