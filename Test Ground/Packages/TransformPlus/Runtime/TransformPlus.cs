using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TP
{
    public class TransformPlus
    {
        /**
         * TODO: Implement
         */
        public static TransformPlus AlignSegments(TP.Pose line1_point1, TP.Pose line1_point2, TP.Pose line2_point1, TP.Pose line2_point2)
        {
            TP.Pose line1 = line1_point2 - line1_point1;
            TP.Pose line2 = line2_point2 - line2_point1;
            // TODO: get scale difference
            float dx1 = line1.position.magnitude;
            float dx2 = line2.position.magnitude;

            // TODO: get rotation difference

            // TODO: get position difference
        }

        /**
         * TODO: Implement
         */
        public static TransformPlus AlignSegments(Transform line1_point1, Transform line1_point2, Transform line2_point1, Transform line2_point2)
        {
            return this.AlignSegments(
                new TP.Pose(line1_point1),
                new TP.Pose(line1_point2),
                new TP.Pose(line2_point1),
                new TP.Pose(line2_point2));
        }
    }
}
