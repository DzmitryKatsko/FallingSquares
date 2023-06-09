using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameController
{
    public class GameController : MonoBehaviour
    {
        [SerializeField]
        private GameObject _gameScreen;
        [SerializeField]
        private GameObject _gameOverScreen;

        [SerializeField]
        private float _gameOverScreenShowDelay; 

        private bool _wasGameOver;


        private void Update()
        {
            if (_wasGameOver)
            {
                _gameOverScreenShowDelay -= Time.deltaTime;

                if (_gameOverScreenShowDelay <= 0)
                {
                    ShowGameOverScreen();
                }
            }
        }

        public void RestartGame()
        {
            var sceneName = SceneManager.GetActiveScene().name; //получаем название сцены
            SceneManager.LoadSceneAsync(sceneName); //загружаем данную сцену
        }

        public void OnPlayerDied()
        {
            _wasGameOver = true;
        }

        private void ShowGameOverScreen()
        {
            _gameScreen.SetActive(false);
            _gameOverScreen.SetActive(true);
        }
    }
}