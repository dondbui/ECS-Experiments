# ECS-Experiments

This contains my tests around Unity's new Entity Component System. If you're interested in learning more then checkout Unity's official videos about the new system here: 

https://unity3d.com/learn/tutorials/topics/scripting/introduction-ecs

# Rotating Cube Test
This test was inspired by Brackeys video: https://www.youtube.com/watch?v=_U9wRgQyy6s
The rotating cube test I currently have is comprised of three scenes currently.
- MainScene (I know it's a terrible name. I defaulted to my old quick prototyping name)
- HybridScene
- SingleBehaviorScene

### MainScene 
This scene is doing thing the ole-fashioned Unity recommended way of throwing a Monobehavior on a GameObject and letting that MonoBehavior handle the rotating of the cube. It's all done by **RotateBehavior** that's been dropped onto the **behaviorCube** GameObject prefab. 

### HybridScene
This scene is using a hybrid approach to Monobehaviors, Entities, and Components. While we do have a Monobehavior to store data, we're using the Game Object Entity component on little Mr. Cube. We're using **HybridRotatorComponent** to get ALL the entities that have both a **DataBehavior** && **Transform** which could only be instances of our **hybridCube**.

### SingleBehaviorScene
This is a single monobehavior that spawns the cubes, keeps reference to them, and handles the rotation on update.

### Results
These results are measured in ***CPU ms time*** for the rotation of 50k cubes on screen. 

**Monobehavior Approach:** ~230ms
This approach was one monobehavior on each cube

**Hybrid Approach:** ~160ms
This approach was to use a hybrid ECS approach.

**Single Monobehavior Approach:** ~140ms
This approach used a single monobehavior in the whole scene which spawned and rotated the cubes

As you can see the results show about a 22.22% improvement in performance just from partly transitioning to Unity's new ECS system. Unfortunately though the fact that we still have a monobehavior on all 50k cubes is still enough overhead to make the hybrid approach still lose out to the single monobehavior approach. 

Now I wonder how it'll do once I transition to full ECS for this test.
