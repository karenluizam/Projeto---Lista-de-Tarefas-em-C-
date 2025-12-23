using Projeto_Lista_Tarefas.Models;
//Usando a classe Tarefas com seu namespace



Tarefas Tarefa = new Tarefas();
//Declarando um objeto da classe Tarefas

while(true)
{
    Console.Clear();
    Tarefas.MostrarMenu();
    //Mostra o Menu    
    string opcao = Console.ReadLine();
    //Declara a variável opção para o switch

    switch (opcao)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("DIGITE A TAREFA:");
            Tarefa.AdicionarTarefa();
            //Usando o objeto Tarefa para usar o método Adicionar Tarefa
            Console.WriteLine("TAREFA ADICIONADA");
            break;

        case "2":
            Console.Clear();
            Tarefa.ListarTarefasNumeradas();
            Console.WriteLine("DIGITE O NÚMERO DA TAREFA QUE DESEJA CONCLUIR:");
            string entrada = Console.ReadLine();
            //entrada recebe o numero da tarefa a ser concluída

            if (int.TryParse(entrada, out int indice) &&
                indice >= 1 &&
                indice <= Tarefa.QuantidadeTarefas)
            {
                Tarefa.ConcluirTarefaPorIndice(indice - 1);
            }
            else
            {
                Console.WriteLine("Número inválido.");
                Console.ReadKey();
            }
            break;
            //Caso o numero informado estiver no range da lista, faz o método


        case "3":
            Console.Clear();
            Tarefa.ListarTarefasNumeradas();
            //Usando o objeto Tarefa para usar o método ListarTarefas
            Console.WriteLine("DIGITE O NÚMERO DA TAREFA QUE DESEJA CONCLUIR:");
            entrada = Console.ReadLine();
            if (int.TryParse(entrada, out indice) &&
                indice >= 1 &&
                indice <= Tarefa.QuantidadeTarefas)
            {
                Tarefa.ExcluirTarefaPorIndice(indice - 1);
            }
            else
            {
                Console.WriteLine("Número inválido.");
                Console.ReadKey();
            }
            break;
            //Caso o numero informado estiver no range da lista, faz o método

        case "4":
            Console.Clear();
            Console.WriteLine("TAREFAS:");
            Console.WriteLine();
            Tarefa.ListarTarefas();
            Console.WriteLine(); 
            Console.WriteLine("PRESSIONE QUALQUER TECLA PARA PROSSEGUIR");
            Console.ReadKey();           
            break;
            //Faz o método de listagem

        case "5":
            Console.Clear();
            Console.WriteLine("TAREFAS CONCLUÍDAS:");
            Console.WriteLine();
            Tarefa.ListarTarefasConcluidas();
            Console.WriteLine();
            Console.WriteLine("PRESSIONE QUALQUER TECLA PARA PROSSEGUIR");
            Console.ReadKey();            
            break;
            //Faz o método de listagem

        case "6":
            Console.Clear();
            Console.WriteLine("ENCERRANDO PROGRAMA");
            Environment.Exit(0);
            break;
            //Encerra o programa

        default:
            Console.Clear();
            Console.WriteLine("OPÇÃO INVÁLIDA. TENTE NOVAMENTE");
            Console.ReadKey();            
            break;
            //Caso um valor inválido seja inserido, apresenta a mensagem.

    }

}
