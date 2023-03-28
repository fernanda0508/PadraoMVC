using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelProject;


namespace PersistenceProject
{
    class Repository
    {
        private IList<Fornecedor> fornecedores = new List<Fornecedor>();
        private IList<Produto> produtos = new List<Produto>();
        private IList<NotaEntrada> notaEntrada = new List<NotaEntrada>();

        public Fornecedor InsertFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores.Add(fornecedor);
            return fornecedor;

        }
        public void RemoveFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores.Remove(fornecedor);
        }

        public IList<Fornecedor> GetAllFornecedores()
        {
            return this.fornecedores;
        }
        
        public Fornecedor updateFornecedor(Fornecedor fornecedor)
        {
            this.fornecedores[this.fornecedores.IndexOf(fornecedor)] = fornecedor;
            return fornecedor;
        }


        public Produto InsertProduto(Produto produto)
        {
            this.produtos.Add(produto);
            return produto;

        }
        public void RemoveProduto(Produto produto)
        {
            this.produtos.Remove(produto);
        }

        public IList<Produto> GetAllProduto()
        {
            return this.produtos;
        }

        public Produto updateProduto(Produto produto)
        {
            this.produtos[this.produtos.IndexOf(produto)] = produto;
            return produto;
        }

        public NotaEntrada InsertnotaEntrada(NotaEntrada notaentrada)
        {
            this.notaEntrada.Add(notaentrada);
            return notaentrada;

        }
        public void RemoveNotaEntrada(NotaEntrada notaentrada)
        {
            this.notaEntrada.Remove(notaentrada);
        }

        public IList<NotaEntrada> GetAllNotaEntrada()
        {
            return this.notaEntrada;
        }

        public NotaEntrada updateNotaEntrada(NotaEntrada notaentrada)
        {
            this.notaEntrada[this.notaEntrada.IndexOf(notaentrada)] = notaentrada;
            return notaentrada;
        }
    }
}
