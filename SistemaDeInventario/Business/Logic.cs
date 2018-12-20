using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeInventario.Data;
using SistemaDeInventario.Structures;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaDeInventario.Presentation
{
    public class Logic
    {
        /*
        *  Esta matriz contine los diferentes idiomas
        *  0 = Labels español
        *  1 = Labels ingles
        *  2 = btns español
        *  3 = btns ingles
        */
        public string[][] text =
        {
            new string[] {"Usuario", "Contraseña", "Registrar Activo", "Tipo de activo", "Numero de serie", "Nombre", "Marca / Color", "Descripción", "Cantidad", "Tipo", "Departamento", "Registrar Departamento", "Encargado", "Sub encargado","Idioma"},
            new string[] {"User", "Password", "Record Asset", "Asset Type", "Serial Number", "Name", "Brand / Color", "Description", "Quantity", "Type", "Department", "Record department","Manager", "Sub manager","Language"},
            new string[] {"Ingresar","Cancelar","Volver","Limpiar","Registrar","Mostrar","Editar","Borrar","Aceptar","Archivo","Cerrar Sesión", "Salir", "Departamento", "Activos","Préstamos" ,"Ayuda" ,"Registrar" ,"Ver lista" ,"Información" ,"Opciones"},
            new string[] {"Enter", "Cancel", "Back","Clean","Record","Show","Edit","Delete", "Accept", "File", "Close Session", "Exit", "Department", "Assets", "Loans", "Help", "Register", "See list", "Info", "Options" }
        };

        public Image[][] logos =
        {
            new Image[] {Properties.Resources.btn_MP_Usuario, Properties.Resources.btn_MP_Departamento, Properties.Resources.btn_MP_Activos, Properties.Resources.btn_MP_Prestamos, Properties.Resources.btn_MP_Opciones,Properties.Resources.btn_Login_Acceder,Properties.Resources.btn_Login_Cancelar,Properties.Resources.btn_MP_CompararActivos, Properties.Resources.btn_MP_Registro,Properties.Resources.btn_MP_Informacion,Properties.Resources.btn_MP_Opciones, Properties.Resources.btn_MP_RegistrarActivo,Properties.Resources.btn_MP_VerLista},
            new Image[] {Properties.Resources.btn_MP_User, Properties.Resources.btn_MP_Departament, Properties.Resources.btn_MP_Assets, Properties.Resources.btn_MP_Loans, Properties.Resources.btn_MP_Options,Properties.Resources.btn_Login_Enter,Properties.Resources.btn_Login_Cancel, Properties.Resources.btn_MP_CompareAssets, Properties.Resources.btn_MP_Registry, Properties.Resources.btn_MP_Information, Properties.Resources.btn_MP_Options, Properties.Resources.btn_MP_Register, Properties.Resources.btn_MP_SeeList},
            new Image[] {Properties.Resources.btn_MP_Usuario_Hover, Properties.Resources.btn_MP_Departamento_Hover, Properties.Resources.btn_MP_Activos_Hover, Properties.Resources.btn_MP_Prestamos_Hover, Properties.Resources.btn_MP_Opciones_Hover,Properties.Resources.btn_Login_Acceder_Hover,Properties.Resources.btn_Login_Cancelar_Hover,Properties.Resources.btn_MP_CompararActivos_Hover, Properties.Resources.btn_MP_Registro_Hover, Properties.Resources.btn_MP_Informacion_Hover, Properties.Resources.btn_MP_Opciones_Hover, Properties.Resources.btn_MP_RegistrarActivo_Hover,Properties.Resources.btn_MP_VerLista_Hover},
            new Image[] {Properties.Resources.btn_MP_User_Hover, Properties.Resources.btn_MP_Departament_Hover, Properties.Resources.btn_MP_Assets_Hover, Properties.Resources.btn_MP_Loans_Hover, Properties.Resources.btn_MP_Options_Hover, Properties.Resources.btn_Login_Enter_Hover, Properties.Resources.btn_Login_Cancel_Hover, Properties.Resources.btn_MP_CompareAssets_Hover, Properties.Resources.btn_MP_Registry_Hover, Properties.Resources.btn_MP_Information_Hover, Properties.Resources.btn_MP_Options_Hover, Properties.Resources.btn_MP_Register_Hover, Properties.Resources.btn_MP_SeeList_Hover}
        };

        Connection cn = new Connection();

        public void Mensaje(char _tipo, string _mensaje)
        {
            var icon = MessageBoxIcon.Information;
            var Titulo = "Informacion";

            switch (_tipo)
            {
                case 'E':
                    icon = MessageBoxIcon.Error;
                    Titulo = "Error !!!";
                    break;

                case 'A':
                    icon = MessageBoxIcon.Warning;
                    Titulo = "¡Alerta!";
                    break;

                case 'Q':
                    icon = MessageBoxIcon.Question;
                    Titulo = "¿Desea...?";
                    break;

                default:

                    break;
            }
            MessageBox.Show(_mensaje, Titulo, MessageBoxButtons.OK, icon);
        }

        public int GenerarNumSerie()
        {
            int num = 0;
            Random rnd = new Random();
            string serie = "";
            for (int i = 0; i < 4; i++)
            {
                serie += rnd.Next(1, 9);
            }
            num = int.Parse(serie);
            return num;
        }

        public string ObtenerNombreUsuario()
        {
            string query = "Select Usuario from dbo.sistema";
            return cn.TraerElemento(query);
        }

        public string ObtenerContrasenaActual ()
        {
            string query = String.Format("Select Contrasena from usuario where usuario = '{0}'",Global.Usuario);
            return cn.TraerElemento(query);
        }

        public string ObtenerFecha()
        {
            return DateTime.Now.ToString("dd/MM/yy");
        }

        public string ObtenerHora()
        {
            return DateTime.Now.ToString("hh:mm tt");
        }

        public int ObtenerIdioma()
        {
            string query = "select idioma from Opciones";
            return cn.TraerNumero(query);
        }

        public void ActualizarIdioma(int indice)
        {
            string query = string.Format("update opciones set idioma = {0}", indice);
            cn.EjecutarQuery(query);
        }

        // Obtine los departamentos de la base de datos y los agrega al combo que se le pasa por parametro 
        public ComboBox LlenarComboBoxDepartamentos(ComboBox _temp)
        {
            List<Departamento> list = cn.LlenarListaDeparta(0);
            _temp.DataSource = list;
            _temp.DisplayMember = "Nombre";
            return _temp;
        }

        public ComboBox LlenarComboBoxDepartamentos(ComboBox _temp, int exclu)
        {
            List<Departamento> list = cn.LlenarListaDeparta(exclu);
            _temp.DataSource = list;
            _temp.DisplayMember = "Nombre";
            return _temp;
        }

        public ComboBox LlenarComboBoxUsuarios(ComboBox _temp)
        {
            _temp.DataSource = cn.LlenarListaUsuarios();
            _temp.DisplayMember = "Nombre";
            return _temp;
        }

        public void RegistraNuevoUsuario(string _Usuario, int _rol)
        {
            string query = String.Format("Insert Into dbo.Usuario (Usuario, rol) values ('{0}',{1});", _Usuario,_rol);
            cn.EjecutarQuery(query);
            RegistrarOperacion("Se ha registrado el Usuario: " + _Usuario);
        }

        public string RegistrarActivo(int NumSerie, string Nombre, string Marca, string Descripcion, int Cantidad, string Tipo, int Departamento)
        {
            string query = String.Format("Insert Into dbo.Activo values ({0},'{1}','Propietario','{2}','{3}',{4},'{5}',{6});", NumSerie, Nombre, Marca, Descripcion, Cantidad, Tipo, (Departamento + 1));
            cn.EjecutarQuery(query);
            RegistrarOperacion("Se registro el activo: " + Nombre);
            return "Se Ha registrado un nuevo activo";
        }

        public string ActualizarActivo(int id, int NumSerie, string Nombre, string Marca, string Descripcion, int Cantidad, string Tipo, int Departamento)
        {
            string query = "";
            query = String.Format("Update dbo.Activo set NumeroSerie = {0}, Nombre = '{1}', Marca = '{2}', Descripcion = '{3}', Cantidad = {4}, Tipo = '{5}', Departamento = {6} where id = {7};", NumSerie, Nombre, Marca, Descripcion, Cantidad, Tipo, (Departamento + 1), id);
            cn.EjecutarQuery(query);
            RegistrarOperacion("Se actualizo el activo: " + Nombre);
            return "Se ha actualizado el activo";
        }

        public string RegistrarDepartamento(string Nombre, int Encargado, int Subencargado)
        {
            string query = String.Format("Insert Into dbo.Departamento values ('{0}',{1},{2});", Nombre, Encargado, Subencargado);
            cn.EjecutarQuery(query);
            RegistrarOperacion("Se registro el departamento: " + Nombre);
            return "Se ha registrado un nuevo departamento";
        }

        public string ActualizarDepartamento(string Nombre, int Encargado, int Subencargado, int id)
        {
            string query = String.Format("Update dbo.Departamento set nombre = '{0}', encargado = {1}, subencargado = {2} where id = {3};", Nombre, Encargado, Subencargado, id);
            cn.EjecutarQuery(query);
            RegistrarOperacion("Se actualizo el departamento: " + Nombre);
            return "Se han actualizado los datos del departamento";
        }

        public string RegistrarPrestamo(int _id, string _nombre, int _cantidad, int _depaOrigen, int _depaPrestamo, string _fechaRetorno)
        {
            string query = String.Format("Insert into dbo.Prestamo Values ('{0}',{1},{2},{3},'{4}');", _nombre, _depaOrigen, _depaPrestamo, _cantidad, _fechaRetorno);
            cn.EjecutarQuery(query);

            query = String.Format("Update Activo set estado = '{0}',departamento = {1}  where id = {2}", "Prestamo/" + _depaOrigen, _depaPrestamo, _id);
            cn.EjecutarQuery(query);
            RegistrarOperacion("Se realizo el prestamo del activo: " + _nombre + " del departamento: " + _depaOrigen + " al departamento " + _depaPrestamo);

            return "Se ha registrato el prestamo";
        }

        public string ActualizarUsuario(int _id,string _nombre, string _correo, int _rol, int _edad)
        {
            string query = String.Format("Update Usuario set nombre = '{0}',correo = '{1}', rol = {2}, edad = {3}  where id = {4};", _nombre, _correo, _rol, _edad, _id);
            cn.EjecutarQuery(query);

            RegistrarOperacion("Se se guardaron los datos del usuario: " + _nombre);

            return "Se ha guardado los datos";
        }

        public string DevolverPrestamo(int _id, string _nombre, int _depaOrigen, int _depaPrestamo)
        {
            string query = String.Format("Update Activo set estado = '{0}',departamento = {1}  where id = {2}", "Propietario", _depaOrigen, _id);
            cn.EjecutarQuery(query);
            query = "delete Prestamo where id = " + _id;
            cn.EjecutarQuery(query);
            RegistrarOperacion("Se realizo la devolucion del activo: " + _nombre + " del departamento: " + _depaOrigen + " al departamento " + _depaPrestamo);
            return "Se ha realizado la devolucion";
        }

        public void RegistrarOperacion(string _data)
        {
            cn.EjecutarQuery(String.Format("Insert into dbo.Registro Values ('{0}', getDate())", _data));
        }

        public string CambiarContrasena(string _contrasena)
        {
            string query = String.Format("Update Usuario set Contrasena = '{0}' where id = {1};",_contrasena, cn.ObtenerID());
            cn.EjecutarQuery(query);
            return "Se ha cambiado la contraseña";
        }

        public string CambiarContrasena(string _contrasena, int x)
        {
            int id = cn.TraerNumero("Select max(id) from usuario");
            string query = String.Format("Update Usuario set Contrasena = '{0}' where id = {1};", _contrasena, id);
            cn.EjecutarQuery(query);
            return "Se ha cambiado la contraseña";
        }

        public void CerrarSesion()
        {
            cn.EjecutarQuery("Update Sistema set Usuario = 'None'");
            Global.Usuario = "";
            Global.Rol = 0;
        }

        public Usuario ObtenerUsuario ()
        {
            Usuario user = cn.ObtenerDatosUsuario(cn.ObtenerID());
            return user;
        }

    }
}
