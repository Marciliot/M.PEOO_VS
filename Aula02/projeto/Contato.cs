using System;
using System.Collections.Generic;
using System.Text;

namespace projeto
{
    class Contato
    {
        private string nome, email, fone;
        public Contato(string n,string e , string f)
        {
            nome = n;
            email = e;
            fone = f;
        }
        public override string ToString()
        {
            return ${nome} {email} { fone};
        }
    }
}
