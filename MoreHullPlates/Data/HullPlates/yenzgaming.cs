﻿using SMLHelper;
using SMLHelper.Patchers;
using UnityEngine;

namespace MoreHullPlates.HullPlates
{
    public partial class Load
    {
        private static UnityEngine.GameObject YenzenGObject()
        {
            return GameObject.Get(yenztt, "Hullyenzgaming", yenztexture);
        }

        private static TechType yenztt = TechTypePatcher.AddTechType("Hullyenzgaming", "yenzgaming Hull Plate", "Modder. Creator of Custom Food and Egg Info (Item added by MoreHullPlates)");

        private static Texture2D yenztexture = 
            AssetBundle.LoadFromFile($@"./QMods/MoreHullPlates/Assets/yenzgaming.assets").
            LoadAsset<UnityEngine.Sprite>("yenzgaming").texture;

        public static void yenzgaming()
        {
            CraftDataPatcher.customBuildables.Add(yenztt);
            CraftDataPatcher.AddToCustomGroup(TechGroup.Miscellaneous, TechCategory.MiscHullplates, yenztt);
            CustomPrefabHandler.customPrefabs.Add(new CustomPrefab("Hullyenzgaming", "Submarine/Build/Hullyenzgaming", yenztt, YenzenGObject));
            CustomSpriteHandler.customSprites.Add(new CustomSprite(yenztt, Sprite.Get));
            CraftDataPatcher.customTechData.Add(yenztt, TechData.Get);
        }
    }
}
