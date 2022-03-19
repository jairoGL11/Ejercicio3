﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Accesos;
using Datos.Entidades;

namespace Ejercicio3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            UsuarioDA usuarioDA = new UsuarioDA();
            Usuario usuario = new Usuario();

            usuario = usuarioDA.Login(UsuarioTextBox.Text, ClaveTextBox.Text);


            if(usuario == null)
            {
                MessageBox.Show("Usuario No Existe");
                return;
            }
            else if(!usuario.EstaActivo)
            {
                MessageBox.Show("Usuario Inactivo");
                return;
            }

            ListaDeUsuarios listaDeUsuarios = new ListaDeUsuarios();
            listaDeUsuarios.Show();
        }
    }
}
