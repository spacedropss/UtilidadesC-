using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilidades
{
    public class EstadosCidadesBrasil
    {
        public EstadosCidadesBrasil(string estado, ComboBox cb) 
        {
            cb.Items.AddRange(new Cidade().GetCidades(estado));
        }
         

    }
}
