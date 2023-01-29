using AprendizadoDados.Entities;
using AprendizadoDados.Repository;

Console.WriteLine("\n *** Cadastro da Turma *** \n");

var turma = new Turma();
turma.Professor =new Professor();
turma.Curso= new Curso();

try
{
    turma.IdTurma = Guid.NewGuid();
  
    Console.Write("Informe o Nome da Turma...: " );
    turma.Nome = Console.ReadLine();

    Console.Write("Informe a data de inicio...: ");
    turma.DataInicio = DateTime.Parse(Console.ReadLine());

    Console.Write("Informe o Horário...: ");
    turma.Horario = Console.ReadLine();


    turma.Professor.IdProfessor = Guid.NewGuid();

    Console.Write("Informe o nome do professor...: ");
    turma.Professor.Nome = Console.ReadLine();

    Console.Write("Informe o telefone do professor...: ");
    turma.Professor.Telefone = Console.ReadLine();

    Console.Write("Informe o Email do professor...: ");
    turma.Professor.Email = Console.ReadLine();


    turma.Curso.IdCurso = Guid.NewGuid();

    Console.Write("Informe o Título do curso...:");
    turma.Curso.Titulo = Console.ReadLine();

    Console.Write("Informe a Carga horária do curso...: ");
    turma.Curso.CargaHoraria = decimal.Parse(Console.ReadLine());

    Console.WriteLine("\n Dados da Turma: ");

    Console.WriteLine($"\tId.....: {turma.IdTurma}");
    Console.WriteLine($"\tNome....:{turma.Nome}");
    Console.WriteLine($"\tData de Início...: {turma.DataInicio}");
    Console.WriteLine($"\tHorário...: {turma.Horario}");

    Console.WriteLine($"\tId do professor...: {turma.Professor.IdProfessor}");
    Console.WriteLine($"\tNome do Professor...:{turma.Professor.Nome}");
    Console.WriteLine($"\tTelefone...: {turma.Professor.Telefone}");
    Console.WriteLine($"\tEmail...{turma.Professor.Email}");

    Console.WriteLine($"\tId do Curso....: {turma.Curso.IdCurso}");
    Console.WriteLine($"\tTítulo do curso...:{turma.Curso.Titulo}");
    Console.WriteLine($"\tCarga Horária...: {turma.Curso.CargaHoraria}");


    Console.Write("\nEscolha (1)JSON ou (2)XML...: ");
    var opcao = int.Parse(Console.ReadLine());

    var turmaRepository = new TurmaRepository();

    switch (opcao)
    {
        case 1:
            turmaRepository.ExportarJson(turma);
            Console.WriteLine("\nArquivo JSON gravado com sucesso!");
            break;

        case 2:
            turmaRepository.ExportarXml(turma);
            Console.WriteLine("\nArquivo XML gravado com sucesso!");

            break;

        default:
            Console.WriteLine("\nOpção Inválida!");
            break;
    }



}
catch (ArgumentException e)
{
    Console.WriteLine("\nErro de validação:");
    Console.WriteLine(e.Message);

}
catch (Exception e)
{
    Console.WriteLine("\nFALHA AO EXECUTAR O PROGRAMA:");
    Console.WriteLine(e.Message);
}

Console.ReadKey();