# 用来记录我对Cesium-Unity代码的修改

### 2023/7/26

1. CesiumGeoreference.cs中添加了一个GeodeticSurfaceNormalInUnity方法，用来获取地球上任意位置的大地测量法线在Unity中的数值
2. 修改CesiumCameraController.cs的控制方式，改为鼠标左键平移，右键旋转，滚轮前进/后退，WASDQE及方向键控制保留，并增加了rotationSpeed、panMoveSpeed、mouseScrollSpeed属性

### 2023/7/28

1. 新增了一个CesiumPickedResult结构体，用于场景拾取结果的返回
2. CesiumGeoreference.cs中添加PickFromRay、PickFromScreen、PickFromLine等方法，用于对场景进行拾取操作
3. CesiumGeoreference.cs中添加了cameraController、cameraFlyToController等属性对象的获取