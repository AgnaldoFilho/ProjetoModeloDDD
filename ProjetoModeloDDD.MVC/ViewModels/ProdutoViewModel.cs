using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoID { get; set; }

        [Required(ErrorMessage ="Preencha o campo Nome.")]
        [MaxLength(150, ErrorMessage ="Máximo {0} de caracteres.")]
        [MinLength(2, ErrorMessage = "Mínimo {0} de caracteres.")]
        public string Nome { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal),"0","999999999999")]
        [Required(ErrorMessage ="Preencha o campo Valor.")]
        public decimal Valor { get; set; }

        [DisplayName("Disponível?")]
        public bool Disponivel { get; set; }

        public int ClienteID { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }
    }
}