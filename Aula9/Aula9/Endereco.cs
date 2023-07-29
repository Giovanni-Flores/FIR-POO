using System;
using System.Collections.Generic;
using System.Text;

namespace Aula9
{
    class Endereco
    {
        public String rua;
        public String cidade;
        private String pais;

        public String setRua(String rua)
        {
            return this.rua = rua;
        }
        public String setCidade(String cidade)
        {
            return this.cidade = cidade;
        }

        public String getPais()
        {
            return pais;
        }
        public String setPais(String pais) {
            return this.pais = pais; 
        }

        public override string ToString()
        {
            return $"\nRua: {rua}" +
                $"\nCidade: {cidade}" +
                $"\nPaís: {pais}";
        }
    }
}
