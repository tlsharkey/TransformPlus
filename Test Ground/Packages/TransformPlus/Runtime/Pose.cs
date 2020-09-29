using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TP
{
    /**
     * struct for handling poses and applying them to Transformations
     */
    public class Pose
    {
        public Vector3 position;
        public Quaternion rotation;
        public Vector3 scale;

        public Pose(Transform t)
        {
            this.position = t.localPosition;
            this.rotation = t.localRotation;
            this.scale = t.localScale;
        }

        public Pose(Vector3 position, Quaternion rotation, Vector3 scale)
        {
            this.position = position;
            this.rotation = rotation;
            this.scale = scale;
        }

        public Pose(bool zeroScale = false)
        {
            this.position = new Vector3(0, 0, 0);
            this.rotation = new Quaternion(0, 0, 0, 0);
            this.scale = zeroScale ? new Vector3(0, 0, 0) : new Vector3(1, 1, 1);
        }

        /** 
         * Applies the pose to the passed transform
         * TODO: Implement
         */
        public void ApplyTo(Transform t, bool useGlobal = false)
        {
            if (useGlobal)
            {
                t.position = this.position;
                t.rotation = this.rotation;
                //t.lossyScale = this.scale;
            }
            else
            {
                t.localPosition = this.position;
                t.locationRotation = this.rotation;
                t.localScale = this.scale;
            }
        }

        /** 
         * Adds the Pose to the passed transform
         * TODO: Implement
         */
        public void ApplyAsTransformation(Transform t, bool useGlobal = false)
        {
            if (useGlobal)
            {
                t.lossyScale += this.scale;
                t.rotation *= this.rotation;
                t.position += this.position;
            }
            else
            {
                t.localScale += this.scale;
                t.localRotation += this.rotation;
                t.localPosition += this.position;
            }
        }

        public static Pose operator +(Pose a, Pose b) =>
            new Pose(
                a.position + b.position,
                a.rotation * b.rotation,
                a.scale + b.scale
            );

        public static Pose operator -(Pose a, Pose b) =>
            new Pose(
                a.position - b.position,
                Quaternion.Inverse(a.rotation) * b.rotation,
                a.scale - b.scale
            );

        public string ToString(string format = "0.0")
        {
            return string.Format("({0}, {1}, {2})    ({3}, {4}, {5}, {6})    ({7}, {8}, {9})",
                this.position.x.ToString(format),
                this.position.y.ToString(format),
                this.position.z.ToString(format),
                this.rotation.w.ToString(format),
                this.rotation.x.ToString(format),
                this.rotation.y.ToString(format),
                this.rotation.z.ToString(format),
                this.scale.x.ToString(format),
                this.scale.y.ToString(format),
                this.scale.z.ToString(format)
            );
        }
    }
}