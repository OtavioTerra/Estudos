using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {

                switch (opcaoUsuario)
                {
                    case "1":
                        
                        Console.WriteLine("Informe o nome do aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine("Informe a nota:");

                        if(decimal.TryParse(Console.ReadLine(), out decimal nota)){
                            aluno.Nota = nota;
                        }
                        else{
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;

                    case "2":
                        
                        foreach(var a in alunos){
                            if(!string.IsNullOrEmpty(a.Nome))
                                Console.WriteLine($"Aluno: {a.Nome} - Nota: {a.Nota}");
                        }
                        break;

                    case "3":
                        decimal notaTotal = 0;
                        for(int i = 0; i < alunos.Length; i++){
                            notaTotal = alunos[i].Nota + notaTotal;
                        }
                        notaTotal = notaTotal/alunos.Length;
                        Console.WriteLine($"A nota media eh {notaTotal}");
                        break;
                    
                    case "4":
                        int maiorNota = 0;
                        for(int i = 0; i < alunos.Length; i++){
                            if(alunos[i].Nota > alunos[maiorNota].Nota){
                                maiorNota = i;
                            }
                        }
                        Console.WriteLine($"Aluno com maior nota: {alunos[maiorNota].Nome} - Nota: {alunos[maiorNota].Nota}");
                        break;

                    default:
                        throw new ArgumentOutOfRangeException("Opcao invalida");

                }

                opcaoUsuario = ObterOpcaoUsuario();

            }

        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular media");
            Console.WriteLine("4 - Ver a maior nota\n");

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}