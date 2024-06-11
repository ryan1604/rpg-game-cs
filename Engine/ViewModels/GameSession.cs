using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player currentPlayer { get; set; }

        public GameSession()
        {
            currentPlayer = new Player();
            currentPlayer.name = "Ryan";
            currentPlayer.characterClass = "Fighter";
            currentPlayer.hitPoints = 10;
            currentPlayer.experiencePoints = 0;
            currentPlayer.level = 1;
            currentPlayer.gold = 1000000;
        }
    }
}
