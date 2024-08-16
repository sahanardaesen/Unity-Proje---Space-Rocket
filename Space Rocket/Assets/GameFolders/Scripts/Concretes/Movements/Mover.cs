using System.Collections;
using System.Collections.Generic;
using SpaceRocket.Controllers;
using UnityEngine;

namespace SpaceRocket.Movements
{
    public class Mover
    {
        Rigidbody _rigidbody; 
        PlayerController _playerController;

        public Mover(PlayerController playerController)
        {
            _playerController = playerController;
            _rigidbody = playerController.GetComponent<Rigidbody>();
        }

        public void FixedTick()
        {
            Debug.Log("FixedTick");
            _rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * _playerController.force);
        }
    }
}

