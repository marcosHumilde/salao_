﻿using Projeto4_Junior.Modelo;
using Projeto4_Junior.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4_Junior.Banco
{
    class BancoDadosProduto : IBancoDadosProduto
    {
        public IBancoDadosProduto ibancodados = new PersistenciaProduto();

        public void CadastrarProdutos(Produto produto)
        {            
            this.ibancodados.CadastrarProdutos(produto);
        }
        public Produto BuscarProdutos(Produto produto)
        {            
            return this.ibancodados.BuscarProdutos(produto);
        }
        public void RemoverProdutos(Produto produto)
        {            
            this.ibancodados.RemoverProdutos(produto);
        }
        public void AlterarProdutos(Produto produto)
        {            
            this.ibancodados.AlterarProdutos(produto);
        }
    }
}
