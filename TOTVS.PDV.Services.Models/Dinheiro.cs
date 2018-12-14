﻿using System.Collections.Generic;

namespace TOTVS.PDV.Services.Models
{
    /// <summary>
    /// Classe responsável pelo gerenciamento de quantidades de cédulas e moedas
    /// </summary>
    public class Dinheiro
    {
        #region Construtores
        private Dinheiro() { }

        public Dinheiro(float valor, int quantidade, TipoDinheiro tipo, string urlImagem, string descricao)
        {
            Valor = valor;
            Quantidade = quantidade;
            Tipo = tipo;
            UrlImagem = urlImagem;
            Descricao = descricao;
        }
        #endregion

        #region Propriedades
        /// <summary>
        /// Chave primária
        /// </summary>
        /// <example>Inteiro superior a zero</example>
        public int IdDinheiro { get; private set; }

        /// <summary>
        /// Valor contábil da cédula ou moeda
        /// </summary>
        /// <example>0.5f, 0.1f, 10, 100</example>
        public float Valor { get; private set; }

        /// <summary>
        /// Quantidade disponível para realizar transação
        /// </summary>
        /// <example>100, 200, 1000</example>
        public int Quantidade { get; private set; }

        /// <summary>
        /// Tipo do dinheiro: cédula ou moeda
        /// </summary>
        /// <example>1 = cédula, 2 = Moeda</example>
        public TipoDinheiro Tipo { get; private set; }

        /// <summary>
        /// Url completa com uma imagem da cédula ou moeda
        /// </summary>
        /// <example>1 = cédula, 2 = Moeda</example>
        public string UrlImagem { get; private set; }

        /// <summary>
        /// Descritivo da cédula ou moeda
        /// </summary>
        /// <example>1 real, 25 centavos</example>
        public string Descricao { get; private set; }

        /// <summary>
        /// Indica se a cédula ou moeda ainda está em circulação
        /// </summary>
        /// <example>1 real, 25 centavos</example>
        public bool Ativo { get; private set; } = true;

        /// <summary>
        /// Tipo do dinheiro
        /// </summary>
        public enum TipoDinheiro
        {
            Cedula = 1,
            Moeda = 2
        }
        #endregion

        #region Relacionamentos
        /// <summary>
        /// Lista de relacionamento
        /// </summary>
        /// <example>Inteiro superior a zero</example>
        public List<Troco> TrocoList { get; private set; }
        #endregion

        #region Ações

        /// <summary>
        /// Altera algumas informações de armazenamento de dinheiro
        /// </summary>
        /// <returns>this</returns>
        public Dinheiro Alterar(int quantidade, string urlImagem)
        {
            Quantidade = quantidade;
            UrlImagem = urlImagem;

            return this;
        }

        /// <summary>
        /// Decrementa a quantidade do dinheiro
        /// </summary>
        /// <returns>this</returns>
        public Dinheiro Retirar()
        {
            Quantidade--;
            return this;
        }

        /// <summary>
        /// Desativa o dinheiro
        /// </summary>
        /// <returns>this</returns>
        public Dinheiro Desativar()
        {
            Ativo = false;
            return this;
        }

        /// <summary>
        /// Ativa o dinheiro
        /// </summary>
        /// <returns>this</returns>
        public Dinheiro Ativar()
        {
            Ativo = true;
            return this;
        }

        /// <summary>
        /// Seta a propriedade Id da entidade. 
        /// Uso para seed e quando for utilizado SqlCommand.
        /// </summary>
        /// <returns>this</returns>
        public Dinheiro SetId(int id)
        {
            IdDinheiro = id;
            return this;
        }

        #endregion
    }
}
