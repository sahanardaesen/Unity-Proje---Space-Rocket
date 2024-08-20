using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceRocket.Controllers
{
    public class StartFloorController : MonoBehaviour
    {
        private void OnCollisionExit(Collision other) {
            PlayerController player = other.collider.GetComponent<PlayerController>();
            if (player != null)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
