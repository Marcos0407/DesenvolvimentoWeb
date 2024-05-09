
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesenvolvimentoWeb.Models {

    [Table("Usuarios")]

    public class Usuario {

        [Key]
        public  int Id { get; set; }


        [Required(ErrorMessage = "Obrigatorio informar o Nome")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Obrigatorio informar a Senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }


        [Required(ErrorMessage = "Obrigatorio informar o Perfil")]
        public Perfil Perfil { get; set; }

    }


    public enum Perfil {
        Admin,
        User
    }

}
