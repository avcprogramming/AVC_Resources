# AVC_Resources
This project contains strings and icons for the AVC plugins for AutoCAD and BricsCAD. The project must be compiled for .Net Framework 4.8 (although it will also be used under AutoCAD 2025 with Net 8.0). The finished library should be placed in the folder with the main plugin libraries: C:\Users\<user>\AppData\Roaming\Autodesk\ApplicationPlugins\AVC_<plugin>.bundle\Contents\Windows

The strings are not contained in resources, but in C# code. This makes it more convenient for me to translate into several languages at once. Strings are grouped by purpose into C# arrays. Each array contains as many lines as the number of languages used in the plugins. If you add your own language, you need to add a new line to all absolutely arrays. The program knows the language index in the arrays. Index 0 is always English, index 1 is Russian, and so on. If the program does not find lines with the required index, if the array is too short, or if some line is empty, then the line with index 0 will be output, that is, English will be used. Therefore, you can not translate all arrays and files at once, but do this work gradually. But you cannot add another language until the translation into the previous one is completed, since you may not notice that the array is too short and enter the translation into the wrong index or into the wrong language.

When translating, you must take into account the translation of AutoCAD into the same language. Your translation must exactly match the names of the drawing objects, the names of typical layers (Model Documentation layers), and the names of standard line types.

Translation of command line options must take into account that options cannot contain any characters other than letters and numbers. Capital letters specify the input key and must be unique and not match the hidden selection options for a given AutoCAD localization (otherwise they simply cannot be selected; AutoCAD will prefer the built-in options).

Some lines have wildcard characters {0}, {1}, {2}, and so on. All translations must contain all these substitutions, otherwise it will be fatal.

Icons are stored as resources in PNG files. You cannot rename icons - this will lead to fatal crashes. But you can replace them with others with the same name and the same size. Please note that the library code contains only icons and pictures for dialog forms. Menu and ribbon icons are stored not in a DLL library, but in a CUIX file. You can open the CUIX file as a ZIP archive and replace the png files there. No recompilations are required there.

# Important note. 
Do not attempt to run CAD and AVC plugins while Visual Studio or other debuggers are running. Conflicts are possible up to AutoCAD fatalities. Block AVC plugins from loading when you are debugging your plugins.

----------------------------------------------------------------------------
# RU
В данном проекте содержатся строки и иконки для плагинов AVC для AutoCAD и BricsCAD. Проект должен быть скомпилирован для .Net Framework 4.8 (хотя будет использоваться и под AutoCAD 2025 с Net 8.0). Готовую библиотеку следует поместить в папку с основными библиотеками плагина: C:\Users\<user>\AppData\Roaming\Autodesk\ApplicationPlugins\AVC_<plugin>.bundle\Contents\Windows

Строки содержатся не в ресурсах, а в коде на C#. Мне так удобнее делать перевод на несколько языков сразу. Строки сгруппированы по назначению в массивы C#. В каждом массиве столько строк, сколько языков используется в плагинах. Если вы добавляете свой язык вам надо во все абсолютно массивы добавить новую строку. Программа знает индекс языка в массивах. Индекс 0 – это всегда английский, индекс 1 – русский, и так далее. Если программа не найдет строки с нужным индексом, если массив окажется слишком коротким, или если какая-то строка окажется пустой, то будет выведена строка с индексом 0, то есть будет использован английский язык. Поэтому вы можете переводить не все массивы и файлы сразу, а делать эту работу постепенно. Но нельзя добавлять еще один язык, пока не закончен перевод на предыдущий, так как вы можете не заметить, что массив слишком короткий и ввести перевод не на тот индекс, не на тот язык.

При переводе требуется учитывать перевод AutoCAD на этот же язык. В вашем переводе должны точно соответствовать названия объектов чертежа, названия типовых слоев (слоев Model Documentation), названия стандартных типов линий.

Перевод опций командной строки должен учитывать, что в опциях не может быть никаких знаков кроме букв и цифр. Заглавные буквы задают ключ ввода и должны быть уникальны и не совпадать со скрытыми опциями выбора для данной локализации AutoCAD (иначе их просто невозможно выбрать, Автокад предпочтет сои встроенные опции).

В некоторых строках есть символы подстановки данных {0}, {1}, {2} и так далее. Во всех переводах обязательно должны присутствовать все эти подстановки, иначе – фатал. 

Иконки хранятся в ресурсах в файлах PNG. Нельзя переименовывать иконки – это приведет к фатальным сбоям. Но можно заменять на другие, с тем же именем и того же размера. Учтите, что в коде библиотеки присутствуют только иконки и картинки для форм диалога. Иконки меню и ленточных панелей хранятся не в DLL-библиотеке, а в CUIX-файле. CUIX файл вы можете открыть как ZIP-архив и заменить там png-файлы. Никаких перекомпиляций там не требуется.

# Важное примечание. 
Не пытайтесь запускать CAD и плагины AVC когда работает Visual Studio или другие отладчики. Возможну конфликты вплоть до фаталов AutoCAD. Заблокируйте загрузку плагинов AVC, когда отлаживаете свои плагины.
