using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeClasses
{
    public partial class Form1 : Form
    {
        
        WorkoutUser userProfile = new WorkoutUser();
        public Form1()
        {
            
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            Workouts myWorkouts = new Workouts();
            if(e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                myWorkouts.setWorkoutName(textBox1.Text);
            }
        }

        public class WorkoutUser
        {
            string userLastName;
            string userFirstName;
            ICollection<Workouts> workouts = new List<Workouts>();
            

            public void compileWorkoutsList()
            {
                Workouts myWorkouts = new Workouts();
                string WorkoutName = "";
                WorkoutName = myWorkouts.getWorkoutName();
                workouts.Add((Workouts)WorkoutName);
                //Having problems adding the damn workoutname to this list......

            }


            
        }
        public class Workouts
        {
            public string workoutName;
            private string workoutdescription;
            ICollection<IExerciseActivity> exActivity = new List<IExerciseActivity>();

            public void setWorkoutName(string wrkoutName)
            {
                workoutName = wrkoutName;
            }

            public string getWorkoutName()
            {
                return workoutName;
            }
           
        }

        public interface IExerciseActivity
        {

        }

    }
}
