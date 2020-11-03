# Game-Engines-Assignment

<h1>Game Idea</h1>
For my Game Engines Assignment, I will be doing a procedurally generated city shooter game. This city will feature procedurally generated buildings of different heights that the player can roam around.
<br>
On top of the procedurally generated city, I will look at using the unity spectrum data to make a sun in the game with rotating rings that reacts to the sound of the game music.

<h2>How will I achieve this?</h2>
I will achieve the procedurally generated city by using Perlin noise. This technique will allow me to have some of the buildings, different heights in the game as it will sample the Perlin noise and then instantiate the building's height from that sample of the Perlin noise.
<br>
To achieve the unity data spectrum, I will get the songs data from the audio source and then from that data I dynamically change the height of the cubes which form up the rings that rotate around the sun. To add a bit more flare to the game I will use unity post-processing effect so that I can have each of the cubes that form the ring around the sun, a different colour.

<h2>Player's gaol in the game</h2>
The goal of the game is for the player to kill all of the enemy robots. These enemy robots will move towards the player, but the player can choose to roam a