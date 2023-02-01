using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediateScripting
{
    public class Attributes : MonoBehaviour
    {
        [Range(-100, 100)] public int speed = 0;
        
        // Update is called once per frame
        void Update()
        {
            transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
        }
    }
}
