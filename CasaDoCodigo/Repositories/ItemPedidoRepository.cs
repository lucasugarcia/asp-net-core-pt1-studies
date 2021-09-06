﻿using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{
    public interface IItemPedidoRepository
    {
        void UpdateQuantidade(ItemPedido itemPedido);
    }

    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public void UpdateQuantidade(ItemPedido itemPedido)
        {
            var itemPedidoDB = dbSet.Where(i => i.Id == itemPedido.Id).SingleOrDefault();

            if(itemPedido != null)
            {
                itemPedidoDB.AtualizarQuantidade(itemPedido.Quantidade);

                contexto.SaveChanges();
            }
        }
    }
}
