using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    private StoneSpawner _stoneSpawner;

     private float _timer;
    [SerializeField] private float _delay;

    private void Update()
    {
        _timer+=Time.deltaTime;

       if(_timer>=_delay){
        _timer=0;
        _stoneSpawner.Spawn();
       }
    }


}
