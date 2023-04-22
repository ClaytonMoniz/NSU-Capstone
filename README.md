# NSU-Capstone - Zombie Shooter Game
## Description
Short game where you fight zombies that get harder as you progress through the levels.
Game was made using C# Windows forms, and some Python PyAutoGUI for automated testing.
Visual studio was used for developing the game and visual studio code was used for testing. 
## Folder Layout
1. The [Documents](Documents) folder contains the project proposal.
2. The [Links_For_Assets](Links_For_Assets) folder contains all the links to the free images I used to make the game.
3. The [Models](Models) folder contains the activity and use case diagrams.
4. The [SourceCode](SourceCode) folder contains all of the source code for the game.
5. The [ZombieShooterSetup](ZombieShooterSetup) folder contains everything that is needed for installing the game.
6. The [testing](testing) folder contains the images and the python file used for testing with PyAutoGUI
7. The [LICENSE](LICENSE) File contains the MIT license.
## Installation Guide
This will take you step by step to install the game.
1. Go to the [ZombieShooterSetup](ZombieShooterSetup) folder right click on ***ZombieShooterSetup.msi*** and ***Save link as*** to a location of your choosing do the same for ***setup.exe***.

https://user-images.githubusercontent.com/118314166/233803866-08e7e589-822c-422a-8559-4d326cc74f78.mp4

2. Then navigate to the folder you have placed both the ***ZombieShooterSetup.msi*** and the ***setup.exe*** run the ***setup.exe*** and choose the location where you want the game installed. 

https://user-images.githubusercontent.com/118314166/233804146-62898ed8-11e6-4e46-928d-0f38ebb560e9.mp4

3. Then simply navigate to the location you installed the game run ***ZombieShooter.exe*** which will run the game or navigate to the desktop where a shortcut called ***ZombieShooter*** will have been automatically created and double click on it to run the game.
### If it did not work
If it did not install or work properly follow the steps again and ***MAKE SURE THESE ARE TRUE***
- ***BOTH*** the ***ZombieShooterSetup.msi*** and ***setup.exe*** are in the same folder.
- Run the ***setup.exe*** ***NOT*** the ***ZombieShooterSetup.msi***
- I you placed the setup files in the same folder you installed the game to make sure you ***run ZombieShooter.exe to start the game NOT setup.exe***
## Testing Information
### How testing was done
- Testing was done using PyAutoGUI and by simply playing the game.
- PyAutoGUI was only used to test inputs and buttons on the StartMenu, Information page, and first level.
- No further testing was done with PyAutoGUI as the other forms shared the same structure and it was easy to test manually.
### Testing results
- All key inputs work
- All Buttons Work
- All Form transitions work
- All damage is properly calculated
- All enemies are spawning
- All interactions work

[Here](testing) is the folder containing all the images and the python file.
## Assets
All of the asset images I used are free and open source I am not a good artist so this was the best thing for me to use.
- Here are links to all the assets they can also be found in [this](Links_For_Assets) folder.
  - [Health Pickup Icon](https://fightswithbears.itch.io/2d-health-and-ammo-pickups)
  - [Higher Level Zombie](https://tokka.itch.io/top-down-basic-set)
  - [Low Level Zombie, Player Character, Ammo Icon](https://www.mooict.com/c-tutorial-create-a-zombie-survival-shooting-game-in-visual-studio/)
  - [Door and key Image](https://www.mooict.com/c-tutorial-make-a-multiple-level-game-in-windows-form-application/)
  - [Boss level Zombie](https://opengameart.org/content/animated-top-down-zombie)







