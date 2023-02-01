using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediateScripting
{
    public class TeleportScript : MonoBehaviour
    {
        void OnEnable()
        {
            EventManager.OnClicked += Teleport;
        }
        
        void OnDisable()
        {
            EventManager.OnClicked -= Teleport;
        }
        
        void Teleport()
        {
            Vector3 pos = transform.position;
            pos.y = Random.Range(1.0f, 3.0f);
            transform.position = pos;
        }
    }
}
