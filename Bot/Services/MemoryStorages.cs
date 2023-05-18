using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bot.Models;
using Bot.Services;

namespace Bot.Services {
    internal class MemoryStorages : IStorage {
        /// <summary>
        /// Хранилище сессий
        /// </summary>
        private readonly ConcurrentDictionary<long, Session> _sessions;
        public MemoryStorages () {
            _sessions = new ConcurrentDictionary<long, Session>();
        }
        public Session GetSession (long chatId) {
            if(_sessions.ContainsKey(chatId)) {
                return _sessions[chatId];
            }
            var newSession = new Session() { ChooiceType = "SN" };
            _sessions.TryAdd(chatId, newSession);
            return newSession;

        }
    }
}
