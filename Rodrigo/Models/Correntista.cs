using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqlCsharp.Models
{
    [Table("Correntista")]
    public class Correntista
    {

            [Display(Description ="Código")]     
            public int Id { get; set; }

            [Display(Name = "Nome do Usuário")]
            [Column("Nome")]
            [Required(ErrorMessage = "Informe o nome do usuário", AllowEmptyStrings = false)]
            public string Nome { get; set; }
            
            [Column("DataDeNacimento")]
            public string DataNascimento { get; set; }

            [Column("CPF")]
            public string Cpf { get; set; }

            DateTime date = new DateTime(2000, 01, 01);

    }
}