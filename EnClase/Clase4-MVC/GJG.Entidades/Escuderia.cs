namespace GJG.Entidades;

public class Escuderia
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Pais { get; set; }
    public string ImagenUrl { get; set; }
    public int Fundacion { get; set; }
    public string Motor { get; set; }
    public List<string> Pilotos { get; } = new List<string>();
    public int Puntos {get; set;}

}