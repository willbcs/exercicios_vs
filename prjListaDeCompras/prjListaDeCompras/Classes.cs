using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjListaDeCompras
{
    
    public class Compras 
    {
        private List<ItemDeCompra> listaCompras;
        public Compras() 
        {

            listaCompras = new List<ItemDeCompra>();
        

        }   
        
        public void Add(ItemDeCompra item) 
        {

            listaCompras.Add(item);
            listaCompras.Sort();
        
        }

        public float Total() 
        {

            float total = 0;
            foreach (ItemDeCompra item in listaCompras) 
            {

                total += item.quantidade * item.preco;
            
            }
            return total;

        }

        public String relatorio() 
        {
        
            StringBuilder str = new StringBuilder();
            foreach (ItemDeCompra item in listaCompras) 
            {
            
                str.AppendLine(item.ToString());

            }
            return str.ToString();
        
        }
    
    }
    
    public class ItemDeCompra : IComparable<ItemDeCompra> /* Interface... é abstrato. Uma classe se extende (apenas uma vez), uma interface se implementa quantas eu quiser. */ 
    {
        
        public string nomeProduto { get; private set; } /*propriedade*/
        public int quantidade { get; private set; }
        public float preco { get; private set; }

        public ItemDeCompra(String nomeProduto, int quantidade, float preco) /*Construtor*/
        {
            this.nomeProduto = nomeProduto;
            this.quantidade = quantidade;   
            this.preco = preco;
        
        }

        public override string ToString()
        {
            return String.Format("{0} | Quantidade: {1:###,##0} | Preço: {2:###,##0.00} | Total: {3:###,##0.00}", nomeProduto, quantidade, preco, quantidade * preco);

        }
                
        public int CompareTo(ItemDeCompra ?outro) 
        {

            if (outro == null) return -1;
            return nomeProduto.CompareTo(outro.nomeProduto);
           

        }


    }
}
