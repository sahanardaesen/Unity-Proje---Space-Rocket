using System.Collections;
using System.Collections.Generic;
using SpaceRocket.Managers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SpaceRocket.Controllers
{
    public class FinishFloorController : MonoBehaviour
    {
        [SerializeField] ParticleSystem _particleSystem;
        private void OnCollisionEnter(Collision other) {
           PlayerController player = other.collider.GetComponent<PlayerController>();
           if(player == null || !player.canMove)
            {
                return;
            }
            if (other.GetContact(0).normal.y == -1)
            {
                _particleSystem.Play();
                GameManager.Instance.MissionSucceded();
            }
            else
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}