using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1
{
    enum ChoiceExperience { goBack = 0, MutualAid = 1, Ceridian = 2 }

    public class Experience : subMenus
    {
        public void ExperienceList()
        {
            Console.WriteLine("-------------------------EXPERIENCE-------------------------");
            Console.WriteLine("1. Mauritius Civil Services Mutual Aid Association (02 July 2020 to 25 September 2020)");
            Console.WriteLine("2. CERIDIAN Mauritius Limited (05 September 2022 to 11 November 2022)");
            Console.WriteLine("0. Go Back");
            Console.WriteLine();
            Console.WriteLine("Please select an option for Experience details or 0 to go back to Main Menu");
        }

        public override int select()
        {
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                setChoice(num);
            }
            catch (System.FormatException)
            {
                new Experience().ExperienceList();
                select();
            }

            return getChoice();
        }

    }

    public class ExperienceDescription : Experience
    {

        Experience experience = new Experience();

        public override int backToMenu()//override function so that it will go back to the sub menu of Experience
        {
            experience.ExperienceList();
            setChoice(experience.select());
            return getChoice();
        }

        public int experienceDescription(int choice)
        {

            switch (choice) {

                case (int)ChoiceExperience.MutualAid:
                {
                    Console.WriteLine("-------------------------MutualAid-------------------------");
                    Console.WriteLine("Loan Abeyance / Updating Customers details on FINACLE system");
                    Console.WriteLine();

                    return backToMenu();

                };
                case (int)ChoiceExperience.Ceridian:
                {
                    Console.WriteLine("-------------------------Ceridian-------------------------");
                    Console.WriteLine("Taking part in the JEDI/SKILLSLAB training");
                    Console.WriteLine();

                    return backToMenu();

                };
                default ://if any other choice is made, we just display the sub menu and wait for another selection
                {
                    return backToMenu();
                }
            }
        }
    }
}

