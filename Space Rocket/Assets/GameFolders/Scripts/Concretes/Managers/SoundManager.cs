using System.Collections;
using System.Collections.Generic;
using SpaceRocket.Abstracts.Utilities;
using UnityEngine;
namespace SpaceRocket.Managers
{
    public class SoundManager : SingletonThisObject<SoundManager>
    {
        private void Awake() {
            SingletonThisGameObject(this); 
        }
    }
}
