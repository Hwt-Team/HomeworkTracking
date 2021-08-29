using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Exit = "Want to close the program ?";

        #region CheckCurrentRow
        public static string CheckRowSelectedOrExists = "Any line did not selected or no line";
        public static string CheckRowExists = "No line to delete";
        public static string CheckRowExistsForSearch="No line to search";
        #endregion



        #region Exercise
        public static string ExerciseAdd = "A new exercise will be added.";
        public static string ExerciseDelete = "Selected exercise will be deleted.";
        public static string ExerciseDeleteAll = "All data will be deleted.";
        public static string ExerciseUpdate = "Changed exercise will be updated.";
        #endregion

        #region Group
        public static string GroupAdd = "A new group will be added.";
        public static string GroupDelete = "Selected group will be deleted.";
        public static string GroupDeleteAll = "All data will be deleted.";
        public static string GroupUpdate = "Changed group will be updated.";
        #endregion

        #region State 
        public static string StateAdd = "A new state will be added.";
        public static string StateDelete = "Selected state will be deleted.";
        public static string StateDeleteAll = "All data will be deleted.";
        public static string StateUpdate = "Changed state will be updated.";
        #endregion

        #region Student Exercise 
        public static string StudentExerciseAdd = "A new student & exercise will be added.";
        public static string StudentExerciseDelete = "Selected student & exercise will be deleted.";
        public static string StudentExerciseUpdate = "A student & exercise will be updated.";
        #endregion

        #region Graduate
        public static string GraduateAdd = "A new graduate will be added.";
        public static string GraduateDelete = "Selected graduate will be deleted.";
        public static string GraduateDeleteAll = "All data will be deleted.";
        public static string GraduateUpdate = "Changed graduate will be updated.";
        #endregion

        #region Studies
        public static string StudiesAdd = "A new studying will be added.";
        public static string StudiesDelete = "Selected studying will be deleted.";
        public static string StudiesDeleteAll = "All data will be deleted.";
        public static string StudiesUpdate = "Changed studying will be updated.";
        #endregion

        #region Task
        public static string TaskAdd = "A new task will be added.";
        public static string TaskDelete = "Selected task will be deleted.";
        public static string TaskDeleteAll = "All data will be deleted.";
        public static string TaskUpdate = "Changed task will be updated.";    
        #endregion

    }
}
