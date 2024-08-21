using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SpaceRocket.Managers
{
    public class GameManager : MonoBehaviour
    {
        public event System.Action OnGameOver;
        public static GameManager Instance { get; private set; }
        public event System.Action OnMissionSucceded;

        private void Awake() {
            SingletonThisObject();
        }
         
        private void SingletonThisObject()
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

        public void MissionSucceded()
        {
            OnMissionSucceded?.Invoke();
        }

        public void LoadLevelScene(int levelIndex = 0)
        {
            StartCoroutine(LoadLevelSceneWithDelay(levelIndex));
        }

        private IEnumerator LoadLevelSceneWithDelay(int levelIndex = 0)
        {
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelIndex); 
        }

        public void LoadMenuScene()
        {
            StartCoroutine(LoadMenuSceneWithDelay());
        }

        private IEnumerator LoadMenuSceneWithDelay()
        {
            yield return SceneManager.LoadSceneAsync("MenuScene");
        }

        public void Exit()
        {
            Debug.Log("Game is closing...");
            Application.Quit();
        }
    }
}
