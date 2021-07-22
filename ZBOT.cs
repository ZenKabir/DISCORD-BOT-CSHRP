package techtoolbox.Bot;

import javax.security.auth.login.LoginException;

import net.dv8tion.jda.core.JDABuilder;
import net.dv8tion.jda.core.OnlineStatus;
import net.dv8tion.jda.core.entities.Game;
import techtoolbox.Bot.events.GuildMessageReceived;

public class Bot {
    public static String prefix = "~";

    public static void main(String[] args) throws LoginException {
        JDABuilder builder = new JDABuilder();
        builder.setToken("Your token goes here.");
        builder.setStatus(OnlineStatus.ONLINE);
        builder.setGame(Game.playing("boring comedy shows."));

        // Register listeners
        builder.addEventListener(new GuildMessageReceived());

        builder.build();
    }
}