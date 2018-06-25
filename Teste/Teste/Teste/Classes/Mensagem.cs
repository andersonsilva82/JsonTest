using System;
using System.Collections.Generic;
using System.Text;

namespace Teste.Classes
{
    public class Mensagem
    {
        public int Id { get; set; }
        public string Assunto { get; set; }
        public string Aviso { get; set; }
        public string Previa { get => Aviso.Substring(1, 160) + "..."; set => Aviso = value; }
        public string Tipo { get; set; }
        public string Visualizado { get; set; }
        public DateTime DtAviso { get; set; }
    }
}
