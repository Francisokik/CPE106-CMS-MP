﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MPGuiVersion
{
    public class Task
    {
        private string taskName;
        private string dueDate;
        private bool isDone;
        private double budget;
        private int employeesNeeded;
        private string description;
        private string materialsNeeded;

        public string TaskName { get => taskName; set => taskName = value; }
        public string DueDate { get => dueDate; set => dueDate = value; }
        public double Budget { get => budget; set => budget = value; }
        public int EmployeesNeeded { get => employeesNeeded; set => employeesNeeded = value; }
        public string Description { get => description; set => description = value; }
        public string MaterialsNeeded { get => materialsNeeded; set => materialsNeeded = value; }
        public bool IsDone { get => isDone; set => isDone = value; }
    }
}