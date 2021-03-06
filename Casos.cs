using System;

namespace testa
{
    public class Casos
    {
        public static void CadastrarAluno(Aluno[] alunos, int indice, Action exc)
        {
            Console.WriteLine("escreva o nome do aluno");
           var aluno = new Aluno();
            aluno.Nome = Console.ReadLine();
            Console.WriteLine(); 
            Console.WriteLine("escreva a nota do aluno");
            if (decimal.TryParse(Console.ReadLine(), out decimal nota))
            {
                aluno.Nota = nota;
            }
            else
            {
              exc ();
            }
            alunos[indice]= aluno;
           
        }  
    }
}