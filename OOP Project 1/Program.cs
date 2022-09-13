using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1
{
    internal class Program
    {

        enum MainMenuChoices
        {
            goBack=0,
            experience=1,
            education=2,
            skills=3,
            technologicalSkills=4,
            contactDetails=5
        }

        static void Main(string[] args)
        {

            int choice, experienceChoice, educationChoice;

            Introduction intro = new Introduction();

            MainMenu mainMenu = new MainMenu();
            choice = mainMenu.select();

            //ensuring if a wrong input in main menu is captured from start, it will display the MM again
            displayMainMenuBackAgain(ref choice, mainMenu);

            while (choice != (int)MainMenuChoices.goBack)
            {
                //ensuring if a wrong input in main menu is captured after a valid input, it will display the MM again
                displayMainMenuBackAgain(ref choice, mainMenu);

                switch (choice) {

                    case (int)MainMenuChoices.experience:
                        {
                            Experience experience = new Experience();
                            experience.ExperienceList();
                            experienceChoice = experience.select();

                            //calling function displayExperience
                            choice = displyExperience(ref experienceChoice, experience, ref choice);
                        };break;

                    case (int)MainMenuChoices.education:
                        {
                            Education education = new Education();
                            education.EducationList();
                            educationChoice = education.select();

                            //calling function displayEducation
                            choice = displyEducation(ref educationChoice, education, ref choice);

                        };break;

                    case (int)MainMenuChoices.skills:
                        {
                            Skills skill = new Skills();
                            choice = skill.printDetails();
                        };break;

                    case (int)MainMenuChoices.technologicalSkills:
                        {
                            TechnologicalSkills technologicalSkill = new TechnologicalSkills();
                            choice = technologicalSkill.printDetails();
                        };break;

                    case (int)MainMenuChoices.contactDetails:
                        {
                            ContactDetail contactDetail = new ContactDetail();
                            choice = contactDetail.printDetails();
                        }break;

                }
            }//end of while loop (will exit the loop if go back is selected)

            if(choice == (int)MainMenuChoices.goBack)
            {
                Environment.Exit(0);
            }

            Console.ReadLine();
        }

        public static void displayMainMenuBackAgain(ref int choice, MainMenu menu)
        {

            while (!Enum.IsDefined(typeof(MainMenuChoices), choice))
            {
                menu = new MainMenu();
                choice = menu.select();
            }
        }

        public static int displyExperience(ref int experienceChoice, Experience experience, ref int choice)
        {
            if (experienceChoice != (int)MainMenuChoices.goBack)
            {
                do
                {
                    ExperienceDescription jobDescription = new ExperienceDescription();
                    experienceChoice = jobDescription.experienceDescription(experienceChoice);
                } while (experienceChoice != (int)MainMenuChoices.goBack);
            }
            if (experienceChoice == (int)MainMenuChoices.goBack)
            {
                //here the new value that will be captured in choice when the user redo a selection in main menu
                return experience.backToMenu();
            }else
            {
                return 0;
            }
        }

        public static int displyEducation(ref int educationChoice, Education education, ref int choice)
        {
            if (educationChoice != (int)MainMenuChoices.goBack)
            {
                do
                {
                    EducationDescription universityDescription = new EducationDescription();
                    educationChoice = universityDescription.educationDescription(educationChoice);
                } while (educationChoice != (int)MainMenuChoices.goBack);
            }
            if (educationChoice == (int)MainMenuChoices.goBack)
            {
                //here the new value that will be captured in choice when the user redo a selection in main menu
                return education.backToMenu();
            }
            else
            {
                return 0;
            }

        }

    }

}
