using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bot.Models;

namespace Bot.Services {
    interface IStorage {
        Session GetSession (long chatId);
    }
}
