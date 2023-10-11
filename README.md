# this has been archived due to a recent redesign of ALVR which itself manages decoupling itself from SteamVR's main processes a lot better.

# ALVRestart

restart all components of SteamVR and ALVR in one go!
![Screenshot of ALVRestart](https://soafen.love/software/ALVRestart/ALVRestart_render.png)

## Functionality

this is a tiny program i mainly made for my own use but it has:
- a dark/light mode toggle
- a customizable choice of browser process so you can make sure ALVRestart kills the one ALVR is using
- 'Kill' button that doesn't restart ALVR. useful for quickly killing SteamVR and ALVR.

## Why does this exist?

sometimes ALVR or SteamVR acts up and needs a full restart of both itself, the Chromium embedded browser it's using, and SteamVR's components.
this is *very annoying* to do while you're in VR, and can be simply impossible if you are, for example, doing some VR marathon challenge where you can't leave the headset, even if everything crashes (this is not an anecdote! what do you mean! that's crazy talk!)
this program should make restarting everything fully just a click away!

## ALVR is cool

ALVR lets you stream a PCVR game from SteamVR to an Oculus Go/Quest/Quest 2, as a SteamVR plugin, entirely negating the need to have Oculus Desktop installed, something that sets it apart from most of the alternatives. this is not only beneficial for privacy reasons but additionally there is heaps of performance gain from *not running every game you play through three VR compositors, the Headset, Oculus Desktop and SteamVR..!* you can check it out [here](https://github.com/alvr-org/ALVR)! it's got even more cool features like the ability to run the VR stream through a USB-C connection, very similar to that of Oculus Link!

i am not a software developer. i'm aspiring, but this is just a small visual basic program made for my needs.
i am always open to contributions ! 💖
