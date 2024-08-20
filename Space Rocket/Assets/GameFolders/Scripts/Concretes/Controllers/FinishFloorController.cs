using System.Collections;
using System.Collections.Generic;
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
                Debug.Log("Finish");
                _particleSystem.Play();
                //return;
            }
            // if (other.GetContact(0).normal.y == -1)
            // {
            //     Debug.Log("Finish");
            //     _particleSystem.Play();
            // }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}