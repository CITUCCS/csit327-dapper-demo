
using DapperDemo.Models;
using DapperDemo.Repositories;

internal class Program
{
    private static void Main(string[] args)
    {
        IAgentRepository agentRepository = new AgentRepository();
        
        var newAgent = new Agent
        {
            Name = "Reyna",
            Role = "Duelist",
            Country = "Mexico"
        };
        // Insert agent
        var id = agentRepository.Add(newAgent);
        // print new agent id
        Console.WriteLine("New id: " + id);

        // print all
        foreach(var agent in agentRepository.GetAll())
        {
            Console.WriteLine(agent);
        }
    }
}