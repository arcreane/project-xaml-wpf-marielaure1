using TownCraft.Gameplay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TownCraft.Core;

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
        public TownCraft.Gameplay.Audio Audio { get; private set; }
        public TownCraft.Core.Game Game { get; private set; }
        public TownCraft.Core.Menu Menu { get; private set; }
          
        public GameManager()
        {
            //_menu = new TownCraft.Core.Menu();
            Game = new Game();
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
            //if (_gameData != null)
            //{
            //    string json = JsonConvert.SerializeObject(_gameData);
            //    File.WriteAllText("gameData.json", json);
            //}
        }
    }
}


