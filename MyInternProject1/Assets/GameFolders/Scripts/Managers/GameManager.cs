using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MyInternProject1.Managers
{
    public class GameManager : MonoBehaviour
    {
        public event System.Action OnGameOver;
        public event System.Action OnLevelCompleted;
        public static GameManager Instance { get; private set; }

        private void Awake()
        {
            SingletonThisGameObject();
        }
        private void SingletonThisGameObject()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        public void GameOver()
        {
            OnGameOver?.Invoke();
        }
        public void LevelSucceed()
        {
            OnLevelCompleted?.Invoke();
        }
        public void LoadLevelScene(int levelIndex=0)
        {
            StartCoroutine(LoadLevelSceneAsync(levelIndex));
        }
        private IEnumerator LoadLevelSceneAsync(int levelIndex)
        {
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex+levelIndex);
        }
        public void LoadMenuScene()
        {
            StartCoroutine(LoadMenuSceneAsync());
        }
        private IEnumerator LoadMenuSceneAsync()
        {
            yield return SceneManager.LoadSceneAsync("Menu");
        }
        public void Exit()
        {
            Application.Quit();
        }
    }
}

