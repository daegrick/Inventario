using CommunityToolkit.Mvvm.ComponentModel;
using Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Inventario.Views.ViewModels
{
    public class ItemPatrimonioViewModel : ObservableValidator
    {
        private readonly ItemPatrimonio itemPatrimonio;
        private ReadOnlyDictionary<Guid, string> categorias;


        public ItemPatrimonioViewModel(ItemPatrimonio item)
        {
            itemPatrimonio = item;
        }

        public ItemPatrimonioViewModel()
        {
            itemPatrimonio = new ItemPatrimonio();
            Categorias = new ReadOnlyDictionary<Guid, string>(InitializeCategorias());
        }

        public ReadOnlyDictionary<Guid, string> Categorias
        {
            get => categorias;
            set => SetProperty(ref categorias, value);
        }

        [Required]
        [MinLength(2)]
        [MaxLength(300)]
        public string Descricao
        {
            get => itemPatrimonio.Descricao;
            set => SetProperty(itemPatrimonio.Descricao, value, itemPatrimonio, (u, n) => u.Descricao = n, true);
        }

        [Required]
        [MinLength(2)]
        [MaxLength(300)]
        public string NumeroSerie
        {
            get => itemPatrimonio.NumeroSerie;
            set => SetProperty(itemPatrimonio.NumeroSerie, value, itemPatrimonio, (u, n) => u.NumeroSerie = n, true);
        }

        [Required]
        public DateTime DataAquisicao
        {
            get => itemPatrimonio.DataAquisicao;
            set => SetProperty(itemPatrimonio.DataAquisicao, value, itemPatrimonio, (u, n) => u.DataAquisicao = n, true);
        }

        [Required]
        public Guid CategoriaIde
        {
            get => itemPatrimonio.CategoriaIde;
            set => SetProperty(itemPatrimonio.CategoriaIde, value, itemPatrimonio, (u, n) => u.CategoriaIde = n, true);
        }

        private static Dictionary<Guid, string> InitializeCategorias() => new()
        {
            {Guid.Parse("a069d444-9371-487e-8d59-52745ef1a44e"), "Moveis" },
            { Guid.Parse("2ee328d0-4329-48fa-8f0b-00113d34d9a4"), "Eletrônicos" }
        };
    }
}
