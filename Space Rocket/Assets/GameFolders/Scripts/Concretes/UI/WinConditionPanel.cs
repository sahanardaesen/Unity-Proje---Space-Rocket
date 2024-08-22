using System.Collections;
using System.Collections.Generic;
using SpaceRocket.Managers;
using UnityEngine;

namespace SpaceRocket.UI
{
    public class WinConditionPanel : MonoBehaviour
    {
        public void WinConditionButton()
        {
            GameManager.Instance.LoadLevelScene(1);
        }
    }
}
