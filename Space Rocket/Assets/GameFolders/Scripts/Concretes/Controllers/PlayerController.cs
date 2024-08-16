using System.Collections;
using System.Collections.Generic;
using SpaceRocket.Inputs;
using SpaceRocket.Movements;
using UnityEngine;

namespace SpaceRocket.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float _rotationSpeed = 10f;
        [SerializeField] private float _force = 50f;
        private Mover _mover;
        private DefaultInput _defaultInput;
        bool _isForceUp;
        float _leftRight;
        Rotater _rotater;
        public float rotationSpeed => _rotationSpeed;
        public float force => _force;

        private void Awake()
        {
            _defaultInput = new DefaultInput();
            _mover = new Mover(this);
            _rotater = new Rotater(this);
        }
        private void Start()
        {
            
        }

        private void Update()
        {
            Debug.Log(_defaultInput.leftRight);
            if (_defaultInput.isForceUp)
            {
                _isForceUp = true;
            }    
            else
            {
                _isForceUp = false;
            }

            _leftRight = _defaultInput.leftRight;
        }

        private void FixedUpdate() {
            if (_isForceUp)
            {
                Debug.Log("FixedUpdate");
                _mover.FixedTick();
            }
            _rotater.FixedTick(_leftRight);
        }
    }
}