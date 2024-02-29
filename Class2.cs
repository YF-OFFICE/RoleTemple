using CommandSystem.Commands.RemoteAdmin.ServerEvent;
using Exiled.API.Extensions;
using Exiled.API.Features;
using Exiled.API.Interfaces;
using Exiled.Events;
using Exiled.Events.EventArgs.Player;
using MEC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingPlugin
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
     

    }
    public class Class2: Plugin<Config>
    {
        public override string Author => "YF-OFFICE";
        public override Version Version => new Version(1, 0, 0);
        public override string Name => "Rolename";
        public Class2 plugin;
        public string RoleID = "";
        public override void OnEnabled()
        {
            plugin = this;
            Exiled.Events.Handlers.Server.RestartingRound += this.RoundEnding;
            Exiled.Events.Handlers.Server.RoundStarted += this.RoundStarted;
            Exiled.Events.Handlers.Player.InteractingDoor += this.Indoor;
            Exiled.Events.Handlers.Player.Hurting += this.Hurt;
            Exiled.Events.Handlers.Player.Died += this.Died;

            Log.Info("加载插件中");
            base.OnEnabled();
        }
        public override void OnDisabled()
        {

            Exiled.Events.Handlers.Server.RestartingRound -= this.RoundEnding;
            Exiled.Events.Handlers.Server.RoundStarted -= this.RoundStarted;
            Exiled.Events.Handlers.Player.InteractingDoor -= this.Indoor;
            Exiled.Events.Handlers.Player.Hurting -= this.Hurt;
            Exiled.Events.Handlers.Player.Died -= this.Died;
            plugin = null;
            Log.Info("插件关闭了");
            base.OnDisabled();
        }
        public void RoundStarted()
        {
         
        }
        public void Indoor(InteractingDoorEventArgs ev)
        {
      

        }
        public void Hurt(HurtingEventArgs ev)
        {
          

        }
        public void Died(DiedEventArgs ev)
        {
         


        }
        public void RoundEnding()
        {
           
        }

    }
}
