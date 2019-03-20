using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisadorLexico
{
    class Lexico
    {
        private char peek;
        private int i;

        private char[] codigo;

        private string[] Operadores = {"<", ">", "=", "==", ">=", "<=", "!", "+", "-", "/", "*", "++", "--"};
        private string[] Delimitadores = { "{", "}", "(", ")", ";", ":"};

        private PalavraReservada palavraReservada = new PalavraReservada();

        public Lexico(char[] p)
        {
            codigo = p;
            init();
        }

        private void init()
        {
            i = 0;
            nextChar();
        }

        //Percorre o codigo palavra por palavra
        private void nextChar()
        {
            if (i < codigo.Length)
            {
                peek = codigo[i];
                i++;
            }
            else
            {
                peek = codigo[codigo.Length - 1];
            }
        }

        public string GetToken()
        {
            string token = "";

            //Enquanto tiver espaço ou \t ou \n ele ignora
            while (peek == ' ' || peek == '\t' || peek == '\n')
            {
                nextChar();
            }

            //Numero
            if (Char.IsDigit(peek))
            {
               //vai armezenar o valor do numero         
                string lexema = "";

                while (Char.IsDigit(peek) || (lexema.Contains(",") == false && codigo[i - 1]==','))
                {
                    lexema += token;

                    nextChar();
                };

                token = "<NUM>";
                    
                return token;
            }

            if(peek == '"')
            {
                nextChar();
                string aux = "";

                do
                {
                    aux = aux.Insert(aux.Length, peek.ToString());
                    nextChar();
                } while (!(peek == '"'));

                token = "<LITERAL>";
                nextChar();
                return token;

            }

            //Identificador
            if (Char.IsLetter(peek))
            {
                // armazena as palavras do codigo
                StringBuilder lexema = new StringBuilder();

                while (Char.IsLetterOrDigit(peek))
                {
                    token = lexema.ToString();
                    lexema.Append(peek);
                    nextChar();

                };

                //Verifica se é uma palavra reservada se não ID(variaveis)
                if (palavraReservada.PalavrasReservadas.Where(x => x.ToUpper() == lexema.ToString().ToUpper()).ToList().Count > 0)
                {
                    if(lexema.ToString() == "end")
                    {
                        token = lexema.ToString();
                    }
                    else
                    {
                        token = "<Palavra reservada>";
                    }
                }
                else
                {
                    token = lexema.ToString();
                }

                return token;
            }

            //Operadores
            if (Operadores.Where(x => x == peek.ToString()).ToList().Count > 0)
            {
                StringBuilder lexema = new StringBuilder();

                lexema.Append(peek);

                token = "<RELOP>";

                nextChar();
                return token;
            }

            //Delimitadores
            if (Delimitadores.Where(x => x == peek.ToString()).ToList().Count > 0)
            {
                StringBuilder lexema = new StringBuilder();

                lexema.Append(peek);

                token = "<DELIM>";

                nextChar();
                return token;
            }

            token = peek.ToString();

            return token;
        }
    }
}
