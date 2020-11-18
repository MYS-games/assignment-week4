# Assignment-4 

* Shir Avraham
* Yuval Zarbiv
* Matti Stern

## First Section 
We chose the sub-section 3, and the original change we add is Astroids that cross the screen horizontally and catches the players laser shots, means that it makes it harder for the player to hit the targets.

The scene: https://github.com/MYS-games/assignment-week4/blob/main/Assets/Scenes/Enemies.unity
![Astroieds](https://user-images.githubusercontent.com/57191216/99500031-6b713280-2982-11eb-8bb5-63a71af81f75.png)
We added a spawner on the left side of the screean that moves verticaly and spawn astroids, the astroids cant harm the spaceship but can be hit by the spaceship's lazers.
the code for the creation of the  astroids: https://github.com/MYS-games/assignment-week4/blob/main/Assets/Scripts/2-spawners/TimedShieldsRandom.cs
the code we changed so the astroids wont harm the spaceship: https://github.com/MYS-games/assignment-week4/blob/main/Assets/Scripts/3-collisions/DestroyOnTrigger2D.cs

## Second Section
1. Borders - we added visible walls across the screen, to the orders we created we added rigidBdy to prevent the spaceship from crossing them.
the scene code [here](https://github.com/MYS-games/assignment-week4/blob/main/Assets/Scenes/Borders.unity)

![borders](https://user-images.githubusercontent.com/57191216/99500904-aa53b800-2983-11eb-95d6-c5f5bc842fcc.png)

2. Invisible borders- we added inivisible top border and bottom border.
    The top border destroys all laser that  didnt hit an enemy and the bottom border destroys all the enemys that the player didnt kill.
    we created two sprits (that are the borders) and added each a box collider and a trigger named "destroy by border" 
    [here](https://github.com/MYS-games/assignment-week4/blob/main/Assets/Scripts/3-collisions/DestroyByBorder.cs)
    
3. Round world- we created four invisible borders and for each we added box collider and a script named "RoundWorld" [here](https://github.com/MYS-games/assignment-week4/blob/main/Assets/Scripts/3-collisions/RoundWorld.cs), when the spaceship reaches, for example, the right border her new position will be set to the left border's position +radius (same for the other borders).

![roundworld](https://user-images.githubusercontent.com/57191216/99503109-9b223980-2986-11eb-80c4-f66d4dc2502b.png)

## Third Section
We chose the second sub-section.
The game we created simulates a basketball game.
The player needs to prevent the balls from entering the basket by pressing on the right color when the ball is in the orange square above the net.
If the player presses the color when the ball is outside of the square borders he wont get a point.
Implementaion description:
We created a spawner at the top of the screen that spawns balls in random colors.
Each ball has a script attached to it named "ballDetecter" [here](https://github.com/MYS-games/assignment-week4/blob/main/Assets/Scripts/Handlers/ballDetecter.cs) that checks if the ball is in the orange squares's range and if so it checks that the player pressed the right color and if he did he score is increased by one. [here](https://github.com/MYS-games/assignment-week4/blob/main/Assets/Scripts/Handlers/ScoreHandler.cs)

![BasketBall](https://user-images.githubusercontent.com/57191216/99505271-47fdb600-2989-11eb-834a-388cab1fb263.png)

