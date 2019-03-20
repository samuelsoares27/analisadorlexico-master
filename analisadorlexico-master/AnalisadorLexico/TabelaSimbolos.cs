using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorLexico
{
    class TabelaSimbolos
    {
        public List<Simbolo> Simbolos = new List<Simbolo>();

        public TabelaSimbolos() { }

        public int add_simbolo(string lexema)
        {
            bool ok = false;
            int id = 0;

            foreach (Simbolo item in Simbolos)
            {
                //Verifica se já tem o lexema na tabela
                if (item.Nome == lexema)
                {
                    ok = true;
                    //Coloca o valor do ID do lexema ja existente na tabela
                    id = item.Id;
                }
            }

            //Se não tiver o lexema na tabela ele coloca
            if (ok == false)
            {
                //Adciona o lexema na tabela
                Simbolos.Add(new Simbolo
                {
                    Id = Simbolos.Count + 1,
                    Nome = lexema
                });

                //Coloca o valor do ID do novo lexema na variavel
                id = Simbolos.Count;

                ok = false;
            }

            //Retorna o ID do lexema
            return id;
        }
    }
}
