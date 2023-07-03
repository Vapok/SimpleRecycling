using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using Vapok.SimpleRecycling.Recycling;
using Vapok.SimpleRecycling.UI;

namespace Vapok.SimpleRecycling
{
    [BepInPlugin("vapok.mods.simplerecycling",
        "SimpleRecycling",
        "0.1.16")]
    public class Plugin : BaseUnityPlugin
    {
        public static PluginSettings Settings;
        public static ManualLogSource Log;
        private ContainerRecyclingButtonHolder _containerRecyclingButton;
        private Harmony _harmony;
        public static StationRecyclingTabHolder RecyclingTabButtonHolder { get; private set; }

        private void Awake()
        {
            Log = Logger;
            Settings = new PluginSettings(Config);
        }

        private void Start()
        {
            _harmony = new Harmony("Vapok.SimpleRecycling");
            _harmony.PatchAll();
            _containerRecyclingButton = gameObject.AddComponent<ContainerRecyclingButtonHolder>();
            _containerRecyclingButton.OnRecycleAllTriggered += ContainerRecyclingTriggered;
            RecyclingTabButtonHolder = gameObject.AddComponent<StationRecyclingTabHolder>();
        }

        private void OnDestroy()
        {
            Debug.Log("Unpatching now");
            _harmony.UnpatchSelf();
        }


        // for shortness and readability
        public static string Localize(string text)
        {
            return Localization.instance.Localize(text);
        }

        private void ContainerRecyclingTriggered()
        {
            var player = Player.m_localPlayer;
            var container = (Container) AccessTools.Field(typeof(InventoryGui), "m_currentContainer")
                .GetValue(InventoryGui.instance);
            if (container == null) return;
            Log.LogDebug($"Player {player.GetPlayerName()} triggered recycling");
            Recycler.RecycleInventoryForAllRecipes(container.GetInventory(), player);
        }
    }
}