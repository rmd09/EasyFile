# О приложении
EasyFile - программа для сортировки файлов по папкам. Это десктопное приложение может помочь избавиться от беспорядка в файловой системе. Доступна сортировка по маске, размеру, дате создания и редактирования.
# Варианты запуска
## 1. Скомпилировать проект в Visual Studio
Чтобы запустить приложение, тебе понадобится [Visual Studio](https://visualstudio.microsoft.com/ru/vs/community/). Просто скачай архив кода, распакуй в любую папку и открой файл решения ```EasyFile.sln```. 
Далее кликните ПКМ по решению проекта и перейдите в свойства, поставьте в качестве запускаемого проекта ```Interface```. Соберите решение (*Сборка >> Собрать решение*). Далее перемести папку [Шаблоны](https://github.com/rmd09/EasyFile/tree/main/Interface/Шаблоны) в папку к exe-файлу, это позволит приложению пользоваться уже готовыми шаблонами. Запусти приложение.
Однако могут возникнуть ошибки:
### MSB3821
```MSB3821: не удалось обработать файл <какой-то файл>, так как он находится в Интернете или ограниченной зоне либо имеет веб-метку```
Скорее всего это будут файлы [EasyFile-main/EasyFile/Interface/Form1.resx](https://github.com/rmd09/EasyFile/blob/main/EasyFile/Interface/Form1.resx) и 
[EasyFile-main/EasyFile/Interface/Форма для выбора пути для сортировки/FormForSort.resx](https://github.com/rmd09/EasyFile/blob/main/EasyFile/Interface/Форма%20для%20выбора%20пути%20для%20сортировки/FormForSort.resx). 
Подробно о том, почему происходит такая ошибка, [тут](https://learn.microsoft.com/ru-ru/visualstudio/msbuild/errors/msb3821). Там же будет инструкция о том, как это исправить. 
Но если кратко, то нужно в проводнике перейти в свойства файла и поставить галочку рядом с пунктом *"Разблокировать"* в самом низу и нажать *"Применить"*.
После этих действий заново откройте файл решения и повторите действия с самого начала.
## 2. Установить архив с файлом исполняемой программы (.exe) на [сайте](https://bright-gecko-3d62f8.netlify.app/)
Здесь придётся запустить exe-файл принудительно. 
