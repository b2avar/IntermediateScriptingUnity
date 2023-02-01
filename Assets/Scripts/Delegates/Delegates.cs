using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IntermediateScripting
{
    public class Delegates : MonoBehaviour
    {
        delegate void MyDelegate(int num);
        MyDelegate myDelegate;
        
        
        // Start is called before the first frame update
        void Start()
        {
            myDelegate = PrintNum;
            myDelegate(50);

            myDelegate = DoubleNum;
            myDelegate(50);
        }
        
        void PrintNum(int num)
        {
            print ("Print Num: " + num);
        }

        void DoubleNum(int num)
        {
            print ("Double Num: " + num * 2);
        }
    }
}
