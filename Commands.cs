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
        
        [Command("test")]
        public async Task Test()
        {
            await ReplyAsync("It Works Coz Zen Is The Best");
        }

        [Command("seb")]

       

        public async Task Seb()
        {    
            
             await ReplyAsync("Seb WILL GET KNOCKED OUT");
        }

        [Command("zen")]
        public async Task Zen()
        {
            await ReplyAsync("Zen WILL BUSS UP SEB");
        }

        [Command("Fight link")]
        public async Task Url1()
        {
            await ReplyAsync("https://www.youtube.com/channel/UCTE1SSN13juK7FnBUAX0Pwg/videos");
        }

        [Command("fight link")]
        public async Task Url2()
        {
            await ReplyAsync("https://www.youtube.com/channel/UCTE1SSN13juK7FnBUAX0Pwg/videos");
        }

        [Command("softydog")]

        public async Task Softy()
        {
            await ReplyAsync("SoftyDog is a cool guy");
        }

        static string GetIP()
        {
            using (WebClient webClient = new WebClient())
            {
                Random random  = new Random();
                int num = random.Next();

                return webClient.DownloadString("https://api.my-ip.io/ip.txt");





            }



        }

        [Command("help")]

        public async Task Ip()
        {
            await ReplyAsync($"This you?{GetIP()}");
            




        }

        [Command("fraz")]

        public async Task fraz()
        {
            await ReplyAsync($"Fraz is the biggest imbecile ever{GetIP()}");
        }




    }




}


