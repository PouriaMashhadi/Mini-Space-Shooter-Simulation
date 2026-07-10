# Authors

- Pouria Mashhadi
- Amir Mohammad Kaheh

Acknowledgments

This project was developed as a course assignment.


Course: Advanced programming
Instructor: Dr. Maleki Majd
University: Iran University of Science and Technology

# Space Defender

A 2D top-down space shooter built with **C# Windows Forms**. Pilot your ship through 10 escalating waves of enemies, collect coins, upgrade your firepower with random power-ups, and unlock new ship skins in the in-game shop.

This project belongs to the classic **"Shoot 'em Up" (Shmup)** genre.

## Features

- **10 Waves** of increasingly difficult enemy encounters
- **4 Enemy Types**, each with unique behavior:
  - **Standard** — basic enemy with default movement
  - **Scout** — fast, mobile enemy
  - **Shooter** — enemy that fires projectiles at the player
  - **Heavy Tank** — larger, slow-moving enemy that fires a spread of 8 bullets at once
  - **Terrorist** — aggressive enemy that moves directly toward the player
- **Player Ship**
  - Moves in 4 directions (up, down, left, right)
  - Shoots bullets to destroy enemies
  - Has HP, Coins, and Score tracked throughout the run
- **Power-Ups** (dropped randomly by enemies):
  - **Extra Health** — restores player HP
  - **Boost Fire Rate** — temporarily increases shooting speed
  - **Triple Shot** — fires three bullets at once
  - **Shield** — grants temporary protection from damage
- **In-Game Shop**
  - Spend coins earned during gameplay to purchase new ship skins
  - Purchases are saved persistently using **SQLite**, so unlocked skins remain available across sessions

## Tech Stack

- **Language:** C#
- **Framework:** Windows Forms (.NET)
- **Database:** SQLite (for storing shop purchases / unlocked skins)

## Gameplay Loop

1. Player spawns in and faces Wave 1 of enemies.
2. Destroying enemies grants score, and may drop a random power-up or coin.
3. Player collects power-ups to gain a temporary edge in combat.
4. Surviving all 10 waves completes the game (or player HP reaches 0 for Game Over).
5. Coins earned can be spent in the Shop to unlock new ship skins.
6. Shop purchases are saved locally via SQLite and persist between play sessions.

### Prerequisites
- Windows OS
- .NET Framework / .NET SDK compatible with Windows Forms
- Visual Studio (recommended for building/running the project)

### Running the Project
1. Clone or download the repository.
2. Open the solution (`.slnx`) file in Visual Studio.
4. Build and run the project (F5).
