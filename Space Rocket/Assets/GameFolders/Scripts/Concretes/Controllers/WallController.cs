using System.Collections;
using System.Collections.Generic;
using SpaceRocket.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SpaceRocket.Controllers
{
    public class WallController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other) {
            PlayerController player = other.collider.GetComponent<PlayerController>();
            if (player != null && player.canMove)
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}
