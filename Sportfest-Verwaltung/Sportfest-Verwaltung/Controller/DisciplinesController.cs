using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsFestivalManagement.Provider;
using SportsFestivalManagement.Entities;
using SportsFestivalManagement.View;


namespace SportsFestivalManagement.Controller
{
    class DisciplinesController
    {
        private DisciplinesController() { }

        private DisciplinesGUI DisciplinesGUIForm;

        private static readonly DisciplinesController _instance = new DisciplinesController();

        public static DisciplinesController getInstance
        {
            get { return _instance; }
        } 

        public void OpenDisciplinesGUI()
        {
            List<Discipline> disciplines = DisciplineProvider.getAllDisciplines();
            

            DisciplinesGUIForm = new DisciplinesGUI(this);

            DisciplinesGUIForm.updateDisciplines(disciplines);
            
            DisciplinesGUIForm.ShowDialog();
        }

        public void Save(List<object> saveObjects)
        {
            foreach (Object[] saveObject in saveObjects)
            {
                DisciplineProvider.createDiscipline
                (
                    saveObject[0].ToString(),
                    MeasureProvider.getMeasureById(Convert.ToInt32(saveObject[2])),
                    CategoryProvider.getCategoryById(Convert.ToInt32(saveObject[1]))
                );
            }
            DisciplinesGUIForm.renderDisciplinesGrid(DisciplineProvider.getAllDisciplines());
        }
    }
}
