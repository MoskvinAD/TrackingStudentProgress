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
                "averageCost" => "Средний бал за четверть",
                "InfoCost" => "Оценки за четверть",
                "Period1" => "1",
                "Period2" => "2",
                "Period3" => "3",
                "Period4" => "4",
                "averageCostPeriod1" => "Первая",
                "averageCostPeriod2" => "Вторая",
                "averageCostPeriod3" => "Третья",
                "averageCostPeriod4" => "Четвёртая",
                "average" => "Средний бал",
                _ => String.Empty
            };
            // Отправляем в ответ уведомление о выборе
            await _telegramClient.SendTextMessageAsync(callbackQuery.From.Id,
                $"<b>Вы выбрали - {ChoiceType}.{Environment.NewLine}</b>" +
                $"{Environment.NewLine}Можно поменять в главном меню.", cancellationToken: ct, parseMode: ParseMode.Html);


            if (ChoiceType == "Информация о оценках") {
                var buttonsJournal = new List<InlineKeyboardButton[]>();
                buttonsJournal.Add(new[]
                {
                        InlineKeyboardButton.WithCallbackData($"Оценки за четверть",$"InfoCost"),
                        InlineKeyboardButton.WithCallbackData($"Средний бал за четверть",$"averageCost"),
                        InlineKeyboardButton.WithCallbackData($"Средний бал",$"average"),
                    });
                await _telegramClient.SendTextMessageAsync(callbackQuery.From.Id, $"<b>Четверть</b> ",
                    cancellationToken: ct, parseMode: ParseMode.Html, replyMarkup: new InlineKeyboardMarkup(buttonsJournal));
            }
            if (ChoiceType == "Оценки за четверть")
            {
                var buttonsJournal = new List<InlineKeyboardButton[]>();
                buttonsJournal.Add(new[]
                {
                        InlineKeyboardButton.WithCallbackData($"1",$"Period1"),
                        InlineKeyboardButton.WithCallbackData($"2",$"Period2"),
                        InlineKeyboardButton.WithCallbackData($"3",$"Period3"),
                        InlineKeyboardButton.WithCallbackData($"4",$"Period4")
                    });
                await _telegramClient.SendTextMessageAsync(callbackQuery.From.Id, $"<b>Четверть</b> ",
                    cancellationToken: ct, parseMode: ParseMode.Html, replyMarkup: new InlineKeyboardMarkup(buttonsJournal));
            }

            if (ChoiceType == "Средний бал за четверть")
            {
                var buttonsJournal = new List<InlineKeyboardButton[]>();
                buttonsJournal.Add(new[]
                {
                        InlineKeyboardButton.WithCallbackData($"Первая",$"averageCostPeriod1"),
                        InlineKeyboardButton.WithCallbackData($"Вторая",$"averageCostPeriod2"),
                        InlineKeyboardButton.WithCallbackData($"Третья",$"averageCostPeriod3"),
                        InlineKeyboardButton.WithCallbackData($"Четвёртая",$"averageCostPeriod4")
                    });
                await _telegramClient.SendTextMessageAsync(callbackQuery.From.Id, $"<b>Четверть</b> ",
                    cancellationToken: ct, parseMode: ParseMode.Html, replyMarkup: new InlineKeyboardMarkup(buttonsJournal));
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
            if (ChoiceType == "1")
            {
                var DBProvider = new DBProvider.DBProvider();
                string htmlJournal = $"<b>Первая Четверть</b>";
                List<string> listStr = DBProvider.GetJournalCostByTelegramByQuarter(callbackQuery.From.Username,1);
                if (listStr.Count == 0)
                {
                    htmlJournal += $"{Environment.NewLine}Записей не найдено";
                }
                foreach (string str in listStr)
                {
                    htmlJournal += $"{Environment.NewLine}{str}";

                }
                await _telegramClient.SendTextMessageAsync(callbackQuery.From.Id, $"{htmlJournal}", parseMode: ParseMode.Html);
                DBProvider.DBProviderClosed();
            }

            if (ChoiceType == "2")
            {
                var DBProvider = new DBProvider.DBProvider();
                string htmlJournal = $"<b>Вторая Четверть</b>";
                List<string> listStr = DBProvider.GetJournalCostByTelegramByQuarter(callbackQuery.From.Username, 2);
                if (listStr.Count == 0)
                {
                    htmlJournal += $"{Environment.NewLine}Записей не найдено";
                }
                foreach (string str in listStr)
                {
                    htmlJournal += $"{Environment.NewLine}{str}";

                }
                await _telegramClient.SendTextMessageAsync(callbackQuery.From.Id, $"{htmlJournal}", parseMode: ParseMode.Html);
                DBProvider.DBProviderClosed();
            }

            if (ChoiceType == "3")
            {
                var DBProvider = new DBProvider.DBProvider();
                string htmlJournal = $"<b>Третья Четверть</b>";
                List<string> listStr = DBProvider.GetJournalCostByTelegramByQuarter(callbackQuery.From.Username, 3);
                if (listStr.Count == 0)
                {
                    htmlJournal += $"{Environment.NewLine}Записей не найдено";
                }
                foreach (string str in listStr)
                {
                    htmlJournal += $"{Environment.NewLine}{str}";

                }
                await _telegramClient.SendTextMessageAsync(callbackQuery.From.Id, $"{htmlJournal}", parseMode: ParseMode.Html);
                DBProvider.DBProviderClosed();
            }

            if (ChoiceType == "4")
            {
                var DBProvider = new DBProvider.DBProvider();
                string htmlJournal = $"<b>Четвёртая Четверть</b>";
                List<string> listStr = DBProvider.GetJournalCostByTelegramByQuarter(callbackQuery.From.Username, 4);
                if (listStr.Count == 0)
                {
                    htmlJournal += $"{Environment.NewLine}Записей не найдено";
                }
                foreach (string str in listStr)
                {
                    htmlJournal += $"{Environment.NewLine}{str}";

                }
                await _telegramClient.SendTextMessageAsync(callbackQuery.From.Id, $"{htmlJournal}", parseMode: ParseMode.Html);
                DBProvider.DBProviderClosed();
            }

            if (ChoiceType == "Первая")
            {
                var DBProvider = new DBProvider.DBProvider();
                string htmlJournal = $"<b>Первая четверть</b>";
                List<string> listStr = DBProvider.GetAverageScoreForQuarterByTelegram(callbackQuery.From.Username, 1);
                if (listStr.Count == 0)
                {
                    htmlJournal += $"{Environment.NewLine}Записей не найдено";
                }
                foreach (string str in listStr)
                {
                    htmlJournal += $"{Environment.NewLine}{str}";

                }
                await _telegramClient.SendTextMessageAsync(callbackQuery.From.Id, $"{htmlJournal}", parseMode: ParseMode.Html);
                DBProvider.DBProviderClosed();
            }

            if (ChoiceType == "Вторая")
            {
                var DBProvider = new DBProvider.DBProvider();
                string htmlJournal = $"<b>Вторая четверть</b>";
                List<string> listStr = DBProvider.GetAverageScoreForQuarterByTelegram(callbackQuery.From.Username, 2);
                if (listStr.Count == 0)
                {
                    htmlJournal += $"{Environment.NewLine}Записей не найдено";
                }
                foreach (string str in listStr)
                {
                    htmlJournal += $"{Environment.NewLine}{str}";

                }
                await _telegramClient.SendTextMessageAsync(callbackQuery.From.Id, $"{htmlJournal}", parseMode: ParseMode.Html);
                DBProvider.DBProviderClosed();
            }

            if (ChoiceType == "Третья")
            {
                var DBProvider = new DBProvider.DBProvider();
                string htmlJournal = $"<b>Третья четверть</b>";
                List<string> listStr = DBProvider.GetAverageScoreForQuarterByTelegram(callbackQuery.From.Username, 3);
                if (listStr.Count == 0)
                {
                    htmlJournal += $"{Environment.NewLine}Записей не найдено";
                }
                foreach (string str in listStr)
                {
                    htmlJournal += $"{Environment.NewLine}{str}";

                }
                await _telegramClient.SendTextMessageAsync(callbackQuery.From.Id, $"{htmlJournal}", parseMode: ParseMode.Html);
                DBProvider.DBProviderClosed();
            }

            if (ChoiceType == "Четвёртая")
            {
                var DBProvider = new DBProvider.DBProvider();
                string htmlJournal = $"<b>Четвёртая четверть</b>";
                List<string> listStr = DBProvider.GetAverageScoreForQuarterByTelegram(callbackQuery.From.Username, 4);
                if (listStr.Count == 0)
                {
                    htmlJournal += $"{Environment.NewLine}Записей не найдено";
                }
                foreach (string str in listStr)
                {
                    htmlJournal += $"{Environment.NewLine}{str}";

                }
                await _telegramClient.SendTextMessageAsync(callbackQuery.From.Id, $"{htmlJournal}", parseMode: ParseMode.Html);
                DBProvider.DBProviderClosed();
            }

            if (ChoiceType == "Средний бал")
            {
                var DBProvider = new DBProvider.DBProvider();
                string htmlJournal = $"<b>Средний бал</b>";
                List<string> listStr = DBProvider.GetAverageScoreForByTelegram(callbackQuery.From.Username);
                if (listStr.Count == 0)
                {
                    htmlJournal += $"{Environment.NewLine}Записей не найдено";
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
