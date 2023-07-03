## Changelog

### 0.1.16
- Initial Refactor by Vapok of ABearCode's SimpleRecycle and Remmiz's SimpleRecycleFixed to support Valheim Version 0.216.9 and beyond
- Supports 0.216.9

### 0.0.13

- fixes an issue where moving items with the recycling tab will log errors if it's the last recyclable item in the list
- recycling bronze is now possible, other multireciped items coming _**soon**_

### 0.0.12

- recycling now requires the right crafting station type and level
    - can be disabled in settings via `RequireExactCraftingStationForRecycling`
    - ui is not final, still needs station indicator

  ![](https://i.imgur.com/PtCJ730.png)

### 0.0.11

- added option to ignore items on the hotbar (enabled by default)
- added filter based on the crafting station used by recipe. Initially implemented for food, but can be configured to whatever one's needs are.
- fixed some minor compatibility issues with EpicLoot, moved button more to the right for now, needs proper fix.

### 0.0.10

- setting to disable container recycling button now actually works
- fix a bug where the recycle button would appear in situations when it shouldn't
- main recycler logic now evaluates if an item is equipped and if it is, adds that as a blocking issue for recycling.
- added setting to hide recipes for equipped items, enabled by default

### 0.0.9

- fixed null reference exceptions when plugin starts up (missed due to plugin being loaded before as a script)

### 0.0.8

- added new experimental UI that addds a new tab to the crafting station. Enabled by default.
- container recycle button no longer enabled by default

### 0.0.7

- fixed a bug where recycling an upgraded item with a rate of 1 that used additional resources than the initial recipe (per level rather than initially), would still return that ingredient back
- fixed some config naming consistency

### 0.0.6

- introduced the option to prevent recycling if item yield after recycling is 0. On by default
- added notifications for when the mod cannot (or decides not to) recycle. On by default

### 0.0.5

- fixed a bug when uncrafting a single stacked item would yield returns for the whole stack

### 0.0.4

- __**(!) Added "RecyclingRate" setting**__

  This sets the rate at which the items are recycled. The mod used to return 100% of the resources, but now the rate is 50% by default.

- added a setting that when enabled, will prevent recycling 0 resources on unstackable items
- button position is now movable by pressing left ctrl and dragging it with right click. Persists on reload
- refactored code in preparation for containerless recycling

### 0.0.3

- now searches all recipes
- calculates the amount of resources based on quality level
- will not recycle if not enough slots are available

### 0.0.2

- Fix a null reference exception in main game menu

### 0.0.1

Initial release