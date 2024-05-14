namespace ServicioInyeccionDependenciasV2.Dependencies;
public interface ISender
{
    public void SendMessage(string email, string message);
}