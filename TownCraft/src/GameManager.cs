using App.Gameplay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.GameManager
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
        public App.Gameplay.Audio Audio { get; private set; }
        public App.Core.Game Game { get; private set; }
        public App.Core.Menu Menu { get; private set; }

        public GameManager()
        {
            CurrentTime = new Time();
            Audio = new App.Gameplay.Audio();
            Menu = new App.Core.Menu();
            ShowMenu();
        }

        public void ShowMenu()
        {
            _gameState = GameState.Menu;
            Menu.display();
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
    }
}
