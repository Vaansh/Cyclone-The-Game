# Cyclone - The Game

## Description

This repository contains all the project files for the game "Cyclone", which was made in the Unity game engine and written in C#, along with a Android application package file (CycloneTheSurvivor.apk) - making it playable on any android mobile phone if you wish to test it. I made this project in part to participate in the Software Development Contest (ACUITY 2019), where it would go on to win the second runner's up position.

### Testing

Simply clone the project and move the CycloneTheSurvivor.apk file to an appropriate destination on your android mobile device and install it there to get a playable version of the game.

### Folder structure
#### [Complete Folder Structure](https://pastebin.com/32QQk1aZ)
Here's a simplified folder structure of the project:
```
|-- Cyclone-The-Game
    |-- Assembly-CSharp.csproj
    |-- Cyclone.csproj
    |-- Cyclone.sln
    |-- CycloneTheSurvivor.apk
    |-- CycloneTheSurvivor_beta.apk
    |-- Cyclone_01.apk
    |-- Cyclone_02.apk
    |-- README.md
    |-- Assets
    |   |-- PreFabs
    |   |   |-- Hexagon.prefab
    |   |   |-- Main Camera.prefab
    |   |   |-- New Sprite.prefab
    |   |   |-- Player.prefab
    |   |   |-- Spawner.prefab
    |   |-- Scenes
    |   |   |-- GameOver.unity
    |   |   |-- Home.unity
    |   |   |-- Play.unity
    |   |-- Scripts
    |   |   |-- Hexagon.cs
    |   |   |-- HomeScr.cs
    |   |   |-- Rotator.cs
    |   |   |-- Score.cs
    |   |   |-- Spawner.cs
    |   |   |-- back.cs
    |   |   |-- player.cs
    |   |-- Sprites
    |       |-- backg.png
    |-- Library             #Binary, data and library files, excluded from structure.
    |-- Packages
    |   |-- manifest.json
    |-- ProjectSettings
    |   |-- AudioManager.asset
    |   |-- ClusterInputManager.asset
    |   |-- DynamicsManager.asset
    |   |-- EditorBuildSettings.asset
    |   |-- EditorSettings.asset
    |   |-- GraphicsSettings.asset
    |   |-- InputManager.asset
    |   |-- NavMeshAreas.asset
    |   |-- NetworkManager.asset
    |   |-- Physics2DSettings.asset
    |   |-- PresetManager.asset
    |   |-- ProjectSettings.asset
    |   |-- ProjectVersion.txt
    |   |-- QualitySettings.asset
    |   |-- TagManager.asset
    |   |-- TimeManager.asset
    |   |-- UnityConnectSettings.asset
    |-- obj
        |-- Debug
            |-- Assembly-CSharp.csproj.CoreCompileInputs.cache
            |-- Assembly-CSharp.csprojAssemblyReference.cache
            |-- DesignTimeResolveAssemblyReferencesInput.cache
            |-- TempPE
```

## Product Structure

<img align="left" src="https://i.imgur.com/AbURzxg.jpg" width="400">
<h3>Home Page</h3>
<h4>Descripton:</h4>
This is the home page. It is the first page the user sees as the app is loaded. It also serves as a landing page for the user(s). This page is used to facilitate navigation to other pages on the app by providing links (buttons) to the appropriate pages.

<h4>Page Structure:</h4>

```yml
1. Title: Displays title.

2. Options: Available options.

  2.1 Play Button: On clicking this button, 
    the user begins a new game session.
    
  2.2 Help Button: On clicking this button, 
    the user is sent to the instruction page.
    
  2.3 Quit Button: On clicking this button, 
    the user exists the game.
    
3. Footer: Displays related information.
```
<h4>Conclusion:</h4>
This page is the first page the user sees when they open the application. It provides some basic structure to the website, and a simple colour scheme along with an intuitive layout.
<br>
<img align="left" src="https://i.imgur.com/FbqPL7B.jpg" width="400">
<h3>Help Page</h3>
<h4>Descripton:</h4>
Upon clicking the "help" page on the home screen, the user is lead to this page. It contains the relevant information required in order to play the game.

<h4>Page Structure:</h4>

```yml
1. Title: Displays title.   

2. Instructions: The rules to play the 
    game are stated here. In text,   
    
    2.1 Click on the "Left' half of your screen 
      to rotate the ball in the "counter - clockwise"
      direction. 
      
    2.2 Similarly, the "Right" side for the "clockwise"
      direction.
    
    2.3 Try to get through as many gaps in the hexagon
      as you can and see how long you last!
    
3. Back Button: On clicking this button, 
    the user is sent back to the home page.
```
<h4>Conclusion:</h4>
In order to make a user's journey as smooth as possible, this page is an integral part of any product experience.
<br>
<img align="left" src="https://i.imgur.com/TfU8bhm.jpg" width="400">
<h3>Game Over Page</h3>
<h4>Descripton:</h4>
This page lets the user see their score (time lasted), as well as the highest score achieved by the user (pertains after closing).

<h4>Page Structure:</h4>

```yml
1. Title: Displays page title.

2. Scores: Available records.

  2.1 Time: Time the player lasted in the
    current session that ended.
    
  2.2 High Score: Longest time the user(s)
    have lasted in a session. Updates 
    whenever current record is broken.
    
3. Message: Reads well done.

4. Options: Available options.

  4.1 Retry Button: The user is lead to
    a new game session.
  
  4.2  Home Button: On clicking this button, 
    the user is sent back to the home page.
```
<h4>Conclusion:</h4>
This is the end page. It is the page the user reaches once the game ends. 
<br>

## Demonstration
<h3>Upon opening the game:</h3>
Unity Screen Load and Home Page
<img src="https://media.giphy.com/media/0P0TZeZ1q5nsWXjqGD/giphy.gif" width="1000">
<h3>Brief Gameplay:</h3>
Main Game Session Run and land on Game Over Page
<img src="https://media.giphy.com/media/A5qaVKe1ybhgwVH3AW/giphy.gif" width="1000">
<h3>Functionality of the other pages</h3>
Integrated Home, Help and End Pages
<img src="https://media.giphy.com/media/a3lAjP0DUDYCjsT0da/giphy.gif" width="1000">

## Conclusion
The game was made in Unity Game Engine on a PC running Windows 10. An apk file has been included in this repository, feel free to install the game on your android phone to check it out yourself. Happy gaming!
