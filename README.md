# RandomOffset

A lightweight Unity component that smoothly wiggles a GameObject around its original position in 3D space.  
You can configure the maximum offset distance, motion speed (frequency), and random seed for reproducible or variable motion. An accompanying editor script provides a “Randomize Seed” button for convenience.

---

## Features

- Random motion in **X / Y / Z** axes around the original position  
- Adjustable **offset distance** per axis  
- Adjustable **speed / frequency** of motion  
- Custom **integer seed** input for reproducible motion  
- Editor button to auto-randomize seed  
- Supports multiple selected objects (optional – see usage)

---

## Installation

1. Clone or download this repository into your Unity project under `Assets/…`  
2. Ensure the folder structure is preserved (especially the `Editor/` folder for editor scripts)  
3. Let Unity import and compile the scripts  

---

## Usage

### Setup

1. Attach the `RandomOffset` component to the GameObject(s) you want to animate.  
2. In the Inspector, set:
   - **Offset Distance** (per axis): how far the object can deviate  
   - **Offset Speed**: how fast it moves around  
   - **Random Seed** (integer):  
     - If `0`, a random seed is generated at runtime  
     - If nonzero, it produces the same motion pattern each run  

### Editor “Randomize Seed” button

When you select a GameObject with `RandomOffset`, you’ll see a **“Randomize Seed”** button in the Inspector (thanks to the editor script).  
Clicking it assigns a new random integer seed (e.g. between 1 and 9999), which you can then use for reproducible motion.

---