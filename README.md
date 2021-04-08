# BasicUnityMechanics
This project is part of CSS 385: Intro to Game Development by Dr. Yusuf Pisan. The provided code is taken from https://github.com/t4guw/100-Unity-Mechanics-for-Programmers. Per the assignment, I selected 5 basic mechanics then modified them to produce different versions.  

## WASD Movement
Original: Four directional movement using WASD key set.  
Change: Implement similar movement logic using different set of keys: arrow keys and IJKL key set.  
Application: Two players sharing one keyboard.  
Link: https://play.unity.com/mg/other/wasd-movement-2d  
![WASD_Movement_2D](https://user-images.githubusercontent.com/71927608/113969790-d2bf4e80-985f-11eb-800d-7b50465b3749.png)  

## Camera Shake
Original: User state the duration and magnitude of the shake, then the camera position changed randomly by the stated magnitude for the stated duration.  
Change: Camera shakes in a specific pattern that adapts to the duration and magnitude. The shaking starts out softly then increase at its peak after the half point, then it reduces slowly until disappear. It disappears when the shaking duration ends.  
Application: Fake earthquake or boss room signal.  
Link: https://play.unity.com/mg/other/camera-shake  
![Camera_Shake](https://user-images.githubusercontent.com/71927608/113969833-e8cd0f00-985f-11eb-84ce-0c7335f91a94.png)  

## Space to Shoot 2d
Original: Press Space Key to shoot a bullet upward.  
Change: Player can shoot in four direction: upward, downward, leftward, and rightward (centered at the shooter's body). The triggered keys are the arrow keys. "Space" key does nothing in my version.  
Application: Shoot enemies on a platform game.  
Link: https://play.unity.com/mg/other/arrow-key-to-shoot  
![Arrow_to_Shoot](https://user-images.githubusercontent.com/71927608/113969864-f71b2b00-985f-11eb-8c10-28c7f8ffff68.png)  

## Enemy Followed 2d
Original: Enemy flies directly to the player with a stated speed.  
Change: Added terrain and two more enemies. Enemies are slower than the player, but ocassionally, their speeds are double for a short period. After a period of five seconds, enemies shall randomly spawn on the map (5 units radius from the center of the map).  
Application: Add surprises and prevent players from going in circle.  
Link: https://play.unity.com/mg/other/enemies-follow-player-2d  
![Enemies_Follow_Player_2D](https://user-images.githubusercontent.com/71927608/113969886-013d2980-9860-11eb-8209-ab862e397a27.png)  

## Space Double Jump
Original: Stationary player that can double jump vertically.  
Change: Added terrain and left-right movement.  
Application: Platform game.  
Link: https://play.unity.com/mg/other/wasd-movement  
Interesting Discovery: Apparently touching anywhere of the terrain is considered as a reset for a second jump. Hence, touching the bottom or the side also counts.
![Double_Jump](https://user-images.githubusercontent.com/71927608/113969907-0c905500-9860-11eb-8ef4-f9080dfd7bd4.png)  
