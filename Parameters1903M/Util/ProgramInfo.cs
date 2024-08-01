﻿using Parameters1903M.Model;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Parameters1903M.Util
{
    internal class ProgramInfo
    {
        /// <summary>
        /// Список, содержащий все версии и изменения в них
        /// Добавление новой версии в нулевой элемент списка
        /// </summary>
        public static List<VersionInfo> AllVersionsInfo => new List<VersionInfo>()
        {
            // TODO: сверху добавляем информацию о новой версии программы
            //new VersionInfo()
            //{
            //    Version = $"v.{Assembly.GetEntryAssembly().GetName().Version.Major}.{Assembly.GetEntryAssembly().GetName().Version.Minor}",
            //    CompiledDate = new DateTime(2023, 4, 26),
            //    ChangesVisibleForDeveloper = "+ Реализован запуск только одной копии приложения." + Environment.NewLine,
            //    Changes = "+ Добавлен пункт меню \"Промежуточные значения\" для предварительного просмотра и печати протокола с промежуточными значениями " +
            //            "всех измеренных параметров." + Environment.NewLine +
            //        "+ В окне начала и продолжения испытаний добавлена кнопка \"Настройки\"." + Environment.NewLine +
            //        "* Оптимизирована расшифровка и экспорт файлов. Экспорт файлов стал доступен в демонстрационном режиме." + Environment.NewLine +
            //        "* Изменена формулировка текста заключения в файле протокола." + Environment.NewLine
            //},
            //new VersionInfo()
            //{
            //    Version = $"v.1.2",
            //    CompiledDate = new DateTime(2023, 2, 21),
            //    ChangesVisibleForDeveloper = "+ При запуске проверки для каждого параметра внедрена проверка на существования файла данных измерений. " +
            //            "Если в таблице параметров есть значение параметра, но файл с исходными данными отсутствует, то произойдет очистка значений для параметра в таблице " +
            //            "с последующим сохранением протокола." + Environment.NewLine +
            //        "+ При попытке открыть файл проверки, созданный программой \"Parameters1940\", " +
            //            "предлагается для открытия данной проверки воспользоваться другой программой." + Environment.NewLine,
            //    Changes = "- Удалена поддержка прибора ЦЕ1945." + Environment.NewLine +
            //        "+ Добавлены новые поддерживаемые типы приборов ЦЕ1940-1 и ЦЕ1940-1М." + Environment.NewLine +
            //        "+ Добавлена возможность работы с мультиметром АКИП-2101/2." + Environment.NewLine +
            //        "+ Для проверок параметра \"Температурный коэффициент\" добавлено дополнительное сообщение, в котором спрашивается " +
            //            "был ли проведен предварительный прогрев прибора с выключенной программой." + Environment.NewLine +
            //        "+ Для проверок параметра \"Температурный коэффициент\" введена проверка на полярность выходного напряжения сигнала." + Environment.NewLine +
            //        "+ В пункт меню \"Протокол\" добавлен пункт меню \"Настройки протокола\", который позволяет в отдельном окне гибко настроить отображаемые данные в протоколе " +
            //            "для просмотра и печати" + Environment.NewLine +
            //        "+ В протокол добавлена новая строка назначение. В строке заключение указывается соответствует прибор нормам или нет." + Environment.NewLine +
            //        "+ В окне параметров программы добавлена настройка адреса для мультиметра АКИП-2101/2." + Environment.NewLine +
            //        "+ В окне параметров программы добавлена настройка для сохранения результатов измерений на удаленный сервер. (При включении этой настройки будет создаваться " +
            //            "копия файлов измерений. При продолжении измерений загрузка будет происходить с локального компьютера.)" + Environment.NewLine +
            //        "* Для каждого типа приборов добавлены полные номера документов ТУ и И14, отображаемые в протоколе." + Environment.NewLine +
            //        "* При начале испытаний в поле \"Проверка после\" доступен ввод данных." + Environment.NewLine +
            //        "* Оптимизирован алгоритм сохранения и чтения данных измерений и протокола." + Environment.NewLine +
            //        "* Оптимизирован алгоритм подключения к мультиметру." + Environment.NewLine +
            //        "* Исправлено отображение в шапке протокола для полей \"Номер запуска\" и \"Начало испытаний\"." + Environment.NewLine
            //},
            //new VersionInfo()
            //{
            //    Version = "v.1.1",
            //    CompiledDate = new DateTime(2021, 3, 18),
            //    Changes = "+ В главное меню добавлен пункт меню \"Файл\", в которое добавлен пункт меню \"Открыть\" для просмотра зашифрованных файлов." + Environment.NewLine +
            //        "+ В пункт меню \"Файл\" добавлен пункт меню \"Открыть\", который позволяет расшифровать файл и открыть его содержимое в новом окне " +
            //            "для удобного просмотра исходных данных." + Environment.NewLine +
            //        "+ В пункт меню \"Файл\" добавлен пункт меню \"Экспорт папки\", который позволяет расшифровать все файлы в папке по текущему измерению " +
            //            "и сохранить их в выбранную папку." + Environment.NewLine +
            //        "+ В пункт меню \"Протокол\" добавлен пункт меню \"Сохранить в PDF\"." + Environment.NewLine +
            //        "+ В пункт меню \"Изменить\" добавлен пункт меню \"Настройки\", в котором во вкладке \"Общие\" можно изменить режим обмена данными с мультиметром " +
            //            "и адрес мультиметра (от 0 до 30)." + Environment.NewLine +
            //        "+ В пункт меню \"Изменить\" добавлен пункт меню \"Комплектность\"." + Environment.NewLine +
            //        "+ Добавлена возможность печати протокола из первого окна программы." + Environment.NewLine +
            //        "+ Добавлена возможность измерения параметров прибора ЦЕ1940-3." + Environment.NewLine +
            //        "* Переработан алгоритм сохранения данных." + Environment.NewLine +
            //        "* Переработан алгоритм шифрования данных." + Environment.NewLine +
            //        "* Переработаны алгоритмы подключения и обмена данными с мультиметром."
            //},
            new VersionInfo()
            {
                Version = $"v.{Assembly.GetEntryAssembly().GetName().Version.Major}.{Assembly.GetEntryAssembly().GetName().Version.Minor}",
                CompiledDate = new DateTime(2024, 8, 1),
                Changes = "Начальная версия программы."
            }
        };

        public static string SoftwareName => "Parameters1903M";

        public static string Version => AllVersionsInfo[0].Version;

        public static string SoftwareNameWithVersion => $"{SoftwareName} {Version}";

        public static string SoftwareNameWithVersionAndDate => $"{SoftwareNameWithVersion} ({CompileDate:dd.MM.yyyy})";

        public static DateTime CompileDate => AllVersionsInfo[0].CompiledDate;

        public static string SoftwareDeveloper => "АО \"НПЦАП\" Отдел 041";
    }
}
