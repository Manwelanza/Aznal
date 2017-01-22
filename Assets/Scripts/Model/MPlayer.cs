﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aznal
{
    public class MPlayer
    {
        #region "Public Variables"
        public float speed { get; set; }
        public float shotSpeed { get; set; }
        public float damage { get; set; }
        //TODO: Añadir nuevas variables cuando sea necesario
        #endregion

        public MPlayer ()
        {
            speed = 10;
            shotSpeed = 10;
            damage = 5;
        }

    }
}


