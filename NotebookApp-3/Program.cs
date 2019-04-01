using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookApp_3
{
    class Note
    {
        public string name;
        public string surname;
        public string patronymic;
        public string phoneNumber;
        public string country;
        public string dateOfBirth;
        public string company;
        public string position;
        public string notes;
    }
    class Notebook
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Добрый день!\nЭто программа записаня книжка, созданная в учебных целях для записи данных!!!\n Нажмите любую кнопку...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Хотите начать ???\n 'Y' or 'N' ");
                string s = Console.ReadLine();

                if (s.Equals("y") || s.Equals("Y"))
                {

                }
                else if (s.Equals("n") || s.Equals("N"))
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Неверный ответ, попробуй еще...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;

                }
                Console.Clear();


                Console.WriteLine("**********************************\nСоздать новую запись ----- n\nРедактирование ----- r\nУдаление ----- d\nПросмотр ранее существующих записей ----- w\nПосмотреть все ----- o  ");
                notebook.Menu(Console.ReadLine());

            }

        }

        public void Menu(string i)
        {
            switch (i)
            {
                case "n":
                    CreateNewNote();
                    break;
                case "r":
                    Console.WriteLine("Введите номер страницы кторую хотите редактировать");
                    int x = Convert.ToInt32(Console.ReadLine());
                    x = x - 1;
                    if (x >= 0 && x < notesList.Count)
                    {

                        EditNote(x);
                    }
                    break;
                case "d":
                    Console.WriteLine("Введите номер страницы кторую хотите удалить");
                    int b = Convert.ToInt32(Console.ReadLine());
                    b = b - 1;
                    if (b >= 0 && b < notesList.Count)
                    {
                        DeleteNote(b);
                    }
                    break;
                case "w":
                    Console.WriteLine("Введите номер страницы кторую хотите посмотреть");
                    int a = Convert.ToInt32(Console.ReadLine());
                    a = a - 1;
                    if (a >= 0 && a < notesList.Count)
                    {
                        ReadNote(a);
                    }
                    else
                    {
                        Console.WriteLine("нет такой страницы");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("**********************************\nСоздать новую запись ----- n\nРедактирование ----- r\nУдаление ----- d\nПросмотр ранее существующих записей ----- w\nПосмотреть все ----- o  ");
                        Menu(Console.ReadLine());
                    }
                    break;
                case "o":
                    Console.WriteLine("Все страницы ");
                    ShowAllNotes();
                    break;
                default:
                    Console.WriteLine("Неверный символ...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("**********************************\nСоздать новую запись ----- n\nРедактирование ----- r\nУдаление ----- d\nПросмотр ранее существующих записей ----- w\nПосмотреть все ----- o  ");
                    Menu(Console.ReadLine());
                    break;
            }
        }

        static List<Note> notesList = new List<Note>();


        public void CreateNewNote()
        {

            Console.Clear();

            for (int i = 0; i < 100; i++)
            {
                Note note = new Note() { };
                notesList.Add(note);
                Console.WriteLine("Введите имя:");
                note.name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Введите фамилию:");
                note.surname = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Введите отчество:");
                note.patronymic = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Введите номер телефона:");
                note.phoneNumber = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Введите страну:");
                note.country = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Введите дату рождения:");
                note.dateOfBirth = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Введите компанию:");
                note.company = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Введите должность:");
                note.position = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Введите заметки:");
                note.notes = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("**********************************\nСоздать новую запись ----- n\nРедактирование ----- r\nУдаление ----- d\nПросмотр ранее существующих записей ----- w\nПосмотреть все ----- o  ");

                Menu(Console.ReadLine());

            }

        }

        public void EditNote(int x)
        {
            Console.WriteLine("Запись редактируется");

            Console.WriteLine("Введите имя:");
            notesList[x].name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите фамилию:");
            notesList[x].surname = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите отчество:");
            notesList[x].patronymic = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите номер телефона:");
            notesList[x].phoneNumber = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите страну:");
            notesList[x].country = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите дату рождения:");
            notesList[x].dateOfBirth = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите компанию:");
            notesList[x].company = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите должность:");
            notesList[x].position = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите заметки:");
            notesList[x].notes = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("**********************************\nСоздать новую запись ----- n\nРедактирование ----- r\nУдаление ----- d\nПросмотр ранее существующих записей ----- w\nПосмотреть все ----- o  ");

            Menu(Console.ReadLine());
        }

        public void DeleteNote(int b)
        {
            Console.WriteLine("Запись удаляется");
            notesList.RemoveAt(b);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("**********************************\nСоздать новую запись ----- n\nРедактирование ----- r\nУдаление ----- d\nПросмотр ранее существующих записей ----- w\nПосмотреть все ----- o  ");

            Menu(Console.ReadLine());
        }

        public void ReadNote(int a)
        {
            Console.WriteLine("Запись читается");
            Console.WriteLine("Страница №" + (a + 1));

            Console.WriteLine(notesList[a].name);
            Console.WriteLine(notesList[a].surname);
            Console.WriteLine(notesList[a].patronymic);
            Console.WriteLine(notesList[a].phoneNumber);
            Console.WriteLine(notesList[a].country);
            Console.WriteLine(notesList[a].dateOfBirth);
            Console.WriteLine(notesList[a].company);
            Console.WriteLine(notesList[a].position);
            Console.WriteLine(notesList[a].notes);

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("**********************************\nСоздать новую запись ----- n\nРедактирование ----- r\nУдаление ----- d\nПросмотр ранее существующих записей ----- w\nПосмотреть все ----- o  ");

            Menu(Console.ReadLine());

        }

        public void ShowAllNotes()
        {
            Console.WriteLine("Чтение всех записей");

            for (int i = 0; i < notesList.Count; i++)
            {
                Console.WriteLine(notesList[i].name);
                Console.WriteLine(notesList[i].surname);
                Console.WriteLine(notesList[i].patronymic);
                Console.WriteLine(notesList[i].phoneNumber);
                Console.WriteLine(notesList[i].country);
                Console.WriteLine(notesList[i].dateOfBirth);
                Console.WriteLine(notesList[i].company);
                Console.WriteLine(notesList[i].position);
                Console.WriteLine(notesList[i].notes);

            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("**********************************\nСоздать новую запись ----- n\nРедактирование ----- r\nУдаление ----- d\nПросмотр ранее существующих записей ----- w\nПосмотреть все ----- o  ");
            Menu(Console.ReadLine());
        }
    }
}

