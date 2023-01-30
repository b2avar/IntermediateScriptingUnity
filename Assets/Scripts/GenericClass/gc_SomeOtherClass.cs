using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediateScripting
{
    public class gc_SomeOtherClass : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            gc_SomeClass _gcSomeClass = new gc_SomeClass();
            _gcSomeClass.GenericMethod<int>(5);
        }
    }
}
