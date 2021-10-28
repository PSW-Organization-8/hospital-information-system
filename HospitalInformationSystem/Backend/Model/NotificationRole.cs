using System;
using System.Collections.Generic;
using System.Text;

namespace SIMS.Model
{
    class NotificationRole
    {
        public string Role { get; set; }
        public int Index { get; set; }
        public string Key { get; set; }

        public NotificationRole(string uloga, int indeks)
        {
            Role = uloga;
            Index = indeks;
        }

        public NotificationRole(string uloga, int indeks, string key)
        {
            Role = uloga;
            Index = indeks;
            Key = key;
        }
    }
}
