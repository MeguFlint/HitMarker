using System;
using Exiled.Events.EventArgs;
using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.Events.Extensions;
using Exiled.API.Interfaces;
using Exiled.Events.Handlers;
using Exiled.API.Structs;
using Exiled.Events.Commands;
using Exiled.Events.Patches;

namespace HitMarker
{
    public class Plugin : Plugin<Config>
    {
        public override string Author { get; } = "by MrAfitol for Milky";
        public override string Name { get; } = "Hitmarker";
        public override string Prefix => "hit_marker";
        public override Version RequiredExiledVersion => new Version(5, 3, 0);
        public override Version Version { get; } = new Version(1, 1, 0);

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
            if (ev.Attacker == null) return;
            if (ev.Target == null) return;

            ev.Attacker.ShowHint($"       <size=25><color=blue>X</color></size>  <size=25>[<color=green>{(int)ev.Amount}</color>]\n\n\n\n\n\n\n\n\n\n\n", 2f);
        }
    }
}