namespace VistaPelicula
{
    public class Cls_User
    {
        public string usuarioUser { get; set; }
        public string nombreUsuario { get; set; }
        public string correoUsuario { get; set; }
        public string contraseñaUsuario { get; set; }
        public string tarjetaUsuario { get; set; }
        public string codigoTarUsuario { get; set; }
        public string direccionUsuario { get; set; }
        public string avarUsuario { get; set; }
        public string idPeliculas { get; set; }

        //Constructor vacio
        public Cls_User()
        {

        }


        //Contructor General
        public Cls_User(string usuarioUser, string nombreUsuario, string correoUsuario,
            string contraseñaUsuario, string tarjetaUsuario, string codigoTarUsuario, string direccionUsuario, string avarUsuario, string idPeliculas
            )
        {
            this.usuarioUser = usuarioUser;
            this.nombreUsuario = nombreUsuario;
            this.correoUsuario = correoUsuario;
            this.contraseñaUsuario = contraseñaUsuario;
            this.tarjetaUsuario = tarjetaUsuario;
            this.codigoTarUsuario = codigoTarUsuario;
            this.direccionUsuario = direccionUsuario;
            this.avarUsuario = avarUsuario;
            this.idPeliculas = idPeliculas;
        }
    }
}