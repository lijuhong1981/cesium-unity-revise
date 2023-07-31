using UnityEngine;
using Unity.Mathematics;

//@reviser lijuhong
namespace CesiumForUnity
{
    /// <summary>
    /// Cesium����ʰȡ���
    /// </summary>
    public struct CesiumPickedResult
    {
        /// <summary>
        /// ������ԭ�㵽ʰȡ��ľ���
        /// </summary>
        public float distance;
        /// <summary>
        /// ʰȡ���Unity����ϵλ��
        /// </summary>
        public Vector3 unityPosition;
        /// <summary>
        /// ʰȡ���EarthCenteredEarthFixed(ECEF)����ϵλ��
        /// </summary>
        public double3 earthCenteredEarthFixed;
        /// <summary>
        /// ʰȡ��ľ���(x)��γ��(y)���߶�(z)
        /// </summary>
        public double3 longitudeLatitudeHeight;
        /// <summary>
        /// ʰȡ����Transform����
        /// </summary>
        public Transform transform;
        /// <summary>
        /// ʰȡ����CesiumFeature����
        /// </summary>
        public CesiumFeature[] features;

        public override string ToString()
        {
            var result = "CesiumPickedResult:\ndistance = " + distance
                + ";\nunityPosition = " + unityPosition
                + ";\nearthCenteredEarthFixed = " + earthCenteredEarthFixed
                + ";\nlongitudeLatitudeHeight = " + longitudeLatitudeHeight
                + ";\ntransform = " + transform;
            result += ";\nfeatures = ";
            if (features != null)
            {
                result += "{ ";
                for (int i = 0; i < features.Length; i++)
                {
                    result += "[" + i + "]:" + features[0] + ", ";
                }
                result += "}";
            }
            else
            {
                result += "null";
            }
            return result;
        }
    }
}
