using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ItemPatrimonioDAL
    {
        string AllFields() =>
            $@"{nameof(ItemPatrimonio.Ide)},
{nameof(ItemPatrimonio.Id)},
{nameof(ItemPatrimonio.Descricao)},
{nameof(ItemPatrimonio.DataAquisicao)},
{nameof(ItemPatrimonio.NumeroSerie)},
{nameof(ItemPatrimonio.CategoriaIde)},
{nameof(ItemPatrimonio.AlteradoEm)}";
    }
}
