using System.Numerics;

namespace NKHook6.API.Registry {
    public struct Point {
        /// <summary>
        /// Point in space for this point
        /// </summary>
        public Vector3 point;

        /// <summary>
        /// Scale for bloons to be at in this point, Will adjust current scale while going toward and away from point
        /// </summary>
        public float bloonScale;

        /// <summary>
        /// Scale for moabs to be at in this point, Will adjust current scale while going toward and away from point
        /// </summary>
        public float moabScale;

        /// <summary>
        /// Determines if bloons should be invulnerable at this point.
        /// </summary>
        public bool bloonsInvulnerable;

        /// <summary>
        /// Determines if moabs should be invulnerable at this point.
        /// </summary>
        public bool moabsInvulnerable;
    }
}