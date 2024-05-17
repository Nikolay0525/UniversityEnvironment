using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityEnvironment.View.Forms;
using UniversityEnvironment.Data.Model.Tables;
using MaterialSkin.Controls;

namespace UniversityEnvironment.View.Utility
{
    public class FormCreater
    {
        public static MaterialForm CreateForm(string formName, User user, Course course)
        {
            Type formType = Type.GetType("UniversityEnvironment.View.Forms." + formName);

            if (formType != null && formType.IsSubclassOf(typeof(MaterialForm)))
            {
                MaterialForm formInstance = (MaterialForm)Activator.CreateInstance(formType, user, course);
                return formInstance;
            }
            else
            {
                throw new ArgumentException("Форму з назвою " + formName + " не знайдено.");
            }
        }
        public static MaterialForm CreateTestForm(string formName, User user, Course course, Test test)
        {
            Type formType = Type.GetType("UniversityEnvironment.View.Forms." + formName);

            if (formType != null && formType.IsSubclassOf(typeof(MaterialForm)))
            {
                MaterialForm formInstance = (MaterialForm)Activator.CreateInstance(formType, user, course, test);
                return formInstance;
            }
            else
            {
                throw new ArgumentException("Форму з назвою " + formName + " не знайдено.");
            }
        }
    }
}
