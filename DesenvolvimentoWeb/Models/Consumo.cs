using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesenvolvimentoWeb.Models {

    [Table("Consumos")]

    public class Consumo {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório informar a Descrição")]
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }


        [Display(Name = "Data")]
        [Required(ErrorMessage = "Obrigatório informar a Data")]
        public DateTime Data { get; set; }


        [Required(ErrorMessage = "Obrigatório informar o Valor")]
        public int Valor { get; set; }


        [Required(ErrorMessage = "Obrigatório informar a Quilometragem")]
        [Display(Name = "Quilomentros")]
        public int Km { get; set; }


        [Required(ErrorMessage = "Obrigatório informar o Tipo do Combustivel")]
        [Display(Name = "Tipo Combustivel")]
        public  TipoCombustivel Tipo { get; set; }



        [Required(ErrorMessage = "Obrigatório informar o veiculo")]
        [Display(Name = "Veiculo")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        public Veiculo Veiculo { get; set; }


    }

        
    public enum TipoCombustivel {
        Gasolina,
        Etanol
    }


}
