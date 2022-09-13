using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_1
{

    interface GoBackToMenu
    {
        int select();
    }

    public abstract class subMenus : GoBackToMenu
    {
        protected int choice;

        public int getChoice()
        {
            return this.choice;
        }

        protected void setChoice(int choice)
        {
            this.choice = choice;
        }

        public virtual int backToMenu()
        {
            MainMenu menu = new MainMenu();
            return menu.select();
        }

        public virtual int select()
        {
            return 0;
        }
    }

    public abstract class nonSubMenus
    {
        public static int backToMainMenu()
        {
            MainMenu menu = new MainMenu();
            return menu.select();
        }

        abstract public int printDetails();

    }

}
