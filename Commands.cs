using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Discord.Commands;

namespace DIscordBotCsharp.Modules
{
    
   

    public class Commands : ModuleBase<SocketCommandContext>
    {   
        
        [Command("Ping")]
        public async Task Test()
        {
            await ReplyAsync("Pong!");
        }

        




    }




}


