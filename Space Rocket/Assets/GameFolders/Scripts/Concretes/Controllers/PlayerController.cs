using System.Collections;
using System.Collections.Generic;
using SpaceRocket.Inputs;
using SpaceRocket.Managers;
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
        Fuel _fuel;
        bool _canMove;

        private void Awake()
        {
            _defaultInput = new DefaultInput();
            _mover = new Mover(this);
            _rotater = new Rotater(this);
            _fuel = GetComponent<Fuel>();
        }

        private void Start() {
            _canMove = true;
        }

        private void OnEnable()
        {
            GameManager.Instance.OnGameOver += OnGameOver;
        }

        

        private void OnDisable()
        {
            GameManager.Instance.OnGameOver -= OnGameOver;
        }

        private void Update()
        {
            if(!_canMove)
            {
                return;
            }
            if (_defaultInput.isForceUp && !_fuel.isEmpty)
            {
                _isForceUp = true;
            }    
            else
            {
                _isForceUp = false;
                _fuel.IncreaseFuel(0.01f);
            }
            _leftRight = _defaultInput.leftRight;
        }

        private void FixedUpdate() {
            if (_isForceUp)
            {
                _mover.FixedTick();
                _fuel.DecreaseFuel(0.1f);
            }
            _rotater.FixedTick(_leftRight);
        }

        private void OnGameOver()
        {
            _canMove = false;
            _isForceUp = false;
            _leftRight = 0;
            _fuel.IncreaseFuel(0);
        }
    }
}