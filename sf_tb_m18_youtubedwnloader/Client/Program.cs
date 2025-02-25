﻿using sf_tb_m18_youtubedwnloader.Abstract;
using sf_tb_m18_youtubedwnloader.Commands;
using sf_tb_m18_youtubedwnloader.Models.Invoker;
using sf_tb_m18_youtubedwnloader.Models.Receiver;

public class Program
{
    public async static Task Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в консоль для скачивания видео с Youtube");
        
        var url = AskUrl();

        var youtubeService = new YoutubeService(url);
        var invoker = new CommandInvoker();

        Console.WriteLine("Получение информации о видео...");
        ICommand getIngoCmd = new GetInfoCommand(youtubeService);
        invoker.SetCommand(getIngoCmd);
        await invoker.Start();

        Console.WriteLine();

        Console.WriteLine("Скачивание видео...");
        ICommand downloadCmd = new DownloadCommand(youtubeService);
        invoker.SetCommand(downloadCmd);
        await invoker.Start();

        Console.WriteLine("Видео скачано");
    }

    private static string AskUrl()
    {
        Console.WriteLine("Введите ссылку на видео для скачивания:");

        string url = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(url))
        {
            Console.WriteLine("Ссылка не введена. Введите ссылку на видео для скачивания:");
            url = Console.ReadLine();
        }

        return url;
    }
}
