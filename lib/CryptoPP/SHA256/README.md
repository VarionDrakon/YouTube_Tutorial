RU:
Как использовать этот пример?

* Несколько факторов необходимо для запуска этого кода, первая это IDE или же компилятор [`Clang`](https://clang.llvm.org/get_started.html), как в случае описаном здесь, необходима для начала установленный компилятор и дебагер по совместительству [`LLDB`](https://lldb.llvm.org/resources/build.html) и версия `C++17`, можно выше, можно ниже, а так же `Visual Studio` и его компилятор для компиляции проекта `CryptoPP`.
* Внутри архива `YouTube.VSCode.CryptoPP.MinUseExmp.zip` уже присутсвуют файлы `launch.json` и `tasks.json` для запуска кода в среде `VSCode`. 
* Этот код запускается на `Windows 11` и компиляторе `Clang версии 17.0.6`, на других системах не тестировалось. 
* Следующим фактором ялвяется необходимость скомпилированной целой библиотеки `cryptlib.lib` в `Visual Studio`, но так как не у всех есть желание компилировать, то в архиве так же будет уже готовая версия билиотеки в состоянии `Release`. 
* Дополнительно если Вы используете `VSCode` и некоторые плагины для работы с `Clang` и `C++`, то из-за плагинов будет возможно происходить ошибка `"Unsupported configuration"`, для исправления необходимо поправить в файле `config_os.h` строку `33` с `Error` на `Warning`. Внутри архива так же есть этот поправленный файл, но он для версии `CryptoPP 8.9.0`.
* Ещё помима архива будет папка с таким же названием архива для просмотра кода.

ВНИМАНИЕ, ЭТОТ КОД ВСЕГО-ЛИШЬ ПРОСТОЙ ПРИМЕР ПРИМЕНЕНИЯ БИБЛИОТЕКИ И ВЫЧИСЛЕНИЯ ХЭШ-СУММЫ SHA256.
<hr>
EN:
How to use this example?

* Several factors are necessary to run this code, the first is the IDE or the compiler [`Clang`](https://clang.llvm.org/get_started.html ), as in the case described here, it is necessary to start with an installed compiler and a part-time debugger [`LLDB`](https://lldb.llvm.org/resources/build.html ) and the `C++17` version, as high as possible, as low as possible, as well as `Visual Studio` and its compiler for compiling the `CryptoPP` project.
* Inside the `YouTube.VSCode.CryptoPP.MinUseExmp.zip` files `launch.json` and `tasks.json` are already present to run the code in the `VSCode` environment. 
* This code runs on `Windows 11` and the `Clang compiler version 17.0.6`, it has not been tested on other systems. 
* The next factor is the need to compile the entire library `cryptlib.lib` in `Visual Studio`, but since not everyone has the desire to compile, there will also be a ready-made version of the library in the `Release` state in the archive. 
* Additionally, if you use `VSCode` and some plugins to work with `Clang` and `C++`, then the `Unsupported configuration` error may occur due to the plugins, and you need to correct it in the `config_os` file line `33` from `Error` to `Warning`. There is also this corrected file inside the archive, but it is for the `CryptoPP 8.9.0` version.
* There will also be a folder with the same archive name for viewing the code.

ATTENTION, THIS CODE IS JUST A SIMPLE EXAMPLE OF USING THE LIBRARY AND CALCULATING THE SHA256 HASH SUM.
