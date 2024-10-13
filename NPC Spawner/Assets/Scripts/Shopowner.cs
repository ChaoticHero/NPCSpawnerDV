using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Shopowner : INPC
    {
        public void Speak()
        {
            Debug.Log("Do you wish to purchase something?");
        }
    }
}
