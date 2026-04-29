namespace TP01.Models;

public class Integrante
{
    private int dni;
    private string nombre;
    private DateTime fechanacimiento;
    List<string> ListFamiliares; 
    List<string> Listintereses;

    public Integrante(int dni, string nombre, DateTime fechanacimiento, List<string> ListFamiliares, List<string> Listintereses)
    {

        this.ListFamiliares = ListFamiliares;
        this.Listintereses = Listintereses;                                                                                                 
        this.dni = dni;
        this.nombre = nombre;
        this.fechanacimiento = fechanacimiento;
    }

    public int DevolverDNI(){ return dni;}
    public string DevolverNombre(){ return nombre;}
    public DateTime DevolverFechanacimiento(){ return fechanacimiento;}
    public List<string> DevolverListFamiliares() { return ListFamiliares;}
    public List<string> DevolverListintereses() { return Listintereses;}
}