using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using UnityEngine;

namespace Assets.Collisions
{
    public class PassableCollisionBehaviour : MonoBehaviour
    {
        private GameObject _gameIgnored = null;
        Timer ignoreTimer = new Timer(0);

        void Start ()
        {
            ignoreTimer = new Timer(0);
        }

        void OnCollisionStay2D(Collision2D collision)
        {
            
            if (Input.GetKeyDown(KeyCode.DownArrow) || ignoreTimer.Interval > 0) //&& collision.gameObject.tag.Contains("PC"))
            {
                collision.collider.enabled = false;
                _gameIgnored = collision.gameObject;

                if(ignoreTimer.Interval == 0)
                {
                    ignoreTimer.Interval = 3;
                }

                
                //Physics2D.IgnoreCollision(collision.collider, this.GetComponent<Collider2D>(), false);
            }
            
        }

        void Update()
        {
            if (ignoreTimer.Interval == 0 && _gameIgnored != null)
            {
                _gameIgnored.GetComponent<Collider2D>().enabled = true;
                _gameIgnored = null;
            }
        }


    }
}
