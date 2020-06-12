using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace VenadosTest.Helper
{
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get { return CrossSettings.Current; }
        }

        public static string Jugadores
        {
            get => AppSettings.GetValueOrDefault(nameof(Jugadores), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Jugadores), value);
        }

        public static string Juegos
        {
            get => AppSettings.GetValueOrDefault(nameof(Juegos), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Juegos), value);
        }

        public static string Patrocinadores
        {
            get => AppSettings.GetValueOrDefault(nameof(Patrocinadores), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Patrocinadores), value);
        }

        public static string Estadisticas
        {
            get => AppSettings.GetValueOrDefault(nameof(Estadisticas), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Estadisticas), value);
        }

        public static string Notificaciones
        {
            get => AppSettings.GetValueOrDefault(nameof(Notificaciones), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(Notificaciones), value);
        }

    }
}
