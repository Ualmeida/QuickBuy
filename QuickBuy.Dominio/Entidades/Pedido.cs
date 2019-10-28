using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
	public class Pedido : Entidade
	{
		public int Id { get; set; }
		public DateTime DataPedido { get; set; }
		public int UsuarioId { get; set; }
		public DateTime DataPrevisaoEntrega { get; set; }
		public string CEP { get; set; }
		public string Estado { get; set; }
		public string Cidade { get; set; }
		public string EnderecoCompleto { get; set; }
		public int NumereoEndereco { get; set; }
		
		public int FormaPagamentoId { get; set; }
		public FormaPagamento FormaPagamento { get; set; }

		/// <summary>
		/// Pedido pode ter 1 Item ou varios itens
		/// </summary>
		public ICollection<ItemPedido> ItensPedido { get; set; }

		public override void Validate()
		{

			LimparMensagensValidacao();

			if (!ItensPedido.Any())
				AdicionarCritica("Help - Pedido não pode ficar sem item");
				
			if(string.IsNullOrEmpty(CEP))
				AdicionarCritica("Help - CEP Não Pode estar vazio");


		}
	}
}
