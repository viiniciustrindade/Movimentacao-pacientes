using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movimentacao_pacientes
{
    [Table("mvtHospCadPac")]
    public class PacienteModel
    {
        [Key()]
        public string codPaciente { get; set; }
        public string nomePaciente { get; set; }
        public string dataNasc { get; set; }
        public string mae { get; set; }
    }
}
