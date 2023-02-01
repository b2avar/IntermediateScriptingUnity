using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediateScripting
{
    //This is the class you will be storing
    //in the different collections. In order to use
    //a collection's Sort() method, this class needs to
    //implement the IComparable interface.
    public class BadGuy : IComparable<BadGuy>
    {
        public string _name;
        public int _power;

        public BadGuy(string newName, int newPower)
        {
            _name = newName;
            _power = newPower;
        }

        public int CompareTo(BadGuy other)
        {
            if (other == null)
            {
                return 1;
            }

            return _power - other._power;
        }
    }
}
