using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets
{
    public abstract class JumpBehaviour : MonoBehaviour
    {
        protected abstract void PerformJump();

        public void Jump()
        {
            //Before
            PerformJump();
            //After
        }
    }
}
