using BotTSP.Controllers;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace BotTSP
{
    class Bot : BackgroundService
    {
        private ITelegramBotClient _telegramClient;
        private LentghTextController _lentghTextController;
        private InlineKeyboardController _inlineKeyboardController;
        public Bot(ITelegramBotClient telegramClient, LentghTextController lentghTextController, InlineKeyboardController inlineKeyboardController)
        {
            _telegramClient = telegramClient;
            _lentghTextController = lentghTextController;
            _inlineKeyboardController = inlineKeyboardController;
        }
        async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            try
            {
                if (update.Type == UpdateType.CallbackQuery)
                {
                    await _inlineKeyboardController.Handle(update.CallbackQuery, cancellationToken);
                    return;
                }
                if (update.Type == UpdateType.Message)
                {
                    switch (update.Message!.Type)
                    {
                        case MessageType.Text:
                            await _lentghTextController.Handle(update.Message, cancellationToken);
                            return;
                        default:
                            await _telegramClient.SendTextMessageAsync(update.Message.Chat.Id, $"Вы отправили не сообщение ", cancellationToken: cancellationToken);
                            return;
                    }

                }
            }
            catch { }
        }
        Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            var error = exception switch
            {
                ApiRequestException apiRequestException => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                _ => exception.ToString()
            };
            Console.WriteLine(error);
            Console.WriteLine("Ждем 10 секунд перед повторным подключением");
            Thread.Sleep(10000);
            return Task.CompletedTask;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _telegramClient.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                new ReceiverOptions() { AllowedUpdates = { } },
                cancellationToken: stoppingToken);
            Console.WriteLine("Бот запущен");
        }
    }
}
