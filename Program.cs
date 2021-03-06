using System;
using System.Linq;


namespace testa
{
    class Program
    {
        static void Main(string[] args)
        {
            var alunos = new Aluno[5];
            Aluno aluno;
            var indice=0;

            var opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "x")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        
                        Console.WriteLine("escreva o nome do aluno");
                        aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine(); 
                        Console.WriteLine("escreva a nota do aluno");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new NewArgumentOutOfRangeException("o valor da nota deve ser decimal");
                        }
                        alunos[indice]= aluno;
                        indice++;
                    break; 
                    case "2":
                        foreach (var item in alunos)
                        {
                            if (item != null && !string.IsNullOrWhiteSpace(item.Nome))
                            {
                                var aprovado = item.Aprovado?"sim":"nao";
                                Console.WriteLine($"aluno: {item.Nome}- nota: {item.Nota}- aprovado: {aprovado}");
                            }
                        }
                    break;

                    case "3":
                        var notas = alunos.Where(n=>n!=null).Select(n => n.Nota).ToList();
                        Console.WriteLine($"A media geral é: {(notas.Sum()/notas.Count).ToString("n2")}");

                    break;

                    default:
                        throw new NewArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();

            }


           

        }

        private class NewArgumentOutOfRangeException : Exception
        {
            public NewArgumentOutOfRangeException() //definiu contrutor
            {             
            }

            public NewArgumentOutOfRangeException(string mensage) : base(mensage)
            {
            }
             public NewArgumentOutOfRangeException(string mensage, Exception inerException) : base(mensage, inerException)
            {
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("informe a opção desejado");
            Console.WriteLine(" 1- inserir aluno");
            Console.WriteLine("2- listar aluno");
            Console.WriteLine("3- calcular media geral");
            Console.WriteLine("x- sair");
            Console.WriteLine();

            string OpcaoUsuario = Console.ReadLine();
            return OpcaoUsuario;
        }
    }
}
