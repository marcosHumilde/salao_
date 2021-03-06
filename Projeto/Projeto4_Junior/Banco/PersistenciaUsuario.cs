﻿using Projeto4_Junior.Modelo;
using Projeto4_Junior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto4_Junior.Negocios;
using Projeto4_Junior.Factory;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto4_Junior.Banco
{
    class PersistenciaUsuario : IBancoDadosUsuario
    {
        public void CadastrarUsuario(Usuario usuario)
        {
            FactoryConnection conn = new FactoryConnection();
            try
            {
                String query = "insert into Usuario (Nome, Login, Senha, isGestor) values" +
                "('" + usuario.Nome + "', '" + usuario.Login + "', '" + usuario.Senha +
                "', '" + usuario.isGestor + "')";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());
                //comand.ExecuteNonQuery(); <---- Não seria melhor usar o comand pra executar a instrução SQL ?
                SqlDataReader reader = comand.ExecuteReader();
                conn.FecharConnecxao();                
            }
            catch (Exception e)
            {

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
            bool retorno = false;
            FactoryConnection conn = new FactoryConnection();   
                         
                String query = "select Login, Senha from Usuario where Login='" + usuario + "' and Senha='" + senha + "'";                

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());

                SqlDataReader reader = comand.ExecuteReader();

                if (reader.Read())
                {
                    retorno = true;                    
                }
                else
                {
                    retorno = false;
                }
                
            conn.FecharConnecxao();                       
            
            return retorno;            
        }
        public bool VerificarUsuarioExistente(String login)
        {
            bool retorno = true;

            FactoryConnection conn = new FactoryConnection();
           try
            {
                String query = "select Login from Usuario where Login ='" + login + "'";

                SqlCommand comand = new SqlCommand(query, conn.AbrirConnexao());
                
                SqlDataReader reader = comand.ExecuteReader();

                if (reader.Read())
                {
                    retorno = true;
                }
                else
                {
                    retorno = false;
                }
                conn.FecharConnecxao();
            }
           catch (Exception e)
           {

           }

            return retorno;
        }        
    }
}
