﻿using Projeto4_Junior.Modelo;
using Projeto4_Junior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto4_Junior.Banco;
using System.Windows.Forms;

namespace Projeto4_Junior.Negocios
{
    class ControladorUsuario : IfachadaUsuario
    {
        private IBancoDadosUsuario ibancodados = new BancoDadosUsuario();
        public void CadastrarUsuario(Usuario usuario)
        {
            if (this.ibancodados.VerificarUsuarioExistente(usuario.Login) == true)
            {
                MessageBox.Show("Usuario já cadastrado!");
            }
            else
            {
                ibancodados.CadastrarUsuario(usuario);
                MessageBox.Show("Cadastrado com sucesso!");
            }
            
        }
        public Usuario BuscarUsuario(Usuario usuario)
        {
            return null;
        }
        public void RemoverUsuario(Usuario usuario)
        {
            
        }

        public void AlterarUsuario(Usuario usuario)
        {
            
        }

        public bool Autenticar(String usuario, String senha)
        {
            return this.ibancodados.Autenticar(usuario, senha);
        }
       
    }
}
