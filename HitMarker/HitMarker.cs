using System;
using Exiled.Events.EventArgs;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.Extensions;
using Exiled.API.Interfaces;

namespace HitMarker
{
    public class Plugin : Plugin<Config>
    {
        public override string Author { get; } = "KoT0XleB#4663";
        public override string Name { get; } = "Hitmarker";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.Hurting += PlayerOnHurting;
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Hurting -= PlayerOnHurting;
        }
        public static void PlayerOnHurting(HurtingEventArgs ev)
        {
                ev.Attacker.ShowHint($"       <size=25><color=blue>X</color></size>  <size=25>[<color=green>{(int)ev.Amount}</color>]\n\n\n\n\n\n\n\n\n\n\n", 2f);
            }
        }
    }