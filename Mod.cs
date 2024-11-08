﻿using Colossal.Logging;
using Game;
using Game.Modding;
using Game.SceneFlow;
using System.IO;
using Colossal.UI;

namespace DansParkingPack
{
    public class Mod : IMod
    {
        //public static ILog log = LogManager.GetLogger($"{nameof(DansRuralPack)}.{nameof(Mod)}").SetShowsErrorsInUI(false);

        public static string Name = "Dans Parking with Parks Pack";
        public static string Version = "1.0.0";
        public static string Author = "DanielVNZ";

        public static string uiHostName = "danielvnz-dansparkingpack";

        public void OnLoad(UpdateSystem updateSystem)
        {




            GameManager.instance.modManager.TryGetExecutableAsset(this, out var asset);
            UIManager.defaultUISystem.AddHostLocation(uiHostName, Path.Combine(Path.GetDirectoryName(asset.path), "thumbs"), false);


        }

        public void OnDispose()
        {

            UIManager.defaultUISystem.RemoveHostLocation(uiHostName);
        }
    }
}
