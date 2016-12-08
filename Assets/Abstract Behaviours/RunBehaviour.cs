using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    public abstract class RunBehaviour : MonoBehaviour
    {

        public void Run()
        {
            //Before
            PerformRun();
            //After
        }

        protected abstract void PerformRun();

    }
}
