using System.Collections;
using System.Collections.Generic;
using SpaceRocket.Managers;
using UnityEngine;

namespace SpaceRocket.UI
{
    public class MenuPanel : MonoBehaviour
    {
        public void OnClickStartButton()
        {
            GameManager.Instance.LoadLevelScene(1);
        }

        public void OnClickExitButton()
        {
            GameManager.Instance.Exit();
        }
    }
}
