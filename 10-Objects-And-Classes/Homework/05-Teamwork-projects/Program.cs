using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Team
{
	public string TeamName { get; set; }
	public string CreatorName { get; set; }
	public List<string> Members { get; set; }

	public Team(string name, string creator)
	{
		this.TeamName = name;
		this.CreatorName = creator;
		this.Members = new List<string>();
	}
}
class Program
{
	static void Main(string[] args)
	{
		int teamsCount = int.Parse(Console.ReadLine());
		List<Team> teams = new List<Team>();
		for (int i = 0; i < teamsCount; i++)
		{
			List<string> tokens = Console.ReadLine().Split('-').ToList();
			Team team = new Team(tokens[1],tokens[0]);
			if (!teams.Select(x => x.TeamName).Contains(team.TeamName))
			{
				if (!teams.Select(x => x.CreatorName).Contains(team.CreatorName))
				{
					teams.Add(team);
					Console.WriteLine($"Team {tokens[1]} has been created by {tokens[0]}!");
				}
				else
				{
					Console.WriteLine($"{team.CreatorName} cannot create another team!");
				}
			}
			else
			{
				Console.WriteLine($"Team {team.TeamName} was already created!");
			}
		}

		string teamRegistration = Console.ReadLine();

		while (teamRegistration != "end of assignment")
		{
			List<string> tokens = teamRegistration.Split(new string[] { "->" },StringSplitOptions.None).ToList();
			string newUser = tokens[0];
			string teamName = tokens[1];
			if (!teams.Select(x => x.TeamName).Contains(teamName))
			{
				Console.WriteLine($"Team {teamName} does not exist!");
			}
			else if (teams.Select(x => x.Members).Any(x => x.Contains(newUser)) || teams.Select(x => x.CreatorName).Contains(newUser))
			{
				Console.WriteLine($"Member {newUser} cannot join team {teamName}!");
			}
			else
			{
				int teamToJoinIndex = teams.FindIndex(x => x.TeamName == teamName);
				teams[teamToJoinIndex].Members.Add(newUser);
			}

			teamRegistration = Console.ReadLine();
		}

		List<Team> teamsToDisband = teams.OrderBy(x => x.TeamName).Where(x => x.Members.Count == 0).ToList();
		List<Team> fullTeams = teams.
		OrderByDescending(x => x.Members.Count).
		ThenBy(x => x.TeamName).
		Where(x => x.Members.Count > 0).ToList();

		foreach (var team in fullTeams)
		{
			Console.WriteLine($"{team.TeamName}");
			Console.WriteLine($"- {team.CreatorName}");
			foreach (var member in team.Members.OrderBy(x => x))
			{
				Console.WriteLine($"-- {member}");
			}
		}

		Console.WriteLine("Teams to disband:");
		foreach (var item in teamsToDisband)
		{
			Console.WriteLine(item.TeamName);
		}

	}
}

