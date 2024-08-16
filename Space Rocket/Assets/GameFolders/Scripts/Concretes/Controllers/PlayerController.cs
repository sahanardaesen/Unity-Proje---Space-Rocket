using System.Collections;
using System.Collections.Generic;
using SpaceRocket.Inputs;
using SpaceRocket.Movements;
using UnityEngine;

namespace SpaceRocket.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        private Mover _mover;
        private DefaultInput _defaultInput;
        bool _isForceUp;

        private void Awake()
        {
            _defaultInput = new DefaultInput();
            _mover = new Mover(GetComponent<Rigidbody>());
        }
        private void Start()
        {
            
        }

        private void Update()
        {
            if (_defaultInput.isForceUp)
            {
                _isForceUp = true;
            }    
            else
            {
                _isForceUp = false;
            }
        }

        private void FixedUpdate() {
            if (_isForceUp)
            {
                Debug.Log("FixedUpdate");
                _mover.FixedTick();
            }
        }
    }
}