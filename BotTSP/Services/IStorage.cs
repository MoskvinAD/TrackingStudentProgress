using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BotTSP.Models;

namespace BotTSP.Services {
    interface IStorage {
        Session GetSession (long chatId);
    }
}
