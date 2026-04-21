namespace TP01.Models;

public class Integrante
{
    private int dni;
    private string nombre;
    private DateTime fechanacimiento;
    private string foto;
    List<string> ListFamiliares; 
    List<string> Listintereses;

    public Integrante(int dni, string nombre, date fechanacimiento, string foto, List<string> ListFamiliares, List<string> Listintereses)
    {

        this.ListFamiliares = ListFamiliares;
        this.Listintereses = Listintereses;                                                                                                 
        this.dni = dni
        this.nombre = nombre
        this.fechanacimiento = fechanacimiento
        this.foto = foto
    }

    public int DevolverDNI(){ return dni;}
    public string DevolverNombre(){ return nombre;}
    public string DevolverFoto(){ return foto;}
    public date DevolverFechanacimiento(){ return fechanacimiento;}
    public List<string> DevolverListFamiliares() { return ListFamiliares;}
    public List<string> DevolverListintereses() { return Listintereses;}
}