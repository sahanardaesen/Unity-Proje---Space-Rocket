using System.Collections;
using System.Collections.Generic;
using SpaceRocket.Managers;
using UnityEngine;

namespace SpaceRocket.UI
{
    public class GameOverPanel : MonoBehaviour
    {
       public void TryAgainButton()
        {
            GameManager.Instance.LoadLevelScene();
        }

        public void MenuButton()
        {
            GameManager.Instance.LoadMenuScene();
        }
    }
}