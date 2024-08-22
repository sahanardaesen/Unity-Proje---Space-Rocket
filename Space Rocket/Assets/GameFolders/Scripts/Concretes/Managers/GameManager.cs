using System;
using System.Collections;
using System.Collections.Generic;
using SpaceRocket.Abstracts.Utilities;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SpaceRocket.Managers
{
    public class GameManager : SingletonThisObject<GameManager>
    {
        public event System.Action OnGameOver;
        public event System.Action OnMissionSucceded;

        private void Awake() {
            SingletonThisGameObject(this);
        }

        private void Start() {
            
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
            SoundManager.Instance.StopSound(1);
            yield return SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelIndex); 
            SoundManager.Instance.PlaySound(2);
        }

        public void LoadMenuScene()
        {
            StartCoroutine(LoadMenuSceneWithDelay());
        }

        private IEnumerator LoadMenuSceneWithDelay()
        {
            SoundManager.Instance.StopSound(2);
            yield return SceneManager.LoadSceneAsync("MenuScene");
            SoundManager.Instance.PlaySound(1);
        }

        public void Exit()
        {
            Debug.Log("Game is closing...");
            Application.Quit();
        }
    }
}
