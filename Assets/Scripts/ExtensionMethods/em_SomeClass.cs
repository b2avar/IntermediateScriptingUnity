using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediateScripting
{
    public class em_SomeClass : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            //Notice how you pass no parameter into this
            //extension method even though you had one in the
            //method declaration. The transform object that
            //this method is called from automatically gets
            //passed in as the first parameter.
            transform.ResetTransformation();
        }
        
    }
}
