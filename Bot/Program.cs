using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Telegram.Bot;

namespace Bot
{
    class Program
    {
        private static string _token = "5798862107:AAEDcdaBsR4HKsTDhLaDVIa4n64qM5HhoNw";
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            // Объект, отвечающий за постоянный жизненный цикл приложения
            var host = new HostBuilder()
                .ConfigureServices((hostContext, services) => ConfigureServices(services)) // Задаем конфигурацию
                .UseConsoleLifetime() // Позволяет поддерживать приложение активным в консоли
                .Build(); // Собираем

            Console.WriteLine("Сервис запущен");
            // Запускаем сервис
            await host.RunAsync();
            Console.WriteLine("Сервис остановлен");
        }

        static void ConfigureServices(IServiceCollection services)
        {
           // services.AddSingleton<LentghTextController>();
           // services.AddSingleton<IStorage, MemoryStorages>();
           // services.AddSingleton<InlineKeyboardController>();
            // Регистрируем объект TelegramBotClient c токеном подключения
            services.AddSingleton<ITelegramBotClient>(provider => new TelegramBotClient(_token));
            // Регистрируем постоянно активный сервис бота
           // services.AddHostedService<Bot>();
        }
    }
}
