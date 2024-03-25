
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum GameState
{
    Menu,
    Running,
    Paused,
    Ended
}

namespace GameManagerNamespace
{
    public class GameManager
    {

        private GameState _gameState = GameState.Menu;

        public Time CurrentTime;

        public Audio Audio;

        public Game Game;

        public Menu Menu;

        public GameManager()
        {
            CurrentTime = new Time();
            Audio = new Audio();
            Menu = new Menu();
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
