using Laboratorio12.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Input;

namespace Laboratorio12.ViewModels
{
    public class TaskViewModel : ViewModelBase
    {
        string title;
        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    OnPropertyChanged();
                }
            }
        }

        string description;
        public string Description
        {
            get { return description; }
            set
            {
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged();
                }
            }
        }

        bool status;
        public bool Status
        {
            get { return status; }
            set
            {
                if (status != value)
                {
                    status = value;
                    OnPropertyChanged();
                }
            }
        }

        List<TaskModel> tasks;
        public List<TaskModel> Tasks
        {
            get { return tasks; }
            set
            {
                if (tasks != value)
                {
                    tasks = value;
                    OnPropertyChanged();
                }
            }
        }


        public ICommand Save { protected set; get; }
        public ICommand Get { protected set; get; }

        public TaskViewModel()
        {
            
        }
    }
}
