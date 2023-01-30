using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediateScripting
{
    public class gc_SomeClass : MonoBehaviour
    {
        public T GenericMethod<T>(T param)
        {
            return param;
        }
    }
}
