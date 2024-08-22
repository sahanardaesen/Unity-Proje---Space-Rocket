using System.Collections;
using System.Collections.Generic;
using SpaceRocket.Controllers;
using SpaceRocket.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SpaceRocket.Abstracts.Controllers
{
    public abstract class WallController : MonoBehaviour
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
