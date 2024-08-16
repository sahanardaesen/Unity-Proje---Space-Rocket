using System.Collections;
using System.Collections.Generic;
using SpaceRocket.Inputs;
using UnityEngine;


namespace SpaceRocket.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float _forceUp = 10f;
        private Rigidbody _rigidbody;
        private DefaultInput _defaultInput;
        bool _isForceUp;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _defaultInput = new DefaultInput();
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
                Debug.Log("Force Up");
                _rigidbody.AddForce(Vector3.up * Time.deltaTime * _forceUp);
            }
        }
    }
}