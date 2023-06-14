using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movimentacao_pacientes
{
    public class MovModel
    {
        public string sequencia { get; set; }
        public string data { get; set; }
        public string hora { get; set; }
        public string motivo { get; set; }
        public string localizacao { get; set; }
        public string leito { get; set; }
        public string centroCusto { get; set; }
        public string clinicaMedica { get; set; }
        public string medico { get; set; }
        public string crm { get; set; }

        [ForeignKey("mvHospCadPac")]
        [Column("codPaciente")]
        public string pacienteId { get; set; }
        public virtual PacienteModel PacienteModel { get; set; }

        [ForeignKey("mvtCadCentroCusto")]
        [Column("codCentroCusto")]
        public string centroCustoId { get; set; }
        public virtual CentroCustoModel CentroCustoModel { get; set; }

        /* [ForeignKey("mvHospRegInt")]
         [Column("codProntuario")]
         public string prontuarioId { get; set; }
         public virtual ProntuarioModel ProntuarioModel { get; set; }*/

    }
}
