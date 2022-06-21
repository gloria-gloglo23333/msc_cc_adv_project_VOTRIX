# msc_cc_adv_project_VOTRIX
Environmnet group project by Dongzhuo Liu, Yansong Wang, Lingyu Guo, Fengyi Li.
 
 
## Votrix
__Voice Matrix. A magic matrix contain different aninals in different scences.


#### The Votrix is a simple scenario game. Players need to use the leap motion as the main mode of operation, which is composed of four different scenes. We add four different animals in four different styles and themes of scenes, those animals will hit the ground like a pinball and make a sound, and each animal has different sound effects representing different instruments. Players need to control those animals-pinballs to find the final destination to enter the next level.

### Concept

We aiming to help animals to make noise. Player can use the animal's body to make sounds by hitting the ground.

For example, the sheep’s intestines are used to make strings, the horn is used to make a trumpet, and there are also instruments associated with animal features, such as the zebra and the white tiger’s patterns, the piano keys and the animal’s ribs, the marimba.

### How to play?

When player first see the game, there will be cube rotating automaticlly. 4 sides of the cube have 4 different themes scences which contain different animal pineballs. THen the palyer just need to press the space key to enter the first scence to start. In each scene.

https://user-images.githubusercontent.com/73170220/174636909-6e8cdd96-9f6e-4ae8-be65-1248be1ef943.mp4


The player will use leap motion to control the cube. The leap motion will recognise waving and grabbing movements to control the cube in each different scene. The goal of this game is to help the animal pineball reaching the target icon and entering next level. During the process of reaching the goal, the animals will make different pitched sounds by hitting different terrains.

- The Avatar Cliff


https://user-images.githubusercontent.com/73170220/174638212-dd40e062-93fe-4e1a-b463-ee6adea26245.mp4


- The Lost Temple




https://user-images.githubusercontent.com/73170220/174639757-4ad60e94-2ca7-4ad2-ba59-4b9282bd8106.mp4




- THe Fairy Tale Forest


https://user-images.githubusercontent.com/73170220/174638892-1abce225-1e99-42b5-ac9b-af0d9d64c1da.mp4

- The Frozen Haven



https://user-images.githubusercontent.com/73170220/174639293-454fddf8-7c86-49f9-b48d-5d87a2a1041c.mp4




### - ✨Dongzhuo is doing scence change, portal effect and teleport, camera motion scripts:

- [Leap motion interaction](https://github.com/gloria-gloglo23333/msc_cc_adv_project_VOTRIX/blob/main/Assets/0605export/-Scripts/Rotator.cs)


Call the C# API provided by leapmotion to implement the manipulation logic script based on the left and right palm positions and the corresponding normal angle, and optimize the inertia by calculating the acceleration of the palm motion.

- [Camera auto motion](https://github.com/gloria-gloglo23333/msc_cc_adv_project_VOTRIX/blob/main/Assets/0605export/-Scripts/CameraRotator.cs)


Automate the camera movement logic to achieve automatic level selection and access to levels in the main interface.

- [Audio sequence recording & sequencing](https://github.com/gloria-gloglo23333/msc_cc_adv_project_VOTRIX/blob/main/Assets/0605export/-Scripts/AudioClipList.cs)


Record random audio generated by collisions during play and add different rhythmic intervals to be played again at the end of the level.

- [Portal effect & teleportation](https://github.com/gloria-gloglo23333/msc_cc_adv_project_VOTRIX/blob/main/Assets/0605export/-Scripts/PortalTeleporter1.cs)

Based on Brackeys portal series of tutorials to achieve the effect of different sides of the cube presenting different worlds, as well as portals.

[Video demo here!](https://www.youtube.com/watch?v=cuQao3hEKfs "https://www.youtube.com/watch?v=cuQao3hEKfs")

- [Participate in scene building](https://github.com/gloria-gloglo23333/msc_cc_adv_project_VOTRIX/blob/main/Assets/0605export/-Scripts/loadscene.cs)

Take part of the building work of the selection scene.

- [Key press enter](https://github.com/gloria-gloglo23333/msc_cc_adv_project_VOTRIX/blob/main/Assets/0605export/-Scripts/moveForwardButton.cs)

Press the space key to enter the game.




### - Yansong is doing all the pineball collier, weather, sounds script, who also made the sheep model and cliff scence:

- Making the sheep scene(with Avatar Cliffs)

The Avatar Cliffs (lamb’s perch), which is a scene with five floating cliffs. Each cliff is covered in lush vegetation. At the bottom of the scene is an ocean of water. The aim is to control the lamb by recognising gestures with Leap motion to crash into the bottom cliff and move on to the next level. If the lamb falls into the sea, the scene will restart.



<img width="1904" alt="Screenshot 2022-05-15 at 12 47 44" src="https://user-images.githubusercontent.com/73170220/174687167-458aac43-6d99-44de-a932-713e2d57e94c.png">

<img width="1904" alt="Screenshot 2022-05-23 at 18 53 11" src="https://user-images.githubusercontent.com/73170220/174687183-c68f37f4-0627-4dc6-806b-36c6cde97f5a.png">

<img width="1904" alt="Screenshot 2022-05-23 at 20 48 02" src="https://user-images.githubusercontent.com/73170220/174687200-d5865009-e499-4f98-84ef-b7fdc6076bc5.png">

<img width="1904" alt="Screenshot 2022-05-12 at 11 31 34" src="https://user-images.githubusercontent.com/73170220/174687148-c4f7b530-04ef-475f-abe6-1844585a56b5.png">

![untitled](https://user-images.githubusercontent.com/73170220/174687243-1cc96e4d-818a-4592-9618-043ceb5a9ede.png)



- [Make sound](https://github.com/gloria-gloglo23333/msc_cc_adv_project_VOTRIX/blob/main/Assets/0605export/-Scripts/AudioClipList.cs)

In oder to make the animal make sound, a way called 'on trigger enter' or 'on collider enter' in c# is a good way to start. This founction will detch every collid or triger when one object hit the other one when you give the object a collider and make it on trigger.

Here is what happened when one object hit the other one and make a sound. A sound source is given to the impacted object, and when the impacted object detects the impact on the trigger, it will evoke and play the sound source, thus achieving the sound of the impact.


- [Weather simulation](https://github.com/gloria-gloglo23333/msc_cc_adv_project_VOTRIX/blob/main/Assets/0605export/Yansong/Script/WeatherManager.cs)

By making a weather system simulator to enrich the scene. The principle is to change the colour of the light as well as the intensity over deltatime.


- [Camera pixel shader](https://github.com/gloria-gloglo23333/msc_cc_adv_project_VOTRIX/blob/main/Assets/0605export/Yansong/shader/shaderharder.cs)

Initially, we think giving camera a pixel shader might look better. What the pixel shader do is that making the whole scene pixelated. However, we found it does not suit the scene, so we abandoned this option.

 
- [Load active scene and load next scene](https://github.com/gloria-gloglo23333/msc_cc_adv_project_VOTRIX/blob/main/Assets/0605export/Yansong/Script/SwitchScene.cs)


Reload the scene when the animal “dead”, for each scene in our game, when the animal collide with a specific object, it will “dead”. When the animal dead it will reload the scene. This founction is same as load next level, but just a small difference, when the animal hit the “load next level” object, it will let the camera animation play first, when the animation finished, it will load the next scene.
All the functions for transforming scenes are implemented by means of triggers.


### - Lingyu is making 2 animal pineballs and a scence (The Lost Temple) 

- The Lost Temple

The scence contain 4 platforms and several other things that allowed pineball to collide. Each collision produces a different marimba sound. The player need to hit the skull isle to enter the next level.

![9f08b47860e8258ef7c3abc38f52abd](https://user-images.githubusercontent.com/73170220/174691402-c215ea64-9f8d-4321-9d60-c8d16914fec6.png)


- The snake ball


- The snow tiger ball



- The toon shader

In order to run the game smoother, toon shader is a good way to reduce the program's operation on light. However, the shader is not wokring perfectly, we decided to use Flatkit Shader.

![df1e8842c3b21c75d1ce4c2b5d526ad](https://user-images.githubusercontent.com/73170220/174692667-3feae573-9c75-408d-ae27-7faf6b6a581f.png)


after using Flatkit Shader:


![af73aa021a98000ab8e90fd5a807032](https://user-images.githubusercontent.com/73170220/174692728-8ab3d48f-6ffe-401a-bb07-255b6b554a56.png)


- The grphic for The Avatar Cliff and The Lost Temple

the cliff (which is not fit the scence and we did not used at the end:

![045b54b075e143910ff7f02ef9f7803](https://user-images.githubusercontent.com/73170220/174692817-3c90b91a-d8fe-41ff-9ce6-4749982326ac.png)


 ![WeChat Image_20220621013819](https://user-images.githubusercontent.com/73170220/174693232-c59a2713-0110-4f35-9413-f5d40c30fe27.png)


the temple:

![b2a8d6b3504f2122c108f3b33e8c1f4](https://user-images.githubusercontent.com/73170220/174692631-ca944fa6-bf17-451b-87d1-170eca99986a.png)



 
### - Fengyi is in charge of building 2 scences and a animal model.
 
- The little bull ball:

<img width="1512" alt="µê¬σ▒Å2022-05-31 19 56 38" src="https://user-images.githubusercontent.com/73170220/174632321-00712205-e1ef-49af-98cc-945356ec49a5.png">


- The Snow(tiger) scence:

![WechatIMG243](https://user-images.githubusercontent.com/73170220/174632347-75e53e0f-a08c-4f67-8267-9cc345d625de.jpeg)

- The Grass(bull) scence:


![WechatIMG244](https://user-images.githubusercontent.com/73170220/174632373-cbb97e50-7adf-4d89-8a1e-ed0b91bf47bd.jpeg)

- The front picture for the scence:



 ![UI2_τö╗µ¥┐ 1](https://user-images.githubusercontent.com/73170220/174632413-a5d93321-f56c-4f09-9dec-d1f9825ca0fb.png)

 
