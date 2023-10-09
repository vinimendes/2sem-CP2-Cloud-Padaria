using System.ComponentModel.DataAnnotations.Schema;

namespace PadariaDoceAroma.Models
{
    [Table("TB_PEDIDO")]
    public class Pedido
    {

        [Column("cd_pedido")]
        public int IdPedido { get; set; }


        [Column("dt_pedido")]
        public DateTime DataPedido { get; set; }

        [Column("nm_cliente")]
        public string NomeCliente{ get; set; }




    }
}
