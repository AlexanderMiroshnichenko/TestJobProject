using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSpawner : MonoBehaviour
{
   
  [SerializeField] public GameObject[] stones;
    private GameObject _stoneClone;
   [SerializeField]

 
    
      
        public void Spawn()
        {
            _stoneClone =Instantiate(stones[0],transform.position,transform.rotation); 
        }
       


    
}
