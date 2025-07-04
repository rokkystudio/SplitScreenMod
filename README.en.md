# 🎮 SpliteScreenMod for Terraria

## 🌐 Languages
- [🇷🇺 Russian](README.md)
- [🇬🇧 English](README.en.md)

![Software](/images/ru/software.png)

### 🔮 Not a mod – it’s magic! Make it work yourself!
**SpliteScreenMod** allows multiple players to play Terraria simultaneously on **a single PC**.  
You can enjoy local co-op for **2–4 players** using **gamepads**.

<br>

### 🕹️ ***Gamepads supported – let’s play!***  
### 😈 ***Keyboard and mouse not supported.***  
### 😎 ***Key advantages over other tools:***
- No game modifications required  
- Compatible with the latest Terraria versions  
- Tested on Terraria **1.4.1.2**

<br>

# 🚀 Quick Start

### 🎁 Install Terraria via Steam or other sources.

### ✅ Make sure the game runs without issues.

### 🔎 Locate the installed game folder, for example:
- 🗂️ `C:\Program Files (x86)\Steam\steamapps\common\Terraria\`
- 🗂️ `C:\Program Files\Steam\steamapps\common\Terraria\`
- 🗂️ `D:\SteamLibrary\steamapps\common\Terraria\`

### 🏗️ Copy the game files into separate folders for each player:
- 🗂️ `D:\GAMES\Terraria_Player_1\ *game files*`
- 🗂️ `D:\GAMES\Terraria_Player_2\ *game files*`
- 🗂️ etc., for each player

### 🎭 Rename **Terraria.exe** in each folder:
- Helps you distinguish each running process
- 🗂️ `Terraria_Player_1\Terraria_1.exe`
- 🗂️ `Terraria_Player_2\Terraria_2.exe`

### 🕹️ Copy the **x360ce** gamepad emulator into each folder:
- 🗂️  `Terraria_Player_1\x360ce_x86.exe` – 32-bit version works great even on 64-bit OS
- 🗂️  `Terraria_Player_1\x360ce.ini` – config file created on first launch of **x360ce**
- 🗂️  `Terraria_Player_1\xinput1_3.dll` – DLL file to intercept xinput calls for emulation
- 🗂️  `Terraria_Player_N\` – copy x360ce to every game folder for each player  
<br>

- The **xinput1_3.dll** file is created when launching **x360ce** (look for the **CREATE** button popup).  
- Each Terraria window is controlled by its own **gamepad**, configured via **x360ce**.  
- **x360ce** maps the selected gamepad as **Player 1** for that game copy.  
- Terraria only allows input from the **first xinput controller**.  
- See below for detailed instructions on joystick remapping.

- Version 3.2.10.82 (32-bit) of **x360ce** works reliably.  
- Newer versions may not configure properly.

### 🏃🏻‍♀️ Launch each game copy and wait until it fully loads.  
- CPU optimization instructions are below.

<br>

### 🔲 Enable **windowed mode** in each Terraria copy.
Go to: `Settings → Video → Resolution`:  
- “Borderless Window” → **Off**  
- Enable **Windowed Mode**  
- Click **Apply**  
- ⚠️ You may need to restart Terraria to apply changes  

- Resize, move, and position windows however you like.  
- You can use multiple monitors via extended display mode.  
- Or play on a TV via HDMI — works great.

<br>

![Software](/images/ru/window.png)
<br>

### ✅ Make sure each window is controlled by the correct gamepad!
- Each game window must be **focused** (clicked) for the gamepad to respond.  
- When focus is lost, the game loses sound and input.

### Launch **SpliteScreenMod** and detect Terraria windows (manually or automatically).
- The app can auto-detect windows by title, though it may fail on non-English systems.
- You can manually add windows: focus the desired window, and it will highlight and appear in **SpliteScreenMod**.
- Click “Add” to add the selected window to the list.
- Make sure the number of detected windows matches the number of game copies running.
- Press **Activate** – SpliteScreenMod will keep them “active” at all times.
- You can now play all copies simultaneously.

### ⚙️ Extra configuration tips
- Lower the music volume in all copies except one, to avoid echo.
- No need to mute game sounds completely.
- Adjust `Zoom` and `UI Scale` for each player.
- Terraria won’t allow shrinking the UI too much – make sure window size is large enough.

---

### 🎮 Playing Terraria with a Gamepad

At first, playing with a gamepad might feel awkward. You're used to keyboard and mouse — that's okay.  
But after a few hours, you'll get comfortable. After a few days, you'll master it.

And soon you won't want to go back:
- play while lying on the couch  
- connect to a TV via HDMI  
- no need to sit at a desk anymore

---

### 🧠 CPU Optimization

Terraria doesn't handle multi-core CPUs well.  
When running multiple copies, the load often sticks to **Core 0**, causing lag.

✅ Solution: use Task Manager → “Set affinity” to assign each process to its **own core**.

**Result:** smooth gameplay even with 4 windows open.

---

### 🧼 How to Exit Properly

1. First, close the copies that **joined** the host.  
2. Last, close the copy that **hosted** the world.  

⚠️ This is a recommendation for consistent saving. Usually everything saves fine regardless, but safer this way.

---

### 🌐 Common Launch Issues

- Terraria may **fail to start** or **load very slowly** with poor internet.  
- Make sure **Steam** is running.  
- Game may not start if it requires an update. After updating:
  - re-copy the game for each player  
  - ensure everyone uses the **same version**

---

### 💵💰💳 Support the Developers

Yes, pirated versions often work fine because Steam can’t update them.  
But I highly recommend buying Terraria to support the devs.

Who knows — one day, **you might be the devs** people want to support 😉
