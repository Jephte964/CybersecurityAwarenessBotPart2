
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CybersecurityAwarenessBot.GUI
{
    public partial class TaskListWindow : Window
    {
        public class SecurityTask : INotifyPropertyChanged
        {
            private bool isCompleted;

            public string Description { get; set; }

            public bool IsCompleted
            {
                get { return isCompleted; }
                set
                {
                    if (isCompleted != value)
                    {
                        isCompleted = value;

                        PropertyChanged?.Invoke(
                            this,
                            new PropertyChangedEventArgs(nameof(IsCompleted)));
                    }
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;
        }

        private readonly ObservableCollection<SecurityTask> tasks =
            new ObservableCollection<SecurityTask>();

        public TaskListWindow()
        {
            InitializeComponent();

            TaskList.ItemsSource = tasks;

            // Add some example tasks.
            tasks.Add(new SecurityTask
            {
                Description = "Create a strong, unique password",
                IsCompleted = false
            });

            tasks.Add(new SecurityTask
            {
                Description = "Enable two-factor authentication",
                IsCompleted = false
            });

            tasks.Add(new SecurityTask
            {
                Description = "Review social media privacy settings",
                IsCompleted = false
            });

            tasks.Add(new SecurityTask
            {
                Description = "Check for software and security updates",
                IsCompleted = false
            });

            tasks.Add(new SecurityTask
            {
                Description = "Learn how to recognise phishing emails",
                IsCompleted = false
            });

            UpdateProgress();
        }

        private void AddTaskButton_Click(object sender, RoutedEventArgs e)
        {
            string description = TaskInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show(
                    "Please enter a task before clicking Add Task.",
                    "Task Required",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                TaskInput.Focus();
                return;
            }

            if (description.Length > 150)
            {
                MessageBox.Show(
                    "Please keep your task to 150 characters or fewer.",
                    "Task Too Long",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);

                return;
            }

            tasks.Add(new SecurityTask
            {
                Description = description,
                IsCompleted = false
            });

            TaskInput.Clear();
            TaskInput.Focus();

            UpdateProgress();
        }

        private void TaskCheckBox_Changed(object sender, RoutedEventArgs e)
        {
            UpdateProgress();
        }

        private void RemoveTaskButton_Click(object sender, RoutedEventArgs e)
        {
            SecurityTask selectedTask = TaskList.SelectedItem as SecurityTask;

            if (selectedTask == null)
            {
                MessageBox.Show(
                    "Please select a task to remove.",
                    "No Task Selected",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                return;
            }

            tasks.Remove(selectedTask);
            UpdateProgress();
        }

        private void ClearCompletedButton_Click(object sender, RoutedEventArgs e)
        {
            var completedTasks = tasks
                .Where(task => task.IsCompleted)
                .ToList();

            if (completedTasks.Count == 0)
            {
                MessageBox.Show(
                    "There are no completed tasks to clear.",
                    "No Completed Tasks",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);

                return;
            }

            foreach (SecurityTask task in completedTasks)
            {
                tasks.Remove(task);
            }

            UpdateProgress();
        }

        private void UpdateProgress()
        {
            int completed = tasks.Count(task => task.IsCompleted);

            ProgressText.Text =
                $"Completed: {completed} of {tasks.Count} tasks";
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
