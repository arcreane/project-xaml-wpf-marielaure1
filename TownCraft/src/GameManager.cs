using TownCraft.Gameplay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TownCraft.Core;
using System.Configuration;
using TownCraft.Database;

namespace TownCraft
{
    public enum GameState
    {
        Menu,
        Running,
        Paused,
        Ended
    }

    public class GameManager
    {
        private GameState _gameState = GameState.Menu;

        public Time CurrentTime { get; private set; }
        public Audio Audio { get; private set; }
        public Game Game { get; private set; }
        public Menu Menu { get; private set; }
        public Database.Database Database { get; private set; }


        public GameManager()
        {
            Database = new Database.Database();
            Database.OpenConnection();
            //_menu = new TownCraft.Core.Menu();
            Game = new Game(this);  
            CurrentTime = new Time();
            Audio = new TownCraft.Gameplay.Audio();
        }

        public void ShowMenu()
        {
            _gameState = GameState.Menu;
            //Menu.Display();
            Console.ReadLine();
        }

        public void CreateGame(string player, string city)
        {
            Game.CreatePlayer(player);
            Game.CreateCity(city);
            Game.CreateFinance();
        }

        public void LoadGame(int idPlayer, int idCity)
        {
            Game.LoadPlayer(idPlayer);
            //Game.SetCity(city);
        }

        public Game StartGame()
        {
            Game.IsRunning = true;
            return Game;
        }

        public void PauseGame()
        {
            // TODO implement here
        }

        public void ResumeGame()
        {
            // TODO implement here
        }

        public void EndGame()
        {
            // TODO implement here
        }

        public void Update()
        {
            // TODO implement here
        }

        public void SaveGame()
        {
        }
    }
}
