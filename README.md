# RandomOffset

A lightweight Unity component that smoothly **wiggles** a GameObject around its original position in X/Y/Z using Perlin noise. Configure per-axis **offset distance**, **speed (frequency)**, and an integer **seed** for deterministic or varied motion. Includes an **Inspector button** to randomize seeds (supports **multi-selection**).

## ✨ Features

* Smooth Perlin-noise motion in **X / Y / Z**
* Per-axis **Offset Distance**
* **Offset Speed** (frequency)
* Integer **Random Seed**

  * `0` → auto-random each play
  * non-zero → deterministic pattern
* **Editor button**: Randomize Seed for one or many selected objects

## 📦 Installation

1. Copy `RandomOffset.cs` to `Assets/Scripts/` (or any folder under `Assets/`).
2. Copy `RandomOffsetEditor.cs` to an `Editor/` subfolder, e.g. `Assets/Scripts/Editor/RandomOffsetEditor.cs`.
3. Unity will compile automatically.

## 🚀 Quick Start

1. Add **RandomOffset** to any GameObject.
2. Set:

   * **Offset Distance** (`Vector3`): max local displacement per axis
   * **Offset Speed** (`float`): how fast it moves
   * **Random Seed** (`int`): 0 for auto; any positive int for repeatable motion
3. (Optional) Select one or many objects and click **Randomize Seed** in the Inspector.


## 🛠️ Editor Tools

* **Randomize Seed** button appears when a `RandomOffset` is selected.
* With multiple GameObjects selected, clicking the button assigns **different** seeds to each (undo supported).

## 💡 Notes & Tips

* Motion is applied to **localPosition** (relative to parent).
  If you prefer world-space, change to `transform.position` in the script.
* Perlin noise gives **organic wobble**. If you want snappier “jitter,” swap to interval-based `Random.insideUnitSphere` logic.
* For consistent results across a group, assign distinct integer seeds (e.g., 1, 2, 3…).

## ✅ Compatibility

* Unity 2020+ (tested on recent LTS).
* Pipeline-agnostic (URP/HDRP/Built-in)—it only moves transforms.
