# NSU-Capstone - Zombie Shooter Game
## Description
This section is a brief description of what the game is and how it plays as well as what was used to make the game.
- Short game where you fight zombies that get harder as you progress through the levels.
- Collect the key that spawns to transition to the next level.
- Collect ammo when you are our out to continue fighting.
- Collect health pickup when health is low to restore health.
- Defeat the final boss to finish the game.
### What was used in development
- Visual studio - C# and windows forms used to create the game.
- Microsoft visual studio installer project - Visual studio extension used to create installer.
## Folder Layout
1. The [Documents](Documents) folder contains the project proposal.
2. The [Links_For_Assets](Links_For_Assets) folder contains all the links to the free images I used to make the game.
3. The [Models](Models) folder contains the activity and use case diagrams.
4. The [SourceCode](SourceCode) folder contains all of the source code for the game.
5. The [ZombieShooterSetup](ZombieShooterSetup) folder contains everything that is needed for installing the game.
6. The [testing](testing) folder contains the images and the python file used for testing with PyAutoGUI
7. The [LICENSE](LICENSE) File contains the MIT license.
## Testing Information
### How testing was done
- Testing was done using PyAutoGUI in visual stuido code and by simply playing the game.
- PyAutoGUI was only used to test inputs and buttons on the StartMenu, Information page, and first level.
- No further testing was done with PyAutoGUI as the other forms shared the same structure and it was easy to test manually.
### Testing results
- All key inputs work
- All Buttons Work
- All Form transitions work
- All damage is properly calculated
- All enemies are spawning
- All interactions work

[Here](testing) is the folder containing all the images and the python file used in testing.
***IMPORTANT*** I did the testing on a 1440p monitor so if your monitor is a different resolution the images may not work.
That is just how PyAutoGUI is it will have a hard time locating the image if the resolution is different.
## Assets
All of the asset images I used are free and open source I am not a good artist so this was the best thing for me to use.
- Here are links to all the assets the links can also be found in [this](Links_For_Assets) folder.
  - [Health Pickup Icon](https://fightswithbears.itch.io/2d-health-and-ammo-pickups)
  - [Higher Level Zombie](https://tokka.itch.io/top-down-basic-set)
  - [Low Level Zombie, Player Character, Ammo Icon](https://www.mooict.com/c-tutorial-create-a-zombie-survival-shooting-game-in-visual-studio/)
  - [Door and key Image](https://www.mooict.com/c-tutorial-make-a-multiple-level-game-in-windows-form-application/)
  - [Boss level Zombie](https://opengameart.org/content/animated-top-down-zombie)
## Installation Guide
This will take you step by step to install the game.
1. Go to the [ZombieShooterSetup](ZombieShooterSetup) folder click on ***ZombieShooterSetup.msi*** then right click on download and ***Save link as*** to a folder of your choosing do the same for ***setup.exe*** make sure they are ***both in the same folder***.

https://user-images.githubusercontent.com/118314166/233819996-ff75e33f-649b-4b03-8f73-d9d960702911.mp4

2. Then navigate to the folder you have placed both the ***ZombieShooterSetup.msi*** and the ***setup.exe*** run the ***setup.exe*** and choose the folder where you want the game installed it does not have to be installed in the same folder the setup files are in. 

https://user-images.githubusercontent.com/118314166/233804146-62898ed8-11e6-4e46-928d-0f38ebb560e9.mp4

3. Then simply navigate to the folder you installed the game run ***ZombieShooter.exe*** which will run the game or navigate to the desktop where a shortcut called ***ZombieShooter*** will have been automatically created and double click on it to run the game.
### Installation issues
If you are unsure if the game is installed or working the easiset way to test this is to ***go to desktop and double click on the ZombieShooter shortcut***.
Which should have been automatically generated if the game is installed correctly.
If it did not install or work properly follow the install steps again and ***MAKE SURE THESE ARE TRUE***
- ***BOTH*** the ***ZombieShooterSetup.msi*** and ***setup.exe*** are in the same folder.
- Run the ***setup.exe*** ***NOT*** the ***ZombieShooterSetup.msi***.
- If you placed the setup files in the same folder you installed the game to make sure you ***run ZombieShooter.exe to start the game NOT anything else***.
