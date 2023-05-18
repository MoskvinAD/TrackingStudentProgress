using BotTSP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace BotTSP.Controllers
{
    class LentghTextController
    {
        private readonly ITelegramBotClient _telegramClient;
        private readonly IStorage _memoryStorage;
        // private OrderRep
        public LentghTextController(ITelegramBotClient telegramBotClient, IStorage storage)
        {
            _telegramClient = telegramBotClient;
            _memoryStorage = storage;
        }

        public async Task Handle(Message message, CancellationToken ct)
        {
            switch (message.Text)
            {
                case "/start":
                    var buttons = new List<InlineKeyboardButton[]>();
                    buttons.Add(new[]
                    {
                        InlineKeyboardButton.WithCallbackData($"Информация о оценке",$"CS"),
                        InlineKeyboardButton.WithCallbackData($"Отменить заказ",$"SN")
                    });
                    await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"<b> Бот умеет выводить информацию по заказу и отменять заказ</b> ", cancellationToken: ct, parseMode: ParseMode.Html, replyMarkup: new InlineKeyboardMarkup(buttons));
                    break;
                default:
                    string userChoocuType = _memoryStorage.GetSession(message.Chat.Id).ChooiceType;
                    int a = 0;
                    if (userChoocuType == "CS")
                    {
                        
                        await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"Заказ на сумму {message.Text} {message.Chat.Username}", cancellationToken: ct);
                        //message.Text = "/start";
                        //await Handle(message, ct); повторно вызывает кнопки

                    }
                    else
                    {
                        //await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"Заказ {message.Text} отменен", cancellationToken: ct);
                        //message.Text = "/start";
                        //await Handle(message, ct);
                    }


                    break;
            }
        }
    }
}
