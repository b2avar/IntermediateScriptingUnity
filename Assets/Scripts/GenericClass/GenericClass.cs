using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediateScripting
{
    public class GenericClass <T>
    {
        private T _item;

        public void UpdateItem(T newItem)
        {
            _item = newItem;
        }
    }
}
