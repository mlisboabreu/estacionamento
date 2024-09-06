using System;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using Veiculos;
public class Program
{
    public List<string> Nomes = new List<string>() ;
    public List<string> Placas = new List<string>() ;
    public List<DateTime> Horario = new List<DateTime>();
    public string Escolher()
    
    {   
        Console.Write("Qual opção você deseja?:");
        return Console.ReadLine();
    }
    
    public void Cadastrar()
    {
        Console.WriteLine("///Cadastro///");
        Console.Write("Digite a placa do seu veículo: ");
        string Placa = Console.ReadLine();
        Console.Write("Digite seu nome: ");
        string Nome = Console.ReadLine();
        Placas.Add(Placa);
        Nomes.Add(Nome);
        Horario.Add(DateTime.Now);

    }

    public void RemoverCadastro()
    {
        Console.WriteLine("///Cadastro///");
        Console.Write("Qual o seu nome?: ");
        string Nome = Console.ReadLine();
        for(int i = 0; i < Nomes.Count ; i++)
        {
            string VasculharNome = Nomes[i];
            if(VasculharNome == Nome){
                Nomes.Remove(Nomes[i]);
                Placas.Remove(Placas[i]);
                Horario.Remove(Horario[i]);
            }
        }
    }
    public static void Main(string[] args)
    {
        Program program = new Program();
        int Loop = 1;
        while(Loop == 1)
        {
            string Opcoes = "A: Cadastrar veículo\nB: Remover veículo\nC:Visualizar veículos\nD:Sair";
            Console.Clear();
            Console.WriteLine("///Menu Estacionamento///");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine(Opcoes);
            string OpcaoEscolhida = program.Escolher().ToUpper();
            if (OpcaoEscolhida == "A")
            {
                program.Cadastrar();
                Console.ReadLine();
            }
            else if (OpcaoEscolhida == "B")
            {
                Console.Clear();
                program.RemoverCadastro();
                Console.ReadLine();
            }
            else if (OpcaoEscolhida == "C")
            {   
                Console.Clear();
                Console.WriteLine("//Visualizar veículos// ");
                if(program.Placas.Count > 0)
                {
                    for(int i = 0; i < program.Placas.Count; i++)
                    {
                        string Placa = program.Placas[i];
                        string Nome = program.Nomes[i];
                        DateTime Hora = program.Horario[i];
                        Console.WriteLine($"{Placa} - {Nome} - entrada no estacionamento:{Hora}");
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum veículo cadastrado");
                }
                Console.ReadLine();    
            }
        }
    }

}
