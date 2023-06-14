using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movimentacao_pacientes
{
    [Table("mvtCadCentroCusto")]
    public class CentroCustoModel
    {   
        
            [Key()]
            public string codCentroCusto { get; set; }
            public string nomeCentroCusto { get; set; }
        
    }
}
