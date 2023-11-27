using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.InputSystem;

public class TimelineTrigger : MonoBehaviour
{
    [SerializeField] private PlayableDirector _playableDirector;
    [SerializeField] private PlayerInput _playerInput;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" )        
            _playableDirector.Play();
    }

    public void StopInput()
    {
        if(_playableDirector.time == 0f)
        _playerInput.enabled = false;
    }

    public void EnableInput()
    {
        if(_playableDirector.time >= 2.85f) 
        _playerInput.enabled = true;

        this.gameObject.SetActive(false);
    }

}
