using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SpaceRocket.Movements
{
    public class Fuel : MonoBehaviour
    {
        [SerializeField] private float _maxFuel = 100f;
        [SerializeField] private float _currentFuel = 100f;
        [SerializeField] ParticleSystem _particleSystem;
        public bool isEmpty => _currentFuel < 1;
        public float currentFuel => _currentFuel / _maxFuel;
        private void Awake() {
            _currentFuel = _maxFuel;
        }

        public void IncreaseFuel(float amount)
        {
            _currentFuel += amount;
            _currentFuel = Mathf.Min(_currentFuel, _maxFuel);
            if(_particleSystem.isPlaying)
            {
                _particleSystem.Stop();
            }
        }
        
        public void DecreaseFuel(float amount)
        {
            _currentFuel -= amount;
            _currentFuel = Mathf.Max(_currentFuel, 0);

            if(_particleSystem.isStopped)
            {
                _particleSystem.Play();
            }
        }
    }
}
