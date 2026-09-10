using GJG.Entidades;

namespace GJG.Logica;

public interface IEscuderiasServicios
{
    void Agregar(Escuderia escuderia);
    void Actualizar(Escuderia escuderia, string? piloto = null);
    void Eliminar(int id);
    List<Escuderia> Listar();
    Escuderia? ObtenerPorId(int id);
}

public class EscuderiasServicios : IEscuderiasServicios
{
    private static List<Escuderia> lista = new List<Escuderia>()
    {
        new Escuderia()
        {
            Id = 1,
            Nombre = "Mercedes",
            Pais = "Alemania",
            ImagenUrl = "/img/mercedes.jfif",
            Fundacion = 1954,
        },
        new Escuderia()
        {
            Id = 2,
            Nombre = "Ferrari",
            Pais = "Italia",
            ImagenUrl = "/img/ferrari.jfif",
            Fundacion = 1929,
        },
        new Escuderia()
        {
            Id = 3,
            Nombre = "Red Bull",
            Pais = "Austria",
            ImagenUrl = "/img/redbull.jfif",
            Fundacion = 2005,
        },
        new Escuderia()
        {
            Id = 4,
            Nombre = "McLaren",
            Pais = "Reino Unido",
            ImagenUrl = "/img/mclaren.jfif",
            Fundacion = 1963,
        },
        new Escuderia()
        {
            Id = 5,
            Nombre = "Alpine",
            Pais = "Francia",
            ImagenUrl = "/img/alpine.jfif",
            Fundacion = 2021,
        },
        new Escuderia()
        {
            Id = 6,
            Nombre = "Racing Bulls",
            Pais = "Austria",
            ImagenUrl = "/img/racingbulls.jfif",
            Fundacion = 2005,
        },
        new Escuderia()
        {
            Id = 7,
            Nombre = "Audi",
            Pais = "Alemania",
            ImagenUrl = "/img/audi.jfif",
            Fundacion = 1909,
        },
        new Escuderia()
        {
            Id = 8,
            Nombre = "Haas",
            Pais = "Estados Unidos",
            ImagenUrl = "/img/haas.jfif",
            Fundacion = 2014,
        },
        new Escuderia()
        {
            Id = 9,
            Nombre = "Williams",
            Pais = "Reino Unido",
            ImagenUrl = "/img/williams.jfif",
            Fundacion = 1977,
        },
        new Escuderia()
        {
            Id = 10,
            Nombre = "Aston Martin",
            Pais = "Reino Unido",
            ImagenUrl = "/img/astonmartin.jfif",
            Fundacion = 1913,
        },
        new Escuderia()
        {
            Id = 11,
            Nombre = "Cadillac",
            Pais = "Estados Unidos",
            ImagenUrl = "/img/cadillac.jfif",
            Fundacion = 1902,
        },
    };

    public EscuderiasServicios() { }

    public void Agregar(Escuderia escuderia)
    {
        int nuevoId = lista.Count > 0 ? lista.Max(e => e.Id) + 1 : 1;
        escuderia.Id = nuevoId;

        lista.Add(escuderia);
    }

    public void Actualizar(Escuderia escuderia, string? piloto = null)
    {
        var escuderiaDB = ObtenerPorId(escuderia.Id);
        if (escuderiaDB != null)
        {
            escuderiaDB.Motor = escuderia.Motor;
            escuderiaDB.Puntos = escuderia.Puntos;
            if (piloto != null)
            {
                escuderiaDB.Pilotos.Add(piloto);
            }
        }
    }

    public void Eliminar(int id)
    {
        var escuderiaDB = ObtenerPorId(id);
        if (escuderiaDB != null)
        {
            lista.Remove(escuderiaDB);
        }
    }

    public List<Escuderia> Listar()
    {
        return lista;
    }

    public Escuderia? ObtenerPorId(int id)
    {
        return lista.Find(e => e.Id == id);
    }
}
