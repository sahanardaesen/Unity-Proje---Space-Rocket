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
        ParticleSystem _particleSystem;
        private void OnCollisionEnter(Collision other) {
            PlayerController player = other.collider.GetComponent<PlayerController>();
            _particleSystem = player.explosionParticle;
            if (player != null && player.canMove)
            {
                _particleSystem.Play();
                SoundManager.Instance.StopAllSoundsAndPlayExplosion();
                GameManager.Instance.GameOver();
            }
        }
    }
}
