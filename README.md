# ECS-Experiments

This contains my tests around Unity's new Entity Component System. If you're interested in learning more then checkout Unity's official videos about the new system here: 

https://unity3d.com/learn/tutorials/topics/scripting/introduction-ecs

# Rotating Cube Test
This test was inspired by Brackeys video: https://www.youtube.com/watch?v=_U9wRgQyy6s
The rotating cube test I currently have is comprised of two scenes currently.
- MainScene (I know it's a terrible name. I defaulted to my old quick prototyping name)
- HybridScene

### MainScene 
This scene is doing thing the ole-fashioned Unity recommended way of throwing a Monobehavior on a GameObject and letting that MonoBehavior handle the rotating of the cube. It's all done by **RotateBehavior** that's been dropped onto the **behaviorCube** GameObject prefab. 

### HybridScene
This scene is using a hybrid approach to Monobehaviors, Entities, and Components. While we do have a Monobehavior to store data, we're using the Game Object Entity component on little Mr. Cube. We're using **HybridRotatorComponent** to get ALL the entities that have both a **DataBehavior** && **Transform** which could only be instances of our **hybridCube**.

### Results
These results are measured in ***CPU ms time*** for the rotation of 50k cubes on screen. 

**Monobehavior Approach: ** ~315ms
**Hybrid Approach: ** ~245ms

As you can see the results show about a 22.22% improvement in performance just from partly transitioning to Unity's new ECS system. Now I wonder how it'll do once I transition to full ECS for this test.
