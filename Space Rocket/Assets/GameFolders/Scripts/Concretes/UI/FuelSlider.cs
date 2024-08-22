using System.Collections;
using System.Collections.Generic;
using SpaceRocket.Managers;
using SpaceRocket.Movements;
using UnityEngine;
using UnityEngine.UI;

namespace SpaceRocket.UI
{
    public class FuelSlider : MonoBehaviour
    {
        Slider _slider;
        Fuel _fuel;

        private void Awake() {
            _slider = GetComponent<Slider>();
            _fuel = FindObjectOfType<Fuel>();
        }

        private void Update() {
            _slider.value = _fuel.currentFuel;
        }
    }
}