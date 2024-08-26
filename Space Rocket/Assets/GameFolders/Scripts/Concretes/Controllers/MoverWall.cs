using System;
using System.Collections;
using System.Collections.Generic;
using SpaceRocket.Abstracts.Controllers;
using UnityEngine;

namespace SpaceRocket.Controllers
{
    public class MoverWall : WallController
    {
        [SerializeField] Vector3 _direction;
        [Range(0, 1)]
        [SerializeField] float _factor;
        [SerializeField] float _speed = 1f;
        Vector3 _startPosition;
        private const float _fullCircle = 2 * Mathf.PI;

        private void Awake() {
            _startPosition = transform.position;
        }

        private void Update() {
            float cycle = Time.time / _speed;
            float sinWave = Mathf.Sin(cycle * _fullCircle);
            _factor = sinWave / 2 + 0.5f;
            //_factor = Mathf.Abs(sinWave);
            Vector3 offset = _direction * _factor;
            transform.position = _startPosition + offset;
        }
    }
}
