using Datos.Accesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class ListaDeUsuarios : Form
    {
        public ListaDeUsuarios()
        {
            InitializeComponent();
        }
        UsuarioDA usuarioDA = new UsuarioDA();

        private void ListaDeUsuarios_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        private void ListarUsuarios()
        {
            ListadataGrid.DataSource = usuarioDA.ListarUsuario();
        }
    }
}
