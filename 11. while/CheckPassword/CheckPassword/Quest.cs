using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CheckPassword {
	class Quest {
		public Quest() {
			ShowBriefFrame();
		}

		void ShowBriefFrame() {
			ShowHeader("Ты - супергерой. Твоя задача - вызволить принцессу из плена Всемирной Сети, куда она попала, по неосторожности ткнув в рекламный баннер. Выбери действие:");

			Console.WriteLine();
			ShowOption("1. Поиграть в Доту");
			ShowOption("2. Узнать на каком сайте она застряла");
			int answer = int.Parse(Console.ReadLine());
			Console.WriteLine();
			if (answer == 1) {
				ShowGameover("Ты просидел в Доте до утра, и принцессу спас другой хакер");
			}
			else if (answer == 2) {
				ShowDetailsFrame();
			}
			else {
				WriteAlert();
			}
		}

		void ShowDetailsFrame() {
			ShowHeader("Оказывается, принцессе пришло письмо с рекламой суперстойкой помады, и там был баннер со ссылкой на сайт dontclickme.noob.");

			Console.WriteLine();
			ShowOption("1. Послушаться совета в адресе сайта и поиграть в Доту");
			ShowOption("2. Перейти на сайт");
			ShowOption("3. Обновить антивирус, а потом перейти на сайт");
			int answer = int.Parse(Console.ReadLine());
			Console.WriteLine();
			if (answer == 1) {
				ShowGameover("Проигрыш - другой хакер спас принцессу");
			}
			else if (answer == 2) {
				ShowGameover("Проигрыш - игрок заразился тем же вирусом, что и принцесса, застрял на том же сайте со сломанным компьютером");
			}
			else if (answer == 3) {
				ShowMonsterFrame();
			}
			else {
				WriteAlert();
			}
		}

		void ShowMonsterFrame() {
			ShowHeader("Игрок встречает противника - Капча-Монстра, который не дает обновить антивирус. Чтобы его победить, нужно решить задачку: сколько будет 2 + 2 * 2?");

			Console.WriteLine();
			ShowOption("1. А, ну ее, математика для нубов! Пойду в Доту поиграю!");
			ShowOption("2. Проверить исходный код Капча-Монстра");
			ShowOption("3. Ответить монстру: 6");
			int answer = int.Parse(Console.ReadLine());
			Console.WriteLine();
			if (answer == 1) {
				ShowGameover("Проигрыш - другой хакер спас принцессу");
			}
			else if (answer == 2) {
				ShowSecretRevealedFrame();
			}
			else if (answer == 3) {
				ShowGameover("Проигрыш - было бы слишком легко выиграть! На самом деле там невидимые скобки - это и есть супер-способность Капча-Монстра! Задание выглядит как (2 + 2) * 2");
			}
			else {
				WriteAlert();
			}
		}

		void ShowSecretRevealedFrame() {
			ShowHeader("Игрок вскрывает код Капча-Монстра и видит, что тот печатает черным цветом некоторые символы. Ух ты! Их не видно на черном фоне!");

			Console.WriteLine();
			ShowOption("1. Круто, пойду попробую так в своей программе!");
			ShowOption("2. Ответить монстру: 6");
			ShowOption("3. Заменить цвет всех черных символов на белый и перезагрузить Капчу-Монстра");
			int answer = int.Parse(Console.ReadLine());
			Console.WriteLine();
			if (answer == 1) {
				ShowGameover("Проигрыш - принцесса заблудилась во Всемирной Сети, пока герой ковырялся не там, где надо");
			}
			else if (answer == 2) {
				ShowGameover("Проигрыш - зря, что ли, подвох находил??");
			}
			else if (answer == 3) {
				ShowRiddleFrame();
			}
			else {
				WriteAlert();
			}
		}

		void ShowRiddleFrame() {
			ShowHeader("Капча-Монстра хрипит консольными командами, догружается, наконец, до конца и выдает: сколько будет (2 + 2) * 2?");

			Console.WriteLine();
			ShowOption("1. Ответить монстру: 8");
			ShowOption("2. Герою лень считать, и он идет в Доту");
			int answer = int.Parse(Console.ReadLine());
			Console.WriteLine();
			if (answer == 1) {
				ShowAntivirusFrame();
			}
			else if (answer == 2) {
				ShowGameover("Проигрыш - другой хакер спас принцессу");
			}
			else {
				WriteAlert();
			}
		}

		void ShowAntivirusFrame() {
			ShowHeader("Капча-Монстр обиженно сопит \"Как ты догадался? Я же спрятал скобки!\", отступает и позволяет обновить антивирус. Теперь герой защищен, и может перейти на сайт! Едва он делает это, как получает сообщение антивируса: Замечена и заблокирована вредоносная программа: WinLock 1.0. Файл-лекарство можно найти здесь: C:Antiviruscure.exe.");

			Console.WriteLine();
			ShowOption("1.Отправить лекарство принцессе по почте и пойти в Доту");
			ShowOption("2.Записать лекарство на флешку и пойти к принцессе домой");
			int answer = int.Parse(Console.ReadLine());
			Console.WriteLine();
			if (answer == 1) {
				ShowGameover("Проигрыш - у нее сломался компьютер, она не может получить твой файл! Принцессу спасает другой хакер");
			}
			else if (answer == 2) {
				ShowHeader("Победа!!!");

				Console.WriteLine();
				Restart();
			}
			else {
				WriteAlert();
			}
		}

		void WriteAlert() {
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.WriteLine("Введен неподдерживаемый вариант! Конец игры");

			Console.WriteLine();
			Restart();
		}

		void ShowHeader(string header) {
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine(header);
			Console.ForegroundColor = ConsoleColor.Gray;
		}

		void ShowOption(string option) {
			Thread.Sleep(500);
			Console.WriteLine(option);
		}

		void ShowGameover(string text) {
			Console.Write("Конец игры! ");
			Console.WriteLine(text);

			Console.WriteLine();
			Restart();
		}

		void Restart() {
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Хотите начать заново?");
			string answer = Console.ReadLine().ToLower();

			if (answer == "да") {
				Console.Clear();
				ShowBriefFrame();
			}
			else if (answer == "нет") {
				Console.WriteLine();
				Console.WriteLine("Пока!");
				Console.ReadLine();
				Environment.Exit(0);
			}
			else {
				Console.WriteLine();
				Console.WriteLine("Ответ нераспознан. Возможно, вы хотели начать заново");
				Console.ReadLine();
				Console.Clear();
				ShowBriefFrame();
			}
		}
	}
}
