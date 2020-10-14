using System;

namespace SOLID01SingleResponsibilityPrinciple
{

  public class DatabaseTasks
  {
    public void save(Task task)
    {
      Console.WriteLine($"Saved on {task.getTitle()}");
    }
  }

  public class Database
  {
    public DatabaseTasks tasks = new DatabaseTasks();

    public Database() { }

    public Database connect(string cnn)
    {
      Console.WriteLine($"Database connect @ {cnn}");
      return this;
    }
  }

  public class Task
  {
    private string _title;
    private DateTime _deadline;

    public Task(string title, DateTime deadline)
    {
      this._title = title;
      this._deadline = deadline;
    }

    public string getTitle()
    {
      return $"{this._title} ({this._deadline})";
    }
  }

  public class TaskRepository
  {
    private Database _db;

    public TaskRepository()
    {
      this._db = new Database().connect("admin:password@fakedb");
    }

    public void save(Task task)
    {
      this._db.tasks.save(task);
    }

  }

  class Program
  {
    static void Main(string[] args)
    {
      TaskRepository taskRepo = new TaskRepository();

      Task task = new Task("Title X2", new DateTime());
      taskRepo.save(task);
    }
  }
}
