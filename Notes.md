* The **orthographic projection** ignores perspective. Clicking the label under the axis widget at the top right of the scene window toggles between orthographic and perspective mode.
* We can instruct the inspector to enforce a range for our resolution. This is done by attaching the Range attribute to it. For instance 
  ```c#
  [SerializeField, Range(10, 100)] private int resolution = 10;
  ```
* We can set up parent object for instantiated objects after instantiating(1) or during instantiating(2):
  ```c#
  point.SetParent(parentsTransform); //1
  //or
  point = Instantiate(pointPrefab, parentsTransform, false); //2
  ```
* Unity has 3 render pipelines: default, Universal (URP) and High-Definition (HDRP) render pipelines. Render pipelines have different features and limitations. The default render pipeline's feature set is frozen.
  How to work with special RP:
  1. Create an asset for it, via Assets / Create / Rendering / Universal Render Pipeline / Pipeline Asset (Forward Renderer). This will also automatically create another asset for a renderer.
  2. Go to the Graphics section of the project settings and assign the URP asset to the Scriptable Renderer Pipeline Settings field.
  3. Create a new shader graph via Assets / Create / Shader Graph / URP / Lit Shader Graph. (Because materials use one RP thus when we switch on other RP old materials turn magenta (Unity's error material). We need new shader.)
* Saturate function is a special function that clamps all components to 0–1. It is a common operation in shaders known as saturation. We used it for claim our colors (Y component) to 0-1.