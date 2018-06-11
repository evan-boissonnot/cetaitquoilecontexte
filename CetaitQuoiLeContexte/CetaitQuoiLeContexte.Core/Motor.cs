using CetaitQuoiLeContexte.Core.Interfaces;
using CetaitQuoiLeContexte.Core.Interfaces.Data;
using System;

namespace CetaitQuoiLeContexte.Core
{
    public class Motor : IMotor
    {
        #region Fields
        private static Motor __motor = new Motor();
        #endregion

        #region Constructors
        private Motor() { }
        #endregion

        #region Properties
        /// <summary>
        /// Instance unique
        /// </summary>
        public static Motor Instance { get => __motor; }

        /// <summary>
        /// Accès à la configuration du projet
        /// </summary>
        public IAppSettings Settings { get; set; }
        #endregion
    }
}
