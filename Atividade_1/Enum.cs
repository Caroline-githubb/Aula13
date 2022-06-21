using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Atividade_1
{
    public class Enum
    {
        public enum CodigosDeErros
        {
            Ok = 200,
            RedirecionamentoPermanente = 301,
            RedirecionamentoTemporário = 302,
            NãoEncontrado = 404,
            NãoAutorizado = 405,
            ServidorIndisponível = 503,
            TempoEsgotado = 504
        }
    }


}

