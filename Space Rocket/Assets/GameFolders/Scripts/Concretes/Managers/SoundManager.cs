using System.Collections;
using System.Collections.Generic;
using SpaceRocket.Abstracts.Utilities;
using UnityEngine;
namespace SpaceRocket.Managers
{
    public class SoundManager : SingletonThisObject<SoundManager>
    {
        AudioSource[] _audioSource;
        private void Awake() {
            SingletonThisGameObject(this); 
            _audioSource = GetComponentsInChildren<AudioSource>();
        }

        public void PlaySound(int index)
        {
            if(!_audioSource[index].isPlaying)
            {
                _audioSource[index].Play();
            }
        }

        public void StopSound(int index)
        {
            if(_audioSource[index].isPlaying)
            {
                _audioSource[index].Stop();
            }
        }

        public void StopAllSoundsAndPlayExplosion()
        {
            for (int i = 0; i < _audioSource.Length; i++)
            {
                if(_audioSource[i].isPlaying)
                {
                    _audioSource[i].Stop();
                }
                else if(i == 3)
                {
                    continue;
                }
            }
            _audioSource[3].Play();
        }

        public void StopAllSoundsAndPlayFinish()
        {
            for (int i = 0; i < _audioSource.Length; i++)
            {
                if(_audioSource[i].isPlaying)
                {
                    _audioSource[i].Stop();
                }
                else if(i == 4)
                {
                    continue;
                }
            }
            _audioSource[4].Play();
        }
    }
}
