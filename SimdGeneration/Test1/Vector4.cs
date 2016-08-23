#region Using Statements
using System.Runtime.InteropServices;
#endregion

namespace Test1
{
    /// <summary>
    /// Represents a 4D vector.
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct Vector4
    {
        /// <summary>
        /// X component.
        /// </summary>
        [FieldOffset(0)]
        public float X;

        /// <summary>
        /// Y component.
        /// </summary>
        [FieldOffset(4)]
        public float Y;

        /// <summary>
        /// Z component.
        /// </summary>
        [FieldOffset(8)]
        public float Z;

        /// <summary>
        /// W component.
        /// </summary>
        [FieldOffset(12)]
        public float W;

        #region Initialize

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4"/> struct.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="z">The z.</param>
        /// <param name="w">The w.</param>
        public Vector4(float x, float y, float z, float w)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.W = w;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Vector4"/> struct.
        /// </summary>
        /// <param name="value">The value.</param>
        public Vector4(float value)
        {
            this.X = this.Y = this.Z = this.W = value;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Implements the operator *.
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static Vector4 operator *(Vector4 value1, Vector4 value2)
        {
            Vector4 vector;

            vector.X = value1.X * value2.X;
            vector.Y = value1.Y * value2.Y;
            vector.Z = value1.Z * value2.Z;
            vector.W = value1.W * value2.W;

            return vector;
        }

        #endregion
    }
}
