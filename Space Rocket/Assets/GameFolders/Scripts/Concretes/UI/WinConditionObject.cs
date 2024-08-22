using System.Collections;
using System.Collections.Generic;
using SpaceRocket.Managers;
using UnityEngine;

namespace SpaceRocket.UI
{
    public class WinConditionObject : MonoBehaviour
    {
        [SerializeField] GameObject _winConditionPanel;

        private void Awake() {
            if(_winConditionPanel.activeSelf) {
                _winConditionPanel.SetActive(false);
            }
        }

        private void OnEnable() {
            GameManager.Instance.OnMissionSucceded += OnWinConditionHandler;
        }

        private void OnDisable() {
            GameManager.Instance.OnMissionSucceded -= OnWinConditionHandler;
        }

        private void OnWinConditionHandler()
        {
            Debug.Log("WinCondition");
            if(!_winConditionPanel.activeSelf) {
                _winConditionPanel.SetActive(true);
            }
        }
    }
}
