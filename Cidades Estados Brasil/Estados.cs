using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilidades
{
    public abstract class Estados
    {
        private string[] estadosBrasil;

        /// <summary>
        /// Retorna todos os estados do Brasil em um componente ComboBox.
        /// </summary>
        /// <param name="cb"></param>
        public virtual string[] EstadosBrasilNome()
        {
            this.estadosBrasil = new string[]
            {
                "Acre",
                "Alagoas",
                "Amapá",
                "Amazonas",
                "Bahia",
                "Ceará",
                "Distrito Federal",
                "Espírito Santo",
                "Goiás",
                "Maranhão",
                "Mato Grosso",
                "Mato Grosso do Sul",
                "Minas Gerais",
                "Pará",
                "Paraíba",
                "Paraná",
                "Pernambuco",
                "Piauí",
                "Rio de Janeiro",
                "Rio Grande do Norte",
                "Rio Grande do Sul",
                "Rondônia",
                "Roraima",
                "Santa Catarina",
                "São Paulo",
                "Sergipe",
                "Tocantins"
             };

            return estadosBrasil;
        }
        public virtual string[] EstadosBrasilUF()
        {
            this.estadosBrasil = new string[]
            {
                "AC",
                "AL",
                "AP",
                "AM",
                "BA",
                "CE",
                "DF",
                "ES",
                "GO",
                "MA",
                "MT",
                "MS",
                "MG",
                "PA",
                "PB",
                "PR",
                "PE",
                "PI",
                "RJ",
                "RN",
                "RS",
                "RO",
                "RR",
                "SC",
                "SP",
                "SE",
                "TO"
             };

            return estadosBrasil;
        }
    }
}
