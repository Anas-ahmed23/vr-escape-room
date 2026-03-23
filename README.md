# VR Escape Room

A fully interactive Virtual Reality Escape Room experience built in Unity 6 using OpenXR and the XR Interaction Toolkit. Players must explore a laboratory environment, solve three interconnected puzzles, and escape.

---

## Gameplay Overview

Players start inside a detailed 3D laboratory. To escape, they must solve three puzzles in sequence:

1. **Puzzle 1 - Power System:** Find and insert three batteries into their correct sockets to restore power to the lab.
2. **Puzzle 2 - Keypad Lock:** Discover the correct code and press the buttons in the right order to unlock the next stage.
3. **Puzzle 3 - Key and Door:** Locate the hidden key, grab it, and insert it into the door socket to unlock the exit.

---

## Features

- Immersive 3D laboratory environment with atmosphere and lighting
- VR teleportation and continuous locomotion
- Snap turning and smooth movement
- Full object grab and interaction mechanics
- XR Socket Interactor snap-to-place system
- Three fully functional puzzles with sequential progression logic
- Visual feedback via color changes on puzzle completion
- Audio feedback for button clicks, success, and fail states
- Ambient laboratory background audio
- World-space UI message on escape completion
- Meta Quest controller support

---

## Technologies

- Unity 6 (6000.2.2f1)
- XR Interaction Toolkit 3.2.2
- OpenXR
- C#
- TextMeshPro

---

## Project Structure

```
Assets/
├── Audio/          # Sound effects and ambient audio
├── Materials/      # All scene and puzzle materials
├── Models/         # 3D environment and puzzle models
├── Prefabs/        # Reusable puzzle and interaction prefabs
├── Scenes/         # Main laboratory scene
├── Scripts/        # All C# game logic
│   ├── DoorController.cs
│   ├── KeypadSystem.cs
│   └── Puzzle1_Manager.cs
├── Settings/       # XR and input configuration
└── XRI/            # XR Interaction Toolkit configuration
```

---

## Controls (XR Device Simulator)

| Action              | Input                        |
|---------------------|------------------------------|
| Move                | W A S D                      |
| Look                | Right Mouse Button + Mouse   |
| Switch Controller   | Tab                          |
| Grab Object         | G                            |
| Trigger / Press     | Left Mouse Click             |
| Teleport            | Hold Left Mouse then Release |

---

## How to Run

### In Unity Editor

1. Clone the repository
2. Open in Unity 6 (6000.2.2f1)
3. Install XR Interaction Toolkit 3.2.2 via Package Manager
4. Open Assets/Scenes/Laboratory Scene
5. Press Play and use the XR Device Simulator

### On Meta Quest (APK)

1. Enable Developer Mode on your Quest device
2. Install via SideQuest or ADB:

```
adb install VR-Escape-Room.apk
```

3. Launch from Unknown Sources in your Quest library

---

## Requirements

- Unity 6 (6000.2.2f1)
- XR Interaction Toolkit 3.2.2
- OpenXR Plugin
- Meta Quest 2 or 3, or XR Device Simulator for PC testing

---

## Submission

- GitHub Repository with full project and commit history
- APK build for Meta Quest
- Gameplay demo video (60 seconds minimum)

---

## Developer

Anas Ahmed
DMVR606 - Virtual and Augmented Reality Development
ESLSCA University - Year 3, Semester 2, 2026
