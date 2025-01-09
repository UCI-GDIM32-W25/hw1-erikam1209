[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.

## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.

Objects:
    Player
        - Attribute: Bunny Sprite
        - Input: WASD, Space
        - Output: Moves, plants seeds (makes a plant sprite appear, which decreases the number of seeds remaining and increases the number of seeds planted)

    Plant
        - Attribute: Plant Sprite
        - Output: Appears in the spot where the player plants the seed (only can be planted if the number of seeds remaining is bigger than zero)

    Text UI
        - Attribute: Text
        - Output: Displays the number of seeds remaining and the number of seeds planted (Numbers update based on when the space bar is pressed)


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
