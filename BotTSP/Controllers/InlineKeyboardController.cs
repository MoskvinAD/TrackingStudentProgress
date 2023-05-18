using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types;
using Telegram.Bot;
using BotTSP.Services;
using Telegram.Bot.Types.ReplyMarkups;

namespace BotTSP.Controllers
{
    class InlineKeyboardController
    {
        private readonly ITelegramBotClient _telegramClient;
        private readonly IStorage _memorystorage;
        public InlineKeyboardController(ITelegramBotClient telegramClient, IStorage memoryStoradge)
        {
            _telegramClient = telegramClient;
            _memorystorage = memoryStoradge;           
        }
        public async Task Handle(CallbackQuery? callbackQuery, CancellationToken ct)
        {
            if (callbackQuery?.Data == null)
                return; 
            // Обновление пользовательской сессии новыми данными
            _memorystorage.GetSession(callbackQuery.From.Id).ChooiceType = callbackQuery.Data;
            // Генерим информационное сообщение
            string ChoiceType = callbackQuery.Data switch
            {
                "Ocen" => "Информация о оценках",
                "Raspisanie" => "Расписание на неделю",
                "Dz" => "Домашние задание на завтра",
                _ => String.Empty
            };
            // Отправляем в ответ уведомление о выборе
            await _telegramClient.SendTextMessageAsync(callbackQuery.From.Id,
                $"<b>Вы выбрали - {ChoiceType}.{Environment.NewLine}</b>" +
                $"{Environment.NewLine}Можно поменять в главном меню.", cancellationToken: ct, parseMode: ParseMode.Html);


            if (ChoiceType == "Информация о оценках") {
                var DBProvider = new DBProvider.DBProvider();
                string htmlJournal =  $"<b>Список оценок за неделю</b>";
                List<string> listStr = DBProvider.GetJournalCostByTelegram(callbackQuery.From.Username);
                if (listStr.Count == 0)
                {
                    htmlJournal += $"{Environment.NewLine}Оценки не найдены";
                }
                foreach (string str in listStr)
                {
                    htmlJournal += $"{Environment.NewLine}{str}";

                }
                await _telegramClient.SendTextMessageAsync(callbackQuery.From.Id,$"{htmlJournal}", parseMode: ParseMode.Html);
                DBProvider.DBProviderClosed();
            }

            if (ChoiceType == "Расписание на неделю")
            {
                var DBProvider = new DBProvider.DBProvider();
                string htmlJournal = $"<b>Расписание на неделю</b>";
                List<string> listStr = DBProvider.GetScheduletByTelegram(callbackQuery.From.Username);
                foreach (string str in listStr)
                {
                    htmlJournal += $"{Environment.NewLine}{str}";

                }
                await _telegramClient.SendTextMessageAsync(callbackQuery.From.Id, $"{htmlJournal}", parseMode: ParseMode.Html);
                DBProvider.DBProviderClosed();
            }

            if (ChoiceType == "Домашние задание на завтра")
            {
                var DBProvider = new DBProvider.DBProvider();
                string htmlJournal = $"<b>Домашние задание на завтра</b>";
                List<string> listStr = DBProvider.GetHomeWorktByTelegram(callbackQuery.From.Username);
                if (listStr.Count == 0) {
                    htmlJournal += $"{Environment.NewLine}Задания не найдены";
                }
                foreach (string str in listStr)
                {
                    htmlJournal += $"{Environment.NewLine}{str}";

                }
                await _telegramClient.SendTextMessageAsync(callbackQuery.From.Id, $"{htmlJournal}", parseMode: ParseMode.Html);
                DBProvider.DBProviderClosed();
            }

            var buttons = new List<InlineKeyboardButton[]>();
            buttons.Add(new[]
            {
                        InlineKeyboardButton.WithCallbackData($"Информация о оценках",$"Ocen"),
                        InlineKeyboardButton.WithCallbackData($"Расписание на неделю",$"Raspisanie"),
                        InlineKeyboardButton.WithCallbackData($"Домашние задание на завтра",$"Dz"),
                    });
            await _telegramClient.SendTextMessageAsync(callbackQuery.From.Id, $"<b>Меню</b> ",
                cancellationToken: ct, parseMode: ParseMode.Html, replyMarkup: new InlineKeyboardMarkup(buttons));

        }
    }
}
