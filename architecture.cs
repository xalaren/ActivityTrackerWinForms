    class AppController
    {
        public Accounts Accounts { get; set; }  //Свойство для управления профилями пользователей
        public bool RegisterRequest(User user);  //Метод запроса на регистрацию. Возврат True, если успешно, иначе False
        public bool LoginRequest(string nickname, string password);  //Метод запроса на вход. Возврат True, если успешно, иначе False
        public void LogoutRequest();  //Метод запроса на выход из профиля
    }

    class Accounts
    {
        public List<User> Users { get; private set; } //Коллекция пользователей
        public User ActiveUser { get; set; } //Свойство, для определения активного пользователя
        public bool Add(User user); //Метод для добавления пользователя в коллекцию
        public void Delete(User user); //Метод для удалеия пользователя из коллекции
    }

    class User
    {
        public string Name { get; private set; }  //Свойство для хранения имени пользователя
        public string LastName { get; private set; }  //Свойство для хранения фамилии пользователя
        public string NickName { get; private set; }  //Свойство для хранения никнейма
        public string Password { get; private set; }  //Свойство для хранения пароля
        public string Height { get; set; }  //Свойство для хранения роста пользователя
        public string Weight { get; set; } //Свойство для хранения веса пользователя
        public string Age { get; set; } //Свойство для хранения возраста пользователя
        public Activities Activities { get; set; }  //Свойство для управления активностями
        public TasksList TasksList { get; set; }  //Свойство для управления списком задач
    }

    class TasksList
    {
        public List<string> ActiveTasks { get; set; }  //Свойство для коллекции активных задач
        public List<string> CompletedTasks { get; set; }  //Свойство для коллекции выполненных задач
        public void AddTask(string taskDescription);  //Добавление задачи
        public void CompleteTask(string taskDescription);  //Выполнение задачи
        public void RemoveActiveTask(string taskDescription);  //Удаление активной задачи
        public void RemoveCompletedTask(string taskDescription);  //Удаление выполненной задачи
    }

    class Activities
    {
        public List<Activity> CompletedActivities { get; private set; }  //Коллекция завершенных активностей
        public Activity CurrentActivity { get; private set; }  //Действующая активность
        public void CompleteActivity(); //Завершить действующую активность
    }

    class Activity
    {
        public uint Steps { get; set; }  //Количество шагов
        public double Distance { get; set; }  //Пройденное расстояние
        public byte SleepTimeHour { get; set; }   //Длительность сна (часы)
        public byte SleepTimeMinute { get; set; } //Длительность сна (минуты)
        public byte StartSleepHour { get; set; }  //Начало времени сна (часы)
        public byte StartSleepMinute { get; set; } //Начало времени сна (минуты)
        public byte EndSleepHour { get; set; } //Конец времени сна (часы)
        public byte EndSleepMinute { get; set; } //Конец времени сна (минуты)
        public uint WaterCounter { get; set; }  //Количество воды
        public List<string> Exercices { get; set; }  //Коллекция для новых упражнений
        public List<string> SavedExercices { get; set; }  //Коллекция выполненных упражнений
        public DateTime Date { get; set; }  //Дата активности
        public void AddWater();  //Увеличение количества воды
        public void RemoveWater();  //Уменьшение количества воды
        public string FixSleepTime();  //Зафиксировать длительность сна по началу и концу времени сна
        public void ConvertToDistance(uint height);  //Перевод шагов в расстояние с учетом роста пользователя
    }
