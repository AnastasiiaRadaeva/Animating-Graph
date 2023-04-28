# Animating-Graph
<p align="left">
   <img src="https://img.shields.io/badge/Engine-Unity%202021.3.14f1-blue" alt="Unity Version">
</p>

## About
This is the project by [Catlike Coding's tutorial](https://catlikecoding.com/unity/tutorials/basics/building-a-graph/).   
This is an animated sine wave with changing block colours and possibility to change resolution of graph (in inspector of Graph object). There are two different shaders with different render pipelines (Point Surface - shader with default RP; Point URP - shader with Universal RP).
## Documentation
Colours in shaders depend on parameters:
* Point Surface - R and B colour components depend on X and Y.
* Point URP - R and G colour components depend on X and Y.
### How to change shaders:
* In Assets/Point you need to change the material of "Point" (prefab) to "Point Surface" or "Point URP" material.
* Change the Scriptable Renderer Pipeline Settings to needed (URP - how to create this RP see in [Notes](Notes.md) - or None (default RP)) in Edit -> Project Settings -> Graphics.
## Screenshots
<p float="left">
  <img src="ReadmeAssets/Point_Surface_Screen.png" width="300" />
  <img src="ReadmeAssets/Point_URP_Screen.png" width="300" />
</p>
<p float="left">
  <img src="ReadmeAssets/Point_Surface.gif" width="300" />
  <img src="ReadmeAssets/Point_URP.gif" width="300" />
</p>
Point Surface (left), Point URP (right)

## Developers
🙋‍♀️ [Anastasiia Radaeva](https://github.com/AnastasiiaRadaeva)
