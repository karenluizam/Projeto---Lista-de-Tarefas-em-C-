using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Lista_Tarefas.Models
{
    public class Tarefas
    //Classe pública Tarefas, onde há métodos referentes às tarefas
    {
        List<string>ListaDeTarefas = new List<string>();
        //Lista de tarefas a serem feitas
        List<string>ListaDeTarefasConcluidas = new List<string>();
        //Lista de Tarefas Concluídas
        string novaTarefa = "";
        //Declara a variável novaTarefa


        public void ListarTarefas()
        //Método para mostrar a lista de tarefas
        //Não é necessário usar parâmetros dentro dos parênteses
        //porque os dados usados já existem dentro da classe/campo/propriedade
        {
            foreach(string tarefa in ListaDeTarefas)            
            {
                Console.WriteLine(tarefa);                
            }            
        }

        public void ListarTarefasNumeradas()
        //Método para mostrar a lista de tarefas numerada        
        {
            for (int i = 0; i < ListaDeTarefas.Count; i++)            
            {
                Console.WriteLine($"{i + 1} - {ListaDeTarefas[i]}");                
            }
        }


        public void AdicionarTarefa()
        //Método para adicionar uma tarefa a lista de tarefas
        {
            novaTarefa = Console.ReadLine();            
            ListaDeTarefas.Add(novaTarefa.ToUpper());             
            Console.WriteLine("TAREFA ADICIONADA!");            
            Console.ReadKey();                 
        }

        
        public int QuantidadeTarefas => ListaDeTarefas.Count;
        //Método que retorna um valor inteiro
        //Valor da quantidade de elementos na ListaDeTarefas

        public void ConcluirTarefaPorIndice(int indice)
        //Método para concluir tarefa pelo índice
        {
            string tarefa = ListaDeTarefas[indice];            
            ListaDeTarefasConcluidas.Add(tarefa);
            ListaDeTarefas.RemoveAt(indice);
            Console.WriteLine("TAREFA CONCLUÍDA!");            
            Console.ReadKey();
            //Adiciona o índice recebido na lista de tarefas concluídas
            //E remove da lista de tarefas
        }


        public void ExcluirTarefaPorIndice(int indice)
        //Método apra excluir uma tarefa
        {
            string tarefa = ListaDeTarefas[indice];            
            ListaDeTarefas.Remove(tarefa);            
            Console.WriteLine("TAREFA EXCLUÍDA!");            
            Console.ReadKey();
            //O conteúdo é removido da lista de tarefas
        }

        public void ListarTarefasConcluidas()
        //Método para listar as tarefas concluídas
        {
            foreach(string tarefa in ListaDeTarefasConcluidas)            
            {
                Console.WriteLine(tarefa);                               
            }
        }

        public static void MostrarMenu()
        //Método para mostrar o Menu
        {
            Console.WriteLine("SELECIONE UMA OPÇÃO:");
            Console.WriteLine("1 - Adicionar Tarefa");
            Console.WriteLine("2 - Concluir Tarefa");
            Console.WriteLine("3 - Excluir Tarefa");
            Console.WriteLine("4 - Ver Lista de Tarefas");
            Console.WriteLine("5 - Ver Tarefas Concluídas");
            Console.WriteLine("6 - Encerrar");
        }
    }
}