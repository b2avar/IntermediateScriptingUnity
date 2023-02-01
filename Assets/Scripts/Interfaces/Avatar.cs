using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediateScripting
{
    public class Avatar : MonoBehaviour, IKillable, IDamageable<float>
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void Kill()
        {
            //Do something fun
        }

        public void Damage(float damageTaken)
        {
            //Do something fun
        }
    }
}
