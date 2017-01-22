using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aznal
{
    public class Game
    {
        #region "Singleton method"
        private static Game _instancia = null;
        public static bool isGameCreated { get { return _instancia != null; } }
        public static Game instancia
        {
            get
            {
                if (_instancia == null)
                {
                    throw new System.Exception("The game has not been created");
                }
                return _instancia;
            }

            set
            {
                _instancia = value;
            }
        }
        #endregion

        #region "Public Variables"
        public MPlayer player { get; set; }
        public float speed { get; set; }
        #endregion

        public Game ()
        {
            player = new MPlayer();
        }

        #region "Games type"
        public static Game CreateNormalGame ()
        {
            Game game = new Aznal.Game();
            game.speed = 1;

            return game;
        }
        #endregion
    }
}


