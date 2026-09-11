using GJG.Entidades;

namespace GJG.Logic;

public interface IPilotosServicio
{
    void Agregar(Escuderia escuderia, Piloto piloto);
    void Actualizar(Piloto piloto, int? puntos = 0);
    void Eliminar(Piloto piloto);
    List<Piloto> Listar();
    List<Piloto> ListarPorEscuderia(Escuderia escuderia);
    Piloto? ObtenerPorId(int id);
}

public class PilotosServicio : IPilotosServicio
{
    private static List<Piloto> lista = new List<Piloto>()
    {
        new Piloto()
        {
            EscuderiaId = 1,
            Nombre = "Kimi Antonelli",
            Numero = 12,
            Pais = "Italia",
        },
        new Piloto()
        {
            EscuderiaId = 1,
            Nombre = "George Russell",
            Numero = 63,
            Pais = "Inglaterra",
        },
        new Piloto()
        {
            EscuderiaId = 2,
            Nombre = "Charles Leclerc",
            Numero = 16,
            Pais = "Mónaco",
        },
        new Piloto()
        {
            EscuderiaId = 2,
            Nombre = "Lewis Hamilton",
            Numero = 44,
            Pais = "Reino Unido",
        },
        new Piloto()
        {
            EscuderiaId = 3,
            Nombre = "Max Verstappen",
            Numero = 3,
            Pais = "Países Bajos",
        },
        new Piloto()
        {
            EscuderiaId = 3,
            Nombre = "Isack Hadjar",
            Numero = 6,
            Pais = "Francia",
        },
        new Piloto()
        {
            EscuderiaId = 4,
            Nombre = "Lando Norris",
            Numero = 1,
            Pais = "Reino Unido",
        },
        new Piloto()
        {
            EscuderiaId = 4,
            Nombre = "Oscar Piastri",
            Numero = 81,
            Pais = "Australia",
        },
        new Piloto()
        {
            EscuderiaId = 5,
            Nombre = "Pierre Gasly",
            Numero = 10,
            Pais = "Francia",
        },
        new Piloto()
        {
            EscuderiaId = 5,
            Nombre = "Franco Colapinto",
            Numero = 43,
            Pais = "Argentina",
        },
        new Piloto()
        {
            EscuderiaId = 6,
            Nombre = "Liam Lawson",
            Numero = 30,
            Pais = "Nueva Zelanda",
        },
        new Piloto()
        {
            EscuderiaId = 6,
            Nombre = "Arvid Lindblad",
            Numero = 41,
            Pais = "Reino Unido",
        },
        new Piloto()
        {
            EscuderiaId = 7,
            Nombre = "Gabriel Bortoleto",
            Numero = 5,
            Pais = "Brasil",
        },
        new Piloto()
        {
            EscuderiaId = 7,
            Nombre = "Nico Hülkenberg",
            Numero = 27,
            Pais = "Alemania",
        },
        new Piloto()
        {
            EscuderiaId = 8,
            Nombre = "Oliver Bearman",
            Numero = 87,
            Pais = "Reino Unido",
        },
        new Piloto()
        {
            EscuderiaId = 8,
            Nombre = "Esteban Ocon",
            Numero = 31,
            Pais = "Francia",
        },
        new Piloto()
        {
            EscuderiaId = 9,
            Nombre = "Carlos Sainz",
            Numero = 55,
            Pais = "España",
        },
        new Piloto()
        {
            EscuderiaId = 9,
            Nombre = "Alexander Albon",
            Numero = 23,
            Pais = "Tailandia",
        },
        new Piloto()
        {
            EscuderiaId = 10,
            Nombre = "Fernando Alonso",
            Numero = 14,
            Pais = "España",
        },
        new Piloto()
        {
            EscuderiaId = 10,
            Nombre = "Lance Stroll",
            Numero = 18,
            Pais = "Canadá",
        },
        new Piloto()
        {
            EscuderiaId = 11,
            Nombre = "Sergio Pérez",
            Numero = 11,
            Pais = "México",
        },
        new Piloto()
        {
            EscuderiaId = 11,
            Nombre = "Valtteri Bottas",
            Numero = 77,
            Pais = "Finlandia",
        },
    };

    public PilotosServicio() { }

    /// <summary>
    /// Agrega un Piloto a una Escuderia
    /// </summary>
    /// <param name="piloto"></param>
    /// <param name="escuderio"></param>
    public void Agregar(Escuderia escuderia, Piloto piloto)
    {
        piloto.EscuderiaId = escuderia.Id;
        piloto.Id = lista.Max(p => p.Id) + 1;
        lista.Add(piloto);
    }

    /// <summary>
    /// Actualiza los datos de un Piloto. Tambien puede actualizar los puntos del piloto.
    /// </summary>
    /// <param name="escuderia"></param>
    /// <param name="piloto"></param>
    public void Actualizar(Piloto piloto, int? puntos = 0)
    {
        var pilotoExistente = ObtenerPorId(piloto.Id);
        if (pilotoExistente != null)
        {
            pilotoExistente.Nombre = piloto.Nombre;
            pilotoExistente.Numero = piloto.Numero;
            pilotoExistente.Pais = piloto.Pais;
            if (puntos.HasValue)
            {
                pilotoExistente.puntos += puntos.Value;
            }
        }
    }

    /// <summary>
    /// Elimina un Piloto
    /// </summary>
    /// <param name="piloto"></param>
    public void Eliminar(Piloto piloto)
    {
        var pilotoExistente = ObtenerPorId(piloto.Id);
        if (pilotoExistente != null)
        {
            lista.Remove(pilotoExistente);
        }
    }

    /// <summary>
    /// Lista todos los Pilotos
    /// </summary>
    public List<Piloto> Listar()
    {
        return lista;
    }

    /// <summary>
    /// Lista los Pilotos por Escuderia
    /// </summary>
    /// <param name="escuderia"></param>
    public List<Piloto> ListarPorEscuderia(Escuderia escuderia)
    {
        return lista.FindAll(p => p.EscuderiaId == escuderia.Id);
    }

    /// <summary>
    /// Obtiene un Piloto por su ID
    /// </summary>
    /// <param name="id"></param>
    public Piloto? ObtenerPorId(int id)
    {
        return lista.Find(p => p.Id == id);
    }
};
