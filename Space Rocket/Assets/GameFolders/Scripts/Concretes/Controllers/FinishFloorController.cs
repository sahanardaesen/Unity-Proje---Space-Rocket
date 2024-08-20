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
            if (player != null && other.GetContact(0).normal.y == -1)
            {
                _particleSystem.Play();
            }
            else
            {
                GameManager.Instance.GameOver();
            }
        }
    }
}