using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Movimentacao_pacientes
{
    [Table("mvtHospCadPac")]
    public class ProntuarioModel
    {
        [Key()]
        public string codProntuario { get; set; }
    }
}
