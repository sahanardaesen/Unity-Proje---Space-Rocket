using System;
using System.Collections;
using System.Collections.Generic;
using SpaceRocket.Managers;
using UnityEngine;

namespace SpaceRocket.UI
{
    public class GameOverObject : MonoBehaviour
    {
        [SerializeField] GameObject _gameOverPanel;

        private void Awake() {
            if(_gameOverPanel.activeSelf) {
                _gameOverPanel.SetActive(false);
            }
        }

        private void OnEnable() {
            GameManager.Instance.OnGameOver += OnGameOverHandler;
        }

        private void OnDisable() {
            GameManager.Instance.OnGameOver -= OnGameOverHandler;
        }

        private void OnGameOverHandler()
        {
            if(!_gameOverPanel.activeSelf) {
                _gameOverPanel.SetActive(true);
            }
        }
    }
}
