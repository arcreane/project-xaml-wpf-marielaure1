using TownCraft.Gameplay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        private TownCraft.Core.Menu _menu;
          
        public GameManager()
        {
            //_menu = new TownCraft.Core.Menu();

            CurrentTime = new Time();
            Audio = new TownCraft.Gameplay.Audio();
            // Afficher le menu au démarrage du jeu
            //_menu.Display();
            // Attendre la sélection de l'utilisateur
            //int option = int.Parse(Console.ReadLine());
            // Gérer l'option sélectionnée
            //_menu.SelectOption(option);
        }

        public void ShowMenu()
        {
            _gameState = GameState.Menu;
            //Menu.Display();
            Console.ReadLine();
        }

        public void StartGame()
        {
            // TODO implement here
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
            if (_gameData != null)
            {
                string json = JsonConvert.SerializeObject(_gameData);
                File.WriteAllText("gameData.json", json);
            }
        }
    }
}


