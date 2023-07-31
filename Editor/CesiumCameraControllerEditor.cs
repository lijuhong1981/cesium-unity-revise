using UnityEditor;
using UnityEngine;

namespace CesiumForUnity
{
    [CustomEditor(typeof(CesiumCameraController))]
    public class CesiumCameraControllerEditor : Editor
    {
        private SerializedProperty _enableMovement;
        private SerializedProperty _enableRotation;

        private SerializedProperty _defaultMaximumSpeed;

        private SerializedProperty _enableDynamicSpeed;
        private SerializedProperty _dynamicSpeedMinHeight;

        //@reviser lijuhong ���rotationSpeed����
        private SerializedProperty _rotationSpeed;

        //@reviser lijuhong ���panMoveSpeed����
        private SerializedProperty _panMoveSpeed;

        //@reviser lijuhong ���mouseScrollSpeed����
        private SerializedProperty _mouseScrollSpeed;

        private SerializedProperty _enableDynamicClippingPlanes;
        private SerializedProperty _dynamicClippingPlanesMinHeight;

        private void OnEnable()
        {
            this._enableMovement =
                this.serializedObject.FindProperty("_enableMovement");
            this._enableRotation =
                this.serializedObject.FindProperty("_enableRotation");

            this._defaultMaximumSpeed =
                this.serializedObject.FindProperty("_defaultMaximumSpeed");

            this._enableDynamicSpeed =
                this.serializedObject.FindProperty("_enableDynamicSpeed");
            this._dynamicSpeedMinHeight =
                this.serializedObject.FindProperty("_dynamicSpeedMinHeight");

            //@reviser lijuhong ���rotationSpeed����
            this._rotationSpeed =
                this.serializedObject.FindProperty("_rotationSpeed");

            //@reviser lijuhong ���panMoveSpeed����
            this._panMoveSpeed =
                this.serializedObject.FindProperty("_panMoveSpeed");

            //@reviser lijuhong ���mouseScrollSpeed����
            this._mouseScrollSpeed =
                this.serializedObject.FindProperty("_mouseScrollSpeed");

            this._enableDynamicClippingPlanes =
                this.serializedObject.FindProperty("_enableDynamicClippingPlanes");
            this._dynamicClippingPlanesMinHeight =
                this.serializedObject.FindProperty("_dynamicClippingPlanesMinHeight");
        }

        public override void OnInspectorGUI()
        {
            this.serializedObject.Update();
            this.DrawProperties();
            this.serializedObject.ApplyModifiedProperties();
        }

        private void DrawProperties()
        {
            // The labels for this component are particularly long, so use a custom value
            // instead of the editor style's default.
            int labelWidth = 215;

            GUILayout.BeginHorizontal();
            GUIContent enableMovementContent = new GUIContent(
                "Enable Movement",
                "Whether movement is enabled on this controller. Movement is controlled " +
                "using the W, A, S, D keys, as well as the Q and E keys for vertical " +
                "movement with respect to the globe.");
            GUILayout.Label(enableMovementContent, GUILayout.Width(labelWidth));
            EditorGUILayout.PropertyField(this._enableMovement, GUIContent.none);
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            GUIContent enableRotationContent = new GUIContent(
                "Enable Rotation",
                "Whether rotation is enabled on this controller. Rotation is controlled " +
                "by movement of the mouse.");
            GUILayout.Label(enableRotationContent, GUILayout.Width(labelWidth));
            EditorGUILayout.PropertyField(this._enableRotation, GUIContent.none);
            GUILayout.EndHorizontal();

            EditorGUILayout.Space(5);

            GUILayout.BeginHorizontal();
            GUIContent defaultMaximumSpeedContent = new GUIContent(
                "Default Maximum Speed",
                "The controller's maximum speed when dynamic speed is disabled. " +
                "If dynamic speed is enabled, this value will not be used.");
            GUILayout.Label(defaultMaximumSpeedContent, GUILayout.Width(labelWidth));
            EditorGUILayout.PropertyField(this._defaultMaximumSpeed, GUIContent.none);
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            GUIContent enableDynamicSpeedContent = new GUIContent(
                "Enable Dynamic Speed",
                "If enabled, the controller's speed will change dynamically based on " +
                "elevation and other factors.");
            GUILayout.Label(enableDynamicSpeedContent, GUILayout.Width(labelWidth));
            EditorGUILayout.PropertyField(this._enableDynamicSpeed, GUIContent.none);
            GUILayout.EndHorizontal();

            EditorGUI.BeginDisabledGroup(!this._enableDynamicSpeed.boolValue);

            GUILayout.BeginHorizontal();
            GUIContent dynamicSpeedMinHeightContent = new GUIContent(
                "Dynamic Speed Min Height",
                "The minimum height where dynamic speed starts to take effect." +
                "\n\n" +
                "Below this height, the current speed will be set as the height of " +
                "the camera above tilesets in the scene. This forces the camera to move " +
                "more slowly when it is right above a tileset.");
            GUILayout.Label(dynamicSpeedMinHeightContent, GUILayout.Width(labelWidth));
            EditorGUILayout.PropertyField(this._dynamicSpeedMinHeight, GUIContent.none);
            GUILayout.EndHorizontal();

            //@reviser lijuhong ���rotationSpeed����
            //begin
            GUILayout.BeginHorizontal();
            GUIContent rotationSpeedContent = new GUIContent(
                "Rotation Speed",
                "The rotation speed of this controller when rotation is enabled. " +
                "If rotation is disabled, this value will not be used.");
            GUILayout.Label(rotationSpeedContent, GUILayout.Width(labelWidth));
            EditorGUILayout.PropertyField(this._rotationSpeed, GUIContent.none);
            GUILayout.EndHorizontal();
            //end

            //@reviser lijuhong ���panMoveSpeed����
            //begin
            GUILayout.BeginHorizontal();
            GUIContent panMoveSpeedContent = new GUIContent(
                "Pan Move Speed",
                "The pan move speed of this controller when movement is enabled. " +
                "If movement is disabled, this value will not be used.");
            GUILayout.Label(panMoveSpeedContent, GUILayout.Width(labelWidth));
            EditorGUILayout.PropertyField(this._panMoveSpeed, GUIContent.none);
            GUILayout.EndHorizontal();
            //end

            //@reviser lijuhong ���mouseScrollSpeed����
            //begin
            GUILayout.BeginHorizontal();
            GUIContent mouseScrollSpeedContent = new GUIContent(
                "Mouse Scroll Speed",
                "The mouse scroll speed of this controller when movement is enabled. " +
                "If movement is disabled, this value will not be used.");
            GUILayout.Label(mouseScrollSpeedContent, GUILayout.Width(labelWidth));
            EditorGUILayout.PropertyField(this._mouseScrollSpeed, GUIContent.none);
            GUILayout.EndHorizontal();
            //end

            EditorGUI.EndDisabledGroup();
            
            EditorGUILayout.Space(5);

            GUILayout.BeginHorizontal();
            GUIContent enableDynamicClippingPlanesContent = new GUIContent(
                "Enable Dynamic Clipping Planes",
                "If enabled, the camera will dynamically reposition its clipping " +
                "planes so that the globe will not get clipped from far away. " +
                "If this option is disabled, the globe and other tilesets may not render " +
                "at large distances because they will be clipped by the camera." +
                "\n\n" +
                "This setting may not work well for rendering objects that are far " +
                "above the Earth but still close to the camera as it zooms out.");
            GUILayout.Label(enableDynamicClippingPlanesContent, GUILayout.Width(labelWidth));
            EditorGUILayout.PropertyField(this._enableDynamicClippingPlanes, GUIContent.none);
            GUILayout.EndHorizontal();

            EditorGUI.BeginDisabledGroup(!this._enableDynamicClippingPlanes.boolValue);

            GUILayout.BeginHorizontal();
            GUIContent dynamicClippingPlanesMinHeightContent = new GUIContent(
                "Dynamic Clipping Planes Min Height",
                "The height to start dynamically adjust the camera's clipping " + 
                "planes. Below this height, the clipping planes will be set to their " +
                "initial values.");
            GUILayout.Label(dynamicClippingPlanesMinHeightContent, GUILayout.Width(labelWidth));
            EditorGUILayout.PropertyField(this._dynamicClippingPlanesMinHeight, GUIContent.none);
            GUILayout.EndHorizontal();

            EditorGUI.EndDisabledGroup();
        }
    }
}
