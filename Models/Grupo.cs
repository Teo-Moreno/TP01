namespace TP01.Models;

public class Grupo
{
    private Dictionary <int, Integrante> Integrantes;

    private void CargaDatosManual()
   {
        Integrantes.Add(49761294, new Integrante(49761294, "jorge", new DateTime(2009, 9, 27), new List<string> { "papa", "mama", "hermano" }, new List<string> { "futbol", "comida", "bebida", "computadora" }));
        Integrantes.Add(50291929, new Integrante(50291929, "teo", new DateTime(2010, 5, 16), new List<string> { "papa", "mama" }, new List<string> { "league of legends", "lotm", "manga", "anime", "juegos", "computadora" }));
        Integrantes.Add(50323228, new Integrante(50323228, "galva", new DateTime(2010, 5, 26), new List<string> { "papa", "mama" }, new List<string> { "anime", "manga", "league of legends", "computadora" }));
   }
    public Grupo()
   {
        Integrantes = new Dictionary<int, Integrante>();
        CargaDatosManual();
   }   



   public Dictionary<int, Integrante> DevolverIntegrantes()
   {
        return Integrantes;
   }


    public Integrante GetIntegrante(int dni)
    {
        if (Integrantes.ContainsKey(dni))
        {
            return Integrantes[dni];
        }
        else
        {
            return null;
        }
    }
}