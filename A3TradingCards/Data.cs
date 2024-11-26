using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3TradingCards
{
    public class Data
    {
        public static List<Player> GetPlayers()
        {
            List<Player> players = new List<Player>();

            Player player = new Player
            {
                Id = 1,
                FullName = "Alberto Contador", 
                DOB = new DateTime(1982, 12, 6), 
                Skills = "Climbing, GC, Time Trial", 
                Nationality = "Spain", 
                GrandTourAppearances = "16 (5 wins)",
                imageId = "1",
                TeamId = 1 //Astana
            };
            player.GeneratePhoto();
            players.Add(player);
            player = new Player
            {
                Id = 2,
                FullName = "Chris Froome",
                DOB = new DateTime(1985, 5, 20),
                Skills = "Climbing, GC, Time Trial",
                Nationality = "UK",
                GrandTourAppearances = "15 (4 wins)",
                imageId = "2",
                TeamId = 2 //Israel-Premier Tech
            };
            player.GeneratePhoto();
            players.Add(player);
            player = new Player
            {
                Id = 3,
                FullName = "Mark Cavendish",
                DOB = new DateTime(1985, 5, 21),
                Skills = "Sprinting, Fast Finishes",
                Nationality = "Isle of Man",
                GrandTourAppearances = "15 (1 win)",
                imageId = "3",
                TeamId = 3 //Dimension Data
            };
            player.GeneratePhoto();
            players.Add(player);
            player = new Player
            {
                Id = 4,
                FullName = "Tom Dumoulin",
                DOB = new DateTime(1990, 11, 11),
                Skills = "Time Trial, GC, Climbing",
                Nationality = "Netherlands",
                GrandTourAppearances = "10 (1 win)",
                imageId = "4",
                TeamId = 4 //Jumbo-Visma
            };
            player.GeneratePhoto();
            players.Add(player);
            player = new Player
            {
                Id = 5,
                FullName = "Mikel Landa",
                DOB = new DateTime(1989, 12, 13),
                Skills = "Climbing, GC",
                Nationality = "Spain",
                GrandTourAppearances = "10 (0 wins)",
                imageId = "5",
                TeamId = 1 //Astana
            };
            player.GeneratePhoto();
            players.Add(player);
            player = new Player
            {
                Id = 6,
                FullName = "Nairo Quintana",
                DOB = new DateTime(1990, 02, 04),
                Skills = "Climbing, GC",
                Nationality = "Colombia",
                GrandTourAppearances = "12 (0 wins)",
                imageId = "6",
                TeamId = 4 //Jumbo-Visma
            };
            player.GeneratePhoto();
            players.Add(player);
            player = new Player
            {
                Id = 7,
                FullName = "Fabio Aru",
                DOB = new DateTime(1990, 07, 03),
                Skills = "Climbing, GC",
                Nationality = "Italy",
                GrandTourAppearances = "8 (1 win)",
                imageId = "7",
                TeamId = 1 //Astana
            };
            player.GeneratePhoto();
            players.Add(player);
            player = new Player
            {
                Id = 8,
                FullName = "Joaquim Rodríguez",
                DOB = new DateTime(1979, 01, 12),
                Skills = "Climbing, GC",
                Nationality = "Spain",
                GrandTourAppearances = "14 (0 wins)",
                imageId = "8",
                TeamId = 3 //Dimension Data
            };
            player.GeneratePhoto();
            players.Add(player);
            player = new Player
            {
                Id = 9,
                FullName = "Andre Greipel",
                DOB = new DateTime(1982, 10, 16),
                Skills = "Sprinting, Fast Finishes",
                Nationality = "Germany",
                GrandTourAppearances = "11 (0 wins)",
                imageId = "9",
                TeamId = 2 //Israel-Premier Tech
            };
            player.GeneratePhoto();
            players.Add(player);
            player = new Player
            {
                Id = 10,
                FullName = "Rigoberto Uran",
                DOB = new DateTime(1987, 01, 26),
                Skills = "Climbing, GC, Time Trial",
                Nationality = "Colombia",
                GrandTourAppearances = "15 (2 wins)",
                imageId = "10",
                TeamId = 3 //Dimension Data
            };
            player.GeneratePhoto();
            players.Add(player);
            player = new Player
            {
                Id = 11,
                FullName = "Alejandro Valverde",
                DOB = new DateTime(1980, 04, 25),
                Skills = "Climbing, Classics, GC",
                Nationality = "Spain",
                GrandTourAppearances = "16 (0 wins)",
                imageId = "11",
                TeamId = 2 //Israel-Premier Tech
            };

            player.GeneratePhoto();
            players.Add(player);
            return players;
        }

        public static List<Team> GetTeams(IEnumerable<Player> players)
        {
            List<Team> teams = new List<Team>();

            Team team = new Team
            {
                Id = 1,
                Name = "Astana",
                Country = "Qazaqstan",
                Players = from p in players
                            where p.TeamId == 1
                            select p

            };
            teams.Add(team);
            team = new Team
            {

                Id = 2,
                Name = "Israel-Premier Tech",
                Country = "Israel",
                Players = from p in players
                          where p.TeamId == 2
                          select p
            };
            teams.Add(team);
            team = new Team
            {
                Id = 3,
                Name = "Dimension Data",
                Country = "South Africa",
                Players = from p in players
                          where p.TeamId == 3
                          select p
            };
            teams.Add(team);
            team = new Team
            {
                Id = 4,
                Name = "Jumbo-Visma",
                Country = "Netherlands",
                Players = from p in players
                          where p.TeamId == 4
                          select p
            };
            teams.Add(team);
            return teams;
        }
    }
}
