using UnityEngine;
using Unity.Mathematics;

//@reviser lijuhong
namespace CesiumForUnity
{
    /// <summary>
    /// Cesium场景拾取结果
    /// </summary>
    public struct CesiumPickedResult
    {
        /// <summary>
        /// 从射线原点到拾取点的距离
        /// </summary>
        public float distance;
        /// <summary>
        /// 拾取点的Unity坐标系位置
        /// </summary>
        public Vector3 unityPosition;
        /// <summary>
        /// 拾取点的EarthCenteredEarthFixed(ECEF)坐标系位置
        /// </summary>
        public double3 earthCenteredEarthFixed;
        /// <summary>
        /// 拾取点的经度(x)、纬度(y)、高度(z)
        /// </summary>
        public double3 longitudeLatitudeHeight;
        /// <summary>
        /// 拾取到的Transform对象
        /// </summary>
        public Transform transform;
        /// <summary>
        /// 拾取到的CesiumFeature数组
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
