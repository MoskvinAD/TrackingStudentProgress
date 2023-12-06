using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types;
using Telegram.Bot;
using Bot.Services;

namespace Bot.Controllers
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
                "CS" => " Инфоормация о заказе",
                "SN" => " Отменить заказ",
                _ => String.Empty
            };

            // Отправляем в ответ уведомление о выборе
            await _telegramClient.SendTextMessageAsync(callbackQuery.From.Id,
                $"<b>Вы выбрали - {ChoiceType}.{Environment.NewLine}</b>" +
                $"{Environment.NewLine}Можно поменять в главном меню.", cancellationToken: ct, parseMode: ParseMode.Html);

        }
    }
}
