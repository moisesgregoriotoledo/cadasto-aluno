using System;



namespace testa
{
    public class Aluno
    {
        public string Nome  { get; set; }
        public decimal Nota { get; set; }  
        public bool Aprovado 

        {
            get {return Nota >=8 ? true: false;}
        }

        
    }
}