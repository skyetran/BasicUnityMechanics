# BasicUnityMechanics
This project is part of CSS 385: Intro to Game Development by Dr. Yusuf Pisan. The provided code is taken from https://github.com/t4guw/100-Unity-Mechanics-for-Programmers. Per the assignment, I selected 5 basic mechanics then modified them to produce different versions.  
### WASD Movement
Original: Four directional movement using WASD key set.  
Change: Implement similar movement logic using different set of keys: arrow keys and IJKL key set.  
Application: Two players sharing one keyboard.  

### Camera Shake
Original: User state the duration and magnitude of the shake, then the camera position changed randomly by the stated magnitude for the stated duration.  
Change: Camera shakes in a specific pattern that adapts to the duration and magnitude. The shaking starts out softly then increase at its peak after the half point, then it reduces slowly until disappear. It disappears when the shaking duration ends.  
Application: Fake earthquake or boss room signal.

### Space to Shoot 2d
Original: Press Space Key to shoot a bullet upward.  
Change: Player can shoot in four direction: upward, downward, leftward, and rightward (centered at the shooter's body). The triggered keys are the arrow keys. "Space" key does nothing in my version.  
Application: Shoot enemies on a platform game.  

### Enemy Followed 2d
Original: Enemy flies directly to the player with a stated speed.  
Change: Added terrain and two more enemies. Enemies are slower than the player, but ocassionally, their speeds are double for a short period. After a period of five seconds, enemies shall randomly spawn on the map (5 units radius from the center of the map).  
Application: Add surprises and prevent players from going in circle.  

### Space Double Jump
Original: Stationary player that can double jump vertically.  
Change: Added terrain and left-right movement.  
Application: Platform game.  
Interesting Discovery: Apparently touching anywhere of the terrain is considered as a reset for a second jump. Hence, touching the bottom or the side also counts.
