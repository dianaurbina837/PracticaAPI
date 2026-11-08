namespace PracticaAPI
{

    public class Model
    {
    
       public class Usuario
       {
        public int Id { get; set; } 
        public string Correo { get; set; } = "";
        public string ClaveHash { get; set; } = "";
        
        public string Nombre { get; set; } = "";
        public bool Disponible { get; set; } = true;

        public int AniosExperiencia { get; set; } = 0;
       }

        //DTO = son los datos que llegan o salten por internet (JSON)

     public record RegistroDto(String Nombre, String Correo, String Clave);
     public record LoginDtos (String Correo, String Clave);
     public record PerfilDto (String Nombre, bool Disponible, int AniosExperiencia);

    
    }

}
