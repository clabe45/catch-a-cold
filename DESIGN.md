# Catch a Cold

> Stay Alive for Christmas!

## Overview

### Concept

*Catch a Cold* is a survival game in which you have to stay warm on a snowy mountain. It starts when, on your way to your family's Christmas reunion, your car breaks down due to a freak incident on a dirt road outside of civilization. You are lost in a blizzard, and you must stay alive until someone drives by (whenever that will be). To do this, you have to make use of your environment and your prepared inventory of camping items in creative and desperate ways.

### Genre

Survival

### Target Audience

This game is meant for gamers who like playing survival games that take place in nature and thinking outside the box.

### Game Flow Summary

The player starts out on the peak of a snowy mountain, looking out over a cold wilderness of trees, rocks and snow. To stay alive, she must stay warm and eat. After a randomized length of time, help will arrive, and if the player is still alive, she wins.

### Look and Feel
*Catch a Cold* is low-poly.

## Gameplay and Mechanics

### Gameplay

To stay warm, the player must create and sustain fire, using his surroundings. To create fire, he must do one of the following:
* Collect (`RMB`) a *flintstone* (quartz, chert or obsidian), place it on the ground, and use (`RMB`) the knife in your prepared inventory on it. (*Required energy*: 1)
<!-- * Collect a board and a stick, and place the board on the ground and use the stick on it. (*Required energy*: 2) -->
* Collect and place something shiny (the player's soda can, his water bottle, his glasses) on the ground. If the sun hits it in the right way, fire will be created.

To sustain the fire, he must collect any sort of fuel and place (`RMB`) it on the fire.

The player starts out with 7 pieces of food.

### Mechanics

The world is composed of the environment (which is static and unusable) and entities (which can be picked up and moved).

**Environment**
- Complete list:
  - The mountain
  - Most trees?
- Static, unusable

**Entities**
- Complete list:
  - Rocks
  - Sticks
  - Food
  - Soda can
  - Water bottle
- Mobile (nonstatic), usable (can be picked up and used by the PC)
- Every entity has a set of attributes.
  - These attributes determine how the entity interact with the world and what the player can do with it.
  - Complete list of attributes:
    - Ignitable (only possessed by flintstones)
    - Burnable
    <!-- - Shiny (possessed by anything that can be used to intensify the sun in order to make fire) -->

## Story, Setting and Character

### Story and Narrative

The introduction to the game is a cut scene that shows the character's car break down. It then shows the character get out of the car and look around. Then the game starts (the character's control is passed from the cut scene to the player).

The game ends when a car drives by and the player runs up to it. When this happens, the player wins.

*Note: Since the times that cars drive by is randomized, the player will be given a score based on the time she survived for.*

### Game World

The game takes place in our world. Specifically, this is anywhere (left open) where the climate is cold and somewhat harsh.

### Characters

The player character is left open (i.e. there is no backstory or given personality). For simplicity, every character that drives by in a car is nice enough to pick up the PC.

## Level

There is only one level, the blizzard in which the player has to stay alive. There is no training level.

## Interface

Catch a Cold has the following HUDs:
- Hunger gauge
- Temperature gauge (how cold you are)

The PC is controlled with the following rules:
- **To move**: `WASD`
- **Sprint modifier**: `Shift`
- **To jump**: `Spacebar`

- **To collect an entity (item)**: `LMB` (no entity can be held while collecting a new one)
- **To signal a car**: `LMB`
- **To use an entity**: `RMB`
- **To place an entity**: `RMB`

## Artificial Intelligence

The only AI in Catch a Cold is the cars driving on the road. Each car is spawned at a random time on a random side of the part of the road on the map. It continues driving at a globally constant speed, without changing directions until it reaches the other side; unless the player signals it so it stops, picks up the player; and continues driving until it reaches the other side.

## Technical

This is a lightweight game, and most computers should be able to run it.

## Game Art

The intended style of the game is harsh and blizzard-like. Visual and auditory art look and sound unforgiving and (somewhat) resemble a blizzard.

Most assets are imported from the Unity Asset Store. All Unity assets used in this game are free ones. The following will be created by members of the team:
- **Music**

## Schedule

The following remains to be done:
- **Design**
  - [**v0.1.0**]:
    - [x] Finish this document.
      - [x] *Story, Setting and Character*
      - [x] *Level*
      - [x] *Interface*
      - [x] *AI*
      - [x] *Technical*
      - [x] *Game Art*
  - [**v0.3.0**]:
    - [ ] Finish list of entities.
    - [ ] Finish list of attributes.

- **Development**
  - [**v0.1.0**]:
    - [ ] Increase performance (1).
      - [ ] Set up a chunking system (that loads and unloads with the player).

  - [**v0.2.0**]:
    - Paint road on terrain
    - Create accumulated snow effect:
      - [ ] Create shader and visual effect
    - Create snowing effect
      - [ ] Change fog algorithm from linear to something more realistic.
      - [ ] Generate particles?
    - Implement day / night lighting (no skybox because the sky is snow)
  - [**v0.3.0**]:
    - [ ] Implement custom entity system.
  - [**v0.4.0**]:
    - [ ] Implement car AI.
  - [**v0.5.0**]:
    - [ ] Replace default player interface with that found in *Interface*.
      - [ ] Controls
      - [ ] HUD
  - [**v0.6.0**]:
    - [ ] Implement game menus and screens.
    - [ ] Implement cut scenes and organize with game play.

- **3D Graphics**
  - [ ] [**v0.3.0**]:
    - [ ] Find a model for each entity.

- **2D Graphics**
  - [ ] [**v0.3.0**]:
    - [ ] Create a 2D icon for each entity?

- **Music & Sound**
  - [ ] [**v0.6.0**]:
    - [ ] Create soundtrack.
    - [ ] Find sound effects.

### Versions

- v0.1.0 - Terrain Update
- v0.2.0 - Graphics Update
- v0.3.0 - Entity Update
- v0.4.0 - AI Update
- v0.5.0 - Player Update
- v0.6.0 - Production Update
- v0.7.0 - Easter Egg & Fun Update!
