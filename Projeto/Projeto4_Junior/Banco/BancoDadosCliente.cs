﻿using Projeto4_Junior.Modelo;
using Projeto4_Junior.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Banco
{
    class BancoDadosCliente : IBancoDadosCliente
    {
        public IBancoDadosCliente ibancodados = new PersistenciaCliente();
        
        public void CadastrarCliente(Cliente cliente)
        {            
            this.ibancodados.CadastrarCliente(cliente);
        }
        public Cliente BuscarCliente(Cliente cliente)
        {           
            return this.ibancodados.BuscarCliente(cliente);
        }
        public void RemoverCliente(Cliente cliente)
        {            
            this.ibancodados.RemoverCliente(cliente);
        }
        public void AlterarCliente(Cliente cliente)
        {            
            this.ibancodados.AlterarCliente(cliente);
        }
    }
}