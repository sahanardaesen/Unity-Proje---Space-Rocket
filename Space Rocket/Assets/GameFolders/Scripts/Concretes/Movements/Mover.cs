using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceRocket.Movements
{
    public class Mover
    {
        Rigidbody _rigidbody; 

        public Mover(Rigidbody rigidbody)
        {
            _rigidbody = rigidbody;
        }

        public void FixedTick()
        {
            Debug.Log("FixedTick");
            _rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * 10000f);
        }
    }
}

